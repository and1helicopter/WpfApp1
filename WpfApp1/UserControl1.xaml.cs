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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App._mainWindow.SetUc2();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App._mainWindow.SetUc3();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App._mainWindow.SetUc4();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            App._mainWindow.SetUc5();
        }
    }
}
