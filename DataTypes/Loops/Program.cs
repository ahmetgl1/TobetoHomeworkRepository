namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Loops!");


            //for döngüsü

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }



            string[] isimler = { "Ali", "Ayşe", "Mehmet", "Zeynep", "Mustafa" };
         
            
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            //while döngüsü



            int sayi = 1;

            while (sayi <= 10)
            {
                Console.WriteLine(sayi);
                sayi++;
            }




            //foreach döngüsü

            string[] names = { "Ali", "Ayşe", "Mehmet", "Zeynep", "Mustafa" };

            Console.WriteLine("İsim Listesi:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }


    }
}