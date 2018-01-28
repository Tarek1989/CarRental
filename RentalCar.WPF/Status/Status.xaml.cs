using RentalCar.DB;
using RentalCar.Test;
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

namespace RentalCar.WPF
{
    /// <summary>
    /// Interaction logic for Status.xaml
    /// </summary>
    public partial class Status : Window
    {
        public Status()
        {
            InitializeComponent();
            UserData();
        }

        public void UserData()
        {

            RentalCarModel RCM = new RentalCarModel();
            _Users u = new _Users(RCM);

            List<Users> userlist = u.GetData();

            UserList.ItemsSource = userlist;
            
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            DeleteUser delete = new DeleteUser();
            delete.Show();
            this.Close();
        }
    }
}
