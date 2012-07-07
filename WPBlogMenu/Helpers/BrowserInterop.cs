using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Browser;

namespace WPBlogMenu.Helpers
{
    public class BrowserInterop
    {
        internal static void OpenWindow(string URL)
        {
            try
            {
                HtmlPage.Window.Navigate(new Uri(URL, UriKind.Absolute), "_blank");
            }
            catch (Exception e)
            {
                //sorry, but I guess we can't navigate
                MessageBox.Show("Navigation Blocked: " + e.Message + "\nThis site is blocking your attempt to navigate to \n" + URL);
            }
        }
    }
}
