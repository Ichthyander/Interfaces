using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class ArithProgression : ISeries
    {
        int startNumber;
        int number;
        int difference;
        public int Difference { get => difference; set => difference = value; }
        public int StartNumber { get => startNumber; set => startNumber = value; }

        public ArithProgression(int startNumber, int difference)
        {
            StartNumber = startNumber;
            Difference = difference;
            number = startNumber;
        }

        public int GetNext()
        {
            number += difference;
            return number;
        }

        public void Reset()
        {
            SetStart(startNumber);
        }

        public void SetStart(int x)
        {
            startNumber = x;
            number = startNumber;
        }
    }
}
