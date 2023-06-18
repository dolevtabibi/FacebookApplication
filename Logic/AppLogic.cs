﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public sealed class AppLogic
    {
        private AppLogic()
        {
            
        }

        private static readonly object sr_LockGetContext = new object();
        private static AppLogic s_Instance;

        public static AppLogic Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockGetContext)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppLogic();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public string AccessToken { get; set; }

        private IFacebookUser m_FacebookUser;

        public IFacebookUser GetUser()
        {
            return m_FacebookUser;
        }

        public void Connect(string i_AppSettingsLastAccessToken, string i_AppId, ref bool io_IsLoggedIn)
        {
            m_FacebookUser = FacebookConnector.Connect(i_AppSettingsLastAccessToken, i_AppId, ref io_IsLoggedIn);
        }
    }
}
