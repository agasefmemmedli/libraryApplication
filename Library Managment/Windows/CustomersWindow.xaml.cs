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

    public partial class CustomersWindow : Window
    {
        DAL.AppContext context = new DAL.AppContext();
        DataRelation dr;
        Customer cr;
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

            foreach (Customer customer in customers)
            {
                this.dgCustomers.Items.Add(customer);
            }
            
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DgCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cr != null)
            {
                cr = dgCustomers.SelectedItem as Customer;
                tbCustomerFullName.Text = cr.FullName.ToString();
                tbPhoneNumber.Text = cr.PhoneNumber.ToString();
                tbAddress.Text = cr.Address.ToString();
                cbGender.Text = cr.Gender.ToString();
            }
        }

        #region Reset Methods
        private void ResetTextBox()
        {
            tbCustomerFullName.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            tbAddress.Text = string.Empty;
            cbGender.Text = string.Empty;
        }

        private void ResetFromLabels()
        {
            lblCustomerFullName.Foreground = Brushes.Black;
            lblPhoneNumber.Foreground = Brushes.Black;
            lblAddress.Foreground = Brushes.Black;
            lblGender.Foreground = Brushes.Black;
        }

        private bool Validation()
        {
            ResetFromLabels();
            if (string.IsNullOrEmpty(tbCustomerFullName.Text))
            {
                lblCustomerFullName.Foreground = Brushes.Red;
                return false;
            }
            if (string.IsNullOrEmpty(tbPhoneNumber.Text))
            {
                lblPhoneNumber.Foreground = Brushes.Red;
                return false;
            }
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                lblAddress.Foreground = Brushes.Red;
                return false;
            }
            if (string.IsNullOrEmpty(cbGender.Text))
            {
                lblGender.Foreground = Brushes.Red;
                return false;
            }
            return true;
        }
        #endregion

        #region CRUD
        private void BtnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            Customer customer = new Customer
            {
                FullName = tbCustomerFullName.Text,
                CreateDate = DateTime.Today,
                PhoneNumber = tbPhoneNumber.Text,
                Address = tbAddress.Text,
                Gender = cbGender.Text
            };
            dr.AddCustomer(customer);
        }
        private void BtnUpdateCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            Customer customer = new Customer
            {
                Id = cr.Id,
                FullName = tbCustomerFullName.Text,
                CreateDate = DateTime.Today,
                PhoneNumber = tbPhoneNumber.Text,
                Address = tbAddress.Text,
                Gender = cbGender.Text
            };
            dr.UpdateCustomer(customer);
        }
        private void BtnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            if (MessageBox.Show("Do you want to delete this Customer?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {

                dr.DeleteCustomer(cr.Id);
                FillDG();

            }
            
        }
        #endregion
    }
}
