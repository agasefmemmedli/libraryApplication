using Library_Managment.Models;
using Library_Managment.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using static Library_Managment.Utilities.DataRelation;

namespace Library_Managment.Windows
{
    /// <summary>
    /// Логика взаимодействия для ReturnBooksWindow.xaml
    /// </summary>
    public partial class ReturnBooksWindow : Window
    {
        List<ReturnRentedBookList> returnRentedBookLists;
        List<ReturnRentedBookList> rentedBooks;
        ReturnRentedBookList rrb;
        DataRelation dr;
        decimal price;
        decimal delay;
        Customer customer;
        public ReturnBooksWindow()
        {
            returnRentedBookLists = new List<ReturnRentedBookList>();
            rentedBooks = new List<ReturnRentedBookList>();
            dr = new DataRelation();
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
            lblBookPriceCount.Content = 0;
            lbldelayCount.Content = 0;
            lblOrderSummaryCount.Content = 0;
            dgCustomerReturnBook.Items.Clear();
            returnRentedBookLists.Clear();
            customer = sender as Customer;
            if (customer != null)
            {
                tbCustomerName.Text = customer.FullName;
                rentedBooks = dr.SearchRentedBook(customer.Id);
                this.dgCustomerTackedBook.Items.Clear();
                foreach (ReturnRentedBookList book in rentedBooks)
                {
                    this.dgCustomerTackedBook.Items.Add(book);
                }
            }
        }



        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DgCustomerTackedBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgCustomerTackedBook.SelectedItem != null)
            {
                rrb = dgCustomerTackedBook.SelectedItem as ReturnRentedBookList;

                dgCustomerTackedBook.Items.Remove(rrb);
                

                decimal different = Convert.ToDecimal(DateTime.Today.Subtract(rrb.TakingDate).TotalDays);
                decimal Calcprice = Math.Round(((rrb.Price / 28) * different * rrb.Count), 2);

                decimal Calcdelay = 0;
                if (rrb.ReturnDate < DateTime.Today)
                {
                    decimal differentDelay = Convert.ToDecimal(DateTime.Today.Subtract(rrb.ReturnDate).TotalDays);
                    Calcdelay = Math.Round(((rrb.Price / 200) * differentDelay * rrb.Count), 2);
                }
                rrb.CalcPrice = Calcprice + Calcdelay;
                price += Calcprice;
                delay += Calcdelay;
                rrb.ReturnDate = DateTime.Today;
                lblBookPriceCount.Content = price;
                lbldelayCount.Content = delay;
                lblOrderSummaryCount.Content = price + delay;
                dgCustomerReturnBook.Items.Add(rrb);
                returnRentedBookLists.Add(rrb);

            }
        }

        private void BtnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            
            if (customer != null)
            {
                if (returnRentedBookLists.Any())
                {
                    if (MessageBox.Show("Do you want to return this books?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        foreach (ReturnRentedBookList bk in returnRentedBookLists)
                        {
                            dr.ReturnBook(bk.Id, bk.RentedBookId, bk.CalcPrice);
                        }
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("You not select Book!!!");
                }

            }
            else
            {
                MessageBox.Show("You not select Customer!!!");

            }
        }
    }
}
