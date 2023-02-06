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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private DispatcherTimer timer;
        private TimeSpan elapsedTime;

        public Window2()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(timer.Interval);
            tiempo.Text = elapsedTime.ToString("g");
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            elapsedTime = TimeSpan.Zero;
            tiempo.Text = elapsedTime.ToString("g");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Reloj_Click(object sender, EventArgs e)
        {
            MainWindow reloj = new MainWindow();
            reloj.Show();
            Hide();
        }

        private void Alarma_Click(object sender, EventArgs e)
        {
            Window1 alarma = new Window1();
            alarma.Show();
            Hide();
        }

        private void Temp_Click(object sender, EventArgs e)
        {
            Window3 temp = new Window3();
            temp.Show();
            Hide();
        }
    }

    internal class DispatcherTime
    {
    }
}
