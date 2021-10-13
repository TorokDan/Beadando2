using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = Letrehoz();
            KiIr(matrix);
            
        }
        static void KiIr(char[,] tomb)
        {
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                Console.Write(tomb[i,j]);
                }
            }
            Console.WriteLine();
        }
        static char[,] Letrehoz()
        {
            Console.WriteLine("Kérem adja meg, a tömb méretét (sorok száma, oszlopok száma szóközzel elválasztva)");
            string bekert = Console.ReadLine();
            char[,] tomb = new char[int.Parse(bekert.Split(' ')[0]), int.Parse(bekert.Split(' ')[1])];
            for (int i = 0; i < tomb.GetLength(0); i++)
            {
                for (int j = 0; j < tomb.GetLength(1); j++)
                {
                    tomb[i, j] = Console.ReadKey().KeyChar;
                }
                Console.WriteLine();
            }
            return tomb;
        }
    }
}
