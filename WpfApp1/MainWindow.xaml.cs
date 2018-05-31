using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _uc1 = new UserControl1();
            ContentControl.Content = _uc1;
           // DelegateDate = DataUpdate;
            WindowState = WindowState.Maximized;
            tm = new TimerCallback(Data);
            dateTimer = new Timer(tm, 0, 0, 1000);

        }

        private void Data(object state)
        {
            Dispatcher.BeginInvoke(new Action(Dadsata));
        }

        private void Dadsata()
        {
            LabelTime.Content = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
            LabelData.Content = DateTime.Now.Day.ToString("D2") + ":" + DateTime.Now.Month.ToString("D2") + ":" + DateTime.Now.Year;
        }

        private TimerCallback tm;
        private Timer dateTimer;

        private UserControl2 _uc2;
        private UserControl1 _uc1;

        public void SetUc2()
        {
            if (_uc2 == null)
            {
                _uc2 = new UserControl2();
                ContentControl.Content = _uc2;
            }
            else
            {
                ContentControl.Content = _uc2;
            }
        }

        private void SetUc1()
        {
            if (_uc1 == null)
            {
                _uc1 = new UserControl1();
                ContentControl.Content = _uc1;
            }
            else
            {
                ContentControl.Content = _uc1;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SetUc1();
        }
    
        private UserControl3 _uc3;
        private UserControl4 _uc4;
        private UserControl5 _uc5;

        public void SetUc3()
        {
            if (_uc3 == null)
            {
                _uc3 = new UserControl3();
                ContentControl.Content = _uc3;
            }
            else
            {
                ContentControl.Content = _uc3;
            }
        }

        public void SetUc4()
        {
            if (_uc4 == null)
            {
                _uc4 = new UserControl4();
                ContentControl.Content = _uc4;
            }
            else
            {
                ContentControl.Content = _uc4;
            }
        }

        public void SetUc5()
        {
            if (_uc5 == null)
            {
                _uc5 = new UserControl5();
                ContentControl.Content = _uc5;
            }
            else
            {
                ContentControl.Content = _uc5;
            }
        }
    }
}
