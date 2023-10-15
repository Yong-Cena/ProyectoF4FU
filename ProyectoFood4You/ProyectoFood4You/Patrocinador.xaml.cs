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
    /// Lógica de interacción para Patrocinador.xaml
    /// </summary>
    public partial class Patrocinador : Window
    {
        public Patrocinador()
        {
            InitializeComponent();
        }

        private void btAlta_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
