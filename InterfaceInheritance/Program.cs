using System;
using System.Linq;

namespace InterfaceInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Child();
            Console.WriteLine(8884619450);
            var res1 = obj.SplitNumberToCharacter(8884619450).ToList();
            res1.ForEach(character =>
            {
                Console.WriteLine(character);
            });
            Console.WriteLine("Vinay Adiga");
            var res2 = obj.SplitStringToCharacters("Vinay Adiga").ToList();
            res2.ForEach(character =>
            {
                Console.WriteLine(character);
            });

            Console.WriteLine("Hello World!");
        }
    }
}
