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

namespace WPF1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            //txtName.Text = string.Empty;
            //txtAddress.Text = string.Empty;
            //txtZipCode.Text = string.Empty;
            lstBox.Items.Clear();
            //btnSubmit.IsEnabled = false;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name;
            string address;
            int ZipCode;
            name = txtName.Text;
            address = txtAddress.Text;
            ZipCode = Convert.ToInt32(txtZipCode.Text);
            
            EntryForm forms = new EntryForm(name, address, ZipCode);
            lstBox.Items.Add(forms);
        }

        //Code for enabling submission button.

        //private void (object sender, TextChangedEventArgs e)
        //{
        //    btnSubmit.IsEnabled = EnableButton();
        //}
        //private void (object sender, TextChangedEventArgs e)
        //{
        //    btnSubmit.IsEnabled = EnableButton();
        //}
        //private void (object sender, TextChangedEventArgs e)
        //{
        //    btnSubmit.IsEnabled = EnableButton();
        //}
        //
        //private bool EnableButton()
        //{
        //    bool result = false;
        //    if (txtName.Text != string.Empty
        //        && txtAddress.Text != string.Empty
        //        && txtZipCode.Text != string.Empty)
        //    {
        //        result = true;
        //    }
        //    return result;
        //}

    }
}
