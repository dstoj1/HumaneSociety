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
                var doggy = from entries in Data.Animals select entries;
                return doggy.ToList();
        }
        public static bool AddAnimal()
        {
            try
            {
                HumaneSocietyDataContext Data = new HumaneSocietyDataContext();
                //Console.WriteLine(things.ToList()[0].Name + " " + things.ToList()[0].Animal_ID);
                Data.Animals.InsertOnSubmit(doggy);
                Data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
