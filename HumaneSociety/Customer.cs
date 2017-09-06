using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Customer
    {
        private string criteria;

        public Customer()
        {

        }
        public void GetAdopterInfo()
        {
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
            HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
            Data.Adopters.InsertOnSubmit(person);
            Data.SubmitChanges();
            //var things = from entries in Data.Adopters where entries.Name == "nathan" select entries;
            //Console.WriteLine(things.ToList()[0].Name + " " + things.ToList()[0].Adopter_ID);
            //Console.ReadLine();
        }
        public void GetCertainCriteria(string species)
        {
            Console.WriteLine("Search by: \n Species \n Name \n  Breed \n Gender \n Personality \n Color \n  Shots \n  Age \n Adoption Price");
            string animal = Console.ReadLine().ToString();
            switch (animal)
            {
                case "Species":
                    animal = getSpecies(criteria);
                    break;
                case "Color":
                    animal = getColor(criteria);
                    break;
                case "Name":
                    animal = getName(criteria);
                    break;
                case "Breed":
                    animal = getBreed(criteria);
                    break;
                case "Gender":
                    animal = getGender(criteria);
                    break;
                case "Personality":
                    animal = getPersonality(criteria);
                    break;
                case "Adoption Price":
                    animal = getAdoption_Price(criteria);
                    break;
                case "Shots":
                    animal = getShots(criteria);
                    break;
                case "Age":
                    animal = getAge(criteria);
                    break;
                default:
                    break;
            }
        }

//        private object getSpecies(object criteria)
//        {
//            throw new NotImplementedException();
//        }
//        private object getColor(object criteria)
//        {
//            throw new NotImplementedException();
//        }
//        private object getName(object criteria)
//        {
//            throw new NotImplementedException();
//        }
//        private object getBreed(object criteria)
//        {
//            throw new NotImplementedException();
//        }
//        private object getGender(object criteria)
//        {
//            throw new NotImplementedException();
//        }
//        private object getSpecies(object criteria)
//        {
//            throw new NotImplementedException();
//        }
//        private object getSpecies(object criteria)
//        {
//            throw new NotImplementedException();
//        }
//        private object getSpecies(object criteria)
//        {
//            throw new NotImplementedException();
//        }
//        private object getSpecies(object criteria)
//        {
//            throw new NotImplementedException();
//        }
//        public void GetTypeOfAnimal()
//        {
//            Console.WriteLine("What type of Animal are you searching for?");
//            string animals = Console.ReadLine().ToLower();
//            switch (animals)
//            {
//                case "Dog":
//                    Console.WriteLine("You choose a dog");
//                    break;
//                case "Cat":
//                    Console.WriteLine("You choose a cat");
//                    break;
//                case "Small Animals":
//                    Console.WriteLine("You choose a small animal");
//                    break;
//                default:
//                    break;
//            }
//        }
//    }
//}
