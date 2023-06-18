namespace BasicFacebookFeatures
{
    partial class FormMemories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemories));
            this.checkBoxOneDay = new System.Windows.Forms.CheckBox();
            this.lableEndDate = new System.Windows.Forms.Label();
            this.labelFirstDate = new System.Windows.Forms.Label();
            this.groupBoxMemoriesDate = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.buttonFetchMemories = new System.Windows.Forms.Button();
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            this.listViewMemoriesPhotos = new System.Windows.Forms.ListView();
            this.listBoxMemoriesList = new System.Windows.Forms.ListBox();
            this.checkedListBoxOptions = new System.Windows.Forms.CheckedListBox();
            this.labelMemoriesOptions = new System.Windows.Forms.Label();
            this.pictureBoxCoverForm = new System.Windows.Forms.PictureBox();
            this.groupBoxMemoriesDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverForm)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxOneDay
            // 
            this.checkBoxOneDay.AutoSize = true;
            this.checkBoxOneDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOneDay.Location = new System.Drawing.Point(47, 113);
            this.checkBoxOneDay.Name = "checkBoxOneDay";
            this.checkBoxOneDay.Size = new System.Drawing.Size(107, 23);
            this.checkBoxOneDay.TabIndex = 10;
            this.checkBoxOneDay.Text = "only one day";
            this.checkBoxOneDay.UseVisualStyleBackColor = true;
            // 
            // lableEndDate
            // 
            this.lableEndDate.AutoSize = true;
            this.lableEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableEndDate.Location = new System.Drawing.Point(29, 86);
            this.lableEndDate.Name = "lableEndDate";
            this.lableEndDate.Size = new System.Drawing.Size(129, 21);
            this.lableEndDate.TabIndex = 7;
            this.lableEndDate.Text = "Choose end date:";
            // 
            // labelFirstDate
            // 
            this.labelFirstDate.AutoSize = true;
            this.labelFirstDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstDate.Location = new System.Drawing.Point(29, 26);
            this.labelFirstDate.Name = "labelFirstDate";
            this.labelFirstDate.Size = new System.Drawing.Size(134, 21);
            this.labelFirstDate.TabIndex = 0;
            this.labelFirstDate.Text = "Choose start date:";
            // 
            // groupBoxMemoriesDate
            // 
            this.groupBoxMemoriesDate.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxMemoriesDate.Controls.Add(this.dateTimePickerStartDate);
            this.groupBoxMemoriesDate.Controls.Add(this.checkBoxOneDay);
            this.groupBoxMemoriesDate.Controls.Add(this.lableEndDate);
            this.groupBoxMemoriesDate.Controls.Add(this.labelFirstDate);
            this.groupBoxMemoriesDate.Location = new System.Drawing.Point(8, -5);
            this.groupBoxMemoriesDate.Name = "groupBoxMemoriesDate";
            this.groupBoxMemoriesDate.Size = new System.Drawing.Size(216, 189);
            this.groupBoxMemoriesDate.TabIndex = 20;
            this.groupBoxMemoriesDate.TabStop = false;
            this.groupBoxMemoriesDate.Text = "z";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(10, 142);
            this.dateTimePickerEndDate.MaxDate = new System.DateTime(2023, 6, 16, 16, 4, 20, 0);
            this.dateTimePickerEndDate.MinDate = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 12;
            this.dateTimePickerEndDate.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(10, 59);
            this.dateTimePickerStartDate.MaxDate = new System.DateTime(2023, 6, 16, 0, 0, 0, 0);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2006, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 11;
            this.dateTimePickerStartDate.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // buttonFetchMemories
            // 
            this.buttonFetchMemories.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonFetchMemories.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchMemories.Image = ((System.Drawing.Image)(resources.GetObject("buttonFetchMemories.Image")));
            this.buttonFetchMemories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFetchMemories.Location = new System.Drawing.Point(25, 400);
            this.buttonFetchMemories.Name = "buttonFetchMemories";
            this.buttonFetchMemories.Size = new System.Drawing.Size(185, 45);
            this.buttonFetchMemories.TabIndex = 18;
            this.buttonFetchMemories.Text = "Fetch!";
            this.buttonFetchMemories.UseVisualStyleBackColor = false;
            this.buttonFetchMemories.Click += new System.EventHandler(this.buttonFetchMemories_Click);
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnToMenu.ForeColor = System.Drawing.Color.White;
            this.buttonReturnToMenu.Location = new System.Drawing.Point(722, 30);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(60, 27);
            this.buttonReturnToMenu.TabIndex = 21;
            this.buttonReturnToMenu.Text = "Return";
            this.buttonReturnToMenu.UseVisualStyleBackColor = false;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // listViewMemoriesPhotos
            // 
            this.listViewMemoriesPhotos.HideSelection = false;
            this.listViewMemoriesPhotos.Location = new System.Drawing.Point(512, 203);
            this.listViewMemoriesPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.listViewMemoriesPhotos.Name = "listViewMemoriesPhotos";
            this.listViewMemoriesPhotos.Size = new System.Drawing.Size(281, 278);
            this.listViewMemoriesPhotos.TabIndex = 23;
            this.listViewMemoriesPhotos.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxMemoriesList
            // 
            this.listBoxMemoriesList.FormattingEnabled = true;
            this.listBoxMemoriesList.Location = new System.Drawing.Point(242, 204);
            this.listBoxMemoriesList.Name = "listBoxMemoriesList";
            this.listBoxMemoriesList.Size = new System.Drawing.Size(266, 277);
            this.listBoxMemoriesList.TabIndex = 22;
            // 
            // checkedListBoxOptions
            // 
            this.checkedListBoxOptions.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkedListBoxOptions.FormattingEnabled = true;
            this.checkedListBoxOptions.Items.AddRange(new object[] {
            "All",
            "Posts",
            "Photos",
            "Events",
            "Friends",
            "Groups"});
            this.checkedListBoxOptions.Location = new System.Drawing.Point(28, 250);
            this.checkedListBoxOptions.Name = "checkedListBoxOptions";
            this.checkedListBoxOptions.Size = new System.Drawing.Size(182, 144);
            this.checkedListBoxOptions.TabIndex = 17;
            this.checkedListBoxOptions.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxOptions_SelectedIndexChanged);
            // 
            // labelMemoriesOptions
            // 
            this.labelMemoriesOptions.AutoSize = true;
            this.labelMemoriesOptions.BackColor = System.Drawing.SystemColors.Menu;
            this.labelMemoriesOptions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMemoriesOptions.Location = new System.Drawing.Point(28, 218);
            this.labelMemoriesOptions.Name = "labelMemoriesOptions";
            this.labelMemoriesOptions.Size = new System.Drawing.Size(180, 25);
            this.labelMemoriesOptions.TabIndex = 16;
            this.labelMemoriesOptions.Text = "Choose what to see:";
            // 
            // pictureBoxCoverForm
            // 
            this.pictureBoxCoverForm.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCoverForm.Image")));
            this.pictureBoxCoverForm.Location = new System.Drawing.Point(242, 6);
            this.pictureBoxCoverForm.Name = "pictureBoxCoverForm";
            this.pictureBoxCoverForm.Size = new System.Drawing.Size(550, 192);
            this.pictureBoxCoverForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoverForm.TabIndex = 19;
            this.pictureBoxCoverForm.TabStop = false;
            // 
            // FormMemories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(807, 490);
            this.Controls.Add(this.groupBoxMemoriesDate);
            this.Controls.Add(this.buttonFetchMemories);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Controls.Add(this.listViewMemoriesPhotos);
            this.Controls.Add(this.listBoxMemoriesList);
            this.Controls.Add(this.checkedListBoxOptions);
            this.Controls.Add(this.labelMemoriesOptions);
            this.Controls.Add(this.pictureBoxCoverForm);
            this.Name = "FormMemories";
            this.Text = "FormMemories";
            this.groupBoxMemoriesDate.ResumeLayout(false);
            this.groupBoxMemoriesDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxOneDay;
        private System.Windows.Forms.Label lableEndDate;
        private System.Windows.Forms.Label labelFirstDate;
        private System.Windows.Forms.GroupBox groupBoxMemoriesDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.PictureBox pictureBoxCoverForm;
        private System.Windows.Forms.Button buttonFetchMemories;
        private System.Windows.Forms.Button buttonReturnToMenu;
        private System.Windows.Forms.ListView listViewMemoriesPhotos;
        private System.Windows.Forms.ListBox listBoxMemoriesList;
        private System.Windows.Forms.CheckedListBox checkedListBoxOptions;
        private System.Windows.Forms.Label labelMemoriesOptions;
    }
}