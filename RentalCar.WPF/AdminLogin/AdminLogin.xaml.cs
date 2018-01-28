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
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        public AdminLogin()
        {
            InitializeComponent();
        }


        private string username;
        private string password;

        //Admin Login Method
        private void Login(object sender, RoutedEventArgs e)
        {
            username = Username.Text;
            password = Password.Password;

            RentalCarModel RCM = new RentalCarModel();
            _Admin a = new _Admin(RCM);

            /*Admin data called and loop through.
             * Because we only have one admin this method should work. If more admins existed this method wouldn't be ideal*/
            List<Admin> adminlist = a.GetData();

            foreach(Admin i in adminlist)
            {
                if(username == i.Name && password == i.Surname)
                {
                    MessageBox.Show("Login Succesful");
                    Status s = new Status();
                    s.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Try Again");
                }
               
            }
       

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
