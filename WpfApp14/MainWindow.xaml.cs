using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Бананы",
                ProdPrice = 70,
                ProdImage = "Data/Бананы.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Кокосы",
                ProdPrice = 120,
                ProdImage = "Data/Кокосы.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Апельсины",
                ProdPrice = 260,
                ProdImage = "Data/Апельсины.jpg",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProdName = "Пылесос",
                ProdPrice = 7000,
                ProdImage = "Data/Пылесос.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Утюг",
                ProdPrice = 3500,
                ProdImage = "Data/Утюг.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Стиральная машина",
                ProdPrice = 35000,
                ProdImage = "Data/Стиральная_машина.jpg",
                ProductCategory = ProductCategories.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
