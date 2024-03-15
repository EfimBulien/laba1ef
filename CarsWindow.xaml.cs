using System.Linq;
using System.Windows;

namespace lab1ef
{
    public partial class CarsWindow : Window
    {
        private lab1Entities lab1Entities = new lab1Entities();
        public CarsWindow()
        {
            InitializeComponent();
            CarsData.ItemsSource = lab1Entities.cars.ToList();
        }
    }
}

