﻿using System;
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

namespace ProyectoFinal
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            fecha.Text = DateTime.Now.ToString("D");
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            reloj.Text = DateTime.Now.ToLongTimeString();
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

        private void Temp_Click(object sender, EventArgs e)
        {
            Window3 temp = new Window3();
            temp.Show();
            Hide();
        }
    }
}
