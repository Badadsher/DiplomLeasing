using Leasing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
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
using static MaterialDesignThemes.Wpf.Theme;

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
            var curobj = DataGR.SelectedItem as LeaseViewModel;
            var cur = AppData.db.Leases.Where(u => u.CarID == curobj.CarID).FirstOrDefault();
            var curcar = AppData.db.LeaseObjects.Where(u => u.ID == cur.CarID).FirstOrDefault();
            if (curobj != null)
            {
                try
                {
                    curcar.CarStatusID = 1;
                    AppData.db.Leases.Remove(cur);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Удалено!");
                    Refresher();
                }
                catch(Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            Refresher();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresher();
        }


        private void Refresher()
        {
            var query = from lease in AppData.db.Leases
                        join leaseObject in AppData.db.LeaseObjects

                        on lease.CarID equals leaseObject.ID
                        join leasestus in AppData.db.LeaseStatus
                        on lease.StatusID equals leasestus.ID
                        where lease.ClientID == usid
                        select new LeaseViewModel
                        {
                            CarId = (int)lease.CarID,
                            Name = leaseObject.Name,
                            Images = leaseObject.Images,
                            MothlyPrice = (int)leaseObject.MothlyPrice,
                            StartDate = lease.StartDate,
                            EndDate = lease.EndDate,
                            Status = leasestus.StatusLeaseName,
                            CarID = (int)lease.CarID
                        };

            DataGR.ItemsSource = query.ToList();
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
