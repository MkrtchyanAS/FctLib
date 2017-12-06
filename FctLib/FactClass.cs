using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctLib
{
    public class FactClass
    {
        public int Fact(int a)
        {
            int factorial = 1;
            for (; a > 0; factorial *= a--) ;
            return factorial;
        }

    }
}
