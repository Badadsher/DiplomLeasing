using Leasing.Model;
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

namespace Leasing.Pages.WorkersPage
{
    /// <summary>
    /// Логика взаимодействия для WorkerHistoryPage.xaml
    /// </summary>
    public partial class WorkerHistoryPage : Page
    {
        private int usid;
        public WorkerHistoryPage(int id)
        {
            InitializeComponent();        
            this.usid = id;
        }

        private void CloseLease(object sender, RoutedEventArgs e)
        {
            var curobj = DataGR.SelectedItem as Leases;
            if(curobj != null)
            {
                try
                {
                    int carid = (int)curobj.CarID;
                    var curcar = AppData.db.LeaseObjects.FirstOrDefault(u=> u.ID == carid);
                    curcar.LeaseID = null;
                    AppData.db.Leases.Remove(curobj);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Удалено!");
                    DataGR.ItemsSource = AppData.db.Leases.Where(u => u.ClientID == usid).ToList();
                }
                catch(Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            DataGR.ItemsSource = AppData.db.Leases.Where(u => u.ClientID == usid).ToList();
            MessageBox.Show("Обновлено!");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGR.ItemsSource = AppData.db.Leases.Where(u => u.ClientID == usid).ToList();
        }

        private void WorkerPageClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WorkerPage(usid));
        }

        private void ExitToAuthClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
