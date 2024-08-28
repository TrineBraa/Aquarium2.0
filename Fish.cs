using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium2._0
{
    internal abstract class Fish
    {
        protected Type.TypeName Name;
        protected string description;
        

        public Type.TypeName name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string Dscription
        {
            get;
            private set;
        }

      

        protected Fish(Type.TypeName Name, string _description)
        {
            Dscription = _description;
           
        }
    }
}
