using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Animal
    {
        public static List<Animal>GetAnimal()
        {
                HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
                var animal = from entries in Data.Animals select entries;
                return animal.ToList();
        }
        public Animal GetSelectedAnimal(int Animal_ID)
        {
                 HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
            Animal typeOfAnimal = (from entries in Data.Animals where entries.Animal_ID == Animal_ID select entries).First();
            return typeOfAnimal;
        }
        public static bool AddAnimal(Animal animal)
        {
            try
            {
                HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
                //Console.WriteLine(things.ToList()[0].Name + " " + things.ToList()[0].Animal_ID);
                Data.Animals.InsertOnSubmit(animal);
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool DeleteAnimal(int Animal_ID)
        {
            try
            {
                HumaneSocietyDataContext Data = new HumaneSocietyDataContext;

            }
        }

    }
}
