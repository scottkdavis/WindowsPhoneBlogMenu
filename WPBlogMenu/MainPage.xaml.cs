using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using WPBlogMenu.Helpers;

namespace WPBlogMenu
{
    public partial class MainPage : UserControl
    {
        /// <summary>
        /// This project is an open source project hosted on CodePlex.  http://WPBlogMenu.CodePlex.com
        /// Please keep this reference to the project site in the code base.
        /// Doing something interesting with the code? Consider sharing your improvements on the codeplex site.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        private void twitter_Click(object sender, RoutedEventArgs e)
        {
            BrowserInterop.OpenWindow("http://www.twitter.com/scottkdavis");
        }

        private void SLTV_Click(object sender, RoutedEventArgs e)
        {
            BrowserInterop.OpenWindow("http://channel9.msdn.com/shows/SilverlightTV/");
        }

        private void TCSLUG_Click(object sender, RoutedEventArgs e)
        {
            BrowserInterop.OpenWindow("http://www.tcslug.com");
        }

    }
}
