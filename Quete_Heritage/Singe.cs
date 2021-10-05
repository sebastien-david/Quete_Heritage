using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Heritage
{
    public class Singe : Animal
    {
        public Singe (string name) : base(name, 4)
        { }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Ils adorent manger des banane entre potes.");
        }

        public override void move()
        {
            Console.WriteLine(" Les " + _name + " se déplacent à quatre pattes ou sur deux jambes mais rien à voir avec la bière.");
        }
    }
}
