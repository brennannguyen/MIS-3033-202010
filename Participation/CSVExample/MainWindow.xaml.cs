using System;
using System.Collections.Generic;
using System.IO;
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

namespace CSVExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnvalidate_Click(object sender, RoutedEventArgs e)
        {
            filePath = txtpath.Text;

            if (File.Exists(filePath) == true)
            {
                btnprocess.IsEnabled = true;
                btnvalidate.IsEnabled = false;
                txtpath.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Invalid file path. Please try again.", "ERROR", MessageBoxButton.OK);
                //txtpath.Clear();
                txtpath.Text = "";
                txtpath.Text = string.Empty;
                txtpath.Focus();
            }
        }

        private void btnprocess_Click(object sender, RoutedEventArgs e)
        {
            string[] lines = File.ReadAllLines(filePath);
            double sum = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                var pieces = line.Split(',');
                double price;

                if (Double.TryParse(pieces[2], out price) == true)
                {
                    sum += Convert.ToDouble(pieces[2]);
                }
                else
                {
                    MessageBox.Show("Sorry, there is a problem with the line {i+1}.");
                }

                1stFile.Items.Add(pieces[1]); //Add the current line to the listbox
            }
            MessageBox.Show($"The sum of all the product prices is {sum.ToString("C2")}.");

            //foreach (var line in lines)
            //{
            //  var pieces = line.Split(",");
            //
            //}
        }
    }
}
