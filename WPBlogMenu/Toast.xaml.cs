using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WPBlogMenu
{
	public partial class Toast : UserControl
	{
		public Toast()
		{
			// Required to initialize variables
			InitializeComponent();
            this.DataContext = this;
		}

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                    Flip.Begin();
            }
            catch (Exception exc)
            {
                //can't imagine what would fail here, but don't let the control crash
            }

        }

        public Brush TileColor
        {
            get { return (Brush)GetValue(TileColorProperty); }
            set { SetValue(TileColorProperty, value); }
        }

        public static readonly DependencyProperty TileColorProperty =
            DependencyProperty.Register("TileColor", typeof(Brush), typeof(Toast), null);

        public string ToastLabel
        {
            get { return (string)GetValue(ToastLabelProperty); }
            set { SetValue(ToastLabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileFrontTextLine1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToastLabelProperty =
            DependencyProperty.Register("ToastLabel", typeof(string), typeof(Toast), null);

        public string ToastText
        {
            get { return (string)GetValue(ToastTextProperty); }
            set { SetValue(ToastTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TileFrontTextLine1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ToastTextProperty =
            DependencyProperty.Register("ToastText", typeof(string), typeof(Toast), null);

        public Visibility TipIconVisiblility
        {
            get { return (Visibility)GetValue(TipIconVisiblilityProperty); }
            set { SetValue(TipIconVisiblilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TipIconVisiblility.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TipIconVisiblilityProperty =
            DependencyProperty.Register("TipIconVisiblility", typeof(Visibility), typeof(Toast), null);

        

	}
}