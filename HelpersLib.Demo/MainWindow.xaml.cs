using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelpersLib.Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            CustomMessageBox dlg = new CustomMessageBox("Do you like Material Design?", "Yea!", "Nope!");
            int result = (int)await DialogHost.Show(dlg);
            switch (result)
            {
                case 1:
                    // do things
                    break;
                case 2:
                    // do things
                    break;
            }
        }

        private void btnBrowseFolder_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}