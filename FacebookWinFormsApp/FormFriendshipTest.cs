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
using System.Threading;
using Facebook;

namespace BasicFacebookFeatures
{
    public partial class FormFriendshipTest : FormFeature
    {
        private readonly AppLogic r_AppLogic = AppLogic.Instance;
        private readonly AppSettings r_AppSettings;
        private readonly FacebookUserProxy m_User;
        private IFriendshipTestInitializer m_FriendshipTester;

        public FormFriendshipTest(FacebookUserProxy i_User)
        {
            InitializeComponent();
            m_User = i_User;
        }

        private void fetchFriends(IFacebookUser i_User)
        {
            listBoxFriendsList.Items.Clear();
            FacebookObjectCollection<User> friends = i_User.GetFriends();
            listBoxFriendsList.DisplayMember = "Name";
            if (friends != null)
            {
                try
                {
                    foreach (User friend in friends)
                    {
                        listBoxFriendsList.Items.Add(friend);
                    }
                }
                catch (FacebookApiException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No friends to retrieve.");
            }
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonChooseFriend_Click(object sender, EventArgs e)
        {
            initializeUserFriends();
            panelChooseFriends.Visible = true;
        }

        private void initializeUserFriends()
        {
            fetchFriends(m_User);
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (listBoxFriendsList.CheckedItems.Count > 0)
            {
                string selectedFriendName = listBoxFriendsList.SelectedItem.ToString();
                User selectedFriendUser = getSelectedUser(selectedFriendName);
                CreateTester(selectedFriendUser);
                FormFriendshipTestQuestion formQuestions = new FormFriendshipTestQuestion(selectedFriendUser, this, m_User, m_FriendshipTester);
                formQuestions.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose a friend!");
            }
        }

        private void CreateTester(User i_User)
        {
            if (m_FriendshipTester == null)
            {
                m_FriendshipTester = new CacheFriendshipTester();
            }

            m_FriendshipTester.CurrentUser = i_User;
        }

        private User getSelectedUser(string i_FriendName)
        {
            User selectedFriend = new User();

            foreach (User friend in m_User.GetFriends())
            {
                if (friend.Name == i_FriendName)
                {
                    selectedFriend = friend;
                }
            }

            return selectedFriend;
        }

        private void buttonSelectRandomFriend_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, m_User.GetFriends().Count);
            User selectedFriendUser = m_User.GetFriends()[randomIndex];
            CreateTester(selectedFriendUser);
            FormFriendshipTestQuestion formQuestions = new FormFriendshipTestQuestion(selectedFriendUser, this, m_User, m_FriendshipTester);
            formQuestions.Show();
        }
    }
}
        


            
        
    
