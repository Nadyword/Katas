using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Desafios
{
    internal class Sum_of_Digits_Digital_Root
    {
        #region Mi solucion

        char[] formatInput;

        public Sum_of_Digits_Digital_Root(int input = 0)
        {
            formatInput = input.ToString().ToCharArray();
        }

        public void Resul()
        {
            int resul;
            do
            {
                resul = 0;
                for (int i = 0; i < formatInput.GetLength(0); i++)
                {
                    resul += Convert.ToInt16(int.Parse(formatInput[i].ToString()));
                }

                formatInput = resul.ToString().ToCharArray();

            } while (resul.ToString().Length > 1);

            Console.WriteLine(resul);
        }
        #endregion

        #region Solicion 1

        public class Number
        {
            public int DigitalRoot(long n)
            {
                int sum = n.ToString().Select(d => Int32.Parse(d.ToString())).Sum();
                if (sum.ToString().Length > 1)
                    sum = DigitalRoot(sum);
                return sum;
            }
        }

        #endregion
    }
}
