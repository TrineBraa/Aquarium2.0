using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium2._0
{
    internal class Type : Fish
    {
        public Type(TypeName typeName) : base(typeName, "")
        {

        }


        public enum TypeName
        {
            Pufferfish,
            Hammerhead,
            Goldfish,
            Jellyfish,
            Tigershark,
        }


        public Dictionary<TypeName,string> FishInformation()
        {
            var fishInfo = new Dictionary<TypeName, string>
            {
                {TypeName.Pufferfish, "Puffs up when scared, is abit Spikey" },
                {TypeName.Hammerhead, "Looks like a hammer, abit bitey!" },
                {TypeName.Goldfish, "The golden one, so shiney!" },
                {TypeName.Jellyfish, "peaceful little blob, so squishy!" },
                {TypeName.Tigershark, "An aggressive guy, so stripey!" }
            };
            return fishInfo;
        }


        public void ListFish(Dictionary<TypeName, string> fishInfo)
        {
            foreach (var Fishey in fishInfo)
            {
                Console.WriteLine($"\t\t{Fishey.Key}");
            }
        }


       
        


    }
}
