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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Library_Managment.Utilities;
using Library_Managment.Windows;

namespace Library_Managment
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            
            string login = tbLogin.Text.Trim();
            string password = tbPassword.Password.Trim();
            Login lg = new Login();
            bool a = lg.LoginCheck(login, password);
            if (a)
            {
                DashboardWindow dashboard = new DashboardWindow();
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login Or Password Wrong");
            }

            //DateTime a = DateTime.Now.AddDays(8);
            //DateTime b = DateTime.Now;
            //string c = (a - b).ToString();
            //string[] n =c.Split('.');
            //MessageBox.Show(n[0]);

        } 
    }
}
