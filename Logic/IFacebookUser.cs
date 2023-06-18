using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IFacebookUser
    {
        string GetFirstName();
        string GetLastName();
        Image GetImageSmall();
        FacebookObjectCollection<Event> GetEvents();
        FacebookObjectCollection<Page> GetLikedPages();
        FacebookObjectCollection<User> GetFriends();
        FacebookObjectCollection<Group> GetGroups();
        FacebookObjectCollection<Group> GetFavoriteTeams();
        FacebookObjectCollection<Album> GetAlbums();
        FacebookObjectCollection<Post> GetPosts();
        string GetProfilePicture();
        Status PostStatus(string io_StatusText, string io_PaceID = null, string io_PictureURL = null, string io_TaggedFriendIDs = null, string io_Link = null, string io_PrivacyParameterValue = null);
        bool PostOnYourFriendWall(string i_MessageToFriend, string i_FriendId);
        void PostStatusOnYourWall(string i_Message);
        string GetLocation();
    }
}
