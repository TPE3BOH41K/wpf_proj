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
using System.Windows.Threading;

namespace Morozov_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TimeSpan a = new TimeSpan();
        DateTime date = new DateTime(2023, 12, 21);
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            a = date - DateTime.Now;
            txb_Time.Text = "Марафон стартует через " + a.Days + "д. " + a.Hours + "ч. " + a.Minutes + "мин. " + a.Seconds + "с. ";
        }
    }

    internal class txb_Time
    {
        public static string? Text { get; internal set; }
    }
}
