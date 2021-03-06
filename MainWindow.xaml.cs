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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Dish {
        public string Title { get; set; }
        public double Price { get; set; }
    }

    public partial class MainWindow : Window {

        public static List<string> basketContains = new List<string>(){};
        public static double totalPrice = 0;
        public static List<Dish> basketContent = new List<Dish>() {};
        
        public MainWindow() {
            InitializeComponent();
        }

        private void ButtonCloseApp_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e) {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch(index){
            case 0:
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(new UserControlDishes());
                break;
            case 1:
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(new UserControlPizza());
                break;
            case 2:
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(new UserControlDeserts());
                break;
            case 3:
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(new UserControlHotDrinks());
                break;
            case 4:
                GridPrincipal.Children.Clear();
                GridPrincipal.Children.Add(new UserControlColdDrinks());
                break;
            default:
                break;
            }
        }

        private void MoveCursorMenu(int index) {
            TransitioningContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, 100 + (60 * index), 0, 0);
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e) {

        }

        private void btn_basket_Click(object sender, RoutedEventArgs e) {
            GridPrincipal.Children.Clear();
            UserControlBasket basket = new UserControlBasket();
            basket.list.ItemsSource = basketContent;

            double totalPrice = 0;
            for(int i = 0; i < basketContent.Count; i++){
                totalPrice += basketContent[i].Price;
            }

            basket.TotalPrice.Text = Convert.ToString(totalPrice)+" р.";
            GridPrincipal.Children.Add(basket);

        }
    }
}
