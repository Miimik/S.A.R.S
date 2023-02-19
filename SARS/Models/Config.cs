﻿using System;
using System.Collections.Generic;

namespace SARS.Models
{
    public class Config
    {
        public string UserId { get; set; }
        public string AuthKey { get; set; }
        public string TwoFactor { get; set; }
        public string ApiKey { get; set; }
        public string PreSelectedAvatarLocation { get; set; }
        public bool PreSelectedAvatarLocationChecked { get; set; }
        public string PreSelectedWorldLocation { get; set; }
        public bool PreSelectedWorldLocationChecked { get; set; }
        public string UnityLocation { get; set; }
        public string ClientVersion { get; set; }
        public string UnityVersion { get; set; }
        public DateTime ClientVersionLastUpdated { get; set; }
        public bool LightMode { get; set; }
        public string ThemeColor { get; set; }
        public string HotSwapName { get; set; }
        public string MacAddress { get; set; }
        public int HsbVersion { get; set; }
    }
}