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

namespace Program_5_5
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

        private void CaracterButton(object resultado, RoutedEventArgs e)
        {
            cadena();
        }

        public void cadena(){

            Tablas.Items.Clear(); 
            int numero = int.Parse(Texto.Text);
            Texto.Text = " ";

            if(numero == 1)
            {
                Tablas.Items.Add("Hola, Como estas?");
            }
            if (numero == 2)
            {
               Tablas.Items.Add("Hasta Mañana");
            }

            if (numero == 3)
            {
                Tablas.Items.Add("Saludos");
            }

            if (numero == 4)
            {
               Tablas.Items.Add("Nos vemos pronto");
            }

            if (numero == 5)
            {
               Tablas.Items.Add("Nos vemos mañana");
            }

            if (numero == 6)
            {
                Tablas.Items.Add("Que dios te llene de vendiciones");
            }

            if (numero == 7)
            {
                Tablas.Items.Add("Dios te vendiga");
            }

            if (numero == 8)
            {
                Tablas.Items.Add("Que dios te cubra con su manto");
            }

            if (numero == 9)
            {
                Tablas.Items.Add("nos vemos otro dia");
            }

            if (numero == 10)
            {
                Tablas.Items.Add("Dios vendiga a todo los que quieres");
            }
        }
    }
}
