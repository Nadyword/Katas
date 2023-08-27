using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Desafios
{
    internal class Consonant_value
    {
        public int Solve(string s)
        {
            char[] bocales = { 'a', 'e', 'i', 'o', 'u' };
            string letras = "abcdefghijklmnopqrstuvwxyz";
            string[] cadena = s.Split(bocales);
            int resul = 0;
            int comprar = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < cadena[i].Length; j++) 
                {
                    comprar += letras.IndexOf(cadena[i][j]) + 1;
                }

                if (comprar > resul) 
                {
                    resul = comprar;
                }
                comprar = 0;
            }

            return resul;
        }
    }
}
