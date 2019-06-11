using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Type_শিখি.Views.Pages;
using System.Text.RegularExpressions;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Type_শিখি
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            CustomizeTitleBar();
        }

        private void CustomizeTitleBar()
        {
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;

            titleBar.BackgroundColor = titleBar.ButtonBackgroundColor = Colors.Black;
            titleBar.ForegroundColor = titleBar.ButtonForegroundColor = Colors.AliceBlue;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            ExecuteDividerLine();
        }

        private void ExecuteDividerLine()
        {
            if (MySplitView.IsPaneOpen)
                DividerLine.Width = 210;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
                NavigateToHome();

            if (Tutorial.IsSelected)
                NavigateToTutorial();

            if (Practice.IsSelected)
                NavigateToPractice();

            if (Progress.IsSelected)
                NavigateToProgress();
        }

        private void NavigateToHome()
        {
            PagesFrame.Navigate(typeof(HomePage));
            SetTitle("Home");
        }

        private void NavigateToTutorial()
        {
            PagesFrame.Navigate(typeof(TutorialPage));
            SetTitle("Tutorial");
        }

        private void NavigateToPractice()
        {            
            PagesFrame.Navigate(typeof(PracticePage));
            SetTitle("Practice");
        }

        private void NavigateToProgress()
        {
            PagesFrame.Navigate(typeof(ProgressPage));
            SetTitle("Progress");
        }

        private void SetTitle(string titleText)
        {
            TitleTextBlock.Text = titleText;
        }
    }
}
