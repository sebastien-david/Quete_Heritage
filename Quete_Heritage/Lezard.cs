using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Heritage
{
    public class Lezard : Animal
    {
        public Lezard(string name) : base(name, 4)
        { }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine(" Ils apprécient tout particulèrement les insectes.");
        }
    }
}
