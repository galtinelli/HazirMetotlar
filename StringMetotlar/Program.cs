using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Bilge Adam Akademi Yıldız Yazılımcı Yetiştirme Programı";

            //Bir string ifadenin içerisinde gönderilen başka bir ifadeyi arar saonuc true yada false olur
            bool varMi = metin.Contains("adam");
            Console.WriteLine(varMi);

            //Bir string ifadenin içindeki karater sayısını bulmak için

            int uzunluk = metin.Length;
            Console.WriteLine(uzunluk);

            //Bir sting ifadenin gönderilen ifadeyle bitip bitmediğini öğrenmek  için

            bool bitiyorMu = metin.EndsWith("mı");
            Console.WriteLine(bitiyorMu);

            //Bir sting ifadenin gönderilen ifadeyle başlayıp başlamadığını öğrenmek  için
            bool basliyoryorMu = metin.StartsWith("Bil");
            Console.WriteLine(bitiyorMu);

            //Bir string ifadeyi tamamen küçük harfe çevirmek için

            string hepsiKucuk = metin.ToLower();
            Console.WriteLine(hepsiKucuk);

            //Bir string ifadeyi tamamen büyük harfe çevirmek için

            string hepsiBuyuk = metin.ToUpper();
            Console.WriteLine(hepsiKucuk);

            //Bir string ifadenin içerisindeki karakterin yerini öğrenmek için

            int nerede = metin.IndexOf('i');
            Console.WriteLine(nerede);
            nerede = metin.IndexOf('i',10); //10uncu karakterden sonra ilk ne rede

            //Bir string ifadenin içerisinde istenilen yere istenilen başka bir ifadeyi yerleştirip döndürmek için

            string eklenmişMetin = metin.Insert(10, " Yazılım");
            Console.WriteLine(eklenmişMetin);

            //Bir string ifadenin yerinden itibAREN istenilen kadarını silmek için
            string silinmisMetin = metin.Remove(15);
            Console.WriteLine(silinmisMetin);

            silinmisMetin = metin.Remove(15, 2);
            Console.WriteLine(silinmisMetin);

            //Bi string ifadenin çerisinde belirtilen bir ifadeyi başka bir ifadeyle değiştirmek için

            string degismisMetin = metin.Replace('e', 'i');
            Console.WriteLine(degismisMetin);

            degismisMetin = metin.Replace("Adam", "Kadın");
            Console.WriteLine(degismisMetin);


            //Bir string ifadeyi belirtilen  bir karaktere göre parçalara ayırıp tüm parçaları string olarak teslim almak için

            string[] parcalanmisMetin = metin.Split(' ');
            foreach (var item in parcalanmisMetin)
            {
                Console.WriteLine(item);
            }

            string altMetin = metin.Substring(15);//15ten sonrasını alt metin olarak yaz
            Console.WriteLine(altMetin);


            string altMetin2 = metin.Substring(15,4);//15ten sonrasını alt metin olarak yaz
            Console.WriteLine(altMetin2);

            //NOT: stringer aslında chardır

            foreach (char item in metin)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(metin);

            Console.ReadKey();
        }
    }
}
