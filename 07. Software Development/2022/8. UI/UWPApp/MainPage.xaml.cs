using System;
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
        // Product Identifier
        private int ProductId = 0;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

            // Products Table
            ProductsList.ItemsSource = Products.GetAll();
        }

        /// <summary>
        /// Save Button Click Event Hanler
        /// </summary>
        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            // Create Product
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

        /// <summary>
        /// Select Product Event Handler
        /// </summary>
        private void ListView_Selection_Changed(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                // Get Product Info
                var item = ProductsList.SelectedItems[0] as Model.Product;
                ProductId = item.Id;
                this.name.Text = item.Name;
                this.price.Text = item.Price.ToString();
                this.stock.Text = item.Stock.ToString();
            }
            catch 
            {
                // nope
            }
        }

        /// <summary>
        /// Update Button Click Event Hanler
        /// </summary>
        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {
            // Create Product
            Product product = new Product()
            {
                Id = ProductId,
                Name = name.Text,
                Price = decimal.Parse(price.Text),
                Stock = int.Parse(stock.Text)
            };

            // Update
            Products.Update(product);

            // Update Products Table
            ProductsList.ItemsSource = Products.GetAll();
        }

        /// <summary>
        /// Delete Button Click Event Hanler
        /// </summary>
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
                var item = ProductsList.SelectedItems[0] as Model.Product;

                // Delete
                Products.Delete(item.Id);

                // Update Products Table
                ProductsList.ItemsSource = Products.GetAll();
            }            
        }

    }
}
