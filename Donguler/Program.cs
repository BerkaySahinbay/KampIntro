﻿using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Gelişirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            // array -> dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Gelişirme Kampı", "Programlamaya Başlangıç için Temel Kurs", "Java", "Python", "C++" };

            // ".Length" kaç eleman varsa onu yazar

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }




    }
}
