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

namespace Program_2_4
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

        private void ElevadoButton(object elevado, RoutedEventArgs e)
        {
            long Base = long.Parse(Elevado.Text);
            long exponencial = long.Parse(Elevado_2.Text);
            long Resultado = 1;

            for (int i = 0; i < exponencial; i++)
            {
                Resultado = Resultado * Base;
            }

            MessageBox.Show($" El resultado es {Resultado}");

        }


    }
}
