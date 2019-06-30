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
    /// Логика взаимодействия для SelectBooksWindow.xaml
    /// </summary>
    public partial class SelectBooksWindow : Window
    {
        public SelectBooksWindow()
        {
            InitializeComponent();
        }

        private void BtnSelectBooks_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
