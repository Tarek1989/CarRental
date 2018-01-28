using RentalCar.DB;
using RentalCar.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Test
{
    public class _Users : Repositories<Users>
    {

        public _Users (RentalCarModel rcm) : base(rcm)
        {

        }

    }
}
