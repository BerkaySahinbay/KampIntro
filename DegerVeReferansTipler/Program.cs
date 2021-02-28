using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
 //Sayi1 kaçtır? -> 30 ilk önce sayi1 ve sayi2 eşitlendi (30,30) daha sonra sayi2 değeri değişti (65) sayi1 in değeri aynı kaldı çünkü sayi2 nin yeni değerinden sonra eşitlik oluşmadı.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
//sayilar1[0] ?-> 999 sayilar1 referans numarası = sayilar2 referans numarası (19. satır) sayilar2 referans numarasının 0. elemanı 999 (20. satır) sayilar1 in 0. elemanı kaçtır? dendiğinde cevap bu yüzden 999 kalıyor.

            // int, decimal, float, double, bool(arka planda 1ve0 ayırır) = *DEĞER TİP*
            // array, class, interface = *REFERANS TİP*

            // sayi1 = 10, sayi2 = 30, gibi belirtmeler STACK bölümünde, (değer tipler)
            // REFERANS tipler HEAP bölümünde çalışır.


        }
    }
}
