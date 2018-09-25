using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App11Tester_Lists
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Works for a string
        ObservableCollection<string> myCollection = new ObservableCollection<string>();
        public ObservableCollection<string> MyCollection
        { get { return myCollection; } }

        //for a Class/Model

        ObservableCollection<string> contentCollection = new ObservableCollection<string>();
        public ObservableCollection<string> contentCollection
        { get { return contentCollection; } }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private int i = 0;
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            i++;
            myCollection.Add(i.ToString());
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Replace string with your object type
            while (myListBox.SelectedItems.Count > 0)
            {
                myCollection.Remove((string)myListBox.SelectedItem);
            }
        }

        private void btnClassAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClassRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        public class Content
        {


        }
    }
}
