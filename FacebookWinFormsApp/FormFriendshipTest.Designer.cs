namespace BasicFacebookFeatures
{
    partial class FormFriendshipTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriendshipTest));
            this.listBoxFriendsList = new System.Windows.Forms.CheckedListBox();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.panelChooseFriends = new System.Windows.Forms.Panel();
            this.buttonChooseFriend = new System.Windows.Forms.Button();
            this.buttonSelectRandomFriend = new System.Windows.Forms.Button();
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            this.labelSentence = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChooseFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.Location = new System.Drawing.Point(23, 19);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(144, 139);
            this.listBoxFriendsList.TabIndex = 16;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonContinue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.White;
            this.buttonContinue.Location = new System.Drawing.Point(51, 162);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(89, 34);
            this.buttonContinue.TabIndex = 15;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // panelChooseFriends
            // 
            this.panelChooseFriends.Controls.Add(this.listBoxFriendsList);
            this.panelChooseFriends.Controls.Add(this.buttonContinue);
            this.panelChooseFriends.Location = new System.Drawing.Point(306, 229);
            this.panelChooseFriends.Name = "panelChooseFriends";
            this.panelChooseFriends.Size = new System.Drawing.Size(186, 197);
            this.panelChooseFriends.TabIndex = 18;
            this.panelChooseFriends.Visible = false;
            // 
            // buttonChooseFriend
            // 
            this.buttonChooseFriend.BackColor = System.Drawing.Color.Green;
            this.buttonChooseFriend.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseFriend.ForeColor = System.Drawing.Color.White;
            this.buttonChooseFriend.Location = new System.Drawing.Point(12, 300);
            this.buttonChooseFriend.Name = "buttonChooseFriend";
            this.buttonChooseFriend.Size = new System.Drawing.Size(155, 71);
            this.buttonChooseFriend.TabIndex = 19;
            this.buttonChooseFriend.Text = "Choose your \r\nfriend";
            this.buttonChooseFriend.UseVisualStyleBackColor = false;
            this.buttonChooseFriend.Click += new System.EventHandler(this.buttonChooseFriend_Click);
            // 
            // buttonSelectRandomFriend
            // 
            this.buttonSelectRandomFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonSelectRandomFriend.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectRandomFriend.ForeColor = System.Drawing.Color.White;
            this.buttonSelectRandomFriend.Location = new System.Drawing.Point(612, 300);
            this.buttonSelectRandomFriend.Name = "buttonSelectRandomFriend";
            this.buttonSelectRandomFriend.Size = new System.Drawing.Size(167, 71);
            this.buttonSelectRandomFriend.TabIndex = 20;
            this.buttonSelectRandomFriend.Text = "Select random \r\nfriend";
            this.buttonSelectRandomFriend.UseVisualStyleBackColor = false;
            this.buttonSelectRandomFriend.Click += new System.EventHandler(this.buttonSelectRandomFriend_Click);
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnToMenu.ForeColor = System.Drawing.Color.White;
            this.buttonReturnToMenu.Location = new System.Drawing.Point(715, 12);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(73, 34);
            this.buttonReturnToMenu.TabIndex = 21;
            this.buttonReturnToMenu.Text = "Return";
            this.buttonReturnToMenu.UseVisualStyleBackColor = false;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // labelSentence
            // 
            this.labelSentence.AutoSize = true;
            this.labelSentence.BackColor = System.Drawing.SystemColors.Control;
            this.labelSentence.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentence.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSentence.Location = new System.Drawing.Point(163, 56);
            this.labelSentence.Name = "labelSentence";
            this.labelSentence.Size = new System.Drawing.Size(442, 32);
            this.labelSentence.TabIndex = 23;
            this.labelSentence.Text = "Let\'s see how well you know your friend";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Black;
            this.labelWelcome.Location = new System.Drawing.Point(108, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(547, 47);
            this.labelWelcome.TabIndex = 22;
            this.labelWelcome.Text = "Welcome to our friendship Test!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(79, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 91);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FormFriendshipTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSentence);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Controls.Add(this.buttonSelectRandomFriend);
            this.Controls.Add(this.buttonChooseFriend);
            this.Controls.Add(this.panelChooseFriends);
            this.Name = "FormFriendshipTest";
            this.Text = "FormFriendshipTest";
            this.panelChooseFriends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox listBoxFriendsList;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Panel panelChooseFriends;
        private System.Windows.Forms.Button buttonChooseFriend;
        private System.Windows.Forms.Button buttonSelectRandomFriend;
        private System.Windows.Forms.Button buttonReturnToMenu;
        private System.Windows.Forms.Label labelSentence;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}