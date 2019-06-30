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
    /// Логика взаимодействия для SelectedBookPropertyWindow.xaml
    /// </summary>
    public partial class SelectedBookPropertyWindow : Window
    {
        public SelectedBookPropertyWindow()
        {
            
            InitializeComponent();
            dpReturnDate.SelectedDate = DateTime.Today.AddDays(28);
            dpReturnDate.DisplayDate = DateTime.Today.AddDays(28);

            
        }

        private void BtnSaveBook_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
