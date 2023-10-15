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
    /// Lógica de interacción para AltaBajaT.xaml
    /// </summary>
    public partial class AltaBajaT : Window
    {
        public AltaBajaT()
        {
            InitializeComponent();
        }

        private void clickBajaT(object sender, RoutedEventArgs e)
        {
            BajaT bt= new BajaT();
            bt.Show();
            this.Close();
        }

        private void clickAltaT(object sender, RoutedEventArgs e)
        {
            AltaT at= new AltaT();
            at.Show();
            this.Close();
        }
    }
}
