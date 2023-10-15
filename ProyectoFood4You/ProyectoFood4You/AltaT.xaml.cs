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
    /// Lógica de interacción para AltaT.xaml
    /// </summary>
    public partial class AltaT : Window
    {
        public AltaT()
        {
            InitializeComponent();
        }

        private void btRegresar1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
            this.Close();
        }

        private void btAltaT_click(object sender, RoutedEventArgs e)
        {
            
        }

        private void txtPlaca_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
