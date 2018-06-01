using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            tm = new TimerCallback(Data);
            _dateTimer = new Timer(tm, 0, 0, 10);
        }

        private bool start = true;
        private bool old = true;
        private TimerCallback tm;
        private Timer _dateTimer;


        private void Data(object state)
        {
            Dispatcher.BeginInvoke(new Action(Start));
        }

        private int i = 1;
        private int count = 1;

        public void Start()
        {
            if (start)
            {
                if (i <= 2048)
                {
                    var asxxdc = (Rectangle)this.FindName("r_" + i);
                    asxxdc.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF4DB03D");
                    i++;
                    if (i > 2048)
                    {
                        _dateTimer.Change(0, 1000);
                    }
                }
                else
                {
                    if (count <= 6)
                    {
                        for (int j = 1; j <= 2048; j++)
                        {
                            var asxxdc = (Rectangle)this.FindName("r_" + j);
                            asxxdc.Fill = count % 2 == 0 ?(SolidColorBrush)new BrushConverter().ConvertFromString("#FFFFFFFF"): (SolidColorBrush)new BrushConverter().ConvertFromString("#FF4DB03D");       
                        }
                        count++;
                    }
                    else
                    {
                        start = false;
                        old = false;
                    }
                }
            }
            else if (!old)
            {
                for (int j = 1; j <= 2048; j++)
                {
                    var asxxdc = (Rectangle)this.FindName("r_" + j);
                    asxxdc.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF4DB03D");

                }
                for (int j = 1; j <= 288; j++)
                {
                    var asxxdc = (Rectangle)this.FindName("b_" + j);
                    asxxdc.Fill = (SolidColorBrush)new BrushConverter().ConvertFromString("#FF4DB03D");
                }
            }
        }

    }
}
