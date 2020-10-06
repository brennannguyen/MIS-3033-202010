using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
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

namespace JSONChuckNorris
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var client = new HttpClient())
            {
                string jsonResults = client.GetStringAsync(@"https://api.chucknorris.io/jokes/categories").Result;
                string[] cats = JsonConvert.DeserializeObject<string[]>(jsonResults);
                cboCategories.Items.Add("All");
                foreach (var category in cats)
                {
                    cboCategories.Items.Add(category);
                }
            }
        }

        private void cboCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((cats)cboCategories.SelectedItem == "All")
            {

            }
        }
    }
}
