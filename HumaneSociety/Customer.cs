using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Customer
    {
        Animal animals = new Animal();

        public Customer()
        {

        }
    }
    public void GetTypeOfAnimal()
    {
        Console.WriteLine("What type of Animal are you searching for?");
        animals = Console.ReadLine().ToLower();
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
}
