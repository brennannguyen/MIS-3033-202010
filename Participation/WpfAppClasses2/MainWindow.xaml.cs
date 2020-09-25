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

namespace WpfAppClasses2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddToy_Click(object sender, RoutedEventArgs e)
        {
            if (txtManufacturer.Text != string.Empty && txtName.Text != string.Empty && txtPrice.Text != string.Empty)
            {
                Toy toy1 = new Toy();
                toy1.Manufacturer = txtManufacturer.Text;
                toy1.Name = txtName.Text;
                toy1.Price = Convert.ToDouble(txtPrice.Text);
                lstToys.Items.Add(toy1);

            }
            else 
            {
                MessageBox.Show("Values for Manufacturer, Name, and/or Price were not correctly inputted.");
            }
        }

        private void lstToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)lstToys.SelectedItem;
            string aisle = selectedToy.GetAisle();
            MessageBox.Show($"Aisle: {aisle}");
        }
    }
}
