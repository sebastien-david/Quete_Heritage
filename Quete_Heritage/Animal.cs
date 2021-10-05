using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Heritage
{
    public abstract class Animal
    {
        protected string _name;
        protected int _numberLegs;

        public Animal (string name, int numberLegs)
        {
            this._name = name;
            this._numberLegs = numberLegs;
        }

        public virtual void Eat()
        {
            Console.WriteLine(" Les " + _name + " mangent avec la bouche plus ou moins proprement =P");
        }

        public virtual void move()
        {
            Console.WriteLine(" Les " + _name + " se déplacent à quatre pattes.");
        }

        public string GetName ()
        {
            return _name;
        }


    }
}
