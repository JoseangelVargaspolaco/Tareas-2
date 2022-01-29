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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Program_1_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TablaButton(object tabla, RoutedEventArgs e)
        {
            int numero = int.Parse(Tabla.Text);

            if (numero < 1 || numero > 10)
            {
                Tablas.Items.Clear();
                Tablas.Items.Add("ERROR");
            }
            else
            {
                Tablas.Items.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    Tablas.Items.Add($"{numero} x {i} = {i * numero}");
                }
            }
        }
    }
}
