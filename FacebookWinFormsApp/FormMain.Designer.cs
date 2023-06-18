namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.buttonFetchFavoriteTeams = new System.Windows.Forms.Button();
            this.buttonFetchGroups = new System.Windows.Forms.Button();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.textBoxStatusText = new System.Windows.Forms.TextBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBoxFriendProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxFavoriteTeam = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroups = new System.Windows.Forms.PictureBox();
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.buttonSortByMostLikes = new System.Windows.Forms.Button();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.tabControlPostItems = new System.Windows.Forms.TabControl();
            this.Status = new System.Windows.Forms.TabPage();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.Posts = new System.Windows.Forms.TabPage();
            this.Groups = new System.Windows.Forms.TabPage();
            this.FavoriteTeams = new System.Windows.Forms.TabPage();
            this.LikedPages = new System.Windows.Forms.TabPage();
            this.Events = new System.Windows.Forms.TabPage();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.buttonBasicInfo = new System.Windows.Forms.Button();
            this.groupBoxFriendsList = new System.Windows.Forms.GroupBox();
            this.buttonMemories = new System.Windows.Forms.Button();
            this.buttonFetchAlbums = new System.Windows.Forms.Button();
            this.buttonFriendshipTest = new System.Windows.Forms.Button();
            this.textBoxSearchFriend = new System.Windows.Forms.TextBox();
            this.buttonFriendsList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
            this.tabControlPostItems.SuspendLayout();
            this.Status.SuspendLayout();
            this.Posts.SuspendLayout();
            this.Groups.SuspendLayout();
            this.FavoriteTeams.SuspendLayout();
            this.LikedPages.SuspendLayout();
            this.Events.SuspendLayout();
            this.groupBoxBasicInfo.SuspendLayout();
            this.groupBoxFriendsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(101, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1029, 17);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(34, 95);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(97, 23);
            this.buttonFetchPosts.TabIndex = 2;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.Location = new System.Drawing.Point(7, 119);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(98, 34);
            this.buttonSetStatus.TabIndex = 5;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = true;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.Location = new System.Drawing.Point(187, 56);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(109, 23);
            this.buttonLikedPages.TabIndex = 6;
            this.buttonLikedPages.Text = "Fetch Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = true;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // buttonFetchFavoriteTeams
            // 
            this.buttonFetchFavoriteTeams.Location = new System.Drawing.Point(190, 61);
            this.buttonFetchFavoriteTeams.Name = "buttonFetchFavoriteTeams";
            this.buttonFetchFavoriteTeams.Size = new System.Drawing.Size(120, 23);
            this.buttonFetchFavoriteTeams.TabIndex = 7;
            this.buttonFetchFavoriteTeams.Text = "Fetch Favorite Teams";
            this.buttonFetchFavoriteTeams.UseVisualStyleBackColor = true;
            this.buttonFetchFavoriteTeams.Click += new System.EventHandler(this.buttonFetchFavoriteTeams_Click);
            // 
            // buttonFetchGroups
            // 
            this.buttonFetchGroups.Location = new System.Drawing.Point(187, 61);
            this.buttonFetchGroups.Name = "buttonFetchGroups";
            this.buttonFetchGroups.Size = new System.Drawing.Size(120, 23);
            this.buttonFetchGroups.TabIndex = 8;
            this.buttonFetchGroups.Text = "Fetch Groups";
            this.buttonFetchGroups.UseVisualStyleBackColor = true;
            this.buttonFetchGroups.Click += new System.EventHandler(this.buttonFetchGroups_Click);
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(190, 53);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(120, 23);
            this.buttonFetchEvents.TabIndex = 9;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // textBoxStatusText
            // 
            this.textBoxStatusText.Location = new System.Drawing.Point(12, 213);
            this.textBoxStatusText.Name = "textBoxStatusText";
            this.textBoxStatusText.Size = new System.Drawing.Size(179, 20);
            this.textBoxStatusText.TabIndex = 11;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 73);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(179, 131);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 12;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxFacebookLogo
            // 
            this.pictureBoxFacebookLogo.Location = new System.Drawing.Point(174, 3);
            this.pictureBoxFacebookLogo.Name = "pictureBoxFacebookLogo";
            this.pictureBoxFacebookLogo.Size = new System.Drawing.Size(340, 99);
            this.pictureBoxFacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebookLogo.TabIndex = 13;
            this.pictureBoxFacebookLogo.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 17;
            this.listBoxPosts.Location = new System.Drawing.Point(3, 0);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(183, 89);
            this.listBoxPosts.TabIndex = 14;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(8, 74);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(178, 147);
            this.listBoxFriends.TabIndex = 15;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 17;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(6, 7);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(178, 157);
            this.listBoxFavoriteTeams.TabIndex = 16;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 17;
            this.listBoxGroups.Location = new System.Drawing.Point(3, 8);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(178, 157);
            this.listBoxGroups.TabIndex = 17;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 17;
            this.listBoxLikedPages.Location = new System.Drawing.Point(3, 6);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(178, 157);
            this.listBoxLikedPages.TabIndex = 18;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = this.photoBindingSource;
            // 
            // photoBindingSource
            // 
            this.photoBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Photo);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 17;
            this.listBoxEvents.Location = new System.Drawing.Point(6, 4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(178, 140);
            this.listBoxEvents.TabIndex = 20;
            // 
            // pictureBoxFriendProfile
            // 
            this.pictureBoxFriendProfile.BackColor = System.Drawing.Color.White;
            this.pictureBoxFriendProfile.Location = new System.Drawing.Point(121, 162);
            this.pictureBoxFriendProfile.Name = "pictureBoxFriendProfile";
            this.pictureBoxFriendProfile.Size = new System.Drawing.Size(65, 58);
            this.pictureBoxFriendProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriendProfile.TabIndex = 21;
            this.pictureBoxFriendProfile.TabStop = false;
            // 
            // pictureBoxFavoriteTeam
            // 
            this.pictureBoxFavoriteTeam.BackColor = System.Drawing.Color.White;
            this.pictureBoxFavoriteTeam.Location = new System.Drawing.Point(119, 103);
            this.pictureBoxFavoriteTeam.Name = "pictureBoxFavoriteTeam";
            this.pictureBoxFavoriteTeam.Size = new System.Drawing.Size(60, 57);
            this.pictureBoxFavoriteTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFavoriteTeam.TabIndex = 0;
            this.pictureBoxFavoriteTeam.TabStop = false;
            // 
            // pictureBoxGroups
            // 
            this.pictureBoxGroups.BackColor = System.Drawing.Color.White;
            this.pictureBoxGroups.Location = new System.Drawing.Point(111, 104);
            this.pictureBoxGroups.Name = "pictureBoxGroups";
            this.pictureBoxGroups.Size = new System.Drawing.Size(65, 57);
            this.pictureBoxGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroups.TabIndex = 30;
            this.pictureBoxGroups.TabStop = false;
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.BackColor = System.Drawing.Color.White;
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(111, 101);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(65, 58);
            this.pictureBoxLikedPages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikedPages.TabIndex = 31;
            this.pictureBoxLikedPages.TabStop = false;
            // 
            // buttonSortByMostLikes
            // 
            this.buttonSortByMostLikes.Location = new System.Drawing.Point(34, 124);
            this.buttonSortByMostLikes.Name = "buttonSortByMostLikes";
            this.buttonSortByMostLikes.Size = new System.Drawing.Size(97, 27);
            this.buttonSortByMostLikes.TabIndex = 32;
            this.buttonSortByMostLikes.Text = "Sort by most likes";
            this.buttonSortByMostLikes.UseVisualStyleBackColor = true;
            this.buttonSortByMostLikes.Click += new System.EventHandler(this.buttonSortByMostLikes_Click);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 17;
            this.listBoxPostComments.Location = new System.Drawing.Point(192, 3);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(200, 157);
            this.listBoxPostComments.TabIndex = 33;
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(13, 42);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(100, 17);
            this.checkBoxRememberUser.TabIndex = 34;
            this.checkBoxRememberUser.Text = "Remember me?";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // tabControlPostItems
            // 
            this.tabControlPostItems.Controls.Add(this.Status);
            this.tabControlPostItems.Controls.Add(this.Posts);
            this.tabControlPostItems.Controls.Add(this.Groups);
            this.tabControlPostItems.Controls.Add(this.FavoriteTeams);
            this.tabControlPostItems.Controls.Add(this.LikedPages);
            this.tabControlPostItems.Controls.Add(this.Events);
            this.tabControlPostItems.Enabled = false;
            this.tabControlPostItems.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPostItems.ImageList = this.imageListIcons;
            this.tabControlPostItems.Location = new System.Drawing.Point(12, 295);
            this.tabControlPostItems.Name = "tabControlPostItems";
            this.tabControlPostItems.SelectedIndex = 0;
            this.tabControlPostItems.Size = new System.Drawing.Size(524, 198);
            this.tabControlPostItems.TabIndex = 36;
            // 
            // Status
            // 
            this.Status.Controls.Add(this.textBoxPost);
            this.Status.Controls.Add(this.buttonSetStatus);
            this.Status.ImageIndex = 0;
            this.Status.Location = new System.Drawing.Point(4, 26);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(516, 168);
            this.Status.TabIndex = 0;
            this.Status.Text = "Status";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(7, 5);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(298, 80);
            this.textBoxPost.TabIndex = 5;
            this.textBoxPost.Text = "What\'s on your mind?";
            this.textBoxPost.Enter += new System.EventHandler(this.addText);
            this.textBoxPost.Leave += new System.EventHandler(this.removeText);
            // 
            // Posts
            // 
            this.Posts.Controls.Add(this.listBoxPosts);
            this.Posts.Controls.Add(this.buttonFetchPosts);
            this.Posts.Controls.Add(this.buttonSortByMostLikes);
            this.Posts.Controls.Add(this.listBoxPostComments);
            this.Posts.ImageIndex = 1;
            this.Posts.Location = new System.Drawing.Point(4, 26);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(516, 168);
            this.Posts.TabIndex = 1;
            this.Posts.Text = "Posts";
            this.Posts.UseVisualStyleBackColor = true;
            // 
            // Groups
            // 
            this.Groups.Controls.Add(this.pictureBoxGroups);
            this.Groups.Controls.Add(this.buttonFetchGroups);
            this.Groups.Controls.Add(this.listBoxGroups);
            this.Groups.ImageIndex = 2;
            this.Groups.Location = new System.Drawing.Point(4, 26);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(516, 168);
            this.Groups.TabIndex = 2;
            this.Groups.Text = "Groups";
            this.Groups.UseVisualStyleBackColor = true;
            // 
            // FavoriteTeams
            // 
            this.FavoriteTeams.Controls.Add(this.buttonFetchFavoriteTeams);
            this.FavoriteTeams.Controls.Add(this.pictureBoxFavoriteTeam);
            this.FavoriteTeams.Controls.Add(this.listBoxFavoriteTeams);
            this.FavoriteTeams.ImageIndex = 3;
            this.FavoriteTeams.Location = new System.Drawing.Point(4, 26);
            this.FavoriteTeams.Name = "FavoriteTeams";
            this.FavoriteTeams.Padding = new System.Windows.Forms.Padding(3);
            this.FavoriteTeams.Size = new System.Drawing.Size(516, 168);
            this.FavoriteTeams.TabIndex = 3;
            this.FavoriteTeams.Text = "Favorite Teams";
            this.FavoriteTeams.UseVisualStyleBackColor = true;
            // 
            // LikedPages
            // 
            this.LikedPages.Controls.Add(this.buttonLikedPages);
            this.LikedPages.Controls.Add(this.pictureBoxLikedPages);
            this.LikedPages.Controls.Add(this.listBoxLikedPages);
            this.LikedPages.ImageIndex = 4;
            this.LikedPages.Location = new System.Drawing.Point(4, 26);
            this.LikedPages.Name = "LikedPages";
            this.LikedPages.Padding = new System.Windows.Forms.Padding(3);
            this.LikedPages.Size = new System.Drawing.Size(516, 168);
            this.LikedPages.TabIndex = 4;
            this.LikedPages.Text = "Liked Pages";
            this.LikedPages.UseVisualStyleBackColor = true;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.listBoxEvents);
            this.Events.Controls.Add(this.buttonFetchEvents);
            this.Events.ImageIndex = 5;
            this.Events.Location = new System.Drawing.Point(4, 26);
            this.Events.Name = "Events";
            this.Events.Padding = new System.Windows.Forms.Padding(3);
            this.Events.Size = new System.Drawing.Size(516, 168);
            this.Events.TabIndex = 5;
            this.Events.Text = "Events";
            this.Events.UseVisualStyleBackColor = true;
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "status.jpg");
            this.imageListIcons.Images.SetKeyName(1, "pen-icon (1).png");
            this.imageListIcons.Images.SetKeyName(2, "Users-icon.png");
            this.imageListIcons.Images.SetKeyName(3, "favorite team.png");
            this.imageListIcons.Images.SetKeyName(4, "liked pages.jpg");
            this.imageListIcons.Images.SetKeyName(5, "Event-search-icon.png");
            // 
            // groupBoxBasicInfo
            // 
            this.groupBoxBasicInfo.Controls.Add(this.listBoxInfo);
            this.groupBoxBasicInfo.Controls.Add(this.buttonBasicInfo);
            this.groupBoxBasicInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBasicInfo.Location = new System.Drawing.Point(207, 117);
            this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
            this.groupBoxBasicInfo.Size = new System.Drawing.Size(261, 135);
            this.groupBoxBasicInfo.TabIndex = 37;
            this.groupBoxBasicInfo.TabStop = false;
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(8, 34);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(247, 69);
            this.listBoxInfo.TabIndex = 2;
            // 
            // buttonBasicInfo
            // 
            this.buttonBasicInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBasicInfo.Image = global::BasicFacebookFeatures.Properties.Resources.Actions_help_about_icon;
            this.buttonBasicInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBasicInfo.Location = new System.Drawing.Point(6, 0);
            this.buttonBasicInfo.Name = "buttonBasicInfo";
            this.buttonBasicInfo.Size = new System.Drawing.Size(133, 30);
            this.buttonBasicInfo.TabIndex = 20;
            this.buttonBasicInfo.Text = "Basic information:";
            this.buttonBasicInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBasicInfo.UseVisualStyleBackColor = true;
            // 
            // groupBoxFriendsList
            // 
            this.groupBoxFriendsList.Controls.Add(this.buttonMemories);
            this.groupBoxFriendsList.Controls.Add(this.buttonFetchAlbums);
            this.groupBoxFriendsList.Controls.Add(this.buttonFriendshipTest);
            this.groupBoxFriendsList.Controls.Add(this.textBoxSearchFriend);
            this.groupBoxFriendsList.Controls.Add(this.buttonFriendsList);
            this.groupBoxFriendsList.Controls.Add(this.pictureBoxFriendProfile);
            this.groupBoxFriendsList.Controls.Add(this.listBoxFriends);
            this.groupBoxFriendsList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFriendsList.Location = new System.Drawing.Point(546, 17);
            this.groupBoxFriendsList.Name = "groupBoxFriendsList";
            this.groupBoxFriendsList.Size = new System.Drawing.Size(452, 276);
            this.groupBoxFriendsList.TabIndex = 38;
            this.groupBoxFriendsList.TabStop = false;
            // 
            // buttonMemories
            // 
            this.buttonMemories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonMemories.Enabled = false;
            this.buttonMemories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMemories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMemories.ForeColor = System.Drawing.Color.White;
            this.buttonMemories.Image = ((System.Drawing.Image)(resources.GetObject("buttonMemories.Image")));
            this.buttonMemories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMemories.Location = new System.Drawing.Point(217, 63);
            this.buttonMemories.Name = "buttonMemories";
            this.buttonMemories.Size = new System.Drawing.Size(184, 67);
            this.buttonMemories.TabIndex = 30;
            this.buttonMemories.Text = "Search Memories\r\n";
            this.buttonMemories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMemories.UseVisualStyleBackColor = false;
            this.buttonMemories.Click += new System.EventHandler(this.buttonMemories_Click);
            // 
            // buttonFetchAlbums
            // 
            this.buttonFetchAlbums.Enabled = false;
            this.buttonFetchAlbums.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchAlbums.Image = global::BasicFacebookFeatures.Properties.Resources.Images_icon;
            this.buttonFetchAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFetchAlbums.Location = new System.Drawing.Point(240, 226);
            this.buttonFetchAlbums.Name = "buttonFetchAlbums";
            this.buttonFetchAlbums.Size = new System.Drawing.Size(138, 43);
            this.buttonFetchAlbums.TabIndex = 29;
            this.buttonFetchAlbums.Text = "Fetch Albums";
            this.buttonFetchAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFetchAlbums.UseVisualStyleBackColor = true;
            this.buttonFetchAlbums.Click += new System.EventHandler(this.buttonFetchAlbums_Click_1);
            // 
            // buttonFriendshipTest
            // 
            this.buttonFriendshipTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonFriendshipTest.Enabled = false;
            this.buttonFriendshipTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFriendshipTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriendshipTest.ForeColor = System.Drawing.Color.White;
            this.buttonFriendshipTest.Image = ((System.Drawing.Image)(resources.GetObject("buttonFriendshipTest.Image")));
            this.buttonFriendshipTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFriendshipTest.Location = new System.Drawing.Point(217, 150);
            this.buttonFriendshipTest.Name = "buttonFriendshipTest";
            this.buttonFriendshipTest.Size = new System.Drawing.Size(184, 67);
            this.buttonFriendshipTest.TabIndex = 28;
            this.buttonFriendshipTest.Text = "Friendship Test";
            this.buttonFriendshipTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFriendshipTest.UseVisualStyleBackColor = false;
            this.buttonFriendshipTest.Click += new System.EventHandler(this.buttonFriendshipTest_Click);
            // 
            // textBoxSearchFriend
            // 
            this.textBoxSearchFriend.Location = new System.Drawing.Point(6, 33);
            this.textBoxSearchFriend.Name = "textBoxSearchFriend";
            this.textBoxSearchFriend.Size = new System.Drawing.Size(249, 22);
            this.textBoxSearchFriend.TabIndex = 12;
            this.textBoxSearchFriend.Text = "Search friend...";
            this.textBoxSearchFriend.TextChanged += new System.EventHandler(this.textBoxSearchFriend_TextChanged);
            this.textBoxSearchFriend.Enter += new System.EventHandler(this.addText);
            this.textBoxSearchFriend.Leave += new System.EventHandler(this.removeText);
            // 
            // buttonFriendsList
            // 
            this.buttonFriendsList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriendsList.Image = ((System.Drawing.Image)(resources.GetObject("buttonFriendsList.Image")));
            this.buttonFriendsList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFriendsList.Location = new System.Drawing.Point(8, 0);
            this.buttonFriendsList.Name = "buttonFriendsList";
            this.buttonFriendsList.Size = new System.Drawing.Size(98, 28);
            this.buttonFriendsList.TabIndex = 23;
            this.buttonFriendsList.Text = "Friends list:";
            this.buttonFriendsList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFriendsList.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1120, 509);
            this.Controls.Add(this.groupBoxFriendsList);
            this.Controls.Add(this.groupBoxBasicInfo);
            this.Controls.Add(this.tabControlPostItems);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.pictureBoxFacebookLogo);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.textBoxStatusText);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
            this.tabControlPostItems.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.Posts.ResumeLayout(false);
            this.Groups.ResumeLayout(false);
            this.FavoriteTeams.ResumeLayout(false);
            this.LikedPages.ResumeLayout(false);
            this.Events.ResumeLayout(false);
            this.groupBoxBasicInfo.ResumeLayout(false);
            this.groupBoxFriendsList.ResumeLayout(false);
            this.groupBoxFriendsList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.Button buttonFetchFavoriteTeams;
        private System.Windows.Forms.Button buttonFetchGroups;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.TextBox textBoxStatusText;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxFacebookLogo;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfile;
        private System.Windows.Forms.PictureBox pictureBoxFavoriteTeam;
        private System.Windows.Forms.PictureBox pictureBoxGroups;
        private System.Windows.Forms.PictureBox pictureBoxLikedPages;
        private System.Windows.Forms.Button buttonSortByMostLikes;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.BindingSource photoBindingSource;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.TabControl tabControlPostItems;
        private System.Windows.Forms.TabPage Status;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TabPage Posts;
        private System.Windows.Forms.TabPage Groups;
        private System.Windows.Forms.TabPage FavoriteTeams;
        private System.Windows.Forms.TabPage LikedPages;
        private System.Windows.Forms.TabPage Events;
        private System.Windows.Forms.GroupBox groupBoxBasicInfo;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Button buttonBasicInfo;
        private System.Windows.Forms.GroupBox groupBoxFriendsList;
        private System.Windows.Forms.TextBox textBoxSearchFriend;
        private System.Windows.Forms.Button buttonFriendsList;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Button buttonFetchAlbums;
        private System.Windows.Forms.Button buttonFriendshipTest;
        private System.Windows.Forms.Button buttonMemories;
    }
}