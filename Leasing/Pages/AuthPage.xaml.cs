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
using Leasing.Pages.AdminsPage;
using Leasing.Pages.WorkersPage;
using Leasing.Model;
namespace Leasing.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }


        private void AuthClick(object sender, RoutedEventArgs e)
        {
            if( !string.IsNullOrEmpty(TxbLogin.Text) && !string.IsNullOrEmpty(TxbPassword.ToString()))
            {
                try
                {
                    var CurrentUser = AppData.db.Users.FirstOrDefault(u => u.Login == TxbLogin.Text && u.Password == TxbPassword.Password);

                    if (CurrentUser != null && CurrentUser.RoleID == 1)
                    {
                        NavigationService.Navigate(new AdminUsers());
                    }
                    else if (CurrentUser != null && CurrentUser.RoleID == 2)
                    {
                        NavigationService.Navigate(new WorkerPage(CurrentUser.ID));
                    }
                    else if (CurrentUser != null && CurrentUser.RoleID == 3)
                    {
                        NavigationService.Navigate(new AdminPage());
                    }
                    else
                    {
                        MessageBox.Show("Данного пользователя нет в базе. Попробуйте снова.");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
          
        }


        private void RegClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
