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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPageLeasesAdd : Page
    {
        public AdminPageLeasesAdd()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresher();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void ExitToAuthClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }  
        private void UsersClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminUsers());
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            Refresher();
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


        private void AddCar(object sender, RoutedEventArgs e)
        {
            DarkOverlay.Visibility = Visibility.Visible;
            Window addleaser = new AddLeas
            {
                Owner = Window.GetWindow(this), // Установите владельца окна
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            addleaser.ShowDialog();
            DarkOverlay.Visibility = Visibility.Collapsed;
        }

        private void EditLease(object sender, RoutedEventArgs e)
        {
            DarkOverlay.Visibility = Visibility.Visible;
            Window editcar = new EditLease
            {
                Owner = Window.GetWindow(this), // Установите владельца окна
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            editcar.ShowDialog();
            DarkOverlay.Visibility = Visibility.Collapsed;
        }

        private void DogovorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminHistory());
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
