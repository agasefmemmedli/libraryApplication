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

namespace Library_Managment.Windows
{
    /// <summary>
    /// Логика взаимодействия для BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        DAL.AppContext context = new DAL.AppContext();
        private readonly DataRelation dr;
        Book bk;
        public BooksWindow()
        {
            bk = new Book();
            dr = new DataRelation();
            InitializeComponent();
            FillDG();
             

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public void FillDG()
        {
            this.dgBooks.Items.Clear();
            List <Book> books = dr.FillBooksList();
            foreach (Book book in books)
            {
                this.dgBooks.Items.Add(book);
            }
            
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DgBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnUpdateBook.Visibility = Visibility.Visible;
            btnDeleteBook.Visibility = Visibility.Visible;
            btnAddBook.Visibility = Visibility.Hidden;

            bk = dgBooks.SelectedItem as Book;
            if (bk != null)
            {
                tbBookName.Text = bk.Name.ToString();
                tbAuthorName.Text = bk.Author.ToString();
                tbBookCount.Text = bk.CountNow.ToString();
                tbPrice.Text = bk.Price.ToString();
            }
            
            
        }

        #region Reset Methods
        private void ResetTextBox()
        {
            tbBookName.Text = string.Empty;
            tbAuthorName.Text = string.Empty;
            tbBookCount.Text = string.Empty;
            tbPrice.Text = string.Empty;
           
        }

        private void ResetFromLabels()
        {
            tbBookName.Foreground = Brushes.Black;
            tbAuthorName.Foreground = Brushes.Black;
            tbBookCount.Foreground = Brushes.Black;
            tbPrice.Foreground = Brushes.Black;
        }

        private bool Validation()
        {
            ResetFromLabels();
            if (string.IsNullOrEmpty(tbBookName.Text))
            {
                lblBookName.Foreground = Brushes.Red;
                return false;
            }
            if (string.IsNullOrEmpty(tbAuthorName.Text))
            {
                lblAuthorName.Foreground = Brushes.Red;
                return false;
            }
            if (string.IsNullOrEmpty(tbBookCount.Text))
            {
                lblBookCount.Foreground = Brushes.Red;
                return false;
            }
            
            if (string.IsNullOrEmpty(tbPrice.Text))
            {
                lblPrice.Foreground = Brushes.Red;
                return false;
            }
            return true;
        }
        #endregion

        #region CRUD
        private void BtnAddBook_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                return;
            }
            
            Book book = new Book
            { 
               Name= tbBookName.Text ,
               Author= tbAuthorName.Text,
               CountNow= Convert.ToInt32(tbBookCount.Text),
               Count =Convert.ToInt32(tbBookCount.Text),
               Price=Convert.ToDecimal(tbPrice.Text)
            };
            dr.AddBooks(book);
            FillDG();
            ResetTextBox();
        }
        private void BtnUpdateBook_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                return;
            }
            Book newBook = new Book
            {
                Id = bk.Id,
                Name = tbBookName.Text,
                Author = tbAuthorName.Text,
                CountNow = Convert.ToInt32(tbBookCount.Text),
                Count = (Convert.ToInt32(tbBookCount.Text) - bk.CountNow) + bk.Count,
                Price = Convert.ToDecimal(tbPrice.Text)
            };
            dr.UpdateBooks(newBook);
            btnAddBook.Visibility = Visibility.Visible;
            btnUpdateBook.Visibility = Visibility.Hidden;
            btnDeleteBook.Visibility = Visibility.Hidden;
            ResetTextBox();
            FillDG();
            
        }
        private void BtnDeleteBook_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                return;
            } 
            if (MessageBox.Show("Do you want to delete this book?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                
                dr.DeleteBooks(bk.Id);
                btnAddBook.Visibility = Visibility.Visible;
                btnUpdateBook.Visibility = Visibility.Hidden;
                btnDeleteBook.Visibility = Visibility.Hidden;
                FillDG();
                ResetTextBox();

            }
            


        }
        #endregion

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
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
