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
        private readonly DataRelation dr;
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

        //return selected customer
        private void CustomerSelected(object sender, EventArgs e)
        {
            customer = sender as Customer;
            tbCustomerName.Text = customer.FullName;
            selectedBooks.Clear();
            this.dgCustomerSelectedBook.Items.Clear();
        }

        private void BtnSelectBooks_Click(object sender, RoutedEventArgs e)
        {
            SelectBooksWindow selectBooksWindow = new SelectBooksWindow();
            selectBooksWindow.OnSelected += new EventHandler(BookSelected);
            selectBooksWindow.ShowDialog();
        }

        //return selected books
        private void BookSelected(object sender, EventArgs e)
        {
            //add selected book in list
            List<SelectedBook> sBooks = sender as List<SelectedBook>;
            selectedBooks.AddRange(sBooks);
            
            this.dgCustomerSelectedBook.Items.Clear();
            decimal price = 0;
            int bCount = 0;
            foreach (SelectedBook book in selectedBooks)
            {
                this.dgCustomerSelectedBook.Items.Add(book);
                price += book.CalcPrice;
                bCount += 1;
            }
            lblBookCount.Content = bCount;
            lblPrice.Content = price;
        }

        private void BtnSaveOrder_Click(object sender, RoutedEventArgs e)
        {
            if (customer != null)
            {
                if (selectedBooks.Any())
                {
                    if (MessageBox.Show("Do you want to add this order?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        Order order = new Order();
                        order.CustomerId = customer.Id;
                        order.TakedDate = DateTime.Today;
                        dr.AddOrder(order);
                        RentedBook rentedBook = new RentedBook();
                        foreach (SelectedBook book in selectedBooks)
                        {

                            rentedBook.BookId = book.Id;
                            rentedBook.OrderId = order.Id;
                            rentedBook.ReturnDate = book.ReturnDate;
                            rentedBook.CalcPrice = book.CalcPrice;
                            rentedBook.Price = book.Price;
                            dr.RentBook(book.Id);
                            dr.AddRentBook(rentedBook);
                        }
                    }
                    this.Close();
                }


                else
                {
                    MessageBox.Show("You not selected Book!!!");
                    
                }
            }
            else
            {
                MessageBox.Show("You not selected Customer!!!");
                
            }
            
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
