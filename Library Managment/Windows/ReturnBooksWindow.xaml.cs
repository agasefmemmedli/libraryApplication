using Library_Managment.Models;
using Library_Managment.Utilities;
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
using System.Windows.Shapes;

namespace Library_Managment.Windows
{
    /// <summary>
    /// Логика взаимодействия для ReturnBooksWindow.xaml
    /// </summary>
    public partial class ReturnBooksWindow : Window
    {
        DataRelation dr;
        Customer customer;
        public ReturnBooksWindow()
        {
            dr = new DataRelation();
            InitializeComponent();
        }

        private void BtnSelectCustomer_Click(object sender, RoutedEventArgs e)
        {
            SelectCustomerWindow selectCustomerWindow = new SelectCustomerWindow();
            selectCustomerWindow.OnSelected += new EventHandler(CustomerSelected);
            selectCustomerWindow.ShowDialog();
        }

        private void CustomerSelected(object sender,EventArgs e)
        {
            customer = sender as Customer;
            tbCustomerName.Text = customer.FullName;
            List<RentedBook> rentedBooks= dr.SearchRentedBook(customer.Id);
            this.dgCustomerTackedBook.Items.Clear();
            foreach (RentedBook book in rentedBooks)
            {
                this.dgCustomerTackedBook.Items.Add(book);
                //book.Book.Name
            }

        }

        private void BtnSaveOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
