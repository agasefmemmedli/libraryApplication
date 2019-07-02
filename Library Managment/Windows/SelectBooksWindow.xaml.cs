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
   
    public partial class SelectBooksWindow : Window
    {
        DAL.AppContext context = new DAL.AppContext();
        DataRelation dr;
        public SelectBooksWindow()
        {
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
            this.Close();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
