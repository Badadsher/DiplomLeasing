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
            DataGR.ItemsSource = AppData.db.LeaseObjects.ToList();
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
                   
                    var curLeas = DataGR.SelectedItem as LeaseObjects;
                    if (curLeas != null){
                        if (!string.IsNullOrEmpty(TxbName.Text))
                        {
                            curLeas.Name = TxbName.Text;
                        }
                        if (_imageDatуa != null)
                        {
                            curLeas.Images = _imageDatуa;
                        } 
                        if (!string.IsNullOrEmpty(TxbCount.Text))
                        {
                            curLeas.MonthCount = Convert.ToInt32(TxbCount.Text);
                        }
                        if (!string.IsNullOrEmpty(TxbPrice.Text))
                        {
                            curLeas.CarPrice = Convert.ToInt32(TxbPrice.Text);
                        }
                        if (combob.SelectedItem != null & combob.SelectedIndex == 0)
                        {
                            curLeas.CarStatusID = 1;
                        }
                        else if (combob.SelectedItem != null & combob.SelectedIndex == 1)
                        {
                            curLeas.CarStatusID = 2;
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
