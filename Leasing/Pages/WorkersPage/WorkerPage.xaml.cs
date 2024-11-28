using Leasing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Логика взаимодействия для WorkerPage.xaml
    /// </summary>
    public partial class WorkerPage : Page
    {
        private int usid;
        public WorkerPage(int id)
        {
            InitializeComponent();
            this.usid = id; 
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGR.ItemsSource = AppData.db.LeaseObjects.Where(u => u.LeaseID == null).ToList();
        }

        private void TakeLease(object sender, RoutedEventArgs e)
        {
            try
            {
                var curobj = DataGR.SelectedItem as LeaseObjects;
              

                Leases newlease = new Leases();
                newlease.ID = AppData.db.Leases.Any() ? AppData.db.Leases.Max(u => u.ID) + 1 : 1;
                newlease.ClientID = usid;
                newlease.StartDate = DateTime.Now.Date;
                newlease.CarID = curobj.ID;
                newlease.CarName = curobj.Name;
                newlease.CarImg = curobj.Images;
                newlease.CarMonthly = curobj.MothlyPrice;
               
                newlease.Status = "В процессе";
                AppData.db.Leases.Add(newlease);
                AppData.db.SaveChanges();
                curobj.LeaseID = AppData.db.Leases.Max(u => u.ID);
                AppData.db.SaveChanges();
                MessageBox.Show("Успешно");
                DataGR.ItemsSource = AppData.db.LeaseObjects.Where(u => u.LeaseID == null).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            DataGR.ItemsSource = AppData.db.LeaseObjects.Where(u => u.LeaseID == null).ToList();
            MessageBox.Show("Успешно");
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    
        private void ExitToAuthClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void HistoryWorker(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WorkerHistoryPage(usid));
        }
    }
}
