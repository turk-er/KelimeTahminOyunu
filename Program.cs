using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemelEgitim2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            List<string> kelime = new List<string>() { "elma", "armut", "kiraz", "karpuz", "ayva", "erik", "avakado", "kavun", "kivi" };

            while (true)
            {

                Console.WriteLine("KELİME BULMA OYUNU");
                Console.WriteLine("*******************");
                Console.WriteLine("Kurallar :\n-----------------\n1.Oyunumuz harf harf ilerlemektedir yani her seferinde bir harf girilecek ve enter tuşuna basılacaktır." +
                                       "\n2.Pualama 100 üzerinden yapılmaktadır\n*****************************************************************************************************");
                Console.Write("Lütfen Adınızı Giriniz: ");
                string isim = Console.ReadLine();
                Console.WriteLine("**************************");

                Random rastgele = new Random();
                int sayı = rastgele.Next(kelime.Count);

                string bulunacakMeyve = kelime[sayı];

                Console.WriteLine($"Merhaba {isim} \nAradığımız Kelime " + bulunacakMeyve.Length + " Harfli Bir Meyve");

                int puan = 0;

                for (int i = 0; i < bulunacakMeyve.Length; i++)
                {
                    char harf;

                    do
                    {

                        harf = Console.ReadLine().ToLower()[0];
                        //harf = Convert.ToChar(Console.ReadLine()); üst te yazılan kodun aynısı fakat birden çok karakter girildiğinde hata oluşmasını önlüyor

                        if (harf == bulunacakMeyve.ElementAt(i))
                        {
                            Console.WriteLine("Doğru lütfen sıradaki harfi girin");
                            for (int j = 0; j <= i; j++)
                            {
                               
                                Console.Write(bulunacakMeyve.ElementAt(j));
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Yanlış harf lütfen tekrar deneyin");
                            for (int j = 0; j <= i; j++)
                            {
                                if (j >= 1)
                                {
                                    Console.Write(bulunacakMeyve.ElementAt(j - 1));
                                }
                            }
                            puan++;
                           
                        }
                        
                    }
                    while (harf != bulunacakMeyve.ElementAt(i));


                }

                Console.WriteLine("\n**********************************************");
                Console.WriteLine($"\n Tebrikler {isim} puanın " + (100 - puan)+"\n"+DateTime.Now);

                Console.WriteLine("Cıkmak için exit yazın devam etmek içn Entera basın");
                string cikis = Console.ReadLine();
                if (cikis=="exit")
                {
                    Environment.Exit(0);
                }

              
                Console.Clear();

               

            }


        }        
    }
}
