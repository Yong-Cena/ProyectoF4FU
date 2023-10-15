using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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



namespace ProyectoFood4You
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void clickDonacion(object sender, RoutedEventArgs e)
        {
            Donacion donacion = new Donacion();
            donacion.Show();
            this.Close();
        }

        private void clickPatrocinador(object sender, RoutedEventArgs e)
        {
            Patrocinador pat= new Patrocinador();
            pat.Show();
            this.Close();
        }

        private void clickRuta(object sender, RoutedEventArgs e)
        {
            RutaAgregarModificar ram= new RutaAgregarModificar();
            ram.Show();
            this.Close();
        }

        private void clickTransporte(object sender, RoutedEventArgs e)
        {
            AltaBajaT ab = new AltaBajaT();
            ab.Show();
            this.Close();
        }
    }
}
