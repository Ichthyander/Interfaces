using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //тестирование арифметической прогрессии
            ArithProgression arithProgression = new ArithProgression(0, 5);
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(arithProgression.GetNext());
            }

            arithProgression.Reset();
            Console.WriteLine();
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(arithProgression.GetNext());
            }
            Console.WriteLine();

            arithProgression.SetStart(3);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(arithProgression.GetNext());
            }
            Console.WriteLine();

            //тестирование геометрической прогрессии
            GeomProgression geomProgression = new GeomProgression(1, 5);
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(geomProgression.GetNext());
            }

            geomProgression.Reset();

            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(geomProgression.GetNext());
            }
            Console.WriteLine();

            geomProgression.SetStart(4);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(geomProgression.GetNext());
            }

            Console.ReadKey();
        }
    }
}
