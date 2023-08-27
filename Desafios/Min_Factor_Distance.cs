using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Desafios
{
    internal class Min_Factor_Distance
    {
        public static int Fator(int n)
        {
            List<int> list = new();
            int i;
            int resul;
            for (i = 1; i < n / 2; i++)
            {
                if ((n % i) < 1)
                {
                    list.Add(i);
                }
            }
            list.Add(n);

            i = 1;
            resul = list[i] - list[0];

            for (int j = 0; j <= list.Count - 2; j++, i++)
            {
                if ((list[i] - list[j]) < resul)
                {
                    resul = list[i] - list[j];
                }
            }

            return resul;
        }
    }
}
