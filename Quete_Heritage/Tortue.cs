using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Heritage
{
    public class Tortue : Animal
    {
        public Tortue(string name) : base(name, 4)
        { }

        public override void move()
        {
            base.move();
            Console.WriteLine(" Elles sont un peu lente mais la " + _name + " a quand même mis misère au lièvre =P");
        }
    }
}
