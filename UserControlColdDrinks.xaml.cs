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

namespace RestaurantMenu {
    /// <summary>
    /// Interaction logic for UserControlColdDrinks.xaml
    /// </summary>
    public partial class UserControlColdDrinks : UserControl {
        public UserControlColdDrinks() {
            InitializeComponent();
        }

        private void cocktail_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Коктейль", Price = 200 });
        }

        private void cola_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Кока-Кола", Price = 230 });
        }

        private void beer_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Пиво", Price = 200 });
        }
    }
}
