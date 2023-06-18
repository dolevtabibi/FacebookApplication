using FacebookWrapper.ObjectModel;
using Logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormMemories : FormFeature
    {
        private FacebookUserProxy m_UserData;
        private MemoriesSearch m_MemoriesSearch;

        public FormMemories(FacebookUserProxy i_UserData)
        {
            InitializeComponent();
            m_UserData = i_UserData;
            m_MemoriesSearch = new MemoriesSearch();
        }

        private void MemoriesForm_Load(object sender, EventArgs e)
        {
            listViewMemoriesPhotos.View = View.LargeIcon;
            listViewMemoriesPhotos.Columns.Add("Photos:", 400);
        }

        private bool checkIfMemoriesTypeSelected()
        {
            bool isSelected = false;

            if (checkedListBoxOptions.CheckedItems.Count > 0)
            {
                isSelected = true;
            }

            return isSelected;
        }

        private bool checkIfAllSettingMemoriesAreSelected()
        {
            bool isSelected = true;
            string msgError = string.Format("Please fix the following:\n");

            if (!dateTimePickerStartDate.Checked)
            {
                isSelected = false;
                msgError = string.Format(msgError + "* Please enter start date!\n");
            }

            if (checkBoxOneDay.CheckState == CheckState.Unchecked && !dateTimePickerEndDate.Checked)
            {
                isSelected = false;
                msgError = string.Format(msgError + "* Please enter end date,\nor select one day range\n");
            }

            if (!checkIfMemoriesTypeSelected())
            {
                isSelected = false;
                msgError = string.Format(msgError + "* Please Choose type of memory to fetch\n");
            }

            if (dateTimePickerEndDate.Value.Date < dateTimePickerStartDate.Value.Date)
            {
                isSelected = false;
                msgError = string.Format(msgError + "* Please Choose chronological time!\n");
            }

            if (!isSelected)
            {
                MessageBox.Show(msgError);
            }

            return isSelected;
        }

        private void buttonFetchMemories_Click(object sender, EventArgs e)
        {
            listBoxMemoriesList.Items.Clear();
            listViewMemoriesPhotos.Items.Clear();
            if (checkIfAllSettingMemoriesAreSelected())
            {
                List<int> choosenOption = getCheckedItemFromListBox(checkedListBoxOptions);

                foreach (int i in choosenOption)
                {
                    if (i != 0)
                    {
                        divideMemoriesByGroups(i);
                    }
                    else
                    {
                        for(int j = 1 ;j <=5; j++)
                        {
                            divideMemoriesByGroups(j);
                        }
                    }
                }
            }
        }

        private void addTitleToListBox(string i_Title)
        {
           listBoxMemoriesList.Items.Add(i_Title);
        }

        private void divideMemoriesByGroups(int i_IndexToShowInList)
        {
            FacebookObjectCollection<FacebookObjectWrapper> ItemsToShow = new FacebookObjectCollection<FacebookObjectWrapper>();
            List<Image> ListOfImagesToShow = new List<Image>();
            ImageList imagesListToListBox = new ImageList();
            imagesListToListBox.ImageSize = new Size(80, 80);
            bool isCheck = checkBoxOneDay.CheckState == CheckState.Checked;
            DateTime startDate = dateTimePickerStartDate.Value.Date;
            DateTime endDate;

            if (!isCheck)
            {
                endDate = dateTimePickerEndDate.Value.Date;
            }
            else
            {
                endDate = startDate;
            }

            ItemsToShow.Clear();
            ListOfImagesToShow.Clear();
            imagesListToListBox.Images.Clear();
            try
            {
                switch (i_IndexToShowInList)
                {
                    case 1: ////posts
                        addTitleToListBox("Posts:");
                        ItemsToShow = m_MemoriesSearch.GetMemoriesOfPosts(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_UserData.GetPosts());
                        addItemsToMemoriesList(ItemsToShow);
                        break;
                    case 2: ////photos
                        ListOfImagesToShow = m_MemoriesSearch.GetMemoriesOfPhotos(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_UserData.GetPhotos());
                        addPhotosToMemoriesListView(ListOfImagesToShow, imagesListToListBox);
                        break;
                    case 3: ////events
                        addTitleToListBox("Events:");
                        ItemsToShow = m_MemoriesSearch.GetMemoriesOfEvents(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_UserData.GetEvents());
                        addItemsToMemoriesList(ItemsToShow);
                        break;
                    case 4: ////friends
                        addTitleToListBox("Friends:");
                        ItemsToShow = m_MemoriesSearch.GetMemoriesOfFriends(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_UserData.GetFriends());
                        addItemsToMemoriesList(ItemsToShow);
                        break;
                    case 5: ////groups
                        addTitleToListBox("Groups:");
                        ItemsToShow = m_MemoriesSearch.GetMemoriesOfGroups(isCheck, dateTimePickerStartDate.Value.Date, dateTimePickerEndDate.Value.Date, m_UserData.GetGroups());
                        addItemsToMemoriesList(ItemsToShow);
                        break;
                }
            }
            catch (Exception e)
            {
                addTitleToListBox(e.Message);
            }
        }

        private void addItemsToMemoriesList(FacebookObjectCollection<FacebookObjectWrapper> i_ItemsToAddToList)
        {
            MemoriesItemsCollection memoriesItemsCollection = new MemoriesItemsCollection(i_ItemsToAddToList);
            IEnumerator<string> iterator = memoriesItemsCollection.GetEnumerator();

            while (iterator.MoveNext())
            {
                listBoxMemoriesList.Items.Add(iterator.Current);
            }
        }

        private void addPhotosToMemoriesListView(List<Image> i_PhotosToAddList, ImageList i_ImageList)
        {
            foreach (Image image in i_PhotosToAddList)
            {
                i_ImageList.Images.Add(image);
            }

            listViewMemoriesPhotos.LargeImageList = i_ImageList;
            for (int i = 0; i < i_ImageList.Images.Count; i++)
            {
                listViewMemoriesPhotos.Items.Add(string.Empty, i);
            }
        }

        private List<int> getCheckedItemFromListBox(CheckedListBox i_BoxToCheck)
        {
            List<int> listToReturn = new List<int>();

            foreach (int item in i_BoxToCheck.CheckedIndices)
            {
                listToReturn.Add(item);
            }

            return listToReturn;
        }
        private void listViewMemoriesPhotos_DoubleClick(object sender, MouseEventArgs e)
        {
            showPictureInBiggerForm();
        }

        private void showPictureInBiggerForm()
        {
            FormBiggerPicture memoryPictureForm = new FormBiggerPicture();
            var item = listViewMemoriesPhotos.SelectedItems[0];
            Image selectedImage = listViewMemoriesPhotos.SelectedItems[0].ImageList.Images[item.ImageIndex];

            memoryPictureForm.PictureBoxBigger.Image = selectedImage;
            memoryPictureForm.ShowDialog();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEndDate.MinDate = dateTimePickerStartDate.Value.Date;
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected index of the checked list box
            int selectedIndex = checkedListBoxOptions.SelectedIndex;

            // Disable other options if the first option is checked
            if (selectedIndex == 0)
            {
                for (int i = 1; i < checkedListBoxOptions.Items.Count; i++) 
                {
                    checkedListBoxOptions.SetItemChecked(i, false); // Uncheck the item if needed
                }
            }
            else
            {
                checkedListBoxOptions.SetItemChecked(0, false); // Uncheck the item if needed
            }
        }
    }
}