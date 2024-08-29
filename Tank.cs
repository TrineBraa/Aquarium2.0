using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium2._0
{
    internal class Tank
    {
        private Type type;

        public Tank()
        {
        type = new Type(Type.TypeName.Pufferfish);
        }

        public void FishListed()
        {
            type.ListFish(type.FishInformation());
        }

        public void PrintChoiceFish(Type.TypeName ChoosenFish)
        {
            var fishInfo = type.FishInformation();
            if (fishInfo.TryGetValue(ChoosenFish, out var description))
            {
                Console.Clear();
                Console.WriteLine($"Fish: {ChoosenFish}");
                Console.WriteLine($"Description: {description}");
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Fish not found!");
            }
            
            Console.ReadKey();
        }

    }
}
