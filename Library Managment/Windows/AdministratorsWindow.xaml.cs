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
    /// Логика взаимодействия для AdministratorsWindow.xaml
    /// </summary>
    public partial class AdministratorsWindow : Window
    {
        DAL.AppContext context = new DAL.AppContext();
        DataRelation dr;
        public AdministratorsWindow()
        {
            dr = new DataRelation();
            InitializeComponent();
            FillDG();
        }

        public void FillDG()
        {
            List<Administrator> books = dr.FillAdministratorsList();
            this.dgAdministrator.ItemsSource = books;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
