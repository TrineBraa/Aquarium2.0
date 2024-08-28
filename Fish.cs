using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium2._0
{
    internal abstract class Fish
    {
        protected Type.TypeName Name { get; set; }
        protected string Description{ get; private set; }

        protected Fish(Type.TypeName name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void FishInfortmation()
        {

        }


    }
}
