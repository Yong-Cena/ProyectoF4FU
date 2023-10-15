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
    /// Lógica de interacción para ModificarR.xaml
    /// </summary>
    public partial class ModificarR : Window
    {
        public ModificarR()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void chEntregado_Checked(object sender, RoutedEventArgs e)
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
