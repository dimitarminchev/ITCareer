using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
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

namespace _03.ChuckNorris_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        // The jokes sourse
        private ObservableCollection<String> source = new ObservableCollection<String>();

        // Constructor
        public MainPage()
        {
            this.InitializeComponent();// UI

            // UI Binding
            this.Jokes.ItemsSource = source;
        }

        // Event Handler for User Clicking on The Button in the UI
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            Uri uri = new Uri("http://api.icndb.com/jokes/random");
            String text = client.GetStringAsync(uri).Result;

            // Deserialize: JSON > OOP
            var json = JsonConvert.DeserializeObject<RootObject>(text);
            var joke = json.value.joke;

            source.Add(joke);
        }
    }
}
