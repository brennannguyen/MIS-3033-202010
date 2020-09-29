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
            //Adjusted code after reviewing previous lectures.
            Toy toy1 = new Toy();
            if (string.IsNullOrEmpty(txtManufacturer.Text) && string.IsNullOrEmpty(txtName.Text) && !int.TryParse(txtPrice.Text, out var value))
            {
                MessageBox.Show("Please input data.");
            }
            else if(string.IsNullOrEmpty(txtManufacturer.Text) && string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("One of the string values are null or empty.");
            }
            else if (!int.TryParse(txtPrice.Text, out var number))
            {
                MessageBox.Show("Price must be a whole number.");
            }
            else
            {
                toy1.Manufacturer = txtManufacturer.Text;
                toy1.Name = txtName.Text;
                toy1.Price = Convert.ToDouble(txtPrice.Text);
                lstToys.Items.Add(toy1);
            }
        }
                
        private void lstToys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Toy selectedToy = (Toy)lstToys.SelectedItem;
            MessageBox.Show($"Aisle: {selectedToy.GetAisle()}");
        }
    }
}
