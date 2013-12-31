using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NyAppWP.Resources;
using System.Windows.Media;

namespace NyAppWP
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void TxtBoxUser_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxUser.Text == "用户名")
            {
                TxtBoxUser.Text = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                TxtBoxUser.Foreground = Brush1;
            }
        }

        private void TxtBoxUser_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxUser.Text == String.Empty)
            {
                TxtBoxUser.Text = "用户名";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                TxtBoxUser.Foreground = Brush2;
            }
        }

        private void TxtBoxPass_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxPass.Text == "登录密码")
            {
                TxtBoxPass.Text = "";
                SolidColorBrush Brush1 = new SolidColorBrush();
                Brush1.Color = Colors.Black;
                TxtBoxPass.Foreground = Brush1;
            }
        }

        private void TxtBoxPass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TxtBoxPass.Text == String.Empty)
            {
                TxtBoxPass.Text = "登录密码";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                TxtBoxPass.Foreground = Brush2;
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.PvtMain.IsLocked = false;
            this.PvtMain.SelectedIndex = 1;
            this.PvtMain.IsLocked = true;
        }

        private void PvtMain_ManipulationCompleted(object sender, System.Windows.Input.ManipulationCompletedEventArgs e)
        {
            this.PvtMain.IsLocked = true;
        }

        private void TxbForgetPass_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {

        }

        private void PvtMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (((Pivot)sender).SelectedIndex)
            {
                case 0:
                    ApplicationBar = null;
                    break;

                case 1:
                    ApplicationBar = ((ApplicationBar)Application.Current.Resources["AppBarHub"]);
                    break;
            }
        }

        private void CateItemMap_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MapPage.xaml",UriKind.Relative));
        }

        private void CatePoiList_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PoiListPage.xaml", UriKind.Relative));
        }


        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}