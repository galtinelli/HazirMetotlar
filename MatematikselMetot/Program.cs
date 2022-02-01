using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mutlak deger

            decimal mutlakSayi = Math.Abs(-454.34M);
            Console.WriteLine(mutlakSayi);

            //Matematik kurallarına göre yuvarlama

            decimal yuvarlaDeger = Math.Round(5.4M);
            Console.WriteLine(yuvarlaDeger);

            //Aşağı yuvarlama
            decimal asagiyuvarlaDeger = Math.Floor(5.4M);
            Console.WriteLine(asagiyuvarlaDeger);

            //Yukarı yuvarlama

            decimal yukariyuvarlaDeger = Math.Ceiling(5.4M);
            Console.WriteLine(yukariyuvarlaDeger);

            //Karekök alma
            double karekok = Math.Sqrt(16);
            Console.WriteLine(karekok);

            //iki değeri karşılaştırıp küçüğü bulma

            double kucukDeger = Math.Min(12.5, 16);
            double buyukDeger = Math.Max(12.5, 16);

            Console.WriteLine(kucukDeger);
            
            //iki değeri karşılaştırıp büyüğü bulma
            Console.WriteLine(buyukDeger);

            //Pi sayısını alma

            Console.WriteLine(Math.PI);

            Console.Read();
        }
    }
}
