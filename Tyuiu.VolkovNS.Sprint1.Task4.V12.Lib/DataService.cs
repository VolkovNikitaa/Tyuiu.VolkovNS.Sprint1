using tyuiu.cources.programming.interfaces.Sprint1;
using Tyuiu.VolkovNS.Sprint1.Task4.V12.Lib;
namespace Tyuiu.VolkovNS.Sprint1.Task4.V12.Lib
{
    public class DataService : ISprint1Task4V12
    {
        public double Calculate(double x, double y)
        {
            return Math.Sin(Math.PI*x)/(x+Math.Sqrt(Math.Abs(y)));
        }
    }
}
