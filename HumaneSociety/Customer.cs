using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Customer
    {

        public Customer()
        {

        }
            public void GetAdopterInfo() {
            Adopter person = new Adopter();

            Console.WriteLine("Please establish a User Id");
            person.Adopter_ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Please establish a password for you account");
            person.Pass = Console.ReadLine();

            Console.WriteLine("Please enter your Name");
            person.Name = Console.ReadLine();

            Console.WriteLine("Please enter your Address");
            person.Address = Console.ReadLine();

            Console.WriteLine("Please enter the City you live in.");
            person.City = Console.ReadLine();

            Console.WriteLine("Please enter the State you live in");
            person.State = Console.ReadLine();

            Console.WriteLine("Please enter your Zipcode");
            person.ZipCode = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Phone Number");
            person.PhoneNumber = int.Parse(Console.ReadLine());
            //HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
            //Data.Adopters.InsertOnSubmit(person);
            //Data.SubmitChanges();
            //var things = from entries in Data.Adopters where entries.Name == "nathan" select entries;
           // Console.WriteLine(things.ToList()[0].Name + " " + things.ToList()[0].Adopter_ID);
            Console.ReadLine();
        }
   }
}
