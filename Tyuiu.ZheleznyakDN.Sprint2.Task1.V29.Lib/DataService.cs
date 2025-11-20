using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task1.V29.Lib
{
    public class DataService : ISprint2Task1V29
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == c) & (c == d);                    
            res[1] = (a != b) | (b < a);                    
            res[2] = (a > b) && (c >= b);                 
            res[3] = (a == b) || (c < d);                 
            res[4] = (a >= c) ^ (b <= a);                 
            res[5] = (a == d) | (c != b);                  
            res[4] = (a >= c) & (b != c);

            return res;
        }
    }
}
