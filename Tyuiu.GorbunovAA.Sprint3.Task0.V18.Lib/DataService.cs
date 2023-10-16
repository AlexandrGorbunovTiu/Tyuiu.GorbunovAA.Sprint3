using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GorbunovAA.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double Value = 1;
            int n = stopValue;
            int f = 1;
            for (int i = startValue; i < n; i++)
            {
                Value = Value *  (Math.Pow(2 / (Math.Cos(1) + 0.5), startValue));


            }
            return Value;
        }
    }
}
