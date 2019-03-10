using Business;
using Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UniversalApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Products
        private ProductBusiness productBusiness = new ProductBusiness();

        // Constructor
        public MainPage()
        {
            this.InitializeComponent();
            UpdateGrid();
        }

        // Grid
        private void UpdateGrid()
        {
            ProductsGrid.ItemsSource = productBusiness.GetAll();
        }

        // Insert
        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product()
            {
                Name = ProductName.Text,
                Price = decimal.Parse(ProductPrice.Text),
                Stock = int.Parse(ProductStock.Text)
            };
            productBusiness.Add(product);
            UpdateGrid();
        }

        // Update
        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsGrid.SelectedItems.Count > 0)
            {
                var item = (Product)ProductsGrid.SelectedItem;
                var id = int.Parse(item.Id.ToString());
                Product update = productBusiness.Get(id);
                ProductName.Text = update.Name;
                ProductPrice.Text = update.Price.ToString();
                ProductStock.Text = update.Stock.ToString();
            }
        }

        // Save
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsGrid.SelectedItems.Count > 0)
            {
                var item = (Product)ProductsGrid.SelectedItem;
                var id = int.Parse(item.Id.ToString());
                Product save = productBusiness.Get(id);
                save.Name = ProductName.Text;
                save.Price = decimal.Parse(ProductPrice.Text);
                save.Stock = int.Parse(ProductStock.Text);
                productBusiness.Update(save);
                UpdateGrid();
            }
        }

        // Delete
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsGrid.SelectedItems.Count > 0)
            {                
                var item = (Product)ProductsGrid.SelectedItem;
                var id = int.Parse(item.Id.ToString());
                productBusiness.Delete(id);
                UpdateGrid();
            }
        }
    }
}
