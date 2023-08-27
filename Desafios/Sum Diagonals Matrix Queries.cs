using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Desafios
{
    internal class Sum_Diagonals_Matrix_Queries
    {
         public int hola(int[,] matris, Tuple<int, int> StarPoint) 
        {
            int Dx = matris.GetLength(0) - 1;
            int Dy = matris.GetLength(1) - 1;
            int Sx = StarPoint.Item2;
            int Sy = StarPoint.Item1;
            int resul = 0;

            resul -= matris[Sy, Sx] * 3;
            while  (Sx <= Dx && Sy <= Dy) 
            {
                //buttm right
                resul += matris[Sy, Sx]; 
                Sy++;
                Sx++;
            }

            Sx = StarPoint.Item2;
            Sy = StarPoint.Item1;

            while (0 <= Sx && 0 <= Sy)
            {
                //Top left
                resul += matris[Sy, Sx];
                Sy--;
                Sx--;
            }

            Sx = StarPoint.Item2;
            Sy = StarPoint.Item1;

            while (Sy <= Dy && 0 <= Sx)
            {
                //buttom left
                resul += matris[Sy, Sx];
                Sy++;
                Sx--;
            }

            Sx = StarPoint.Item2;
            Sy = StarPoint.Item1;

            while (Sx <= Dx && 0 <= Sy)
            {
                //Top right
                resul += matris[Sy, Sx];
                Sy--;
                Sx++;
            }

            return resul;
        }
    }
}
