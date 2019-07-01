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
        public ReturnBooksWindow()
        {
            InitializeComponent();
        }

        private void BtnSelectCustomer_Click(object sender, RoutedEventArgs e)
        {
            SelectCustomerWindow selectCustomerWindow = new SelectCustomerWindow();
            selectCustomerWindow.ShowDialog();
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
