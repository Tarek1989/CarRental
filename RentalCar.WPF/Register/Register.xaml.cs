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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            CarData();
        }



        public void CarData()
        {
            RentalCarModel RCM = new RentalCarModel();
            _CarRental cr = new _CarRental(RCM);

            List<CarRental> carlist = cr.GetData();

            ListCar.ItemsSource = carlist;

        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
            RentalCarModel RCM = new RentalCarModel();
            _Users u = new _Users(RCM);


            try
            {
                if (Days.Text == "" || Convert.ToInt16(Days.Text) == 0)
                {
                    MessageBox.Show("Days required needs value");
                }
                else if (Convert.ToInt16(Days.Text) >= 1)
                {
                    Users users = new Users();
                    users.Name = Name.Text;
                    users.Surname = Surname.Text;
                    users.Age = Convert.ToInt16(Age.Text);
                    users.Car = ListCar.Text;


                    users.Cost = Convert.ToInt16(Days.Text) * Convert.ToInt16(Cost.Text);

                    if (users.Age < 18)
                    {
                        MessageBox.Show("Please be 18+");
                    }
                    else
                    {
                        u.AddData(users);

                        MessageBox.Show("Thank you for registering with CarRental");

                        MainWindow mw = new MainWindow();
                        mw.Show();
                        this.Close();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Please try again");
            }





        }
    }
}

          
            

          

           

        

