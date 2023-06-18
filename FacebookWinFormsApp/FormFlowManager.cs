using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FormFlowManager
    {
        private readonly FormLogin r_StartForm = new FormLogin();
        private FormMain m_FacebookMainForm;

        public void RunApp()
        {
            try
            {
                if (r_StartForm.AppSettings.LastAccessToken == null)
                {
                    r_StartForm.ShowDialog();
                }

                m_FacebookMainForm = new FormMain(r_StartForm.AppSettings);
                if (r_StartForm.IsLoggedIn)
                {
                    m_FacebookMainForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"An error occurred: {ex.Message} {Environment.NewLine} The App will close now.");
            }
        }
    }
}
