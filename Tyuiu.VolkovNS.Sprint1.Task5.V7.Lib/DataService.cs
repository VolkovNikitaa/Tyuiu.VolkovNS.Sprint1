using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VolkovNS.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            return Convert.ToInt32(f * 12 / 360);
        }
    }
}
