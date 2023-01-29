﻿using Newtonsoft.Json;
using SARS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace SARS.Modules
{
    internal class ShrekApi
    {
        private int maxSearch = 10000;
        private string apiKey { get; set; }
        private string coreApiVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        private static string baseUrl = "https://unlocked.ares-mod.com/records/";
        private string apiUrl = $"{baseUrl}Avatars?include=Created,TimeDetected,AvatarID,AvatarName,AvatarDescription,AuthorID,AuthorName,PCAssetURL,QUESTAssetURL,ImageURL,ThumbnailURL,UnityVersion,Releasestatus,Tags,Pin,PinCode&order=Created,desc";

        public ShrekApi(string apiKey = "")
        {
            if (apiKey != "")
            {
                this.apiKey = apiKey;
                baseUrl = "https://unlocked.ares-mod.com/records/";
            }
            else
            {
                baseUrl = "https://api.ares-mod.com/records/";
            }
        }

        private void SetUnlocked()
        {
            baseUrl = "https://unlocked.ares-mod.com/records/";
            apiUrl = apiUrl.Replace("https://api.", "https://unlocked.");
        }

        public void checkLogin()
        {
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(apiUrl + "&size=1");
            webReq.UserAgent = $"SARS V" + coreApiVersion;
            webReq.Method = "GET";
            webReq.Headers.Add("X-API-Key: " + apiKey);
            HttpWebResponse webResp = null;
            try
            {
                webResp = (HttpWebResponse)webReq.GetResponse();
                SetUnlocked();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("403"))
                {
                    MessageBox.Show("API Key Invalid");
                }
                return;
            }
            
        }

        private string webRequest(string url)
        {
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(url);
            webReq.UserAgent = $"SARS V" + coreApiVersion;
            webReq.Method = "GET";
            webReq.Headers.Add("X-API-Key: " + apiKey);

            HttpWebResponse webResp = (HttpWebResponse)webReq.GetResponse();

            string jsonString;
            using (Stream stream = webResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            return jsonString;
        }

        private string urlBuilder(string url, bool publicAvatars, bool privateAvatars, bool questAvatars, bool pcAvatars, int amount, DateTime? dateLessThan, DateTime? dateGreaterThan)
        {
            string buildUrl = url;

            if (publicAvatars && privateAvatars)
            {
                publicAvatars = false;
                privateAvatars = false;
            }
            if (publicAvatars)
            {
                buildUrl += $"&filter=Releasestatus,eq,public";
            }
            if (privateAvatars)
            {
                buildUrl += $"&filter=Releasestatus,eq,private";
            }
            if (questAvatars)
            {
                buildUrl += $"&filter=QUESTAssetURL,sw,https://";
            }
            if (pcAvatars)
            {
                buildUrl += $"&filter=PCAssetURL,sw,https://";
            }
            if (amount > maxSearch)
            {
                amount = maxSearch;
            }
            if (dateGreaterThan.HasValue)
            {
                buildUrl += $"&filter=Created,ge,{dateGreaterThan.Value.ToString("yyyy-MM-dd")}";
            }
            else if (dateLessThan.HasValue)
            {
                buildUrl += $"&filter=Created,le,{dateLessThan.Value.ToString("yyyy-MM-dd")}";
            }
            buildUrl += $"&size={amount}";

            return buildUrl;
        }

        /// <summary>
        /// Gets a list of already ripped avatars
        /// </summary>
        /// <param name="ripped"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public List<Avatar> GetList(List<string> ripped)
        {
            AvatarList avatarList = new AvatarList { records = new List<Avatar>() };

            if (ripped != null)
            {
                foreach (var item in ripped.Distinct().ToList())
                {
                    string url = $"{apiUrl}&filter=AvatarID,eq,{item}";

                    string jsonString = webRequest(url);

                    AvatarList items = JsonConvert.DeserializeObject<AvatarList>(jsonString);

                    avatarList.records = avatarList.records.Concat(items.records).ToList();
                }
                return avatarList.records;
            }
            return null;
        }

        /// <summary>
        /// Searches for avatars by author name
        /// </summary>
        /// <param name="publicAvatars"></param>
        /// <param name="privateAvatars"></param>
        /// <param name="questAvatars"></param>
        /// <param name="pcAvatars"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Avatar> blankSearch(bool publicAvatars = false, bool privateAvatars = false, bool questAvatars = false, bool pcAvatars = true, int amount = 10000, DateTime? before = null, DateTime? after = null)
        {
            if (apiKey == null)
            {
                throw new Exception("No Api Key Supplied");
            }

            string builtUrl = apiUrl;

            builtUrl = urlBuilder(builtUrl, publicAvatars, privateAvatars, questAvatars, pcAvatars, amount, before, after);

            string jsonString = webRequest(builtUrl);

            AvatarList items = JsonConvert.DeserializeObject<AvatarList>(jsonString);
            return items.records;
        }

        /// <summary>
        /// Searches for avatars by author name
        /// </summary>
        /// <param name="authorName"></param>
        /// <param name="containsSearch"></param>
        /// <param name="publicAvatars"></param>
        /// <param name="privateAvatars"></param>
        /// <param name="questAvatars"></param>
        /// <param name="pcAvatars"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Avatar> authorNameSearch(string authorName, bool containsSearch = true, bool publicAvatars = false, bool privateAvatars = false, bool questAvatars = false, bool pcAvatars = true, int amount = 10000, DateTime? before = null, DateTime? after = null)
        {
            if (apiKey == null)
            {
                throw new Exception("No Api Key Supplied");
            }

            string builtUrl = apiUrl;
            string contains = "cs";

            if (!containsSearch)
            {
                contains = "eq";
            }

            builtUrl += $"&filter=AuthorName,{contains},{authorName}";
            builtUrl = urlBuilder(builtUrl, publicAvatars, privateAvatars, questAvatars, pcAvatars, amount, before, after);

            string jsonString = webRequest(builtUrl);

            AvatarList items = JsonConvert.DeserializeObject<AvatarList>(jsonString);
            return items.records;
        }

        /// <summary>
        /// Searches for avatars by avatar name
        /// </summary>
        /// <param name="avatarName"></param>
        /// <param name="containsSearch"></param>
        /// <param name="publicAvatars"></param>
        /// <param name="privateAvatars"></param>
        /// <param name="questAvatars"></param>
        /// <param name="pcAvatars"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Avatar> avatarNameSearch(string avatarName, bool containsSearch = true, bool publicAvatars = false, bool privateAvatars = false, bool questAvatars = false, bool pcAvatars = true, int amount = 10000, DateTime? before = null, DateTime? after = null)
        {
            if (apiKey == null)
            {
                throw new Exception("No Api Key Supplied");
            }

            string builtUrl = apiUrl;
            string contains = "cs";

            if (!containsSearch)
            {
                contains = "eq";
            }

            builtUrl += $"&filter=AvatarName,{contains},{avatarName}";
            builtUrl = urlBuilder(builtUrl, publicAvatars, privateAvatars, questAvatars, pcAvatars, amount, before, after);

            string jsonString = webRequest(builtUrl);

            AvatarList items = JsonConvert.DeserializeObject<AvatarList>(jsonString);
            return items.records;
        }

        /// <summary>
        /// Searches for avatars by author id
        /// </summary>
        /// <param name="authorId"></param>
        /// <param name="publicAvatars"></param>
        /// <param name="privateAvatars"></param>
        /// <param name="questAvatars"></param>
        /// <param name="pcAvatars"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Avatar> authorIdSearch(string authorId, bool publicAvatars = false, bool privateAvatars = false, bool questAvatars = false, bool pcAvatars = true, int amount = 10000, DateTime? before = null, DateTime? after = null)
        {
            if (apiKey == null)
            {
                throw new Exception("No Api Key Supplied");
            }

            string builtUrl = apiUrl;

            builtUrl += $"&filter=AuthorID,eq,{authorId}";
            builtUrl = urlBuilder(builtUrl, publicAvatars, privateAvatars, questAvatars, pcAvatars, amount, before, after);

            string jsonString = webRequest(builtUrl);

            AvatarList items = JsonConvert.DeserializeObject<AvatarList>(jsonString);
            return items.records;
        }

        /// <summary>
        /// Searches for avatar by avatar id
        /// </summary>
        /// <param name="avatarId"></param>
        /// <param name="publicAvatars"></param>
        /// <param name="privateAvatars"></param>
        /// <param name="questAvatars"></param>
        /// <param name="pcAvatars"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<Avatar> avatarIdSearch(string avatarId, bool publicAvatars = false, bool privateAvatars = false, bool questAvatars = false, bool pcAvatars = true)
        {
            if (apiKey == null)
            {
                throw new Exception("No Api Key Supplied");
            }

            string builtUrl = apiUrl;

            builtUrl += $"&filter=AvatarID,eq,{avatarId}";
            builtUrl = urlBuilder(builtUrl, publicAvatars, privateAvatars, questAvatars, pcAvatars, 1, null, null);

            string jsonString = webRequest(builtUrl);

            AvatarList items = JsonConvert.DeserializeObject<AvatarList>(jsonString);
            return items.records;
        }

        /// <summary>
        /// Adds an avatar to the ARES API
        /// </summary>
        /// <param name="avatar"></param>
        /// <returns></returns>
        public bool AddAvatar(Avatar avatar)
        {
            if (AvatarCheck(avatar) == null) return false;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://unlocked.ares-mod.com/records/Avatars");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.UserAgent = $"ARES API.CORE V" + coreApiVersion;
            httpWebRequest.Headers.Add("X-API-Key: " + apiKey);
            string jsonPost = JsonConvert.SerializeObject(avatar);
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsonPost);
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
                Console.WriteLine($"Avatar: {avatar.AvatarID} uploaded to API");
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("(409) Conflict"))
                {
                    Console.WriteLine($"Avatar: {avatar.AvatarID} already on API");
                }
                return false;
            }
            return true;
        }

        private Avatar AvatarCheck(Avatar avatar)
        {
            if (avatar == null) { throw new Exception("Missing avatar model"); }
            if (avatar.PCAssetURL == null & avatar.QUESTAssetURL == null) { throw new Exception("Missing asset urls"); }
            if (avatar.PCAssetURL != null && avatar.PCAssetURL != "None")
            {
                if (!avatar.PCAssetURL.ToLower().Contains("https://api.vrchat.cloud"))
                {
                    throw new Exception("Malformed PC asset url");
                }
            }
            if (avatar.QUESTAssetURL != null && avatar.QUESTAssetURL != "None")
            {
                if (!avatar.QUESTAssetURL.ToLower().Contains("https://api.vrchat.cloud"))
                {
                    throw new Exception("Malformed Quest asset url");
                }
            }
            if (avatar.ThumbnailURL != null)
            {
                if (!avatar.ThumbnailURL.ToLower().Contains("https://api.vrchat.cloud"))
                {
                    throw new Exception("Malformed Thumbnail asset url");
                }
            }
            if (avatar.ImageURL != null)
            {
                if (!avatar.ThumbnailURL.ToLower().Contains("https://api.vrchat.cloud"))
                {
                    throw new Exception("Malformed Image asset url");
                }
            }
            if (avatar.TimeDetected == null)
            {
                avatar.TimeDetected = ((DateTimeOffset)DateTime.Now).ToUnixTimeSeconds().ToString();
            }
            if (avatar.AuthorName == null)
            {
                throw new Exception("Missing Author Name");
            }
            if (avatar.AuthorID == null)
            {
                throw new Exception("Missing Author ID");
            }
            if (avatar.AvatarID == null)
            {
                throw new Exception("Missing Avatar ID");
            }
            if (!avatar.AvatarID.ToLower().Contains("avtr_"))
            {
                throw new Exception("Malformed Avatar ID");
            }
            if (!avatar.AuthorID.ToLower().Contains("usr_"))
            {
                throw new Exception("Malformed User ID");
            }
            if (avatar.AvatarName == null)
            {
                throw new Exception("Missing Avatar Name");
            }
            if (avatar.UnityVersion == null)
            {
                avatar.UnityVersion = "2019.4.31f1";
            }
            if (avatar.Releasestatus == null)
            {
                throw new Exception("Missing release status");
            }
            if (avatar.Tags == null)
            {
                avatar.Tags = "None";
            }
            return avatar;
        }
    }
}