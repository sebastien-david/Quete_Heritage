using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Lezard lezard = new Lezard("lézards");
            Tortue tortue = new Tortue("tortues");
            Elephant elephant = new Elephant("elephants");
            Singe singe = new Singe("singes");
            Humain humain = new Humain("humains");

            Animal[] animalArray = new Animal[] { lezard, tortue, elephant, humain, singe };

            foreach (Animal animal in animalArray)
            {
                Console.WriteLine("------------------------\n");
                Console.WriteLine($"Description des {animal.GetName()}: \n");
                animal.Eat();
                animal.move();
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
