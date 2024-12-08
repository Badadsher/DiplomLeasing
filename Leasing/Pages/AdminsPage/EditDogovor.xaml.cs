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
            DataGR.ItemsSource = AppData.db.Leases.ToList();
        }

        private void EditDogovorClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var startdate = datestart.SelectedDate;
                var enddate = dateend.SelectedDate;
                if (!string.IsNullOrEmpty(TxbClient.Text) || !string.IsNullOrEmpty(TxbClient.Text) || enddate.HasValue || startdate.HasValue || !string.IsNullOrEmpty(TxbCarID.Text))

                {

                    var curLeasing = DataGR.SelectedItem as Leases;
                    if (curLeasing != null)
                    {
                        if (!string.IsNullOrEmpty(TxbClient.Text))
                        {
                            curLeasing.ClientID = Convert.ToInt32(TxbClient.Text);
                        }
                        if (!string.IsNullOrEmpty(TxbCarID.Text))
                        {
                            curLeasing.CarID = Convert.ToInt32(TxbCarID.Text);
                        }

                        if (!string.IsNullOrEmpty(TxbStatus.Text))
                        {
                            curLeasing.Status = TxbStatus.Text;
                        }
                        if (enddate.HasValue)
                        {
                            curLeasing.EndDate = enddate.Value.Date;
                        }
                        if (startdate.HasValue)
                        {
                            curLeasing.StartDate = startdate.Value.Date;
                        }

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

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
