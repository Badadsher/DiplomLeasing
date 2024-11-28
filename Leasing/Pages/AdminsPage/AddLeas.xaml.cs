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
using System.Windows.Shapes;

namespace Leasing.Pages.AdminsPage
{
    /// <summary>
    /// Логика взаимодействия для AddLeas.xaml
    /// </summary>
    public partial class AddLeas : Window
    {
        private byte[] _imageDatуa;
        public AddLeas()
        {
            InitializeComponent();
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

        private void AddLease(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxbName.Text) && !string.IsNullOrEmpty(TxbCount.Text) && !string.IsNullOrEmpty(TxbPrice.Text)
                    && !string.IsNullOrEmpty(TxbAvance.Text) && !string.IsNullOrEmpty(TxbMouthly.Text) && !string.IsNullOrEmpty(TxbAllPrice.Text) && _imageDatуa != null)
                 
                {
                    LeaseObjects lease = new LeaseObjects();

                    lease.ID = AppData.db.LeaseObjects.Any() ? AppData.db.LeaseObjects.Max(u => u.ID) + 1 : 1;
                    lease.Images = _imageDatуa;
                    lease.Name = TxbName.Text;
                    lease.MonthCount = Convert.ToInt32(TxbCount.Text);
                    lease.CarPrice = Convert.ToInt32(TxbPrice.Text);
                    lease.Avance = Convert.ToInt32(TxbAvance.Text);
                    lease.MothlyPrice = Convert.ToInt32(TxbMouthly.Text);
                    lease.AllAmount = Convert.ToInt32(TxbAllPrice.Text);
                    if (!string.IsNullOrEmpty(TxbDogovor.Text))
                    {
                        lease.LeaseID = Convert.ToInt32(TxbDogovor.Text);
                    }
                    AppData.db.LeaseObjects.Add(lease);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Машина для лизинга была добавлена в базу");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка, некоторые поля пустые", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch(Exception er)
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
