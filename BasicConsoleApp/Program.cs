using System;
using System.Text;

namespace BasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 0, weight = 0;

            // Set console encoding to unicode
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //輸入身高
            Console.Write("請輸入身高(cm):");
            var tmp = Console.ReadLine();
            height = int.Parse(tmp);

            //輸入體重
            Console.Write("請輸入體重(kg):");
            tmp = Console.ReadLine();
            weight = int.Parse(tmp);

            //身高轉公尺
            //float h = (float)height / 100;

            //計算BMI
            //float BMI = weight / (h * h);

            //呼叫BMI
            HealthMgr.BmiCalculator bc = new HealthMgr.BmiCalculator();
            bc.onError += (obj, e) => { Console.Write("ERR:" + e); };
            bc.Height = height;
            bc.Weight = weight;
            float BMI = bc.Calculate();
            //顯示
            Console.WriteLine($"BMI:{BMI}");
        }
    }
}
