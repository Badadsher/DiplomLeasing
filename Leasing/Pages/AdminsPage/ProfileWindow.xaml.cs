using Leasing.Model;
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
using static System.Net.Mime.MediaTypeNames;

namespace Leasing.Pages.AdminsPage
{

    public partial class ProfileWindow : Window
    {
        private int usid;
        public ProfileWindow( int id)
        {
            InitializeComponent();
            this.usid = id;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var curUs = AppData.db.UsersData.FirstOrDefault(u => u.ID == usid);
            var imageBytes = curUs.Photo;
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = new MemoryStream(imageBytes);
            bitmapImage.EndInit();
            myImage.Source = bitmapImage;

         
            nameLabelBox.Content =  curUs.Name;
            surnameLabelBox.Content = curUs.Surname;
            patronymicLabelBox.Content = curUs.Patronymic;
            numberLabelBox.Content = curUs.Number;
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
