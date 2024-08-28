using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium2._0
{
    internal class Type : Fish
    {
       

        public enum TypeName
        {
            Pufferfish,
            Hammerhead,
            Goldfish,
            Jellyfish,
            Tigershark,
        }

        private TypeName TypeOfFish { get; }

        public Type(TypeName typeName) : base("", "")
        {
            TypeOfFish = typeName;

        }


        private void FishInformation(TypeName Fish)
        {

        }




    }
}
