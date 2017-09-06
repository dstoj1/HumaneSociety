using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class EmployeeUser
    {
        Employee employee = new Employee();
        private static string yes;

        public void GetAnimalInfo()
        {
            Animal species = new Animal();

            Console.WriteLine("What is the Animal's Name?");
            species.Name = Console.ReadLine();

            Console.WriteLine("What is the Animal's Breed?");
            species.Breed = Console.ReadLine();

            Console.WriteLine("What is the Animal's Gender?");
            species.Gender = Console.ReadLine();

            Console.WriteLine("What is the Animal's Personality?");
            species.Personality = Console.ReadLine();

            Console.WriteLine("What color is the Animal?");
            species.Color = Console.ReadLine();

            Console.WriteLine("Does the Animal have it's shots?");
            species.Shots = GetYesOrNo();

            Console.WriteLine("What Species is the Animal?");
            species.Animal_Type = (Console.ReadLine());

            Console.WriteLine("What is the Animal's Age?");
            species.Age = GetInt();

            Console.WriteLine("What is the Animal's Adoption Price?");
            species.Adoption_Price = GetInt();

            Console.WriteLine("How much food will the Animal eat in a week?");
            species.Food = GetInt();


            HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
            Data.Animals.InsertOnSubmit(species);
            Data.SubmitChanges();
            //var things = from entries in Data.Animals where entries.Name == "nathan" select entries;
            //Console.WriteLine(things.ToList()[0].Name + " " + things.ToList()[0].Animal_ID);
            //Console.ReadLine();

        }

        private string GetYesOrNo()
        {
            string input = Console.ReadLine().ToLower();
            if (input == "yes" || input == "no")
            {
                return input;
            }
            else
            {
                Console.WriteLine("input not accepted please enter yes or no");
                return GetYesOrNo();
            }
        }

        private int? GetInt()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter an Number");
                return GetInt();
            }
        }

        public static bool UpdateShots(Animal animal)
        {
            try
            {
                HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
                Animal currentAnimal = (from r in Data.Animals
                                        where r.Animal_ID == animal.Animal_ID
                                        select r
                                          ).First();
                currentAnimal.Shots = yes;
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    //            Data.Animals.InsertOnSubmit(dog);
    //            Data.SubmitChanges();
    //            var doggy = from entries in Data.Animals where entries.Name == "Sammy" select entries;
    //            Console.WriteLine(things.ToList()[0].Name + " " + things.ToList()[0].Animal_ID);
    //    public void GetStatusShot(Animal animal)
    //{
    //    if (Shot == No)
    //    {
    //        Console.WriteLine("Shots need to be updated,  would you like to update");
    //        Console.ReadLine();
    //        }
    //    else
    //        return;
    //}
    //public void SetAnimalFood(dog)
    //{
    //    if (
    //    {

    //    }
    //}

    //             public static List<Animal> GetAnimal()
    //        {
    //            HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
    //            var animal = from entries in Data.Animals select entries;
    //            return animal.ToList();
    //        }

              //public void GetSelectedAnimal(int Animal_ID)
              //  {
              //     HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
              //     Animal typeOfAnimal = (from entries in Data.Animals where entries.Animal_ID == Animal_ID select entries).First();
              //     return typeOfAnimal;
              //  }
        //        public static bool AddAnimal(Animal animal)
        //        {
        //            try
        //            {
        //                HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
        //                //Console.WriteLine(things.ToList()[0].Name + " " + things.ToList()[0].Animal_ID);
        //                Data.Animals.InsertOnSubmit(animal);
        //                Data.SubmitChanges();
        //                return true;
        //            }
        //            catch
        //            {
        //                return false;
        //            }
        //        }
        //        public static bool DeleteAnimal(int Animal_ID)
        //        {
        //            try
        //            {
        //                HumaneSocietyDataContext Data = new HumaneSocietyDataContext;
        //                Animal obj = (from entries in Data.Animals where entries.Animal_ID.Contains(Animal_ID) select entries).First();
        //                if (obj != null)
        //                {

        //                    Data.Animals.DeleteOnSubmit(obj);
        //                    Data.SubmitChanges();
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            catch
        //            {
        //                return false;
        //            }
    }
  
 

    
 