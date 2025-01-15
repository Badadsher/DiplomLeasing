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
    /// Логика взаимодействия для EditDogovor.xaml
    /// </summary>
    public partial class EditDogovor : Window
    {
        public EditDogovor()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Refresher();
        }

        private void EditDogovorClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var startdate = datestart.SelectedDate;
                var enddate = dateend.SelectedDate;
                if (!string.IsNullOrEmpty(TxbClient.Text) || !string.IsNullOrEmpty(TxbClient.Text) || enddate.HasValue || startdate.HasValue || !string.IsNullOrEmpty(TxbCarID.Text) || combob.SelectedItem != null)

                {

                    var curLeasingInNew = DataGR.SelectedItem as LeaseViewModel;
                    var curLeaseDog = AppData.db.Leases.Where(u => u.ID == curLeasingInNew.LeaseID).FirstOrDefault();
                    if (curLeaseDog != null)
                    {
                        if (!string.IsNullOrEmpty(TxbClient.Text))
                        {
                            curLeaseDog.ClientID = Convert.ToInt32(TxbClient.Text);
                        }
                        if (!string.IsNullOrEmpty(TxbCarID.Text))
                        {
                            curLeaseDog.CarID = Convert.ToInt32(TxbCarID.Text);
                        }

                        if (combob.SelectedItem != null & combob.SelectedIndex == 0)
                        {
                            curLeaseDog.StatusID = 1;
                        }
                        else if (combob.SelectedItem != null & combob.SelectedIndex == 1)
                        {
                            curLeaseDog.StatusID = 2;
                        }
                        if (enddate.HasValue)
                        {
                            curLeaseDog.EndDate = enddate.Value.Date;
                        }
                        if (startdate.HasValue)
                        {
                            curLeaseDog.StartDate = startdate.Value.Date;
                        }
                        Refresher();
                        AppData.db.SaveChanges();
                        MessageBox.Show("Изменения внесены!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Выберите запись для редактирования!");
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

        private void Refresher()
        {
            var query = from lease in AppData.db.Leases
                        join leaseObject in AppData.db.LeaseObjects

                        on lease.CarID equals leaseObject.ID
                        join leasestus in AppData.db.LeaseStatus
                        on lease.StatusID equals leasestus.ID
                        select new LeaseViewModel
                        {
                            LeaseID = lease.ID,
                            CarId = (int)lease.CarID,
                            Name = leaseObject.Name,
                            Images = leaseObject.Images,
                            MothlyPrice = (int)leaseObject.MothlyPrice,
                            StartDate = lease.StartDate,
                            EndDate = lease.EndDate,
                            Status = leasestus.StatusLeaseName,
                            CarID = (int)lease.CarID,
                            ClientID = lease.ClientID
                        };
            DataGR.ItemsSource = query.ToList();
      
        }
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
