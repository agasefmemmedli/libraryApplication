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
using static Library_Managment.Utilities.DataRelation;

namespace Library_Managment.Windows
{
    /// <summary>
    /// Логика взаимодействия для ReportsWindow.xaml
    /// </summary>
    public partial class ReportsWindow : Window
    {
        private readonly DataRelation dr;
        public ReportsWindow()
        {
            dr = new DataRelation();
            InitializeComponent();
            FillDG();
            dpFrom.SelectedDate = DateTime.Today.AddDays(-28);
            dpFrom.DisplayDate = DateTime.Today.AddDays(-28);

            dpTo.SelectedDate = DateTime.Today;
            dpTo.DisplayDate = DateTime.Today;
          

        }

        public void FillDG()
        {
            //List<RentedBookList> rentedBookLists = dr.FillReportsList();

            //foreach (RentedBookList rentedBookList in rentedBookLists)
            //{
            //    this.dgReports.Items.Add(rentedBookList);
            //}
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
