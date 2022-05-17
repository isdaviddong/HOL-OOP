using System;
using System.Text;

namespace BasicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 0, weight = 0, gender = 0;

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

            //輸入性別
            Console.Write("請輸入性別(1:男 2:女):");
            tmp = Console.ReadLine();
            gender = int.Parse(tmp);

            //身高轉公尺
            //float h = (float)height / 100;

            //計算BMI
            //float BMI = weight / (h * h);

            //呼叫BMI
            MyHealthMgr bc = new MyHealthMgr();
            bc.Height = height;
            bc.Weight = weight;
            bc.gender = gender;
            float BMI = bc.Calculate();
            //顯示
            Console.WriteLine($"BMI:{BMI} 超重: {bc.isOverWeight()}");
        }
    }

    public class MyHealthMgr : HealthMgr.BmiCalculator
    {
        public int gender { get; set; } //1:男   2:女

        public bool isOverWeight()
        {
            //throw new NotImplementedException();
            if (gender == 1) //男性
                if (this.BMI > 30) return true; else return false;
            if (gender == 2) //女性
                if (this.BMI > 29) return true; else return false;

            throw new Exception("性別值未設定");
        }
    }
}
