using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.DB
{
    //User class that will hold information about who rents what and at what cost

    public class Users
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Car { get; set; }
        public int Cost { get; set; }

    }
}
