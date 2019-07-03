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

    public partial class AdministratorsWindow : Window
    {
        DAL.AppContext context = new DAL.AppContext();
        DataRelation dr;
        Administrator ad;
        public AdministratorsWindow()
        {
            ad = new Administrator();
            dr = new DataRelation();
            InitializeComponent();
            FillDG();
        }

        public void FillDG()
        {
            this.dgAdministrator.Items.Clear();
            List<Administrator> Administrators = dr.FillAdministratorsList();
            foreach (Administrator administrator in Administrators)
            {
                this.dgAdministrator.Items.Add(administrator);
            }
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DgAdministrator_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ad != null)
            {
                btnAddAdministrator.Visibility = Visibility.Hidden;
                btnUpdateAdministrator.Visibility = Visibility.Visible;
                btnDeleteAdministrator.Visibility = Visibility.Visible;

                ad = dgAdministrator.SelectedItem as Administrator;

                tbAdministratorFullName.Text = ad.FullName.ToString();
                tbAdministratorLogin.Text = ad.Login.ToString();
                tbAdministratorPassword.Password = ad.Password.ToString();
                tbPhoneNumber.Text = ad.PhoneNumber.ToString();
                tbAddress.Text = ad.Address.ToString();
            }
        }

        #region Reset Methods
        private void ResetTextBox()
        {
            tbAdministratorFullName.Text = string.Empty;
            tbAdministratorLogin.Text = string.Empty;
            tbAdministratorPassword.Password = string.Empty;
            tbPhoneNumber.Text = string.Empty;
            tbAddress.Text = string.Empty;
        }

        private void ResetFromLabels()
        {
            lblAdministratorFullName.Foreground = Brushes.Black;
            lblAdministratorLogin.Foreground = Brushes.Black;
            lblAdministratorPassword.Foreground = Brushes.Black;
            lblAddress.Foreground = Brushes.Black;
            lblPhoneNumber.Foreground = Brushes.Black;
        }

        private bool Validation()
        {
            ResetFromLabels();
            if (string.IsNullOrEmpty(tbAdministratorFullName.Text))
            {
                lblAdministratorFullName.Foreground = Brushes.Red;
                return false;
            }
            if (string.IsNullOrEmpty(tbAdministratorLogin.Text))
            {
                lblAdministratorLogin.Foreground = Brushes.Red;
                return false;
            }
            if (string.IsNullOrEmpty(tbAdministratorPassword.Password))
            {
                lblAdministratorPassword.Foreground = Brushes.Red;
                return false;
            }
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                lblAddress.Foreground = Brushes.Red;
                return false;
            }
            if (string.IsNullOrEmpty(tbPhoneNumber.Text))
            {
                lblPhoneNumber.Foreground = Brushes.Red;
                return false;
            }
            
            return true;
        }
        #endregion

        #region CRUD
        private void BtnAddAdministrator_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                return;
            }

            Administrator administrator = new Administrator
            {
               FullName= tbAdministratorFullName.Text ,
               Login= tbAdministratorLogin.Text ,
               CreateDate=DateTime.Today,
               Password= tbAdministratorPassword.Password ,
               PhoneNumber= tbPhoneNumber.Text ,
               Address= tbAddress.Text 
            };
            dr.AddAdministrator(administrator);
            ResetTextBox();
            FillDG();
        }
        private void BtnUpdateAdministrator_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                return;
            }
            btnAddAdministrator.Visibility = Visibility.Visible;
            btnUpdateAdministrator.Visibility = Visibility.Hidden;
            btnDeleteAdministrator.Visibility = Visibility.Hidden;

            Administrator administrator = new Administrator
            {
                Id = ad.Id,
                FullName = tbAdministratorFullName.Text,
                Login = tbAdministratorLogin.Text,
                Password = tbAdministratorPassword.Password,
                CreateDate = DateTime.Today,
                PhoneNumber = tbPhoneNumber.Text,
                Address = tbAddress.Text
            };
            dr.UpdateAdministrator(administrator);
            ResetTextBox();
            FillDG();
        }
        private void BtnDeleteAdministrator_Click(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                return;
            }
            btnAddAdministrator.Visibility = Visibility.Visible;
            btnUpdateAdministrator.Visibility = Visibility.Hidden;
            btnDeleteAdministrator.Visibility = Visibility.Hidden;


            if (MessageBox.Show("Do you want to delete this Administrator?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {

                dr.DeleteAdministrator(ad.Id);
                FillDG();

            }
            ResetTextBox();
            FillDG();
        }
        #endregion
    }
}
