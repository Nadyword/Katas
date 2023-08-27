using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    internal class Stop_gninnipS_My_sdroW
    {
        public string SpinWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            string resul = ""; 
            for (int i = 0; i < words.GetLength(1); i++) 
            {
                resul += words[i].Length >= 5 ? words[i].Reverse() : words[i];
            }
            return resul;
        }
    }
}
