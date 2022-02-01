using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeMeotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih);

            Console.WriteLine("Gün: "+tarih.Day);
            Console.WriteLine("Ay: "+tarih.Month);
            Console.WriteLine("Yıl: "+tarih.Year);
            Console.WriteLine("Saat: "+tarih.Hour);
            Console.WriteLine("Saniye: "+tarih.Minute);
            Console.WriteLine("Milisaniye: "+tarih.Millisecond);

            Console.WriteLine(tarih.ToLongDateString());
            Console.WriteLine(tarih.ToShortDateString());
            Console.WriteLine(tarih.ToLongTimeString());
            Console.WriteLine(tarih.ToShortTimeString());


            DateTime eklenmisTarih = tarih.AddDays(2);
            Console.WriteLine("İki gün eklenmiş tarih: "+eklenmisTarih);

            eklenmisTarih = tarih.AddYears(5);
            Console.WriteLine("5 yıl eklenmiş tarih: "+eklenmisTarih);

            eklenmisTarih = tarih.Add(new TimeSpan(5,6,7,8));
            Console.WriteLine("5 gün 6 saat 7 dakika 8 saniye eklenmiş: "+eklenmisTarih);

            DayOfWeek haftaninGunu = tarih.DayOfWeek;
            Console.WriteLine(haftaninGunu);

            int yilinGunu = tarih.DayOfYear;
            Console.WriteLine("Bugün yilin {0}. günü",yilinGunu);

            Console.ReadLine();
        }
    }
}
