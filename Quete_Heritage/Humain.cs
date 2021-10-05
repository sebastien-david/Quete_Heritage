using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Heritage
{
    public class Humain : Animal
    {
        public Humain(string name) : base(name, 2)
        { }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Ils aiment cuisiner leurs aliments avec une couillere !");
        }
        public override void move()
        {
            Console.WriteLine(" Les " + _name + " se déplacent sur deux jambes, sauf après 2 ou 3 L de bière.");
        }
    }
}
