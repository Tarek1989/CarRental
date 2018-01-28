using RentalCar.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace RentalCar.Repo
{
    public abstract class Repositories<T> where T:class
    {
        RentalCarModel RCM;

        public Repositories(RentalCarModel rcm)
        {
            RCM = rcm;
        }

        //Method to get data
        public List<T> GetData()
        {
            List<T> data = new List<T>();
            foreach (var i in RCM.Set<T>())
            {
                data.Add(i);
            }
            return data;
        }


        public void AddData(T item)
        {
            RCM.Set<T>().Add(item);
            RCM.SaveChanges();

        }


        public void DeleteData(T item)
        {
            RCM.Set<T>().Remove(item);
            RCM.SaveChanges();
        }

        public void UpdateData(T item)
        {
            RCM.Set<T>().AddOrUpdate(item);
            RCM.SaveChanges();
        }


    }
}
