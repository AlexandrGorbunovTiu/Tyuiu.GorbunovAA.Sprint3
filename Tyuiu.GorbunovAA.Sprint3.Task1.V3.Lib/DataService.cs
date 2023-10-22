using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GorbunovAA.Sprint3.Task1.V3.Lib 
{
    public class DataService : ISprint3Task1V3
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double Value = 1;
            int n = stopValue;
            int f = 1;
            var i = startValue;
            var r = stopValue;
            while ( i < r + 1)
            {
                Value = Value * (i / Math.Pow((Math.Cos(5) + 1), 2));
                i++;

            }
            return Value;
        }
    }
}
