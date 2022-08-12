using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class GeomProgression:ISeries
    {
        int startNumber;
        int number;
        int difference;

        public GeomProgression(int startNumber, int difference)
        {
            this.startNumber = startNumber;
            this.difference = difference;
            number = startNumber;
        }

        public int GetNext()
        {
            number *= difference;
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
