using Model;
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

namespace UWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // Конструктор
        public MainPage()
        {
            this.InitializeComponent();
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

            // Актуализация
            ProductsList.ItemsSource = Products.GetAll();
        }
    }
}
