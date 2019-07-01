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
    /// Логика взаимодействия для CustomerWindow.xaml
    /// </summary>
    public partial class CustomersWindow : Window
    {
        DAL.AppContext context = new DAL.AppContext();
        DataRelation dr;
        public CustomersWindow()
        {
            dr = new DataRelation();
            InitializeComponent();
            FillDG();
        }
        public void FillDG()
        {
            this.dgCustomers.Items.Clear();
            List<Customer> customers = dr.FillCustomersList();
            this.dgCustomers.ItemsSource = customers;
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
