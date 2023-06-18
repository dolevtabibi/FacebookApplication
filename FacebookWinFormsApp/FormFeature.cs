using FacebookWrapper.ObjectModel;
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
    public partial class FormFeature : Form
    {
        public IFacebookUser User { get; set; }

        internal FormFeature()
        {
            InitializeComponent();
            ControlBox = false;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            /*if (User == null)
            {
                string vMessage = $"Can't start feature without a user.";

                MessageBox.Show(vMessage);
                Close();
            }*/
        }
    }
}
