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
using System.Windows.Shapes;
using static MaterialDesignThemes.Wpf.Theme;

namespace Leasing.Pages.AdminsPage
{
    /// <summary>
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUserClick(object sender, RoutedEventArgs e)
        {
           
            try
            {
                var curUser = DataGR.SelectedItem as UserView;
                var curUS = AppData.db.Users.Where(u => u.ID == curUser.Id).FirstOrDefault();
                if ( combob.SelectedItem != null || !string.IsNullOrEmpty(TxbLogin.Text) || !string.IsNullOrEmpty(TxbPassword.Password.ToString()) || statusbox.SelectedItem != null) 
                {


                    if (!string.IsNullOrEmpty(TxbLogin.Text))
                    {
                        curUS.Login = TxbLogin.Text;
                    }
                      
                        if (!string.IsNullOrEmpty(TxbPassword.Password.ToString()))
                    {
                        curUS.Password = TxbPassword.Password;
                    }    
                      
                        if(combob.SelectedItem != null & combob.SelectedIndex == 0)
                    {
                        curUS.RoleID = 1;
                    }
                        else if(combob.SelectedItem != null & combob.SelectedIndex == 1)
                    {
                        curUS.RoleID = 2;
                    }
                    if (statusbox.SelectedItem != null & statusbox.SelectedIndex == 0)
                    {
                        curUS.StatusID = 1;
                    }
                    else if (statusbox.SelectedItem != null & statusbox.SelectedIndex == 1)
                    {
                        curUS.StatusID = 2;
                    }


                    AppData.db.SaveChanges();
                        MessageBox.Show("Изменения внесены!");
                          this.Close();
                }
                    else
                    {
                        MessageBox.Show("Заполните хоть одно поле!");
                    }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
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
    }
}
