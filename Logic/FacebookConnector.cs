using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FacebookConnector
    {
        public static IFacebookUser Connect(string i_Token, string i_AppId, ref bool io_IsLoggedIn)
        {
            LoginResult loginResult = null;

            if (string.IsNullOrEmpty(i_Token))
            {
                loginResult = FacebookService.Login(i_AppId,
                    "email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");

                if (loginResult != null && loginResult.FacebookOAuthResult != null && loginResult.FacebookOAuthResult.IsSuccess)
                {
                    AppLogic.Instance.AccessToken = loginResult.AccessToken;
                    io_IsLoggedIn = true;
                }
            }
            else
            {
                loginResult = FacebookService.Connect(i_Token);
                io_IsLoggedIn = true;
            }

            if (loginResult != null && loginResult.LoggedInUser != null)
            {
                return new FacebookUserProxy(loginResult.LoggedInUser);
            }
            else
            {
                return null;
            }
        }
    }
}
