﻿namespace SARS
{
    partial class AvatarSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.avatarGrid = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.lblPrivate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.lblPublic = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.txtAbout = new MetroFramework.Controls.MetroTextBox();
            this.lblSize = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.chkPin = new MetroFramework.Controls.MetroCheckBox();
            this.btnToggleFavorite = new MetroFramework.Controls.MetroButton();
            this.btnSearchFavorites = new MetroFramework.Controls.MetroButton();
            this.cbLimit = new MetroFramework.Controls.MetroComboBox();
            this.txtSearchTerm = new MetroFramework.Controls.MetroTextBox();
            this.btnRipped = new MetroFramework.Controls.MetroButton();
            this.btnViewDetails = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.cbSearchTerm = new MetroFramework.Controls.MetroComboBox();
            this.chkQuest = new MetroFramework.Controls.MetroCheckBox();
            this.chkPC = new MetroFramework.Controls.MetroCheckBox();
            this.chkPrivate = new MetroFramework.Controls.MetroCheckBox();
            this.chkPublic = new MetroFramework.Controls.MetroCheckBox();
            this.lblAvatarCount = new MetroFramework.Controls.MetroLabel();
            this.lblCount = new MetroFramework.Controls.MetroLabel();
            this.lblFilter = new MetroFramework.Controls.MetroLabel();
            this.lblSearchType = new MetroFramework.Controls.MetroLabel();
            this.lblSearchTerm = new MetroFramework.Controls.MetroLabel();
            this.btnPreview = new MetroFramework.Controls.MetroButton();
            this.btnDownload = new MetroFramework.Controls.MetroButton();
            this.btnResetScene = new MetroFramework.Controls.MetroButton();
            this.btnBrowserView = new MetroFramework.Controls.MetroButton();
            this.btnHotswap = new MetroFramework.Controls.MetroButton();
            this.btnUnity = new MetroFramework.Controls.MetroButton();
            this.lblQuestVersion = new MetroFramework.Controls.MetroLabel();
            this.lblPCVersion = new MetroFramework.Controls.MetroLabel();
            this.nmQuestVersion = new System.Windows.Forms.NumericUpDown();
            this.nmPcVersion = new System.Windows.Forms.NumericUpDown();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.AvatarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvatarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarGrid)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuestVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPcVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.metroTabPage1);
            this.tabControl.Controls.Add(this.metroTabPage2);
            this.tabControl.Controls.Add(this.metroTabPage3);
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabControl.Location = new System.Drawing.Point(28, 232);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(848, 456);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.avatarGrid);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(840, 414);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Avatars";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // avatarGrid
            // 
            this.avatarGrid.AllowUserToDeleteRows = false;
            this.avatarGrid.AllowUserToOrderColumns = true;
            this.avatarGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.avatarGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avatarGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.avatarGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.avatarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.avatarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avatarGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.picture,
            this.AvatarName,
            this.Author,
            this.AvatarId,
            this.Logged,
            this.ImageURL});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.avatarGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.avatarGrid.EnableHeadersVisualStyles = false;
            this.avatarGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.avatarGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.avatarGrid.Location = new System.Drawing.Point(0, 0);
            this.avatarGrid.Name = "avatarGrid";
            this.avatarGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.avatarGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.avatarGrid.RowHeadersVisible = false;
            this.avatarGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.avatarGrid.RowTemplate.Height = 200;
            this.avatarGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.avatarGrid.ShowEditingIcon = false;
            this.avatarGrid.ShowRowErrors = false;
            this.avatarGrid.Size = new System.Drawing.Size(840, 414);
            this.avatarGrid.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(840, 414);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Settings";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.lblPrivate);
            this.metroTabPage3.Controls.Add(this.metroLabel19);
            this.metroTabPage3.Controls.Add(this.lblPublic);
            this.metroTabPage3.Controls.Add(this.metroLabel17);
            this.metroTabPage3.Controls.Add(this.txtAbout);
            this.metroTabPage3.Controls.Add(this.lblSize);
            this.metroTabPage3.Controls.Add(this.metroLabel10);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(840, 414);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // lblPrivate
            // 
            this.lblPrivate.AutoSize = true;
            this.lblPrivate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPrivate.Location = new System.Drawing.Point(727, 13);
            this.lblPrivate.Name = "lblPrivate";
            this.lblPrivate.Size = new System.Drawing.Size(17, 19);
            this.lblPrivate.TabIndex = 61;
            this.lblPrivate.Text = "0";
            this.lblPrivate.UseStyleColors = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel19.Location = new System.Drawing.Point(581, 13);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(120, 19);
            this.metroLabel19.TabIndex = 60;
            this.metroLabel19.Text = "Private Avatars: ";
            this.metroLabel19.UseStyleColors = true;
            // 
            // lblPublic
            // 
            this.lblPublic.AutoSize = true;
            this.lblPublic.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPublic.Location = new System.Drawing.Point(437, 13);
            this.lblPublic.Name = "lblPublic";
            this.lblPublic.Size = new System.Drawing.Size(17, 19);
            this.lblPublic.TabIndex = 59;
            this.lblPublic.Text = "0";
            this.lblPublic.UseStyleColors = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(296, 13);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(113, 19);
            this.metroLabel17.TabIndex = 58;
            this.metroLabel17.Text = "Public Avatars: ";
            this.metroLabel17.UseStyleColors = true;
            // 
            // txtAbout
            // 
            this.txtAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAbout.CustomButton.Image = null;
            this.txtAbout.CustomButton.Location = new System.Drawing.Point(464, 2);
            this.txtAbout.CustomButton.Name = "";
            this.txtAbout.CustomButton.Size = new System.Drawing.Size(367, 367);
            this.txtAbout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAbout.CustomButton.TabIndex = 1;
            this.txtAbout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAbout.CustomButton.UseSelectable = true;
            this.txtAbout.CustomButton.Visible = false;
            this.txtAbout.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAbout.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtAbout.Lines = new string[0];
            this.txtAbout.Location = new System.Drawing.Point(3, 39);
            this.txtAbout.MaxLength = 99999999;
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.PasswordChar = '\0';
            this.txtAbout.ReadOnly = true;
            this.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAbout.SelectedText = "";
            this.txtAbout.SelectionLength = 0;
            this.txtAbout.SelectionStart = 0;
            this.txtAbout.ShortcutsEnabled = true;
            this.txtAbout.Size = new System.Drawing.Size(834, 372);
            this.txtAbout.TabIndex = 57;
            this.txtAbout.UseSelectable = true;
            this.txtAbout.UseStyleColors = true;
            this.txtAbout.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAbout.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSize.Location = new System.Drawing.Point(158, 13);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(17, 19);
            this.lblSize.TabIndex = 56;
            this.lblSize.Text = "0";
            this.lblSize.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(12, 13);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(110, 19);
            this.metroLabel10.TabIndex = 55;
            this.metroLabel10.Text = "Database Size: ";
            this.metroLabel10.UseStyleColors = true;
            // 
            // chkPin
            // 
            this.chkPin.AutoSize = true;
            this.chkPin.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkPin.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkPin.Location = new System.Drawing.Point(148, 179);
            this.chkPin.Name = "chkPin";
            this.chkPin.Size = new System.Drawing.Size(98, 19);
            this.chkPin.TabIndex = 72;
            this.chkPin.Text = "Pin Locked";
            this.chkPin.UseSelectable = true;
            this.chkPin.UseStyleColors = true;
            // 
            // btnToggleFavorite
            // 
            this.btnToggleFavorite.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnToggleFavorite.Location = new System.Drawing.Point(750, 163);
            this.btnToggleFavorite.Name = "btnToggleFavorite";
            this.btnToggleFavorite.Size = new System.Drawing.Size(120, 35);
            this.btnToggleFavorite.TabIndex = 71;
            this.btnToggleFavorite.Text = "Toggle Favorite";
            this.btnToggleFavorite.UseSelectable = true;
            this.btnToggleFavorite.UseStyleColors = true;
            // 
            // btnSearchFavorites
            // 
            this.btnSearchFavorites.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearchFavorites.Location = new System.Drawing.Point(626, 163);
            this.btnSearchFavorites.Name = "btnSearchFavorites";
            this.btnSearchFavorites.Size = new System.Drawing.Size(120, 35);
            this.btnSearchFavorites.TabIndex = 70;
            this.btnSearchFavorites.Text = "Load Favorites";
            this.btnSearchFavorites.UseSelectable = true;
            this.btnSearchFavorites.UseStyleColors = true;
            // 
            // cbLimit
            // 
            this.cbLimit.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbLimit.FormattingEnabled = true;
            this.cbLimit.ItemHeight = 23;
            this.cbLimit.Items.AddRange(new object[] {
            "Max",
            "5000",
            "1000",
            "500",
            "250",
            "100",
            "50",
            "10",
            "1"});
            this.cbLimit.Location = new System.Drawing.Point(751, 79);
            this.cbLimit.Name = "cbLimit";
            this.cbLimit.Size = new System.Drawing.Size(119, 29);
            this.cbLimit.TabIndex = 69;
            this.cbLimit.UseSelectable = true;
            this.cbLimit.UseStyleColors = true;
            // 
            // txtSearchTerm
            // 
            // 
            // 
            // 
            this.txtSearchTerm.CustomButton.Image = null;
            this.txtSearchTerm.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.txtSearchTerm.CustomButton.Name = "";
            this.txtSearchTerm.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSearchTerm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchTerm.CustomButton.TabIndex = 1;
            this.txtSearchTerm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchTerm.CustomButton.UseSelectable = true;
            this.txtSearchTerm.CustomButton.Visible = false;
            this.txtSearchTerm.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchTerm.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtSearchTerm.Lines = new string[0];
            this.txtSearchTerm.Location = new System.Drawing.Point(148, 79);
            this.txtSearchTerm.MaxLength = 32767;
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.PasswordChar = '\0';
            this.txtSearchTerm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchTerm.SelectedText = "";
            this.txtSearchTerm.SelectionLength = 0;
            this.txtSearchTerm.SelectionStart = 0;
            this.txtSearchTerm.ShortcutsEnabled = true;
            this.txtSearchTerm.Size = new System.Drawing.Size(472, 29);
            this.txtSearchTerm.TabIndex = 68;
            this.txtSearchTerm.UseSelectable = true;
            this.txtSearchTerm.UseStyleColors = true;
            this.txtSearchTerm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchTerm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRipped
            // 
            this.btnRipped.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRipped.Location = new System.Drawing.Point(500, 163);
            this.btnRipped.Name = "btnRipped";
            this.btnRipped.Size = new System.Drawing.Size(120, 35);
            this.btnRipped.TabIndex = 67;
            this.btnRipped.Text = "Search Ripped";
            this.btnRipped.UseSelectable = true;
            this.btnRipped.UseStyleColors = true;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnViewDetails.Location = new System.Drawing.Point(698, 119);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(172, 35);
            this.btnViewDetails.TabIndex = 65;
            this.btnViewDetails.Text = "View Avatar Full Details";
            this.btnViewDetails.UseSelectable = true;
            this.btnViewDetails.UseStyleColors = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearch.Location = new System.Drawing.Point(500, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(192, 35);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Search API";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseStyleColors = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearchTerm
            // 
            this.cbSearchTerm.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.cbSearchTerm.FormattingEnabled = true;
            this.cbSearchTerm.ItemHeight = 23;
            this.cbSearchTerm.Items.AddRange(new object[] {
            "Avatar Name",
            "Author Name",
            "Avatar ID",
            "Author ID",
            "World Name",
            "World ID"});
            this.cbSearchTerm.Location = new System.Drawing.Point(148, 119);
            this.cbSearchTerm.Name = "cbSearchTerm";
            this.cbSearchTerm.Size = new System.Drawing.Size(343, 29);
            this.cbSearchTerm.TabIndex = 64;
            this.cbSearchTerm.UseSelectable = true;
            this.cbSearchTerm.UseStyleColors = true;
            // 
            // chkQuest
            // 
            this.chkQuest.AutoSize = true;
            this.chkQuest.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkQuest.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkQuest.Location = new System.Drawing.Point(359, 154);
            this.chkQuest.Name = "chkQuest";
            this.chkQuest.Size = new System.Drawing.Size(63, 19);
            this.chkQuest.TabIndex = 63;
            this.chkQuest.Text = "Quest";
            this.chkQuest.UseSelectable = true;
            this.chkQuest.UseStyleColors = true;
            // 
            // chkPC
            // 
            this.chkPC.AutoSize = true;
            this.chkPC.Checked = true;
            this.chkPC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPC.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkPC.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkPC.Location = new System.Drawing.Point(310, 154);
            this.chkPC.Name = "chkPC";
            this.chkPC.Size = new System.Drawing.Size(43, 19);
            this.chkPC.TabIndex = 62;
            this.chkPC.Text = "PC";
            this.chkPC.UseSelectable = true;
            this.chkPC.UseStyleColors = true;
            // 
            // chkPrivate
            // 
            this.chkPrivate.AutoSize = true;
            this.chkPrivate.Checked = true;
            this.chkPrivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrivate.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkPrivate.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkPrivate.Location = new System.Drawing.Point(231, 154);
            this.chkPrivate.Name = "chkPrivate";
            this.chkPrivate.Size = new System.Drawing.Size(73, 19);
            this.chkPrivate.TabIndex = 61;
            this.chkPrivate.Text = "Private";
            this.chkPrivate.UseSelectable = true;
            this.chkPrivate.UseStyleColors = true;
            // 
            // chkPublic
            // 
            this.chkPublic.AutoSize = true;
            this.chkPublic.Checked = true;
            this.chkPublic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPublic.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkPublic.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkPublic.Location = new System.Drawing.Point(148, 154);
            this.chkPublic.Name = "chkPublic";
            this.chkPublic.Size = new System.Drawing.Size(66, 19);
            this.chkPublic.TabIndex = 60;
            this.chkPublic.Text = "Public";
            this.chkPublic.UseSelectable = true;
            this.chkPublic.UseStyleColors = true;
            // 
            // lblAvatarCount
            // 
            this.lblAvatarCount.AutoSize = true;
            this.lblAvatarCount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAvatarCount.Location = new System.Drawing.Point(96, 204);
            this.lblAvatarCount.Name = "lblAvatarCount";
            this.lblAvatarCount.Size = new System.Drawing.Size(17, 19);
            this.lblAvatarCount.TabIndex = 59;
            this.lblAvatarCount.Text = "0";
            this.lblAvatarCount.UseStyleColors = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCount.Location = new System.Drawing.Point(30, 203);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(52, 19);
            this.lblCount.TabIndex = 58;
            this.lblCount.Text = "Count:";
            this.lblCount.UseStyleColors = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFilter.Location = new System.Drawing.Point(30, 167);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(48, 19);
            this.lblFilter.TabIndex = 57;
            this.lblFilter.Text = "Filter:";
            this.lblFilter.UseStyleColors = true;
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSearchType.Location = new System.Drawing.Point(30, 123);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(94, 19);
            this.lblSearchType.TabIndex = 56;
            this.lblSearchType.Text = "Search Type:";
            this.lblSearchType.UseStyleColors = true;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSearchTerm.Location = new System.Drawing.Point(30, 79);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(96, 19);
            this.lblSearchTerm.TabIndex = 55;
            this.lblSearchTerm.Text = "Search Term:";
            this.lblSearchTerm.UseStyleColors = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPreview.Location = new System.Drawing.Point(624, 758);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(246, 35);
            this.btnPreview.TabIndex = 74;
            this.btnPreview.Text = "Preview VRCA";
            this.btnPreview.UseSelectable = true;
            this.btnPreview.UseStyleColors = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownload.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnDownload.Location = new System.Drawing.Point(32, 758);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(245, 35);
            this.btnDownload.TabIndex = 73;
            this.btnDownload.Text = "Download VRCA / VRCW";
            this.btnDownload.UseSelectable = true;
            this.btnDownload.UseStyleColors = true;
            // 
            // btnResetScene
            // 
            this.btnResetScene.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetScene.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnResetScene.Location = new System.Drawing.Point(31, 708);
            this.btnResetScene.Name = "btnResetScene";
            this.btnResetScene.Size = new System.Drawing.Size(120, 35);
            this.btnResetScene.TabIndex = 78;
            this.btnResetScene.Text = "Reset Scene";
            this.btnResetScene.UseSelectable = true;
            this.btnResetScene.UseStyleColors = true;
            // 
            // btnBrowserView
            // 
            this.btnBrowserView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowserView.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBrowserView.Location = new System.Drawing.Point(750, 708);
            this.btnBrowserView.Name = "btnBrowserView";
            this.btnBrowserView.Size = new System.Drawing.Size(120, 35);
            this.btnBrowserView.TabIndex = 77;
            this.btnBrowserView.Text = "Browser View";
            this.btnBrowserView.UseSelectable = true;
            this.btnBrowserView.UseStyleColors = true;
            // 
            // btnHotswap
            // 
            this.btnHotswap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotswap.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHotswap.Location = new System.Drawing.Point(624, 708);
            this.btnHotswap.Name = "btnHotswap";
            this.btnHotswap.Size = new System.Drawing.Size(120, 35);
            this.btnHotswap.TabIndex = 76;
            this.btnHotswap.Text = "HotSwap";
            this.btnHotswap.UseSelectable = true;
            this.btnHotswap.UseStyleColors = true;
            // 
            // btnUnity
            // 
            this.btnUnity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnity.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUnity.Location = new System.Drawing.Point(157, 708);
            this.btnUnity.Name = "btnUnity";
            this.btnUnity.Size = new System.Drawing.Size(120, 35);
            this.btnUnity.TabIndex = 75;
            this.btnUnity.Text = "Open Unity";
            this.btnUnity.UseSelectable = true;
            this.btnUnity.UseStyleColors = true;
            // 
            // lblQuestVersion
            // 
            this.lblQuestVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblQuestVersion.AutoSize = true;
            this.lblQuestVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblQuestVersion.Location = new System.Drawing.Point(469, 718);
            this.lblQuestVersion.Name = "lblQuestVersion";
            this.lblQuestVersion.Size = new System.Drawing.Size(100, 19);
            this.lblQuestVersion.TabIndex = 82;
            this.lblQuestVersion.Text = "Quest Version";
            this.lblQuestVersion.UseStyleColors = true;
            // 
            // lblPCVersion
            // 
            this.lblPCVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPCVersion.AutoSize = true;
            this.lblPCVersion.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPCVersion.Location = new System.Drawing.Point(328, 718);
            this.lblPCVersion.Name = "lblPCVersion";
            this.lblPCVersion.Size = new System.Drawing.Size(80, 19);
            this.lblPCVersion.TabIndex = 81;
            this.lblPCVersion.Text = "PC Version";
            this.lblPCVersion.UseStyleColors = true;
            // 
            // nmQuestVersion
            // 
            this.nmQuestVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nmQuestVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmQuestVersion.Location = new System.Drawing.Point(459, 762);
            this.nmQuestVersion.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmQuestVersion.Name = "nmQuestVersion";
            this.nmQuestVersion.Size = new System.Drawing.Size(130, 26);
            this.nmQuestVersion.TabIndex = 80;
            // 
            // nmPcVersion
            // 
            this.nmPcVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nmPcVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPcVersion.Location = new System.Drawing.Point(313, 762);
            this.nmPcVersion.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmPcVersion.Name = "nmPcVersion";
            this.nmPcVersion.Size = new System.Drawing.Size(129, 26);
            this.nmPcVersion.TabIndex = 79;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(631, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 85;
            this.metroLabel2.Text = "Search Amount:";
            this.metroLabel2.UseStyleColors = true;
            // 
            // picture
            // 
            this.picture.HeaderText = "Picture";
            this.picture.Name = "picture";
            this.picture.Width = 180;
            // 
            // AvatarName
            // 
            this.AvatarName.HeaderText = "Name";
            this.AvatarName.Name = "AvatarName";
            this.AvatarName.Width = 150;
            // 
            // Author
            // 
            this.Author.HeaderText = "Author Name";
            this.Author.Name = "Author";
            this.Author.Width = 150;
            // 
            // AvatarId
            // 
            this.AvatarId.HeaderText = "Avatar ID";
            this.AvatarId.Name = "AvatarId";
            this.AvatarId.Width = 210;
            // 
            // Logged
            // 
            this.Logged.HeaderText = "Date Logged";
            this.Logged.Name = "Logged";
            this.Logged.Width = 150;
            // 
            // ImageURL
            // 
            this.ImageURL.HeaderText = "ImageURL";
            this.ImageURL.Name = "ImageURL";
            this.ImageURL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ImageURL.Visible = false;
            this.ImageURL.Width = 5;
            // 
            // AvatarSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 816);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblQuestVersion);
            this.Controls.Add(this.lblPCVersion);
            this.Controls.Add(this.nmQuestVersion);
            this.Controls.Add(this.nmPcVersion);
            this.Controls.Add(this.btnResetScene);
            this.Controls.Add(this.btnBrowserView);
            this.Controls.Add(this.btnHotswap);
            this.Controls.Add(this.btnUnity);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.chkPin);
            this.Controls.Add(this.btnToggleFavorite);
            this.Controls.Add(this.btnSearchFavorites);
            this.Controls.Add(this.cbLimit);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.btnRipped);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearchTerm);
            this.Controls.Add(this.chkQuest);
            this.Controls.Add(this.chkPC);
            this.Controls.Add(this.chkPrivate);
            this.Controls.Add(this.chkPublic);
            this.Controls.Add(this.lblAvatarCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblSearchType);
            this.Controls.Add(this.lblSearchTerm);
            this.Controls.Add(this.tabControl);
            this.Name = "AvatarSystem";
            this.Text = "Shrek Avatar Recovery System (S.A.R.S)";
            this.Load += new System.EventHandler(this.AvatarSystem_Load);
            this.tabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarGrid)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuestVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPcVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        public MetroFramework.Controls.MetroCheckBox chkPin;
        public MetroFramework.Controls.MetroButton btnToggleFavorite;
        public MetroFramework.Controls.MetroButton btnSearchFavorites;
        public MetroFramework.Controls.MetroComboBox cbLimit;
        public MetroFramework.Controls.MetroTextBox txtSearchTerm;
        public MetroFramework.Controls.MetroButton btnRipped;
        public MetroFramework.Controls.MetroButton btnViewDetails;
        public MetroFramework.Controls.MetroButton btnSearch;
        public MetroFramework.Controls.MetroComboBox cbSearchTerm;
        public MetroFramework.Controls.MetroCheckBox chkQuest;
        public MetroFramework.Controls.MetroCheckBox chkPC;
        public MetroFramework.Controls.MetroCheckBox chkPrivate;
        public MetroFramework.Controls.MetroCheckBox chkPublic;
        public MetroFramework.Controls.MetroLabel lblAvatarCount;
        public MetroFramework.Controls.MetroLabel lblCount;
        public MetroFramework.Controls.MetroLabel lblFilter;
        public MetroFramework.Controls.MetroLabel lblSearchType;
        public MetroFramework.Controls.MetroLabel lblSearchTerm;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel lblPrivate;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel lblPublic;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox txtAbout;
        private MetroFramework.Controls.MetroLabel lblSize;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        public MetroFramework.Controls.MetroButton btnPreview;
        public MetroFramework.Controls.MetroButton btnDownload;
        public MetroFramework.Controls.MetroButton btnResetScene;
        public MetroFramework.Controls.MetroButton btnBrowserView;
        public MetroFramework.Controls.MetroButton btnHotswap;
        public MetroFramework.Controls.MetroButton btnUnity;
        public MetroFramework.Controls.MetroLabel lblQuestVersion;
        public MetroFramework.Controls.MetroLabel lblPCVersion;
        public System.Windows.Forms.NumericUpDown nmQuestVersion;
        public System.Windows.Forms.NumericUpDown nmPcVersion;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid avatarGrid;
        private System.Windows.Forms.DataGridViewImageColumn picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvatarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvatarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logged;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageURL;
    }
}

