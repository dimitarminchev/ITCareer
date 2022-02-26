using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWPApp
{
    // Namespace
    using Model;

    /// <summary>
    /// Products 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Конструктор
        public MainPage()
        {
            this.InitializeComponent();

            // Products Table
            ProductsList.ItemsSource = Products.GetAll();
        }

        // Запис
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product()
            {
                Name = name.Text,
                Price = decimal.Parse(price.Text),
                Stock = int.Parse(stock.Text)
            };
            Products.Add(product);

            // Update Product
            ProductsList.ItemsSource = Products.GetAll();
        }
    }
}
