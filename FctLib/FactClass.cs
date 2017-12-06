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

            int fact;
            fact = 1;
            a = 1;
            for (; a > 0; fact *= a--);
            return fact;

        }

    }
}
