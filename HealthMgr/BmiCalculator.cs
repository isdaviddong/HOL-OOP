using System;

namespace HealthMgr
{
    public class BmiCalculator<T>
    {
        private T _Weight = default(T);
        public T Weight
        {
            get { return _Weight; }
            set
            {
                if (float.Parse(value.ToString()) <= 0)
                    throw new Exception("體重不合法!");
                else
                    _Weight = value;
            }
        }

        private T _Height = default(T);
        public T Height
        {
            get { return _Height; }
            set
            {
                if (float.Parse(value.ToString()) <= 0)
                    throw new Exception("身高不合法!");
                else
                    _Height = value;
            }
        }
        public float BMI { get { return Calculate(); } }

        public BmiCalculator()
        { }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="height">身高</param>
        /// <param name="weight">體重</param>
        public BmiCalculator(T height, T weight)
        {
            _Height = height;
            _Weight = weight;
        }

        /// <summary>
        /// 使用屬性計算BMI
        /// </summary>
        /// <returns></returns>
        public float Calculate()
        {
            float result = 0;

            float height = float.Parse(Height.ToString()) / 100;
            result = float.Parse(Weight.ToString()) / (height * height);

            return result;
        }

        /// <summary>
        /// 直接計算BMI
        /// </summary>
        /// <param name="height">身高</param>
        /// <param name="weight">體重</param>
        /// <returns></returns>
        public float Calculate(T height, T weight)
        {
            float result = 0;

            float h = float.Parse(height.ToString()) / 100;
            result = float.Parse(weight.ToString()) / (h * h);

            return result;
        }
    }
}
