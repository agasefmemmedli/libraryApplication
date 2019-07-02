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
using static Library_Managment.Utilities.DataRelation;

namespace Library_Managment.Windows
{
    /// <summary>
    /// Логика взаимодействия для DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {
        private readonly DataRelation dr;
        public DashboardWindow()
        {
            dr = new DataRelation();
            InitializeComponent();
            FillDG();
        }
        public void FillDG()
        {
            List<ReturnDashboardList> returnDashboardListsToday = dr.FillDashboardList(DateTime.Today);
            List<ReturnDashboardList> returnDashboardListsTomorrow = dr.FillDashboardList(DateTime.Today.AddDays(1));
            List<ReturnDashboardList> returnDashboardListsDelay = dr.FillDashboardList(DateTime.Today.AddDays(-1));
            foreach (ReturnDashboardList returnDashboardList in returnDashboardListsToday)
            {
                this.dgToday.Items.Add(returnDashboardList);
            }
           

            foreach (ReturnDashboardList returnDashboardList in returnDashboardListsTomorrow)
            {
                this.dgTomorrow.Items.Add(returnDashboardList);
            }

            foreach (ReturnDashboardList returnDashboardList in returnDashboardListsDelay)
            {
                this.dgDelay.Items.Add(returnDashboardList);
            }
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnNewOrder_Click(object sender, RoutedEventArgs e)
        {

            NewOrder newOrder = new NewOrder();
            newOrder.ShowDialog();
            //DataRelation data = new DataRelation();
            //MessageBox.Show(data.FillReturnToday().ToString());
        }

        private void BtnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            ReturnBooksWindow returnBooksWindow = new ReturnBooksWindow();
            returnBooksWindow.ShowDialog();
        }

        private void BtnBooks_Click(object sender, RoutedEventArgs e)
        {
            BooksWindow booksWindow = new BooksWindow();
            booksWindow.ShowDialog();
        }

        private void BtnCustomers_Click(object sender, RoutedEventArgs e)
        {
            CustomersWindow customersWindow = new CustomersWindow();
            customersWindow.ShowDialog();
        }

        private void BtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdministratorsWindow administratorsWindow = new AdministratorsWindow();
            administratorsWindow.ShowDialog();
        }

        private void BtnReports_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow();
            reportsWindow.ShowDialog();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
