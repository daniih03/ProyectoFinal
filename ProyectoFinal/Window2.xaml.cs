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
        private DispatcherTimer timer = new DispatcherTimer();
        private int segundos = 0;

        public Window2()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            labelTiempo.Content = TimeSpan.FromSeconds(segundos).ToString(@"hh\:mm\:ss");
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            segundos = 0;
            labelTiempo.Content = TimeSpan.FromSeconds(segundos).ToString(@"hh\:mm\:ss");
            timer.Stop();
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            labelTiempo.Content = TimeSpan.FromSeconds(segundos).ToString(@"hh\:mm\:ss");
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
