using Leasing.Model;
using Leasing.Pages.AdminsPage;
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
            Refresher();
        }

        private void TakeLease(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    var curobj = DataGR.SelectedItem as CarView;
            //    var curCAR = AppData.db.LeaseObjects.Where(u => u.ID == curobj.Id).FirstOrDefault();
            //    if (curobj != null)
            //    {
            //        Leases newlease = new Leases();
            //        newlease.ID = AppData.db.Leases.Any() ? AppData.db.Leases.Max(u => u.ID) + 1 : 1;
            //        newlease.ClientID = usid;
            //        newlease.StartDate = DateTime.Now.Date;

            //        newlease.CarID = curCAR.ID;
            //        newlease.StatusID = 1;

            //        curCAR.CarStatusID = 2;
            //        AppData.db.Leases.Add(newlease);
            //        AppData.db.SaveChanges();
            //        MessageBox.Show("Успешно");
            //        Refresher();

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            Refresher();
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Refresher()
        {
            var query = from car in AppData.db.LeaseObjects
                        join carstatus in AppData.db.CarStatus on car.CarStatusID equals carstatus.ID
                        select new CarView

                        {
                            Id = car.ID,
                            Name = car.Name,
                            MonthCount = car.MonthCount,
                            CarPrice = car.CarPrice,
                            Avance = (int)car.Avance,
                            MothlyPrice = (int)car.MothlyPrice,
                            AllAmount = (int)car.AllAmount,
                            Images = car.Images,
                            Status = carstatus.StatusName
                        };

            CardContainer.ItemsSource = query.ToList();
        }


        private void ExitToAuthClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }


        private void OpenHistory(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WorkerHistoryPage(usid));
        }

        private void OpenCarCard(object sender, MouseButtonEventArgs e)
        {
            try
            {
                // Получаем источник события
                var border = sender as Border;
                if (border != null)
                {
                    // Получаем DataContext из элемента
                    var cur = border.DataContext as CarView;
                    if (cur != null)
                    {
                        int cared = cur.Id;
                        DarkOverlay.Visibility = Visibility.Visible;
                        Window profileWindow = new CarWindow(cared)
                        {
                            Owner = Window.GetWindow(this), // Установите владельца окна
                            WindowStartupLocation = WindowStartupLocation.CenterOwner
                        };
                        profileWindow.ShowDialog();
                        DarkOverlay.Visibility = Visibility.Collapsed;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
