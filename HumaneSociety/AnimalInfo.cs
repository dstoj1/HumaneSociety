using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class AnimalInfo
    {
        public void GetTypeOfAnimal()
        {
            Console.WriteLine("What type of Animal are you searching for?");
            string animals = Console.ReadLine().ToLower();
            switch (animals)
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
        //public void SetAnimalFood()
        //{
        //    Console.WriteLine("How much food does this animal eat?");
        //    string animals = Console.ReadLine().ToLower();
        //    switch (animals)
        //    {
        //        case "German Shepard":
        //            Console.WriteLine("German Shepard gets 1 cup of dog food");
        //            break;
        //        case "Mini Labordoodle":
        //            Console.WriteLine("Mini Labordoodle gets 3/4 cups of dog food");
        //            break;
        //        case "Malti-Poo":
        //            Console.WriteLine("Malti-Poo gets 1/2 cup of dog food");
        //            break;
        //        case "Cats":
        //            Console.WriteLine("Cats gets 1/2 cup of cat food");
        //            break;
        //        default:
        //            break;
        //    }
        
    }
}
