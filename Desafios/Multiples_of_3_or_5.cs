using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    internal class Multiples_of_3_or_5
    {
        #region Mi solucion
        public int Solution(int value)
        {
            
            if (value < 0) return 0;
            List<int> list5 = new List<int>();

            int resul = 0;

            for (int i = 1; value > 5 * i; i++)
            {
                if ((5 * i) <= value)
                {
                    list5.Add(5 * i);
                    resul += 5 * i;
                }
            }

            for (int i = 1; 3 * i < value; i++)
            {
                if ((3 * i) < value)
                {
                    if (!list5.Contains(3 * i))
                    {
                        resul += 3 * i;
                    }
                }
            }
            return resul;
        }
        #endregion

        #region Opccion 1
        public int Solution1(int n)
        {
            return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
        #endregion

        #region Opccion 2
        public static int Solution2(int value)
        {
            var sum = 0;
            for (int i = 3; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            return sum;
        }
        #endregion

        #region Opccion 3
        public static int Solution3(int value)
        {
            int sum = 0;
            for (int i = 3; i < value; i += 3)
            {
                sum += i;
            }
            for (int i = 5; i < value; i += 5)
            {
                if (i % 3 != 0)
                    sum += i;
            }
            return sum;
        }
        #endregion
    }
}
