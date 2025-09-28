using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VolkovNS.Sprint1.Task2.V11.Lib
{
    public class DataService : ISprint1Task1V11
    {
        public double Calculate(double x, double y)
        {
            return 3600 * x + 60 * y;
        }
    }
}
