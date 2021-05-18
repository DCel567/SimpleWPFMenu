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
    /// Interaction logic for UserControlDishes.xaml
    /// </summary>
    public partial class UserControlDishes : UserControl {
        public UserControlDishes() {
            InitializeComponent();
        }

        private void btn_boloneze_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContains.Add("Болоньезе паста");
            RestaurantMenu.MainWindow.totalPrice += 230;
        }

        private void btn_karbonara_Click(object sender, RoutedEventArgs e) {
            RestaurantMenu.MainWindow.basketContains.Add("Карбонара паста");
            RestaurantMenu.MainWindow.totalPrice += 200;
        }
    }
}
