using System.Windows;
using System.Windows.Controls;

namespace HelpersLib
{
    public partial class CustomMessageBox : UserControl
    {
        public CustomMessageBox(string text, string button1 = "Ok", string button2 = "", string button3 = "")
        {
            InitializeComponent();
            Text.Text = text;
            Button1.Content = button1;

            if (!string.IsNullOrEmpty(button2))
            {
                Button2.Visibility = Visibility.Visible;
                Button2.Content = button2;
            }

            Button2.Content = button2;
            if (!string.IsNullOrEmpty(button3))
            {
                Button3.Visibility = Visibility.Visible;
                Button3.Content = button3;
            }
        }
    }
}