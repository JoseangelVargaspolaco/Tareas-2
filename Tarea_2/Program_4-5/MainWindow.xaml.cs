using System.Windows;

namespace Program_4_5
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

        private void FactorialButton(object resultado, RoutedEventArgs e)
        {
            long numero = long.Parse(Resultado.Text);
            long factorial = 1;

            if (numero == 0)
            {
                Tablas.Items.Clear();
                Tablas.Items.Add($"El factorial de 0 es {numero}");
            }
            else
            {
                Tablas.Items.Clear();
                for (int i = 1; i <= numero; i++)
                {
                    factorial = factorial * i;
                    Tablas.Items.Add($" {numero} x {i}");
                }

                Tablas.Items.Add($"El factorial de {numero} es {factorial}");

            }
        }
    }
}
