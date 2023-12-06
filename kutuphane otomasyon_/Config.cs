﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace kutuphane_otomasyon_
{
    public class Config
    {
        private string _authdomain;
        private string _fbdomain;
        private string _fsdomain;
        private string _apikey;

        public Config() 
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            _authdomain = config.DocumentElement.SelectSingleNode("/FireBase/AuthDomain").InnerText.Trim();
            _fbdomain = config.DocumentElement.SelectSingleNode("/FireBase/FBDomain").InnerText.Trim();
            _fsdomain = config.DocumentElement.SelectSingleNode("/FireBase/FSDomain").InnerText.Trim();
            _apikey = config.DocumentElement.SelectSingleNode("/FireBase/ApiKey").InnerText.Trim();
        }

        public string AuthDomain
        { get { return _authdomain; } }
        
        public string FireBaseDomain
        { get { return _fbdomain; } }

        public string FireStorageDomain
        { get { return _fsdomain; } }

        public string ApiKey
        { get { return _apikey; } }
    }
}
