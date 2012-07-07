using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPBlogMenu.Helpers;

namespace WPBlogMenu
{
    /// <summary>
    /// This project is an open source project hosted on CodePlex.  http://WPBlogMenu.CodePlex.com
    /// Please keep this reference to the project site in the code base.
    /// Doing something interesting with the code? Consider sharing your improvements on the codeplex site.
    /// </summary>
    public partial class PersonTileWithFlip : UserControl
	{
        public PersonTileWithFlip()
		{
			// Required to initialize variables
			InitializeComponent();
            this.DataContext = this;
		}

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                if (this.DelaySlideStartBySeconds == 0)
                {
                    Slide.Begin();
                }
                else
                {
                    var timer = new DispatcherTimer();
                    timer.Interval = new TimeSpan(0, 0, this.DelaySlideStartBySeconds);
                    timer.Tick += (s, te) =>
                    {
                        Slide.Begin();
                        timer.Stop();
                        timer = null;
                    };
                    timer.Start();
                }
            }
            catch (Exception exc)
            {
                //can't imagine what would fail here, but don't let the control crash
            }
        }

        public int DelaySlideStartBySeconds
        {
            get { return (int)GetValue(DelaySlideStartBySecondsProperty); }
            set { SetValue(DelaySlideStartBySecondsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DelaySlideStartBySeconds.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DelaySlideStartBySecondsProperty =
            DependencyProperty.Register("DelaySlideStartBySeconds", typeof(int), typeof(PersonTileWithFlip), null);



        public string TileImage
        {
            get { return (string)GetValue(TileImageProperty); }
            set { SetValue(TileImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileImageProperty =
            DependencyProperty.Register("TileImage", typeof(string), typeof(PersonTileWithFlip), null);



        public string TileFrontTextLine1
        {
            get { return (string)GetValue(TileFrontTextLine1Property); }
            set { SetValue(TileFrontTextLine1Property, value); }
        }

        // Using a DependencyProperty as the backing store for TileFrontTextLine1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileFrontTextLine1Property =
            DependencyProperty.Register("TileFrontTextLine1", typeof(string), typeof(PersonTileWithFlip), null);

        public string TileFrontTextLine2
        {
            get { return (string)GetValue(TileFrontTextLine2Property); }
            set { SetValue(TileFrontTextLine2Property, value); }
        }

        // Using a DependencyProperty as the backing store for TileFrontTextLine1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileFrontTextLine2Property =
            DependencyProperty.Register("TileFrontTextLine2", typeof(string), typeof(PersonTileWithFlip), null);

        public string TileBackText
        {
            get { return (string)GetValue(TileBackTextProperty); }
            set { SetValue(TileBackTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileFrontTextLine1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TileBackTextProperty =
            DependencyProperty.Register("TileBackText", typeof(string), typeof(PersonTileWithFlip), null);

        public Brush TileColor
        {
            get { return (Brush)GetValue(TileColorProperty); }
            set { SetValue(TileColorProperty, value); }
        }

        public static readonly DependencyProperty TileColorProperty =
            DependencyProperty.Register("TileColor", typeof(Brush), typeof(PersonTileWithFlip), null);
        
        public string ClickURL
        {
            get { return (string)GetValue(ClickURLProperty); }
            set { SetValue(ClickURLProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClickURL.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClickURLProperty =
            DependencyProperty.Register("ClickURL", typeof(string), typeof(PersonTileWithFlip), null);


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.ClickURL))
            {
                BrowserInterop.OpenWindow(this.ClickURL);
            }
        }
        
    }
}