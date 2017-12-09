using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctLib
{

    public class FactClass
    {
        /// <summary>
        /// Находит факториал переданного числа
        /// </summary>
        public long Fact(long a)
        {
            long factorial = 1;
            for (; a > 0; factorial *= a--);
            return factorial;
        }

    }
}
