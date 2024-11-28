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

namespace Leasing.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void Regclick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxbLogin.Text) && !string.IsNullOrEmpty(TxbPassword.Password.ToString())
                   && !string.IsNullOrEmpty(TxbName.Text) && !string.IsNullOrEmpty(TxbSurname.Text) 
                  )
                {
                    Users people = new Users();

                    people.ID = AppData.db.Users.Any() ? AppData.db.Users.Max(u => u.ID) + 1 : 1;
                    people.Login = TxbLogin.Text;
                    people.Password = TxbPassword.Password;
                    people.RoleID = 2;
                    people.Name = TxbName.Text;
                    people.Surname = TxbSurname.Text;
                    if (!string.IsNullOrEmpty(TxbPatronymic.Text))
                    {
                        people.Patronymic = TxbPatronymic.Text;
                    }
                    AppData.db.Users.Add(people);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Пользователь успешно был добавлен в базу");
                }
                else
                {
                    MessageBox.Show("Ошибка, некоторые поля пустые", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AuthClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage()); 
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
