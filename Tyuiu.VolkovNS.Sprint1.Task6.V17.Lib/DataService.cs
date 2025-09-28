using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VolkovNS.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            int a = 0;
            for (int i = 0; i < value.Length / 2; i++)
            {
                if (value[i] != value[value.Length - 1 - i])
                {
                    a++;
                }
            }
            if (a == 0)
            return true;
            else
                return false;
        }
    }
}
