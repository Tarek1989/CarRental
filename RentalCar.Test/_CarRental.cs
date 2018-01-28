using RentalCar.DB;
using RentalCar.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Test
{
    public class _CarRental : Repositories<CarRental>
    {

        public _CarRental(RentalCarModel rcm) : base(rcm)
        {

        }

       
    }
}
