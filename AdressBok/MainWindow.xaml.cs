using AdressBok.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AdressBok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<ContactPerson> contacts; // Det ska finnas en Lista
        public MainWindow()
        {
            InitializeComponent();
            contacts = new ObservableCollection<ContactPerson>(); //skapar en ny Lista
            lv_contacts.ItemsSource = contacts;
        }

        private void tbn_Add_Click(object sender, RoutedEventArgs e) 
        {
            contacts.Add(new ContactPerson
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
                Email = tb_Email.Text,
                StreetName = tb_StreetName.Text,
                PostalCode = tb_PostalCode.Text,
                City = tb_City.Text,
                
            }); 
        }
    }
}
