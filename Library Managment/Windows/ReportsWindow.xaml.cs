using Library_Managment.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
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

    public partial class ReportsWindow : Window
    {
        private readonly DataRelation dr;
        private string _path;
        public ReportsWindow()
        {
            dr = new DataRelation();
            InitializeComponent();
            
            dpFrom.SelectedDate = DateTime.Today.AddDays(-28);
            dpFrom.DisplayDate = DateTime.Today.AddDays(-28);

            dpTo.SelectedDate = DateTime.Today;
            dpTo.DisplayDate = DateTime.Today;
            FillDG(dpFrom.SelectedDate, dpTo.SelectedDate);

        }

        public void FillDG(DateTime? firstDay, DateTime? lastDay)
        {
            this.dgReports.Items.Clear();
            List <RentedBookList> rentedBookLists = dr.FillReportsList(firstDay, lastDay);
            foreach (RentedBookList rentedBookList in rentedBookLists)
            {
                this.dgReports.Items.Add(rentedBookList);
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            FillDG(dpFrom.SelectedDate, dpTo.SelectedDate);
        }

        private void BtnExportToExcell_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult r = fbd.ShowDialog() ;
            if (r == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            _path = fbd.SelectedPath;
            
            GrantAccess(_path);
            _path += "/Reports.xls";
            dgReports.SelectAllCells();
            dgReports.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, dgReports);
            String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            String result = (string)Clipboard.GetData(DataFormats.Text);
            dgReports.UnselectAllCells();
            try
            {
                System.IO.StreamWriter file1 = new System.IO.StreamWriter(_path);
                file1.WriteLine(result);
                file1.Close();
                MessageBox.Show(" Exporting DataGrid data to Excel file created.xls");
            }
            catch (Exception)
            {
                MessageBox.Show("No access to this folder, Select another!");
            }
        }
        private static void GrantAccess(string file)
        {
            bool exists = System.IO.Directory.Exists(file);
            if (!exists)
            {
                DirectoryInfo di = System.IO.Directory.CreateDirectory(file);
                MessageBox.Show("The Folder is created Sucessfully");
            }
            else
            {
                MessageBox.Show("The Folder already exists");
            }
            DirectoryInfo dInfo = new DirectoryInfo(file);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);

        }

        private void DpFrom_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpFrom.SelectedDate>=dpTo.SelectedDate)
            {
                dpTo.SelectedDate = dpFrom.SelectedDate.Value.AddDays(1);
            }
        }

        private void DpTo_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dpFrom.SelectedDate >= dpTo.SelectedDate)
            {
                dpFrom.SelectedDate = dpTo.SelectedDate.Value.AddDays(-1);
            }
        }
    }
}
