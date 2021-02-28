﻿using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type Safety -> Tip Güvenliği
            // Do  Not Repeat Yourself -> Kendini Tekrarlama

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

           
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
