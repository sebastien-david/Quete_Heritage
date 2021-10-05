using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Heritage
{
   public class Elephant : Animal
    {
        public Elephant(string name) : base(name, 4)
        { }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Ils utilisent leurs grande trompe.\n" +
                " Attention pas celle que vous croyez bande de pervers !");
        }
    }
}
