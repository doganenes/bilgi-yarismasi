using System;

namespace Bilgi_Yarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            Console.WriteLine("Enes Doğan'ın Sunmuş olduğu Doğanlar Bilgi Yarışmasına Hoşgeldiniz: ");
            Console.WriteLine();
            Console.WriteLine("*********************************************************************************** ");

            Console.WriteLine();

            int sayi= 1;
            string cevap;


            if (sayi == 1)
            {
                Console.WriteLine("Aşağıdakilerden hangisi javada ekranda yazdırmaya yarar?");

                Console.WriteLine();

                Console.WriteLine("A) Console.log()");
                Console.WriteLine("B) Document.Write()");
                Console.WriteLine("C) System.out.Println()");
                Console.WriteLine("D)Console.Write()");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Lütfen cevabınızı giriniz:");
                cevap = Console.ReadLine();
                
                if (cevap=="C" || cevap == "c")
                {
                    sayi = sayi + 1;
                }
                else
                {
                    Console.WriteLine("Cevabınız yanlış. Yarışma sona erdi. Toplam doğru cevabınız 0.");
                }
            }

            Console.WriteLine();

            if (sayi == 2)
            {

                Console.WriteLine("Hangi Dil Yapay Zekada sıklıkla kullanılmaktadır?");

                Console.WriteLine();

                Console.WriteLine("A)PHP");
                Console.WriteLine("B)C");
                Console.WriteLine("C)Javascript");
                Console.WriteLine("D)Python");


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Lütfen cevabınızı giriniz:");

                cevap = Console.ReadLine();

                if (cevap == "d" || cevap == "D")
                {
                    sayi += 1;
                }
                else
                {
                    Console.WriteLine("Cevabınız yanlış. Yarışma bitti. Doğru sayınız 1");
                }
            }


            Console.WriteLine();

            if (sayi == 3)
            {
                Console.WriteLine("Hangi Programlama dilinin geliştiricisi Google'dır?");

                Console.WriteLine();

                Console.WriteLine("A)Java");
                Console.WriteLine("B)Golang");
                Console.WriteLine("C)R");
                Console.WriteLine("D)PHP");


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Lütfen cevabınızı giriniz:");

                cevap = Console.ReadLine();

                Console.WriteLine();

                if(cevap == "b" ||cevap== "B")
                {
                    Console.WriteLine("Yarışma sona erdi. Bütün soruları bildiniz. TEBRİKLER!!!");
                }
                else
                {
                    Console.WriteLine("Yanlış cevap. Yarışma Sona Erdi. Toplam doğru cevabınız 2");
                }

            }


            Console.Read();
        }
    }
}
