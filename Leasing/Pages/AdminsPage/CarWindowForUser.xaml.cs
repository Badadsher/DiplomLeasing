﻿using Leasing.Model;
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
    /// Логика взаимодействия для CarWindowForUser.xaml
    /// </summary>
    public partial class CarWindowForUser : Window
    {
        private int usid;
        private int carid;
        public CarWindowForUser(int carid, int usid)
        {
            InitializeComponent();
            this.usid = usid;
            this.carid = carid;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
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

            var curQuery = query.FirstOrDefault(u => u.Id == usid);
            var curCar = AppData.db.LeaseObjects.FirstOrDefault(u => u.ID == usid);
            var imageBytes = curCar.Images;
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(imageBytes);
            bitmapImage.EndInit();
            myImage.Source = bitmapImage;


            nameLabel.Content = "ИМЯ: " + curCar.Name;
            statusLabel.Content = "СТАТУС: " + curQuery.Status;
            priceLabel.Content = "ЦЕНА: " + curCar.CarPrice + "₽";
            tarifLabel.Content = "ТАРИФ: " + curCar.MothlyPrice + "₽/В МЕС";
            countLabel.Content = "СРОК: " + curCar.MonthCount + "(В МЕСЯЦАХ)";
            avanceLabel.Content = "АВАНС: " + curCar.Avance + "₽";

        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TakeLease(object sender, RoutedEventArgs e)
        {
            try
            {
                var curobj = carid;
               var curCAR = AppData.db.LeaseObjects.Where(u => u.ID == usid).FirstOrDefault();
               if (curobj != null)
               {
                 Leases newlease = new Leases();
                 newlease.ID = AppData.db.Leases.Any() ? AppData.db.Leases.Max(u => u.ID) + 1 : 1;
                 newlease.ClientID = usid;
                 newlease.StartDate = DateTime.Now.Date;

                  newlease.CarID = curCAR.ID;
                  newlease.StatusID = 1;

                   curCAR.CarStatusID = 2;
                AppData.db.Leases.Add(newlease);
                  AppData.db.SaveChanges();
                   MessageBox.Show("Успешно");

               }
            }
            catch (Exception ex)
           {
                MessageBox.Show(ex.Message);
           }
        }
    }
}
