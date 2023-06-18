using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using Logic;

namespace BasicFacebookFeatures
{
    public static class FormFeatureFactory
    {
        public static FormFeature Create(FacebookUserProxy iUser, eFeature iContext)
        {
            FormFeature result = null;
            
            switch (iContext)
            {
                case eFeature.FormFriendshipTest:
                    result = new FormFriendshipTest(iUser);      
                    break;
                case eFeature.FormFetchAlbums:
                    result = new FormFetchAlbums(iUser);
                    break;
                case eFeature.FormBiggerPicture:
                    result = new FormBiggerPicture();
                    break;
                case eFeature.FormMemories:
                    result = new FormMemories(iUser);
                    break;
            }

            if (result != null)
            {
                result.User = iUser;
            }

            return result;
        }
    }
}
