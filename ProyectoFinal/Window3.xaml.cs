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

namespace ProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
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
