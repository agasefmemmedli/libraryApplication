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
    /// Логика взаимодействия для SelectCustomerWindow.xaml
    /// </summary>
    public partial class SelectCustomerWindow : Window
    {
        public SelectCustomerWindow()
        {
            InitializeComponent();
        }

        
        private void BtnSaveOrder_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
