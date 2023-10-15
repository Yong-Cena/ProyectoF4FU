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
    /// Lógica de interacción para RutaAgregarModificar.xaml
    /// </summary>
    public partial class RutaAgregarModificar : Window
    {
        public RutaAgregarModificar()
        {
            InitializeComponent();
        }

        private void btModificarR_Click(object sender, RoutedEventArgs e)
        {
            ModificarR mr= new ModificarR();
            mr.Show();
            this.Close();
        }

        private void btAlta_Click(object sender, RoutedEventArgs e)
        {
            AltaR ar= new AltaR();
            ar.Show();
            this.Close();
        }
    }
}
