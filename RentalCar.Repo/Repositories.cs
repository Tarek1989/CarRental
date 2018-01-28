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
        //Data Model class used for db table creation
        RentalCarModel RCM;

        public Repositories(RentalCarModel rcm)
        {
            RCM = rcm;
        }

        //Method to get data from db
        public List<T> GetData()
        {
            List<T> data = new List<T>();
            foreach (var i in RCM.Set<T>())
            {
                data.Add(i);
            }
            return data;
        }

        //Method to add data to db
        public void AddData(T item)
        {
            RCM.Set<T>().Add(item);
            RCM.SaveChanges();

        }

        //Method to delete data from db
        public void DeleteData(T item)
        {
            RCM.Set<T>().Remove(item);
            RCM.SaveChanges();
        }

        //Method to update data from db (not used in this app but could be used if needed)
        public void UpdateData(T item)
        {
            RCM.Set<T>().AddOrUpdate(item);
            RCM.SaveChanges();
        }


    }
}
