using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using App11Tester_Lists.Model;

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

        ObservableCollection<Content> contentCollection = new ObservableCollection<Content>();
        public ObservableCollection<Content> ContentCollection
        {
            get
            {
                return contentCollection;
            }
        }

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

        private int x = 0;
        private void btnClassAdd_Click(object sender, RoutedEventArgs e)
        {
            x++;
            Content c = new Content();
            c.Id = c.Id + x;
            c.Category = c.Category + x;
            c.Title = c.Title + x;
            contentCollection.Add(c);    
        }

        private void btnClassRemove_Click(object sender, RoutedEventArgs e)
        {
            //Replace Class with your object type
            while (myClassListBox.SelectedItems.Count > 0)
            {
                contentCollection.Remove((Content)myClassListBox.SelectedItem);
            }
        }

    }
}
