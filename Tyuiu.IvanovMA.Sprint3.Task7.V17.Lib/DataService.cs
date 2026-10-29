
using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.IvanovMA.Sprint3.Task7.V17.Lib
{
    public class DataService : ISprint3Task7V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] result = new double[count];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = x + 1.7;
                double f;

                if (denominator == 0)
                {
                    f = 0;
                }
                else
                {
                    f = Math.Sin(x) / denominator
                        - Math.Cos(x) * 4 * x - 6;
                }

                result[index] = Math.Round(f, 2);
                index++;
            }

            return result;
        }
    }
}
