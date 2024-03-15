using System.Linq;
using System.Windows;

namespace lab1ef
{
    public partial class DriversWindow : Window
    {
        private lab1Entities lab1Entities = new lab1Entities();
        public DriversWindow()
        {
            InitializeComponent();
            DriversData.ItemsSource = lab1Entities.drivers.ToList();
        }
    }
}

