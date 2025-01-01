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
using System.Xml.Linq;

namespace Leasing.Pages.AdminsPage
{
    /// <summary>
    /// Логика взаимодействия для AddDogovor.xaml
    /// </summary>
    public partial class AddDogovor : Window
    {
        public AddDogovor()
        {
            InitializeComponent();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddDogovorClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var startdate = datestart.SelectedDate;
                var enddate = dateend.SelectedDate;
                if (combob.SelectedItem != null && !string.IsNullOrEmpty(TxbClient.Text) && startdate.HasValue && enddate.HasValue)

                {
                    if(Convert.ToInt32(TxbClient.Text) > AppData.db.Users.Max(u => u.ID))
                    {
                        MessageBox.Show("Юзера с таким айди нет!");
                    }
                    else
                    {
                        if (Convert.ToInt32(CarId.Text) > AppData.db.LeaseObjects.Max(u => u.ID))
                        {
                            MessageBox.Show("Машины с таким айди нет!");
                        }
                        else
                        {
                            Leases leasing = new Leases();

                            leasing.ID = AppData.db.LeaseObjects.Any() ? AppData.db.LeaseObjects.Max(u => u.ID) + 1 : 1;

                            if (combob.SelectedItem != null & combob.SelectedIndex == 0)
                            {
                                leasing.StatusID = 1;
                            }
                            else if (combob.SelectedItem != null & combob.SelectedIndex == 1)
                            {
                                leasing.StatusID = 2;
                            }
                      
                            leasing.ClientID = Convert.ToInt32(TxbClient.Text);
                            leasing.StartDate = startdate.Value.Date;
                            leasing.EndDate = enddate.Value.Date;
                            leasing.CarID = Convert.ToInt32(CarId.Text);
                            AppData.db.Leases.Add(leasing);
                            AppData.db.SaveChanges();
                            MessageBox.Show("Договор лизинга успешно был добавлен в базу");
                            this.Close();
                        }
                    }  
                }
                else
                {
                    MessageBox.Show("Ошибка, некоторые поля пустые", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
