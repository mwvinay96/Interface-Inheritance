using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceInheritance
{
    public interface IChild : IParent
    {
        char[] SplitNumberToCharacter(long number);
    }
}
