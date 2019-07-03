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
using Library_Managment.Models;

namespace Library_Managment.Windows
{
    /// <summary>
    /// Логика взаимодействия для SelectCustomerWindow.xaml
    /// </summary>
    public partial class SelectCustomerWindow : Window
    {
        DAL.AppContext context = new DAL.AppContext();
        DataRelation dr;
        Customer customer;

        public event EventHandler OnSelected;
        public SelectCustomerWindow()
        {
            dr = new DataRelation();
            InitializeComponent();
            FillDG();
        }

        public void FillDG()
        {
            this.dgCustomers.Items.Clear();
            List<Customer> customers = dr.FillCustomersList();
            foreach (Customer customer in customers)
            {
                this.dgCustomers.Items.Add(customer);
            }
        }

        private void DgCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = dgCustomers.SelectedItem as Customer;
            lblCustomerFullName.Content = customer.FullName;
        }
        private void BtnSelectCustomer_Click(object sender, RoutedEventArgs e)
        {
            OnSelected(customer, new EventArgs());
            this.Close();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
