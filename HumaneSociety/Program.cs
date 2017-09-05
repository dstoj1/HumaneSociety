using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
            Employee newEmployee = new Employee();

            Console.WriteLine("Please enter you Employee Id");
            newEmployee.Employee_ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Password");
            newEmployee.Pass = Console.ReadLine();

            Console.WriteLine("Please enter your First Name");
            newEmployee.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your Last Name");
            newEmployee.LastName = Console.ReadLine();

            Animal newAnimal = new Animal();

            Console.WriteLine("Enter the ID of the Animal you are interested in");
            newAnimal.Animal_ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Name of the Animal you are looking for");
            newAnimal.Name = Console.ReadLine();

            Console.WriteLine("");



            Adopter person = new Adopter();

            Console.WriteLine("Please establish and User Id");
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

            Data.Adopters.InsertOnSubmit(person);
            Data.SubmitChanges();
            var things = from entries in Data.Adopters where entries.Name == "nathan" select entries;
            Console.WriteLine(things.ToList()[0].Name + " " + things.ToList()[0].Adopter_ID);
            Console.ReadLine();

            Animal dog = new Animal();
            //dog.Name = "Sammy";
            //dog.Name = "Harley";
            //dog.Name = "Penny";
            //dog.Name = "Princess";
            //dog.Name = "Bruce";
            //dog.Name = "Molly";
            Data.Animals.InsertOnSubmit(dog);
            Data.SubmitChanges();
            var doggy = from entries in Data.Animals where entries.Name == "Sammy" select entries;
            Console.WriteLine(things.ToList()[0].Name + " " + things.ToList()[0].Animal_ID);
           public void GetStatusOnShot(dog)
        {
            if (Shot = No)
            {
                Console.WriteLine("Shots need to be updated,  would you like to update");
                Console.ReadLine();
                //need to update shots if they say yes
            }
            else
                return;
                
        }
        public void GetTypeOfAnimal()
        { 
            Console.WriteLine("What type of Animal are you searching for?");
            Animals = Console.ReadLine().ToLower();
            switch (Animals)
            {      
                case "Dog":
                    Console.WriteLine("You choose a dog");
                    break;
                case "Cat":
                    Console.WriteLine("You choose a cat");
                    break;
                case "Small Animals":
                    Console.WriteLine("You choose a small animal");
                    break;
                default:
                    break;
                                  
            }


        }
    }
}
