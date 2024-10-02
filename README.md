Console.Write("Lütfen bir sayı giriniz:");
double number = Convert.ToDouble(Console.ReadLine());
                                                                                                                  Console.Write: Kullanıcıdan sayı girmesini isteyen bir mesaj yazdırır.
                                                                                                                                   Console.ReadLine(): Kullanıcının girdiği veriyi alır. 
                                                                Bu veri bir string olarak gelir, bu yüzden Convert.ToDouble ile double tipine dönüştürülür ve number değişkenine atanır.
         
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
    Console.WriteLine("Girilen sayı 10'a eşittir");
}
                                                                                              If-Else Yapısı: Girilen sayının 10'dan büyük, küçük veya eşit olup olmadığını kontrol eder.
                                                                                                             Eğer sayı 10'dan büyükse, "Girilen sayı 10'dan büyüktür." mesajı yazdırılır.
                                                                                                             Eğer sayı 10'dan küçükse, "Girilen sayı 10'dan küçüktür." mesajı yazdırılır.
                                                                                               Aksi halde, yani sayı 10'a eşit olduğunda, "Girilen sayı 10'a eşittir." mesajı yazdırılır.


if (number % 2 == 0)
{
    Console.WriteLine("Girilen sayı çiftir");
}
else
{
    Console.WriteLine("Girilen sayı tektir");
}
                                                                                                                  Çift ve Tek Kontrolü: Girilen sayının çift veya tek olduğunu belirler.
                                                                 number % 2 == 0: Sayı 2’ye tam bölünüyorsa (yani kalan 0 ise), sayı çifttir ve "Girilen sayı çiftir" mesajı yazdırılır.
                                                                                                                                   Aksi halde, "Girilen sayı tektir." mesajı yazdırılır.
