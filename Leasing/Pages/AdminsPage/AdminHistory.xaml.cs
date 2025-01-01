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

namespace Leasing.Pages.AdminsPage
{
    /// <summary>
    /// Логика взаимодействия для AdminHistory.xaml
    /// </summary>
    public partial class AdminHistory : Page
    {
        public AdminHistory()
        {
            InitializeComponent();
        }

        private void CarsClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void UsersClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminUsers());
        }

        private void ExitToAuthClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DataGR.SelectedItem != null)
                {
                    var cur = DataGR.SelectedItem as Leases;
                    AppData.db.Leases.Remove(cur);
                    AppData.db.SaveChanges();
                    DataGR.ItemsSource = AppData.db.Leases.ToList();

                    MessageBox.Show("Удалено");
                }
                else
                {
                    MessageBox.Show("Выберите объект для удаления");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            Refresher();
        }



        private void EditDogovor(object sender, RoutedEventArgs e)
        {
            DarkOverlay.Visibility = Visibility.Visible;
            Window editdg = new EditDogovor
            {
                Owner = Window.GetWindow(this), // Установите владельца окна
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            editdg.ShowDialog();
            DarkOverlay.Visibility = Visibility.Collapsed;
        }

        private void AddDogovor(object sender, RoutedEventArgs e)
        {
            DarkOverlay.Visibility = Visibility.Visible;
            Window adddogovor = new AddDogovor
            {
                Owner = Window.GetWindow(this), // Установите владельца окна
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            adddogovor.ShowDialog();
            DarkOverlay.Visibility = Visibility.Collapsed;
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
                        select new LeaseViewModel
                        {
                            CarId = (int)lease.CarID,
                            Name = leaseObject.Name,
                            Images = leaseObject.Images,
                            MothlyPrice = (int)leaseObject.MothlyPrice,
                            StartDate = lease.StartDate,
                            EndDate = lease.EndDate,
                            Status = leasestus.StatusLeaseName,
                            CarID = (int)lease.CarID,
                            ClientID = lease.ClientID
                        };

            DataGR.ItemsSource = query.ToList();
        }

        private void OpenLeaseObjects(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPageLeasesAdd());
        }
    }
}