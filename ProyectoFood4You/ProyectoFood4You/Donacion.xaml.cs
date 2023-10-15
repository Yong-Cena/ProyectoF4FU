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

namespace ProyectoFood4You
{
    /// <summary>
    /// Lógica de interacción para Donacion.xaml
    /// </summary>
    public partial class Donacion : Window
    {
        public Donacion()
        {
            InitializeComponent();
        }

        private void btMostrarTodo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btModificar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w= new MainWindow();
            w.Show();
            this.Close();
        }
    }
}
