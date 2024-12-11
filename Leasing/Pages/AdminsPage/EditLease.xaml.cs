using Leasing.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для EditLease.xaml
    /// </summary>
    public partial class EditLease : Window
    {
        private byte[] _imageDatуa;
        public EditLease()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
            Refresher();
        }
        private void Refresher()
        {
            var query = from car in AppData.db.LeaseObjects
                        join carstatus in AppData.db.CarStatus on car.CarStatusID equals carstatus.ID
                        select new CarView

                        {
                            Id = car.ID,
                            Name = car.Name,
                            MonthCount = car.MonthCount,
                            CarPrice = car.CarPrice,
                            Avance = (int)car.Avance,
                            MothlyPrice = (int)car.MothlyPrice,
                            AllAmount = (int)car.AllAmount,
                            Images = car.Images,
                            Status = carstatus.StatusName
                        };

            DataGR.ItemsSource = query.ToList();
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditLeaseClick(object sender, RoutedEventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrEmpty(TxbName.Text) || !string.IsNullOrEmpty(TxbCount.Text) || !string.IsNullOrEmpty(TxbPrice.Text)
                    || !string.IsNullOrEmpty(TxbAvance.Text) || _imageDatуa != null || combob.SelectedItem != null)

                {
                   
                    var curCarView = DataGR.SelectedItem as CarView;
                    var curcar = AppData.db.LeaseObjects.Where(u => u.ID == curCarView.Id).FirstOrDefault();
                    if (curcar != null){
                        if (!string.IsNullOrEmpty(TxbName.Text))
                        {
                            curcar.Name = TxbName.Text;
                        }
                        if (_imageDatуa != null)
                        {
                            curcar.Images = _imageDatуa;
                        } 
                        if (!string.IsNullOrEmpty(TxbCount.Text))
                        {
                            curcar.MonthCount = Convert.ToInt32(TxbCount.Text);
                        }
                        if (!string.IsNullOrEmpty(TxbPrice.Text))
                        {
                            curcar.CarPrice = Convert.ToInt32(TxbPrice.Text);
                        }
                        if (combob.SelectedItem != null & combob.SelectedIndex == 0)
                        {
                            curcar.CarStatusID = 1;
                        }
                        else if (combob.SelectedItem != null & combob.SelectedIndex == 1)
                        {
                            curcar.CarStatusID = 2;
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
