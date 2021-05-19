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
    /// Interaction logic for UserControlPizza.xaml
    /// </summary>
    public partial class UserControlPizza : UserControl {
        public UserControlPizza() {
            InitializeComponent();
        }

        private void btn_margherita_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Маргарита", Price = 400 });
        }

        private void btn_pepperoni_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Пепперони", Price = 450 });
        }

        private void btn_hawaiian_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Гавайская", Price = 100 });
        }
    }
}
