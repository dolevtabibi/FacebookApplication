﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Logic
{
    public sealed class AppSettings
    {
        public string LastAccessToken { get; set; }

        public bool AutoLogin { get; set; }

        public Size LastWindowsSize { get; set; }

        public Point LastWindowsLocation { get; set; }

        private static readonly string sr_AppSettingsFilePath = Directory.GetCurrentDirectory() + "\\appsettings.xml";

        public static AppSettings LoadSettingsFromFile()
        {
            AppSettings appSettings;
            if (File.Exists(sr_AppSettingsFilePath))
            {
                using (Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        private AppSettings()
        {
            AutoLogin = false;
            LastAccessToken = null;
            LastWindowsSize = new Size(1245, 749);
            LastWindowsLocation = new Point(50, 50);
        }

        public void SaveSettingsToFile()
        {
            using (Stream stream = new FileStream(sr_AppSettingsFilePath, FileMode.Create, FileAccess.ReadWrite))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}