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
    public partial class AdminPage : Page
    {
        public AdminPage()
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

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DataGR.SelectedItem != null)
                {
                    var cur = DataGR.SelectedItem as CarView;
                    var curcar = AppData.db.LeaseObjects.Where(u => u.ID == cur.Id).FirstOrDefault();
                    curcar.CarStatusID = 2;
                    AppData.db.SaveChanges();
                    Refresher();
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

            DataGR.ItemsSource = query.ToList();
        }


        private void AddCar(object sender, RoutedEventArgs e)
        {
            Window addleaser = new AddLeas();
            addleaser.Show();
        }

        private void EditLease(object sender, RoutedEventArgs e)
        {
            Window editcar = new EditLease();
            editcar.Show();
        }

        private void DogovorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminHistory());
        }
    }
}
