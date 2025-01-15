using Leasing.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        private byte[] _imageDatуa;
        public RegPage()
        {
            InitializeComponent();
        }

        private void Regclick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxbLogin.Text) && !string.IsNullOrEmpty(TxbPassword.Password.ToString())
                   && !string.IsNullOrEmpty(TxbName.Text) && !string.IsNullOrEmpty(TxbSurname.Text) 
                  )
                {
                    Users people = new Users();
                    UsersData pepopledata = new UsersData();

                    people.ID = AppData.db.Users.Any() ? AppData.db.Users.Max(u => u.ID) + 1 : 1;
                    people.Login = TxbLogin.Text;
                    people.Password = TxbPassword.Password;
                    people.RoleID = 2;
                    people.StatusID = 1;
                    pepopledata.ID = AppData.db.UsersData.Any() ? AppData.db.UsersData.Max(u => u.ID) + 1 : 1;
                    pepopledata.Name = TxbName.Text;
                    pepopledata.Surname = TxbSurname.Text;
                    pepopledata.Photo = _imageDatуa;
                    if (!string.IsNullOrEmpty(TxbPatronymic.Text))
                    {
                        pepopledata.Patronymic = TxbPatronymic.Text;
                    }
                AppData.db.UsersData.Add(pepopledata);
                AppData.db.Users.Add(people);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Пользователь успешно был добавлен в базу");
                }
                else
                {
                    MessageBox.Show("Ошибка, некоторые поля пустые", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
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

        private void AddImg(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                _imageDatуa = File.ReadAllBytes(openFileDialog.FileName);
                MessageBox.Show("Изображение выбрано.");
            }
        }

     
    }
}
