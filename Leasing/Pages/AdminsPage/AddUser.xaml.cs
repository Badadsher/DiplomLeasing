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
using System.Windows.Shapes;

namespace Leasing.Pages.AdminsPage
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddUserClick(object sender, RoutedEventArgs e)
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
                    this.Close();
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
    }
}
