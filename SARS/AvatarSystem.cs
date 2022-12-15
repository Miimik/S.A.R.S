﻿using MetroFramework.Forms;
using SARS.Models;
using SARS.Modules;
using SARS.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SARS
{
    public partial class AvatarSystem : MetroForm
    {
        private ShrekApi shrekApi;
        private List<Avatar> avatars;
        private List<string> rippedList;
        private List<string> favList;
        private string userAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/104.0.5112.79 Safari/537.36";

        public AvatarSystem()
        {
            InitializeComponent();
            StyleManager = metroStyleManager1;
        }

        private void AvatarSystem_Load(object sender, EventArgs e)
        {
            shrekApi = new ShrekApi("9519694b-5938-44d6-904f-19477a0331cb");
            txtAbout.Text = Resources.About;
            cbSearchTerm.SelectedIndex = 0;
            cbLimit.SelectedIndex = 3;
            rippedList = new List<string>();
            favList = new List<string>();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string limit = cbLimit.Text;
            DateTime? before = null;
            DateTime? after = null;
            if (limit == "Max")
            {
                limit = "10000";
            }
            if (limit == "")
            {
                limit = "500";
            }
            if (chkBefore.Checked)
            {
                before = dtBefore.Value;
            }
            if (chkAfter.Checked)
            {
                after = dtAfter.Value;
            }
            if (string.IsNullOrEmpty(txtSearchTerm.Text))
            {
                avatars = shrekApi.blankSearch(!chkPublic.Checked, !chkPrivate.Checked, chkQuest.Checked, chkPC.Checked, Convert.ToInt32(limit), before, after);
            }
            else if (cbSearchTerm.Text == "Avatar Name")
            {
                avatars = shrekApi.avatarNameSearch(txtSearchTerm.Text, chkContains.Checked, !chkPublic.Checked, !chkPrivate.Checked, chkQuest.Checked, chkPC.Checked, Convert.ToInt32(limit), before, after);
            }
            else if (cbSearchTerm.Text == "Author Name")
            {
                avatars = shrekApi.authorNameSearch(txtSearchTerm.Text, chkContains.Checked, !chkPublic.Checked, !chkPrivate.Checked, chkQuest.Checked, chkPC.Checked, Convert.ToInt32(limit), before, after);
            }
            else if (cbSearchTerm.Text == "Avatar ID")
            {
                avatars = shrekApi.avatarIdSearch(txtSearchTerm.Text, !chkPublic.Checked, !chkPrivate.Checked, chkQuest.Checked, chkPC.Checked);
            }
            else if (cbSearchTerm.Text == "Author ID")
            {
                avatars = shrekApi.authorIdSearch(txtSearchTerm.Text, !chkPublic.Checked, !chkPrivate.Checked, chkQuest.Checked, chkPC.Checked, Convert.ToInt32(limit), before, after);
            }
            else if (cbSearchTerm.Text == "World Name")
            {
            }
            else if (cbSearchTerm.Text == "World ID")
            {
            }
            avatarGrid.Rows.Clear();
            LoadData();
            LoadImages();
        }

        private void LoadData()
        {
            Bitmap bitmap2 = null;
            try
            {
                System.Net.WebRequest request = System.Net.WebRequest.Create("https://ares-mod.com/avatars/download.png");
                System.Net.WebResponse response = request.GetResponse();
                System.IO.Stream responseStream = response.GetResponseStream();
                bitmap2 = new Bitmap(responseStream);
            }
            catch { }

            avatarGrid.AllowUserToAddRows = true;
            avatarGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            for (int i = 0; i < avatars.Count; i++)
            {
                try
                {
                    DataGridViewRow row = (DataGridViewRow)avatarGrid.Rows[0].Clone();

                    row.Cells[0].Value = bitmap2;
                    row.Cells[1].Value = avatars[i].AvatarName;
                    row.Cells[2].Value = avatars[i].AuthorName;
                    row.Cells[3].Value = avatars[i].AvatarID;
                    row.Cells[4].Value = avatars[i].Created;
                    row.Cells[5].Value = avatars[i].ThumbnailURL;
                    if (rippedList.Contains(avatars[i].AvatarID))
                    {
                        row.Cells[6].Value = true;
                    }
                    if (favList.Contains(avatars[i].AvatarID))
                    {
                        row.Cells[7].Value = true;
                    }
                    avatarGrid.Rows.Add(row);
                }
                catch { }
            }
            avatarGrid.AllowUserToAddRows = false;
            int count = avatarGrid.Rows.Count;

            lblAvatarCount.Text = (count).ToString();

            avatarGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void LoadImages()
        {
            ThreadPool.QueueUserWorkItem(delegate
            {
                for (int i = 0; i < avatarGrid.Rows.Count; i++)
                {
                    try
                    {
                        if (avatarGrid.Rows[i] != null)
                        {
                            if (avatarGrid.Rows[i].Cells[5].Value != null)
                            {
                                if (!string.IsNullOrEmpty(avatarGrid.Rows[i].Cells[5].Value.ToString().Trim()))
                                {
                                    try
                                    {
                                        HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(avatarGrid.Rows[i].Cells[5].Value.ToString());
                                        myRequest.Method = "GET";
                                        myRequest.UserAgent = userAgent;
                                        HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                                        System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                                        myResponse.Close();
                                        avatarGrid.Rows[i].Cells[0].Value = bmp;
                                    }
                                    catch
                                    {
                                        try
                                        {
                                            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://ares-mod.com/avatars/Image_not_available.png");
                                            myRequest.Method = "GET";
                                            myRequest.UserAgent = userAgent;
                                            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                                            System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(myResponse.GetResponseStream());
                                            myResponse.Close();
                                            avatarGrid.Rows[i].Cells[0].Value = bmp;
                                        }
                                        catch { }
                                    }
                                }
                            }
                        }
                    }
                    catch { }
                }
            });
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in avatarGrid.SelectedRows)
            {
                Avatar info = avatars.FirstOrDefault(x => x.AvatarID == row.Cells[3].Value);
                Avatar_Info avatar = new Avatar_Info();
                avatar.txtAvatarInfo.Text = SetAvatarInfo(info);
                avatar._selectedAvatar = info;
                avatar.Show();
            }
        }

        public string SetAvatarInfo(Avatar avatar)
        {
            string avatarString = $"Time Detected: {avatar.Created} {Environment.NewLine}" +
                $"Avatar Pin: {avatar.PinCode} {Environment.NewLine}" +
                $"Avatar ID: {avatar.AvatarID} {Environment.NewLine}" +
                $"Avatar Name: {avatar.AvatarName} {Environment.NewLine}" +
                $"Avatar Description {avatar.AvatarDescription} {Environment.NewLine}" +
                $"Author ID: {avatar.AuthorID} {Environment.NewLine}" +
                $"Author Name: {avatar.AuthorName} {Environment.NewLine}" +
                $"PC Asset URL: {avatar.PCAssetURL} {Environment.NewLine}" +
                $"Quest Asset URL: {avatar.QUESTAssetURL} {Environment.NewLine}" +
                $"Image URL: {avatar.ImageURL} {Environment.NewLine}" +
                $"Thumbnail URL: {avatar.ThumbnailURL} {Environment.NewLine}" +
                $"Unity Version: {avatar.UnityVersion} {Environment.NewLine}" +
                $"Release Status: {avatar.Releasestatus} {Environment.NewLine}" +
                $"Tags: {avatar.Tags}";
            return avatarString;
        }

        private void btnBrowserView_Click(object sender, EventArgs e)
        {
            if (avatars != null)
            {
                GenerateHtml.GenerateHtmlPage(avatars);
                Process.Start("avatars.html");
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnRipped_Click(object sender, EventArgs e)
        {
            avatars = shrekApi.GetList(rippedList);
            avatarGrid.Rows.Clear();
            LoadData();
            LoadImages();
        }

        private void btnSearchFavorites_Click(object sender, EventArgs e)
        {
            avatars = shrekApi.GetList(favList);
            avatarGrid.Rows.Clear();
            LoadData();
            LoadImages();
        }

        private void btnToggleFavorite_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in avatarGrid.SelectedRows)
            {
                try
                {
                    if (!favList.Contains(row.Cells[3].Value.ToString()))
                    {
                        favList.Add(row.Cells[3].Value.ToString());
                        row.Cells[7].Value = "true";
                    }
                    else
                    {
                        favList.Remove(row.Cells[3].Value.ToString());
                        row.Cells[7].Value = "false";

                    }
                } catch (Exception ex)
                {
                    Console.WriteLine("Some error" + ex.Message);
                }
            }
        }

        private void avatarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}