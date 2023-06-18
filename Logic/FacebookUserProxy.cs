using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class FacebookUserProxy : IFacebookUser
    {
        public User r_FacebookUser { get; private set; }

        private const int k_AgeNotDeclare = -1;
        public int UserAge { get; private set; }

        public int UserYearOfBirth { get; private set; }

        public int UserMonthOfBirth { get; private set; }

        public int UserDayOfBirth { get; private set; }

        public string UserId { get; private set; }

        public string UserName { get; private set; }

        public string ProfilePicURL { get; private set; }

        public string UserLocation { get; private set; }

        private const string k_NotDeclareInfo = "Not declare";
        private readonly List<IDataInitializeObserver> m_DataInitializeObservers = new List<IDataInitializeObserver>();


        public void AttachObserver(IDataInitializeObserver i_DataInitializeObserver)
        {
            m_DataInitializeObservers.Add(i_DataInitializeObserver);
        }

        public void DetachObserver(IDataInitializeObserver i_DataInitializeObserver)
        {
            m_DataInitializeObservers.Remove(i_DataInitializeObserver);
        }

        public FacebookObjectCollection<Post> UserPostsList { get; private set; }

        public FacebookUserProxy(User i_User)
        {
            r_FacebookUser = i_User;
            initializePostsList();
            setUserAge();
            setUserId();
        }

        public FacebookObjectCollection<string> UserBasicInfo { get; private set; }

        public FacebookObjectCollection<Photo> PhotosTaggedIn()
        {
            return r_FacebookUser.PhotosTaggedIn;
        }

        public FacebookObjectCollection<Album> GetAlbums()
        {
            return r_FacebookUser.Albums;
        }

        public FacebookObjectCollection<Photo> GetPhotos() 
        {
            return initializePhoto();
        }

        private FacebookObjectCollection<Photo> initializePhoto()
        {
            FacebookObjectCollection<Photo> photos = new FacebookObjectCollection<Photo>();

            foreach (Album album in r_FacebookUser.Albums) 
            {
                foreach (Photo photo in album.Photos)
                {
                    photos.Add(photo);
                }
            }

            return photos;
        }

        public string GetLocation()
        {
            if (r_FacebookUser.Location != null && r_FacebookUser.Location.Name != null)
            {
                return r_FacebookUser.Location.Name;
            }
            return k_NotDeclareInfo;
        }

        public FacebookObjectCollection<Event> GetEvents()
        {
            return r_FacebookUser.Events;
        }

        public FacebookObjectCollection<Page[]> GetFavoriteTeams()
        {
            FacebookObjectCollection<Page[]> favoriteTeams = new FacebookObjectCollection<Page[]>();

            favoriteTeams.Add(r_FacebookUser.FavofriteTeams);

            return favoriteTeams;
        }

        public string GetFirstName()
        {
            return r_FacebookUser.FirstName;
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            return r_FacebookUser.Friends;
        }

        public FacebookObjectCollection<Group> GetGroups()
        {
            return r_FacebookUser.Groups;
        }

        public string GetLastName()
        {
            return r_FacebookUser.LastName;
        }

        public FacebookObjectCollection<Page> GetLikedPages()
        {
            return r_FacebookUser.LikedPages;
        }

        public Image GetImageSmall()
        {
            return r_FacebookUser.ImageSmall;
        }

        public FacebookObjectCollection<Post> GetPosts()
        {
            return r_FacebookUser.Posts;
        }

        public Status PostStatus(string io_StatusText, string io_PaceID = null, string io_PictureURL = null, string io_TaggedFriendIDs = null, string io_Link = null, string io_PrivacyParameterValue = null)
        {
            return r_FacebookUser.PostStatus(io_StatusText);
        }

        FacebookObjectCollection<Group> IFacebookUser.GetFavoriteTeams()
        {
            return r_FacebookUser.Groups;
        }

        FacebookObjectCollection<Group> IFacebookUser.GetGroups()
        {
            return r_FacebookUser.Groups;
        }

        public string GetProfilePicture()
        {
            return r_FacebookUser.PictureNormalURL;
        }

        public bool PostOnYourFriendWall(string i_MessageToFriend, string i_FriendId)
        {
            bool isPosted;

            try
            {
                r_FacebookUser.PostStatus(i_MessageToFriend, i_FriendId);
                isPosted = true;
            }
            catch (Exception)
            {
                isPosted = false;
            }

            return isPosted;
        }

        public void PostStatusOnYourWall(string i_Message)
        {
            try
            {
                Status postedStatus = r_FacebookUser.PostStatus(i_Message);
                MessageBox.Show("Status Id: ", postedStatus.Id);
            }
            catch
            {
                throw;
            }
        }

        private void setUserAge()
        {
            UserAge = 0;
            if (r_FacebookUser.Birthday != string.Empty)
            {
                string[] dateOfBirth = r_FacebookUser.Birthday.Split('/');

                UserYearOfBirth = int.Parse(dateOfBirth[2]);
                UserMonthOfBirth = int.Parse(dateOfBirth[0]);
                UserDayOfBirth = int.Parse(dateOfBirth[1]);
                UserAge = DateTime.Now.Year - UserYearOfBirth;
                if (DateTime.Now.Month < UserMonthOfBirth)
                {
                    UserAge = UserAge - 1;
                }

                if (DateTime.Now.Month == UserMonthOfBirth)
                {
                    if (DateTime.Now.DayOfYear < UserDayOfBirth)
                    {
                        UserAge = UserAge - 1;
                    }
                }
            }
            else
            {
                UserAge = k_AgeNotDeclare;
                UserDayOfBirth = -1;
                UserMonthOfBirth = -1;
                UserYearOfBirth = -1;
            }
        }

        private void initializePostsList()
        {
            UserPostsList = GetPosts();
            try
            {
                if (r_FacebookUser.Posts.Count > 0)
                {
                    foreach (Post post in r_FacebookUser.Posts)
                    {
                        UserPostsList.Add(post);
                    }
                }
            }
            catch (Exception)
            {
                UserPostsList = null;
            }
        }

        private void setUserId()
        {
            try
            {
                UserId = r_FacebookUser.Id;
            }
            catch (Exception)
            {
                UserId = string.Empty;
            }
        }

        private void setUserLocation()
        {
            try
            {
                if (r_FacebookUser.Location != null && r_FacebookUser.Location.Name != null)
                {
                    UserLocation = r_FacebookUser.Location.Name;
                }
            }
            catch (Exception)
            {
                UserLocation = string.Empty;
            }
        }

        private void initializeBasicInfo()
        {
            UserBasicInfo = new FacebookObjectCollection<string>();
            try
            {
                if (r_FacebookUser.Gender != null)
                {
                    UserBasicInfo.Add("Gender: " + r_FacebookUser.Gender);
                }
                else
                {
                    UserBasicInfo.Add("Gender: " + k_NotDeclareInfo);
                }

                if (r_FacebookUser.Birthday != null)
                {
                    UserBasicInfo.Add("Birthday date: " + r_FacebookUser.Birthday);
                }
                else
                {
                    UserBasicInfo.Add("Birthday date: " + k_NotDeclareInfo);
                }

                if (r_FacebookUser.Location != null && r_FacebookUser.Location.Name != null)
                {
                    UserBasicInfo.Add("Location: " + r_FacebookUser.Location.Name);
                }
                else
                {
                    UserBasicInfo.Add("Location: " + k_NotDeclareInfo);
                }

                if (r_FacebookUser.Email != null)
                {
                    UserBasicInfo.Add("Email: " + r_FacebookUser.Email);
                }
                else
                {
                    UserBasicInfo.Add("Email: " + k_NotDeclareInfo);
                }

                if (r_FacebookUser.RelationshipStatus != null)
                {
                    UserBasicInfo.Add("Relationship Status: " + r_FacebookUser.RelationshipStatus);
                }
                else
                {
                    UserBasicInfo.Add("Relationship Status: " + k_NotDeclareInfo);
                }

                if (r_FacebookUser.Educations != null)
                {
                    UserBasicInfo.Add("Educations: " + r_FacebookUser.Educations[0].ToString());
                }
                else
                {
                    UserBasicInfo.Add("Educations: " + k_NotDeclareInfo);
                }

                if (r_FacebookUser.WorkExperiences != null)
                {
                    UserBasicInfo.Add("Work: " + r_FacebookUser.WorkExperiences[0].ToString());
                }
                else
                {
                    UserBasicInfo.Add("Work: " + k_NotDeclareInfo);
                }
            }
            catch (Exception)
            {
                UserBasicInfo.Add("Cannot retrive info");
            }
        }

        public void InitializeUserData(IFacebookUser i_LoggedInUser)
        {
            UserName = r_FacebookUser.FirstName + r_FacebookUser.LastName;
            ProfilePicURL = r_FacebookUser.PictureNormalURL;
            initializeBasicInfo();
            initializePostsList();
            GetFriends();
            GetGroups();
            GetEvents();
            GetAlbums();
            setUserAge();
            setUserId();
            setUserLocation();
            doWhenDataInitialize();
        }

        private void doWhenDataInitialize()
        {
            notifyAllDataInitializedObservers();
        }

        private void notifyAllDataInitializedObservers()
        {
            foreach (IDataInitializeObserver observer in m_DataInitializeObservers)
            {
                observer.AllDataInitialized();
            }
        }
    }
}
