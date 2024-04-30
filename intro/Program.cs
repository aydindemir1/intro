using Intro.DataAccess.Concretes;
using Intro.Entities;
using Intro.Business;
using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string message1 = "krediler";
            int term = 12;
            double amount = 100000;

            // variables --> camelCase
            bool isAuthenticated = false;
            Console.WriteLine(message1);

            // condition
            if(isAuthenticated)
            {
                Console.WriteLine("Buton --> Hoşgeldin Engin");
            }
            else
            {
                Console.WriteLine("Buton--> Sisteme giriş yap");
            }

            string[] loans = { "kredi 1", "kredi 2", "kredi 3", "kredi 4" , "kredi 5", "kredi 6" };// db den gelecek
           // string[] loans2 = new string[6];
            //loans2[0] = "kredi 1";

                    // start condition increment
            for(int i = 0; i < loans.Length; i++)
            {
                Console.WriteLine(loans[i]);
            }
          
      
            CourseManager courseManager = new CourseManager(new DapperCourseDal());
           
            List<Course> courses2 = courseManager.GetAll();
            for(int i = 0; i < courses2.Count; i++)
            {
                Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
            }

            Console.WriteLine("kod bitti");

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.NationalIdentity = "12345678922";
            customer1.FirstName = "Aslı";
            customer1.LastName = "Karayiğit";
            customer1.CustomerNumber = "12346";

            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 2;
            customer2.NationalIdentity = "56794123";
            customer2.FirstName = "Özgür";
            customer2.LastName = "Atılgan";
            customer2.CustomerNumber = "123456";

            CorporateCustomer customer3 = new CorporateCustomer();
            customer3.Id = 3;
            customer3.Name = "Kodlamaio";
            customer3.CustomerNumber = "654789";
            customer3.TaxNumber = "123456789";

            CorporateCustomer customer4 = new CorporateCustomer();
            customer4.Id = 4;
            customer4.Name = "Abc";
            customer4.CustomerNumber = "654789";
            customer4.TaxNumber = "12345678921231";

            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 50;
            Console.WriteLine(number1);

            string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
            string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

            cities2 = cities1;
            cities1[0] = "Adana";

            Console.WriteLine(cities2[0]);

            //value types --> int, bool, double...
            // reference types --> array, class, interface...
                                          //101        // 102   // 103     // 104              
            BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

            //polymorphism
            foreach (BaseCustomer customer in customers)
            {
            
                Console.WriteLine(customer.CustomerNumber);
            }
            Console.ReadLine();
            

        }
    }
}
