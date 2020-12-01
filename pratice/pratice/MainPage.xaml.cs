using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using pratice.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace pratice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<IconSS> Icons;
        private ObservableCollection<Contact> Contacts;

        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<IconSS>();

            Icons.Add(new IconSS { iconPath = "Assets/img-01.jpg" });
            Icons.Add(new IconSS { iconPath = "Assets/img-02.jpg" });
            Icons.Add(new IconSS { iconPath = "Assets/img-03.jpeg" });
  
            Contacts = new ObservableCollection<Contact>();
        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((IconSS)Images.SelectedValue).iconPath;
            //Thêm item mới
            Contacts.Add(new Contact { FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text, AvatarPath = avatar });

            //Reset data
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";

            //AvatarComboBox.SelectedItem = -1;
            FirstNameTextBox.Focus(FocusState.Programmatic);
        }
    }
}
