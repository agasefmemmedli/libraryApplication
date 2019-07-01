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
            this.dgCustomers.ItemsSource = customers;
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
