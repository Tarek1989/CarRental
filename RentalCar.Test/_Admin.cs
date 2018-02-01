using RentalCar.DB;
using RentalCar.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Test
{
    public class _Admin : Repositories<Admin>
    {


        public _Admin(RentalCarModel rcm) : base(rcm)
        {

        }

    }
}
