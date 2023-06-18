namespace BasicFacebookFeatures
{
    partial class FormBiggerPicture
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
            this.PictureBoxBigger = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBigger)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxBigger
            // 
            this.PictureBoxBigger.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxBigger.Name = "PictureBoxBigger";
            this.PictureBoxBigger.Size = new System.Drawing.Size(260, 237);
            this.PictureBoxBigger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxBigger.TabIndex = 1;
            this.PictureBoxBigger.TabStop = false;
            // 
            // FormBiggerPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = true;
            this.Controls.Add(this.PictureBoxBigger);
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "FormBiggerPicture";
            this.Text = "FormBiggerPicture";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBigger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PictureBoxBigger;
    }
}