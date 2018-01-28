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
    /// Interaction logic for DeleteUser.xaml
    /// </summary>
    public partial class DeleteUser : Window
    {
        Status s = new Status();
        
        List<Users> userdata;

        public DeleteUser()
        {
            InitializeComponent();
            UserDeletion();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            
            s.Show();
            this.Close();
        }

        public void UserDeletion()
        {
            RentalCarModel RCM = new RentalCarModel();
            _Users u = new _Users(RCM);

            userdata = u.GetData();

            UserList.ItemsSource = userdata;

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            RentalCarModel RCM = new RentalCarModel();
            _Users u = new _Users(RCM);

            userdata = u.GetData();
            foreach(Users i in userdata)
            {
                if(i.ID == Convert.ToInt16(UserList.Text))
                {
                    u.DeleteData(i);
                    MessageBox.Show("User succesfully deleted");
                    Status s = new Status();
                    s.Show();
                    this.Close();
                }
            }
        }
    }
}
