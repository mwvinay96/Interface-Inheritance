using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceInheritance
{
    class Child : IChild
    {
        public char[] SplitNumberToCharacter(long number)
        {
            var result = number.ToString().ToCharArray();
            return result;
        }

        public char[] SplitStringToCharacters(string sentance)
        {
            return sentance.ToCharArray();
        }
    }
}
