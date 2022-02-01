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

namespace WpfLesson14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "Принтер",

                ProductPrice = 15000,

                ProductImage = 1,
                ProductType = ProductTypes.Appliances
            });

            products.Add(new Product()
            {
                ProductName = "Торт",

                ProductPrice = 1000,

                ProductImage = 2,
                ProductType = ProductTypes.Food
            });

            products.Add(new Product()
            {
                ProductName = "Мороженое",

                ProductPrice = 60,

                ProductImage = 3,
                ProductType = ProductTypes.Food
            });

            lstBox.ItemsSource = products;

        }
    }
}




