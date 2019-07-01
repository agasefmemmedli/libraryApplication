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
        DataRelation dr;
        public BooksWindow()
        {
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
            this.dgBooks.ItemsSource = books;
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
