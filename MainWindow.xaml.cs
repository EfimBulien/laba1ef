using System.Windows;

namespace lab1ef
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CarsButton_Click(object sender, RoutedEventArgs e)
        {
            CarsWindow cars = new CarsWindow();
            cars.Show();
        }

        private void DriversButton_Click(object sender, RoutedEventArgs e)
        {
            DriversWindow drivers = new DriversWindow();
            drivers.Show();
        }
    }
}

