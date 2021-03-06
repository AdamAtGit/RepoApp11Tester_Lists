﻿using System;
using System.Collections.ObjectModel;
using Windows.ApplicationModel;

namespace App11Tester_Lists.Model
{
    public class Content // : ObservableCollection<Content>
    {
        public Content()
        {        
            if (DesignMode.DesignModeEnabled)
            {
                Id = 1;
                Category = "Human Fx";
                Title = "Out the Door CheckList";
            }
            else
            {
                Id = 0;
                Category = "SED-IB";
                Title = "1.5 Take them Aside";
            }
        }

        #region Class/Model/Record Props & Fields
        public int Id { get; set; }

        private string category;
        public string Category
        {
            get => category;
            set
            {
                category = value;
                // OnPropertyChanged("Category");
            }
        }

        private string title;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                // OnPropertyChanged("Title");
            }
        }
        #endregion

        public override string ToString()
        {

            return Id + " ," + Category  + " ," + Title;
        }
    }
}
