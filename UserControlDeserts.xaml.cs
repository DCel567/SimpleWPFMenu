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
    /// Interaction logic for UserControlDeserts.xaml
    /// </summary>
    public partial class UserControlDeserts : UserControl {
        public UserControlDeserts() {
            InitializeComponent();
        }

        private void btn_tiramisu_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Тирамису", Price = 200 });
        }

        private void btn_yogurt_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Йогурт", Price = 230 });
        }

        private void btn_tortik_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContent.Add(new Dish { Title = "Тортик", Price = 200 });
        }
    }
}
