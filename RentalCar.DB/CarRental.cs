using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.DB
{
    // car Class that that will hold information about car model and cost per day
    public class CarRental
    {
        public int ID { get; set; }
        public string Car { get; set; }
        public int Cost { get; set; }
    }
}
