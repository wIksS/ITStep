using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloningObjects
{
    public class ClonableHuman : ICloneable
    {
        private string name;

        public ClonableHuman(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Clothes Clothes{ get; set; }

        public object Clone()
        {

            return MemberwiseClone();
            //return new ClonableHuman(this.Name)
            //{
            //    Clothes = this.Clothes
            //};
        }

        public override string ToString()
        {
            return String.Format("{0}, Clothes --> {1}", this.Name, this.Clothes.Type.ToString());
        }
    }
}
