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

namespace Leasing.Pages.AdminsPage
{
    /// <summary>
    /// Логика взаимодействия для AdminUsers.xaml
    /// </summary>
    public partial class AdminUsers : Page
    {
        public AdminUsers()
        {
            InitializeComponent();
        }

        private void LeasesClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void ExitToAuthClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresher();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DataGR.SelectedItem != null)
                {
                    var cur = DataGR.SelectedItem as UserView;
                    var curUS = AppData.db.Users.Where(u => u.ID == cur.Id).FirstOrDefault();
                    curUS.StatusID = 2;
                    AppData.db.SaveChanges();
                    MessageBox.Show("Уволен!");
                    Refresher();
                }
                else
                {
                    MessageBox.Show("Выберите объект для удаления");
                }
            }
            catch(Exception er) {
                MessageBox.Show(er.Message);
            }
           
        }

        private void EditUser(object sender, RoutedEventArgs e)
        {
            Window edithorUserWindow = new EditUser();
            edithorUserWindow.Show();
        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            Refresher();
        }

        private void Refresher()
        {
            var query = from user in AppData.db.Users
                        join userData in AppData.db.UsersData on user.ID equals userData.ID
                        join status in AppData.db.StatusTable on user.StatusID equals status.ID
                        join role in AppData.db.Roles on user.RoleID equals role.ID
                        select new UserView
                        {
                            Id = user.ID,
                            Name = userData.Name,
                            Surname = userData.Surname,
                            Patronymic = userData.Patronymic,
                            Number = userData.Number,
                            Photo = userData.Photo,
                            Login = user.Login,
                            Password = user.Password,
                            Status = status.StatusName,
                            Role = role.RoleName
                        };

            DataGR.ItemsSource = query.ToList();
          
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            Window adderUserWindow = new AddUser();
            adderUserWindow.Show();
        }

        private void DogovorClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminHistory());
        }

        private void OpenProfile(object sender, MouseButtonEventArgs e)
        {
            var cur = DataGR.SelectedItem as UserView;
            int profileid = cur.Id;
            Window profileWindow = new ProfileWindow(profileid);
            profileWindow.Show();
        }
    }
}
