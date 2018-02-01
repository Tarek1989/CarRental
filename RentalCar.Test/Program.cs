using RentalCar.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar.Test
{
    /*Namespace RentalCar.Test used for testing the different methods
     * Classes in namespace created in scenario where extra feautures needed to be added
     * but predominantly if app was console UI*/

    class Program
    {

        static void Main(string[] args)
        {
             
            /*First phase:
             * Give user or admin direction to appropriate UI*/
                Console.WriteLine("   xxxxxx");
                Console.WriteLine(" x");
                Console.WriteLine("x");
                Console.WriteLine("x");
                Console.WriteLine("  x");
                Console.WriteLine("   xxxxxx" + "\n");

            RentalCarModel rcm = new RentalCarModel();
            _CarRental c = new _CarRental(rcm);
            _Users u = new _Users(rcm);
            _Admin a = new _Admin(rcm);

            Console.WriteLine("Welcome to Car rental. Please indicate if you are a user or admin" + "\n");

            bool h = true;
            while(h)
            {

                string userinput = Console.ReadLine().ToLower();

                switch (userinput)
                {
                    case "user":
                        Console.WriteLine( "\n"+"User Registration Form" );
                        Console.WriteLine("\n" + "Please Add Name");
                        string name = Console.ReadLine();

                        Console.WriteLine("\n" + "Please Add Surname" );
                        string surname = Console.ReadLine();

                        Console.WriteLine("\n" + "Please Add Age" );
                        int age = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("\n" + "Please type a car with cost/day ");
                        foreach(CarRental item in c.GetData())
                        {
                            Console.Write(item.Car + "\t" + item.Cost + "\n");
                            
                        }

                        /*Dictionary seems to do the trick with the issue encounter with foreach loop.
                         * Foreach loop usually enumerates through each item followed by the condition. Therefore
                         * if the condition asked for a fifth element , the loop should have iterated 5 times before reaching desire value*/

                        Dictionary<string,int> cardic = c.GetData().ToDictionary(car => car.Car, cost=>cost.Cost);

                        foreach(KeyValuePair<string,int> test in cardic)
                        {
                            Console.WriteLine("\n"+"Please type the car of choice: ");
                            string usercar = Console.ReadLine();
                            int days, sum;
                            if(cardic.ContainsKey(usercar))
                            {
                                Console.WriteLine("\n"+"How many days?");
                                days = Convert.ToInt32(Console.ReadLine());
                                sum = days * test.Value; //value is the cost

                                Users customers = new Users();
                                customers.Name = name;
                                customers.Surname = surname;
                                customers.Age = age;
                                customers.Car = usercar;
                                customers.Cost = sum;

                                u.AddData(customers);

                                Console.WriteLine("Thank you for registering");
                                break;
                                
                            }
                        }

                        

                        h = false;
                        break; // if break statement is not place then you get following error Severity	Code	Control cannot fall out of switch from final case label('case "user":') 
                        
                    case "admin":
                        /* Second(a) phase :
                    * Giving access to Admin 
                    *
                        /* While loop that returns back to method if login unsuccesful
                         * This simply dictates that if the loop is true do it again and again.
                         * Since it's true it will loop indefinetely until a false value is isnerted*/
                        
                       bool x = true;
                       while(x)
                       {
                           Console.WriteLine("\n"+"Please enter username");
                           string username = Console.ReadLine();
                           Console.WriteLine("\n"+"Please enter password");
                           string password = Console.ReadLine();

                           foreach(Admin i in a.GetData())
                           {
                               if (i.Name == username && i.Surname == password)
                               {
                                    Console.WriteLine("\n" + "Your data is loading...." + "\n");
                                   for (int users=0; users < u.GetData().Count; users++ )
                                   {
                                       Console.Write(u.GetData()[users].Name +"\t"+ u.GetData()[users].Surname + "\t"+ u.GetData()[users].Age +"\t"+ u.GetData()[users].Car + "\t"+ u.GetData()[users].Cost +"\n"); //users access property (?) 
                                   }

                                   x = false;
                               }
                               else
                               {
                                   Console.WriteLine("try again");
                               }
                           }
                       }

                       
                        h = false;
                        break;

                    default:
                        Console.WriteLine("Please select one of the two");  
                        break;
                }
            }
           
                    Console.ReadLine();
        }
    }
}
