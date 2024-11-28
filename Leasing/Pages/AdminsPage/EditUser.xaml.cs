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
            var curUser = DataGR.SelectedItem as Users;
            try
            {
                if (!string.IsNullOrEmpty(TxbName.Text) || !string.IsNullOrEmpty(TxbSurname.Text) || combob.SelectedItem != null
                    || !string.IsNullOrEmpty(TxbPatronymic.Text) || !string.IsNullOrEmpty(TxbLogin.Text) || !string.IsNullOrEmpty(TxbPassword.Password.ToString()))
                {


                    if (!string.IsNullOrEmpty(TxbLogin.Text))
                    {
                        curUser.Login = TxbLogin.Text;
                    }
                      
                        if (!string.IsNullOrEmpty(TxbPassword.Password.ToString()))
                    {
                        curUser.Password = TxbPassword.Password;
                    }
                      
                        if (!string.IsNullOrEmpty(TxbName.Text))
                    {
                        curUser.Name = TxbName.Text;
                    }
                       
                        if (!string.IsNullOrEmpty(TxbSurname.Text))
                    {
                        curUser.Surname = TxbSurname.Text;
                    }
                       
                        if (!string.IsNullOrEmpty(TxbPatronymic.Text))
                    {
                        curUser.Patronymic = TxbPatronymic.Text;
                    }
                      
                        if(combob.SelectedItem != null & combob.SelectedIndex == 0)
                    {
                        curUser.RoleID = 1;
                    }
                        else if(combob.SelectedItem != null & combob.SelectedIndex == 1)
                    {
                        curUser.RoleID = 2;
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
            DataGR.ItemsSource = AppData.db.Users.ToList();
        }
    }
}
