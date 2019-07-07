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
using System.Text.RegularExpressions;
using Library_Managment.Utilities;
using Library_Managment.Models;
using static Library_Managment.Utilities.DataRelation;

namespace Library_Managment.Windows
{
   
    public partial class SelectBooksWindow : Window
    {
        DAL.AppContext context = new DAL.AppContext();
        DataRelation dr;
        SelectedBook sBook;
        decimal count = 1;
        public event EventHandler OnSelected;
        Book book;
        public SelectBooksWindow()
        {
            sBook = new SelectedBook();
            dr = new DataRelation();
            InitializeComponent();
            FillDG();

        }

        public void FillDG()
        {
            this.dgBooks.Items.Clear();
            List<Book> books = dr.FillBooksList();
            foreach (Book book in books)
            {
                this.dgBooks.Items.Add(book);
            }
            
        }

       
        private void BtnSelectBooks_Click(object sender, RoutedEventArgs e)
        {
            List<SelectedBook> selecteds = new List<SelectedBook>();
            for (int a =0;a<count; a++)
            {
                
                sBook.Id = book.Id;
                sBook.Name = book.Name;
                sBook.TakingDate = DateTime.Today;
                sBook.ReturnDate = dpReturnDate.DisplayDate;
                sBook.CalcPrice = Math.Round(Convert.ToDecimal(lblBookPriceCount.Content)/count,2);
                sBook.Price = book.Price;

                selecteds.Add(sBook);
            }
            OnSelected(selecteds, new EventArgs());
            this.Close();
        }
        private void DgBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbBookCount.SelectionChanged -= new SelectionChangedEventHandler(CmbBookCount_SelectionChanged);
            
            book  = dgBooks.SelectedItem as Book;
            if (book != null)
            {
                tbBookName.Text = book.Name;
                btnSelectBooks.Visibility = Visibility.Visible;
            }
            dpReturnDate.SelectedDate = DateTime.Today.AddDays(28);
            dpReturnDate.DisplayDate = DateTime.Today.AddDays(28);
            lblBookPriceCount.Content = book.Price;
            cmbBookCount.Items.Clear();
            for (int a = 1; a <= book.CountNow; a++)
            {
                cmbBookCount.Items.Add(a);
            }
            cmbBookCount.SelectedIndex = 0;
            cmbBookCount.SelectionChanged += new SelectionChangedEventHandler(CmbBookCount_SelectionChanged);  
        }
        
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void DpReturnDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpReturnDate.SelectedDate < DateTime.Today)
            {
                dpReturnDate.SelectedDate = DateTime.Today.AddDays(1);
            }
            CalcPrice();
        }

        private void CalcPrice()
        {
            decimal different = Convert.ToDecimal(dpReturnDate.SelectedDate.Value.Date.Subtract(DateTime.Today).TotalDays);
            decimal price = Math.Round(((book.Price / 28) * different)*count, 2);
            lblBookPriceCount.Content = price.ToString();
        }
        private void CmbBookCount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            count = Convert.ToDecimal(cmbBookCount.SelectedItem.ToString());
            CalcPrice();
        }

        private void BtnSearchBooks_Click(object sender, RoutedEventArgs e)
        {
            this.dgBooks.Items.Clear();
            List<Book> books = dr.SearchBooks(tbSearch.Text);
            foreach (Book book in books)
            {
                this.dgBooks.Items.Add(book);
            }
        }
    }
}
