using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public static class FilterStrategy
    {
        public static FacebookObjectCollection<Photo> Filter(Album i_PhotosToFilter, Func<Photo, bool> i_FilterMethod) 
        {
            FacebookObjectCollection<Photo> ListOfFilteredPhotos = new FacebookObjectCollection<Photo>();

            if(i_PhotosToFilter == null)
            {
                MessageBox.Show("Not Album Select");
            }
            else
            {
                try
                {
                    foreach (Photo photo in i_PhotosToFilter.Photos)
                    {
                        if (i_FilterMethod.Invoke(photo))
                        {
                            ListOfFilteredPhotos.Add(photo);
                        }
                    }

                }
                catch
                {
                    throw;
                }
            }

            return ListOfFilteredPhotos;
        }
    }
}
