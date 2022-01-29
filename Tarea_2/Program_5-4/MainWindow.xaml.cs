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

namespace Program_5_4
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


        private void PromedioButton(object medio, RoutedEventArgs e)
        {

            promedio();

        }

        public void promedio()
        {

            double edad1 = int.Parse(Edad1.Text);
            double edad2 = int.Parse(Edad2.Text);
            double edad3 = int.Parse(Edad3.Text);

            Tablas.Items.Clear();

            if (edad1 > edad2 && edad1 > edad3)
            {

                Tablas.Items.Add($"la edad {edad1} es mayor");

            }

            if (edad1 < edad2 && edad1 < edad3)
            {

                Tablas.Items.Add($"la edad {edad1} es menor");

            }

            if (edad2 > edad1 && edad2 > edad3)
            {

                Tablas.Items.Add($"la edad {edad2} es mayor");

            }

            if (edad2 < edad1 && edad2 < edad3)
            {

                Tablas.Items.Add($"la edad {edad2} es menor");

            }


            if (edad3 > edad1 && edad3 > edad2)
            {

                Tablas.Items.Add($"la edad {edad3} es mayor");
                
            }

            if (edad3 < edad1 && edad3 < edad2)
            {

                Tablas.Items.Add($" la edad {edad3} es menor");

            }

            double promedio = edad1 / edad2 / edad3;

            Tablas.Items.Add($"El promedio {promedio}");

        }
    }
}
