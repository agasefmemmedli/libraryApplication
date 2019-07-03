using Library_Managment.Models;
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
using Library_Managment.Utilities;
using static Library_Managment.Utilities.DataRelation;

namespace Library_Managment.Windows
{
    /// <summary>
    /// Логика взаимодействия для NewOrder.xaml
    /// </summary>
    public partial class NewOrder : Window
    {
        DAL.AppContext context = new DAL.AppContext();
        DataRelation dr;
        Customer customer;
        List<SelectedBook> selectedBooks;
        public NewOrder()
        {
            dr = new DataRelation();
            selectedBooks = new List<SelectedBook>();
            InitializeComponent();
            
        }

        private void BtnSelectCustomer_Click(object sender, RoutedEventArgs e)
        {
            SelectCustomerWindow selectCustomerWindow = new SelectCustomerWindow();
            selectCustomerWindow.OnSelected += new EventHandler(CustomerSelected);
            selectCustomerWindow.ShowDialog();

            
        }

        private void CustomerSelected(object sender, EventArgs e)
        {
            customer = sender as Customer;
            tbCustomerName.Text = customer.FullName;
        }

        private void BtnSelectBooks_Click(object sender, RoutedEventArgs e)
        {
            SelectBooksWindow selectBooksWindow = new SelectBooksWindow();
            selectBooksWindow.OnSelected += new EventHandler(BookSelected);
            selectBooksWindow.ShowDialog();
        }
        private void BookSelected(object sender, EventArgs e)
        {
            SelectedBook sBook = sender as SelectedBook;
            selectedBooks.Add(sBook);
            this.dgCustomerSelectedBook.Items.Clear();
            foreach (SelectedBook book in selectedBooks)
            {
                this.dgCustomerSelectedBook.Items.Add(book);
            }
        }

        private void BtnSaveOrder_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to add this order?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Order order = new Order();
                order.CustomerId= customer.Id;
                order.TakedDate = DateTime.Today;
                dr.AddOrder(order);
                RentedBook rentedBook = new RentedBook();
                foreach (SelectedBook book in selectedBooks)
                {
                    for (int a = 0; a < book.BooksCount; a++)
                    {
                        rentedBook.BookId = book.Id;
                        rentedBook.OrderId = order.Id;
                        rentedBook.ReturnDate = book.ReturnDate;
                        rentedBook.Price = book.CalcPrice / Convert.ToDecimal(book.BooksCount);
                        dr.AddRentBook(rentedBook);
                    }
                }
                this.Close();
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
