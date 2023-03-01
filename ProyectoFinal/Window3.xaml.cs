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
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private int timeLeft, tiempo;
        private DispatcherTimer timer;

        public Window3()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempo = timeLeft = timeProgressBar.Value == 0 ? 0 : timeLeft - 1;
            timeProgressBar.Value = timeLeft;

            if (timeProgressBar.Value == timeProgressBar.Minimum)
            {
                // El temporizador ha llegado a cero, realizar alguna acción aquí
            }

            timeProgressBar.InvalidateVisual();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {

            tiempo = int.Parse(timeLeftBox.Text);
            timeLeft = tiempo;
            timeProgressBar.Maximum = tiempo;
            timeProgressBar.Value = tiempo;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            timeLeft = 0;
            timeProgressBar.Value = timeLeft;
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

        private void Crono_Click(object sender, EventArgs e)
        {
            Window2 crono = new Window2();
            crono.Show();
            Hide();
        }
    }
}
