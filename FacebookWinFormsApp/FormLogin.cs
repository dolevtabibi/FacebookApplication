using Facebook;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private const string k_AppId = "1901708656860093";
        public AppSettings AppSettings { get; }
        private readonly AppLogic r_AppLogic = AppLogic.Instance;
        public bool IsLoggedIn { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
            AppSettings = AppSettings.LoadSettingsFromFile();
            checkBoxAutoLogin.Checked = false;
            if (AppSettings.AutoLogin == true)
            {
                bool loggedIn = false;
                r_AppLogic.AccessToken = AppSettings.LastAccessToken;
                if (AppSettings.LastAccessToken != null)
                {
                    r_AppLogic.Connect(AppSettings.LastAccessToken, k_AppId, ref loggedIn);
                }

                IsLoggedIn = loggedIn;
            }
            else
            {
                checkBoxAutoLogin.Checked = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                bool loggedIn = false;
                r_AppLogic.Connect(AppSettings.LastAccessToken, k_AppId, ref loggedIn);
                IsLoggedIn = loggedIn;
                Close();
            }
            catch (FacebookApiException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            AppSettings.AutoLogin = checkBoxAutoLogin.Checked;
            base.OnClosed(e);
        }
    }
}
