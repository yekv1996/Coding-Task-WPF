using System.Collections.Generic;

namespace DemoApp
{
    class Model
    {
        public static double[] CreateStepLineSeries(double[] source)
        {
            List<double> returnValue = new List<double>();
            for (int i = 1; i < source.Length; i += 2)
            {
                double currentValueX = source[i - 1];
                double currentValueY = source[i];
                returnValue.Add(currentValueX);
                returnValue.Add(currentValueY);
                if (i < source.Length - 1)
                {
                    double nextValueX = source[i + 1];
                    returnValue.Add(nextValueX);
                    returnValue.Add(currentValueY);
                }
            }
            return returnValue.ToArray();
        }
    }
}

