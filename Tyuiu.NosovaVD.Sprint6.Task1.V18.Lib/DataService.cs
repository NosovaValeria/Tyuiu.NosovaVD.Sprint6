using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NosovaVD.Sprint6.Task1.V18.Lib
{
    public class DataService : ISprint6Task1V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((3 * x + 1.2) == 0)
                {
                    vallueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round(((2.0 * Math.Sin(x))/(3.0*x+1.2) + Math.Cos(x) - 7.0 * x * 2.0), 2);
                    vallueArray[count] = y;
                    count++;
                }
            }
            return vallueArray;
        }
    }
}
