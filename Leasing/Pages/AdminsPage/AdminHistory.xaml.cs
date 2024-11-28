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
            DataGR.ItemsSource = AppData.db.Leases.ToList();
            MessageBox.Show("Обновлено");
        }

        private void EditDogovor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditDogovor());
        }

        private void AddDogovor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddDogovor());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGR.ItemsSource = AppData.db.Leases.ToList();
        }
    }
}
