using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;

namespace UWPApp
{
    // Namespace
    using Model;

    /// <summary>
    /// Products 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Identificator
        private int ProductID = 0;

        // Constructor
        public MainPage()
        {
            this.InitializeComponent();

            // Products Table
            ProductsList.ItemsSource = Products.GetAll();
        }

        // Save Button Click Event Hanler
        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product()
            {
                Name = name.Text,
                Price = decimal.Parse(price.Text),
                Stock = int.Parse(stock.Text)
            };

            // Insert
            Products.Add(product);

            // Update Products Table
            ProductsList.ItemsSource = Products.GetAll();
        }

        // Select ITem Event Handler
        private void ListView_Selection_Changed(object sender, SelectionChangedEventArgs e)
        {
            var product = ProductsList.SelectedItems[0] as Model.Product;
        }

        // Update Button Click Event Hanler
        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Updage
        }

        // Delete Button Click Event Hanler
        private async void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            // Dialog
            ContentDialog diaogDialog = new ContentDialog
            {
                Title = "Delete permanently?",
                Content = "If you delete this, you won't be able to recover it. Do you want to delete it?",
                PrimaryButtonText = "Delete",
                CloseButtonText = "Cancel"
            };
            var dialogResult = await diaogDialog.ShowAsync();

            // Delete the file if the user clicked the primary button.
            if (dialogResult == ContentDialogResult.Primary)
            {
                 Model.Product item = ProductsList.SelectedItems[0] as Model.Product;

                // Delete
                Products.Delete(item.Id);

                // Update Products Table
                ProductsList.ItemsSource = Products.GetAll();
            }            
        }

    }
}
