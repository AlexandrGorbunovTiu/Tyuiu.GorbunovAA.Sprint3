using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GorbunovAA.Sprint3.Task2.V3.Lib
{
    public class DataService : ISprint3Task2V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            int x = 0;
            do
            {
                x = x + ((16 * startValue) + 1);
                startValue++;
            } while (startValue < stopValue);
            return x;
        }
    }
}
