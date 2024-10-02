using System;
namespace Project3IfElse
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen bir sayı giriniz:");
            double number = Convert.ToDouble(Console.ReadLine());
            //örnekteki gibi aynı satıra sayı girmesi için write methodu kullanıldı



            // girilen sayının 10'dan büyük olması durumunu ıf yapısı ile kontrol ediyoruz
            // eğer sayı 10'dan küçükse de else if yapısı ile bunu kontrol ederiz
            // girilen sayı 10dan büyüktür ya da 10dan küçüktür bu iki durumda değise 10'a eşittir
            // else yapısıyla, bu iki durumda geçerli değilse 10'a eşittir durumu kontrol edilir.
            if (number > 10)
            {
                Console.WriteLine("Girilen sayı 10'dan büyüktür.");
            }

            else if (number < 10)
            {
                Console.WriteLine("Girilen sayı 10'dan küçüktür.");
            }

            else
            {
                Console.WriteLine("Girilen sayı 10'a  eşittir");
            }

            // if else yapısını tekrar kullanarak çift/tek durumları kontrol edildi. 
            // if: sayı 2 ye böündüğünde 0 kalanını veriyorsa çifttir.
            // else: değilse tektir.

            if (number % 2 == 0)
            {
                Console.WriteLine("Girilen sayı çiftir");
            }
            else
            {
                Console.WriteLine("Girilen sayı tektir");
            }
        }
    }
}