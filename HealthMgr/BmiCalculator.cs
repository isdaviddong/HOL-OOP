using System;

namespace HealthMgr
{
    public class BmiCalculator
    {
        public int Weight;
        public int Height;
        public float BMI { get { return Calculate(); } }

        public float Calculate()
        {
            float result = 0;

            float height = Height / 100;
            result = Weight / (height * height);

            return result;
        }
    }
}
