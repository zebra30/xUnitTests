using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Calculate
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Mulitply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("y can not equal 0");
            }

            return x / y;
        }
    }
}
