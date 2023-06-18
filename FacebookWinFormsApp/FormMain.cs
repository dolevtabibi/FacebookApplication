using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Facebook;
using Logic;
using System.ComponentModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form, IDataInitializeObserver
    {
        private FacebookUserProxy m_LoggedInUser { get; }
        private readonly AppLogic r_AppLogic = AppLogic.Instance;
        private readonly AppSettings r_AppSettings;

        public FormMain(AppSettings i_AppSettings)
        {
            InitializeComponent();
            r_AppSettings = i_AppSettings;
            Size = r_AppSettings.LastWindowsSize;
            Location = r_AppSettings.LastWindowsLocation;
            checkBoxRememberUser.Checked = r_AppSettings.AutoLogin;
            m_LoggedInUser = (FacebookUserProxy)r_AppLogic.GetUser();
            if (r_AppSettings.AutoLogin && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                this.checkBoxRememberUser.Checked = r_AppSettings.AutoLogin;
                connectAsRememberedUser();
            }

            FacebookService.s_CollectionLimit = 100;
            new Thread(InitializeData).Start();
        }

        private void InitializeData()
        {
            m_LoggedInUser.AttachObserver(this as IDataInitializeObserver);
            m_LoggedInUser.InitializeUserData(m_LoggedInUser);
        }

        private void connectAsRememberedUser()
        {
            LoginResult m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
            this.Size = r_AppSettings.LastWindowsSize;
            this.Location = r_AppSettings.LastWindowsLocation;
            this.checkBoxRememberUser.Checked = r_AppSettings.AutoLogin;
        }

        public void AllDataInitialized()
        {
            fetchFacebookInfo();
            MessageBox.Show("Welcome To Facebook! :)");
            enableButtons();
        }

        private void fetchBasicInfo()
        {
            foreach (string info in m_LoggedInUser.UserBasicInfo)
            {
                listBoxInfo.Invoke(new Action(() => listBoxInfo.Items.Add(info)));
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (checkBoxRememberUser.Checked == true)
            {
                r_AppSettings.LastWindowsSize = Size;
                r_AppSettings.LastWindowsLocation = Location;
                r_AppSettings.LastAccessToken = r_AppLogic.AccessToken;
                r_AppSettings.AutoLogin = checkBoxRememberUser.Checked;
            }
            else
            {
                r_AppSettings.LastAccessToken = null;

            }

            r_AppSettings.SaveSettingsToFile();
            base.OnClosing(e);
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatusText.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (FacebookApiException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void hideControls()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(hideControls));
                return;
            }

            buttonLogout.Visible = false;
            buttonFetchAlbums.Visible = false;
            buttonFetchEvents.Visible = false;
            buttonFetchGroups.Visible = false;
            buttonFetchFavoriteTeams.Visible = false;
            buttonLikedPages.Visible = false;
            buttonFetchPosts.Visible = false;
            buttonSetStatus.Visible = false;
            textBoxStatusText.Visible = false;
            pictureBoxProfile.Visible = false;
            buttonLogin.Enabled = true;
            checkBoxRememberUser.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.Enabled = true;
            this.ClientSize = new System.Drawing.Size(243, 78);
            hideControls();
        }

        private void fetchFacebookInfo()
        {
            pictureBoxProfile.Image = m_LoggedInUser.GetImageSmall();
            buttonLogin.Invoke(new Action(() => buttonLogin.Text = string.Format("Logged in as {0}", m_LoggedInUser.GetFirstName())));
            new Thread(fetchBasicInfo).Start();
            new Thread(fetchPosts).Start();
            new Thread(fetchLikedPages).Start();
            new Thread(fetchFriends).Start();
            new Thread(fetchFavoriteTeams).Start();
            new Thread(fetchEvents).Start();
            new Thread(fetchAlbums).Start();
            new Thread(fetchGroups).Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (this.checkBoxRememberUser.Checked == true)
            {
                r_AppSettings.LastAccessToken = r_AppLogic.AccessToken;
                r_AppSettings.LastWindowsLocation = this.Location;
                r_AppSettings.LastWindowsSize = this.Size;
            }
            else
            {
                r_AppSettings.LastAccessToken = null;
            }

            r_AppSettings.SaveSettingsToFile();
        }

        private void FetchAndPopulateData<T>(IEnumerable<T> items, ListBox listBox)
        {
            try
            {
                if (items != null)
                {
                    List<T> itemList = items.ToList();
                    ListBoxPopulator<T> listBoxPopulator = new ListBoxPopulator<T>(itemList, listBox);
                    listBoxPopulator.FetchAndPopulateData(itemList, listBox);
                }
            }
            catch (FacebookApiException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchLikedPages()
        {
            FetchAndPopulateData(m_LoggedInUser.GetLikedPages(), listBoxLikedPages);
        }

        private void fetchFriends()
        {
            FetchAndPopulateData(m_LoggedInUser.GetFriends(), listBoxFriends);
        }

        private void fetchFavoriteTeams()
        {
            FetchAndPopulateData(m_LoggedInUser.GetFavoriteTeams(), listBoxFavoriteTeams);
        }

        private void fetchEvents()
        {
            FetchAndPopulateData(m_LoggedInUser.GetEvents(), listBoxEvents);
        }

        private void fetchAlbums()
        {
            this.Invoke(new Action(() =>
            {
                albumBindingSource.DataSource = m_LoggedInUser.GetAlbums();
            }));
        }

        private void fetchGroups()
        {
            FetchAndPopulateData(m_LoggedInUser.GetGroups(), listBoxGroups);
        }

        private void fetchPosts()
        {
            try
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
                foreach (Post post in m_LoggedInUser.GetPosts())
                {
                    string message = post.Message ?? post.Caption ?? string.Format("[{0}]", post.Type);
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(message)));
                }

                if (listBoxPosts.Items.Count == 0)
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }
            catch (FacebookApiException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addText(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = string.Empty;
        }

        private void removeText(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "Type here...";
            }
        }

        private void enableButtons()
        {
            buttonFriendshipTest.Invoke(new Action(() => buttonFriendshipTest.Enabled = true));
            buttonFetchAlbums.Invoke(new Action(() => buttonFetchAlbums.Enabled = true));
            buttonFetchEvents.Invoke(new Action(() => buttonFetchEvents.Enabled = true));
            buttonFetchGroups.Invoke(new Action(() => buttonFetchGroups.Enabled = true));
            buttonFetchFavoriteTeams.Invoke(new Action(() => buttonFetchFavoriteTeams.Enabled = true));
            buttonLikedPages.Invoke(new Action(() => buttonLikedPages.Enabled = true));
            buttonSetStatus.Invoke(new Action(() => buttonSetStatus.Enabled = true));
            buttonFetchPosts.Invoke(new Action(() => buttonFetchPosts.Enabled = true));
            buttonLogin.Invoke(new Action(() => buttonLogin.Enabled = true));
            buttonMemories.Invoke(new Action(() => buttonMemories.Enabled = true));
            tabControlPostItems.Invoke(new Action(() => tabControlPostItems.Enabled = true));
        }

        private void showControls()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(showControls));

                return;
            }

            buttonLogout.Visible = true;
            buttonFetchAlbums.Visible = true;
            buttonFetchEvents.Visible = true;
            buttonFetchGroups.Visible = true;
            buttonFetchFavoriteTeams.Visible = true;
            buttonLikedPages.Visible = true;
            buttonFetchPosts.Visible = true;
            textBoxStatusText.Visible = true;
            buttonSetStatus.Visible = true;
            pictureBoxProfile.Visible = true;
            buttonLogin.Enabled = false;
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User friend = listBoxFriends.SelectedItem as User;
                if (friend != null)
                {
                    pictureBoxFriendProfile.LoadAsync(friend.PictureNormalURL);
                }
            }
        }

        private void listBox_SelectedIndexChanged<T>(object sender, EventArgs e)
        {
            
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Group selectedTeam = listBoxFavoriteTeams.SelectedItem as Group;
                if (selectedTeam != null)
                {
                    pictureBoxFavoriteTeam.LoadAsync(selectedTeam.PictureNormalURL);
                }
                else if (listBoxFavoriteTeams.SelectedItem is string) 
                {
                    if (selectedTeam != null)
                    {
                        pictureBoxFavoriteTeam.LoadAsync(selectedTeam.PictureNormalURL);
                    }
                }
            }
        }

        public interface IMostLikedPhotoStrategy
        {
            Photo FindMostLikedPhoto(Album[] albums);
        }

        public class MostLikedPhotoStrategy : IMostLikedPhotoStrategy
        {
            public Photo FindMostLikedPhoto(Album[] albums)
            {
                int likes = 0;
                Photo mostLiked = null;

                foreach (Album album in albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        if (photo.LikedBy.Count() > likes)
                        {
                            mostLiked = photo;
                            likes = photo.LikedBy.Count();
                        }
                    }
                }

                return mostLiked;
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;

                pictureBoxLikedPages.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void buttonSortByMostLikes_Click(object sender, EventArgs e)
        {
            new Thread(sortByMostLikes).Start();
        }

        private void sortByMostLikes()
        {
            Post[] posts = m_LoggedInUser.GetPosts().ToArray();

            if (posts != null)
            {
                try
                {
                    // Sort the posts by number of likes
                    IOrderedEnumerable<Post> sortedPosts = posts.OrderByDescending(p => p.LikedBy.Count);

                    if (sortedPosts.Any())
                    {
                        // Clear the current items in the list box
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));

                        // Add the sorted posts to the list box
                        foreach (Post post in sortedPosts)
                        {
                            if (post.Message != null)
                            {
                                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                            }
                            else if (post.Caption != null)
                            {
                                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                            }
                            else
                            {
                                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No liked posts to retrieve.");
                    }
                }
                catch (FacebookApiException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post[] posts = m_LoggedInUser.GetPosts().ToArray();

            if (listBoxPosts.SelectedIndex >= 0 && listBoxPosts.SelectedIndex < posts.Count())
            {
                listBoxPostComments.Invoke(new Action(() => listBoxPostComments.Items.Clear()));
                Post selected = posts[listBoxPosts.SelectedIndex];
                listBoxPostComments.Invoke(new Action(() => listBoxPostComments.DisplayMember = "Message"));
                foreach (Comment comment in selected.Comments)
                {
                    listBoxPostComments.Invoke(new Action(() => listBoxPostComments.Items.Add(comment.Message)));
                }
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroups.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void buttonFetchFavoriteTeams_Click(object sender, EventArgs e)
        {
            new Thread(fetchFavoriteTeams).Start();
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            new Thread(fetchGroups).Start();
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            new Thread(fetchLikedPages).Start();
        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            new Thread(fetchAlbums).Start();
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            new Thread(fetchEvents).Start();
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void buttonFriendshipTest_Click(object sender, EventArgs e)
        {
            startFeature(eFeature.FormFriendshipTest);
        }

        private void startFeature(eFeature i_Context)
        {
            if (m_LoggedInUser == null)
            {
                MessageBox.Show("You need to login first.");

                return;
            }

            FormFeature feature = null;

            switch (i_Context)
            {
                case eFeature.FormFriendshipTest:
                    feature = FormFeatureFactory.Create(m_LoggedInUser, eFeature.FormFriendshipTest);
                    break;
                case eFeature.FormFetchAlbums:
                    feature = FormFeatureFactory.Create(m_LoggedInUser, eFeature.FormFetchAlbums);
                    break;
                case eFeature.FormMemories:
                    feature = FormFeatureFactory.Create(m_LoggedInUser, eFeature.FormMemories);
                    break;
            }

            feature.ShowDialog();
        }

        private void textBoxSearchFriend_TextChanged(object sender, EventArgs e)
        {
            listBoxFriends.Items.Clear();
            int lenght = textBoxSearchFriend.Text.Count();

            foreach (User friend in m_LoggedInUser.GetFriends())
            {
                if (friend.Name.StartsWith(textBoxSearchFriend.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend.Name)));
                }
            }

            if (listBoxFriends.Items.Count == 0)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("No match!")));
            }
        }

        private void buttonFetchAlbums_Click_1(object sender, EventArgs e)
        {
            startFeature(eFeature.FormFetchAlbums);
        }

        private void buttonFriendshipTest_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMemories_Click(object sender, EventArgs e)
        {
            startFeature(eFeature.FormMemories);
        }
    }
}
