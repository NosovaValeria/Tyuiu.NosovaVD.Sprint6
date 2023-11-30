using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NosovaVD.Sprint6.Task0.V21.Lib
{
    public class DataService : ISprint6Task0V21
    {
        public double Calculate(int x)
        {
            double res = 2 * Math.Pow((double)x, 3) + (1.0 / 2.0) * Math.Pow((double)x, 2) - 3.5 * (double)x + 2.0;
            return Math.Round(res, 3);
        }
    }
}
