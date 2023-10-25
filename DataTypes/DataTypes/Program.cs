using System.Numerics;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Data Types

            //int 32 bit
            int number = 0;
            int min = int.MinValue;
            int max = int.MaxValue;
            Console.WriteLine("Sayı Değeri:" + number);
            Console.WriteLine("En Büyük Değer" + max);
            Console.WriteLine("En Küçük Değer" + min);


            //long : 64bit yer kaplar !

            long sayi1 = 12345678901234567;
            long sayi2 = 98765432109876543;

            long toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam: " + toplam);



            // short: 16bit
            short short1 = 100;
            short short2 = 200;

            short total = (short)(short1 + short2);

            Console.WriteLine("Toplam: " + total);



            //byte 0-255 arasında veri tutar

            byte byte1 = 150;
            byte byte2 = 75;

            byte fark = (byte)(byte1 - byte2);

            byte carpim = (byte)(byte1 * byte2);

            byte bolum = (byte)(byte1 / byte2);

            Console.WriteLine("Çıkarma Sonucu: " + fark);
            Console.WriteLine("Çarpma Sonucu: " + carpim);
            Console.WriteLine("Bölme Sonucu: " + bolum);



            //Char: Tek karakter tutar

            char char1 = 'A';
            char char2 = 'B';

            string  merge = char1.ToString() + char2.ToString();

            Console.WriteLine("Birleşik Karakter: " + merge);




            //double: 64 bit 
            double double1 = 3.5;
            double double2 = 2.0;

            double totalValue = double1 + double2;

            Console.WriteLine("Çarpma Sonucu: " + totalValue);



            Console.ReadKey();

        }

        enum Days
        {
            Sunday, Monday, Tuesday, Wednesday, Friday, Saturday
        }
    }
}