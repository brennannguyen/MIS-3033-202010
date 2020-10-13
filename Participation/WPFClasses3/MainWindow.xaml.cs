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

namespace WPFClasses3
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;

            student.SetAddress(Convert.ToInt32(txtStreetNumber.Text), txtStreetName.Text, txtState.Text, txtCity.Text, Convert.ToInt32(txtZipcode.Text));

            lstStudents.Items.Add(student);
        }

        private void lstStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
