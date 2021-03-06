﻿using System;
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
                    animal = getSpecies();
                    break;
                case "Color":
                    animal = getColor();
                    break;
                case "Name":
                    animal = getName();
                    break;
                case "Breed":
                    animal = getBreed();
                    break;
                case "Gender":
                    animal = getGender();
                    break;
                case "Personality":
                    animal = getPersonality();
                    break;
                case "Adoption Price":
                    animal = getAdoption_Price();
                    break;
                case "Shots":
                    animal = getShots();
                    break;
                case "Age":
                    animal = getAge();
                    break;
                default:
                    break;
            }
        }

        private string getAge()
        {
            throw new NotImplementedException();
        }

        private string getShots()
        {
            throw new NotImplementedException();
        }

        private string getAdoption_Price()
        {
            throw new NotImplementedException();
        }

        private string getPersonality()
        {
            throw new NotImplementedException();
        }

        private string getGender()
        {
            throw new NotImplementedException();
        }

        private string getBreed()
        {
            throw new NotImplementedException();
        }

        private string getName()
        {
            throw new NotImplementedException();
        }

        private string getColor()
        {
            throw new NotImplementedException();
        }

        private string getSpecies()
        {
            throw new NotImplementedException();
        }
    }
}
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
