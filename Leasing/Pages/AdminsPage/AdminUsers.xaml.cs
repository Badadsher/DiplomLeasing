using Leasing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            DataGR.ItemsSource = AppData.db.Users.ToList();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DataGR.SelectedItem != null)
                {
                    var cur = DataGR.SelectedItem as Users;
                    AppData.db.Users.Remove(cur);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Удалено!");
                    DataGR.ItemsSource = AppData.db.Users.ToList();
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
            DataGR.ItemsSource = AppData.db.Users.ToList();
            MessageBox.Show("Обновлено");
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
    }
}
