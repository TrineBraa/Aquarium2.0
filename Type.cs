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


        
        private void FishInformation(TypeName Fish)
        {
            var fishInfo = new Dictionary<TypeName, Fish>
            {

            };
        }




    }
}
