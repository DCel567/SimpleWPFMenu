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
    /// Interaction logic for UserControlHotDrinks.xaml
    /// </summary>
    public partial class UserControlHotDrinks : UserControl {
        public UserControlHotDrinks() {
            InitializeComponent();
        }

        private void tea_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Зеленый чай", Price = 200 });
        }

        private void coffee_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Каппучино", Price = 230 });
        }

        private void grogg_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Грог", Price = 200 });
        }
    }
}
