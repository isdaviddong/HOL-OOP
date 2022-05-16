using System;

namespace HealthMgr
{
    public class BmiCalculator
    {
        private int _Weight = 0;
        public int Weight
        {
            get { return _Weight; }
            set
            {
                if (value <= 0)
                    throw new Exception("體重不合法!");
                else
                    _Weight = value;
            }
        }

        private int _Height = 0;
        public int Height
        {
            get { return _Height; }
            set
            {
                if (value <= 0)
                    throw new Exception("身高不合法!");
                else
                    _Height = value;
            }
        }
        public float BMI { get { return Calculate(); } }

        public float Calculate()
        {
            float result = 0;

            float height =(float) Height / 100;
            result = Weight / (height * height);

            return result;
        }
    }
}
