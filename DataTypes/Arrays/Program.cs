namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[3];

            students[0] = "Ahmet";
            students[1] = "Fatih";
            students[2] = "Güzeller";

            foreach (var student in students)
            {
                Console.WriteLine(student);
                
            }

            //Çok Boyutlu Diziler

            string[,] ulkeler = new string[,]
       {
            {"Türkiye", "Ankara", "Türk Lirası"},
            {"ABD", "Washington, US", "Dolar"},
            {"Fransa", "Paris", "Euro"},
            {"Suudi Arabistan", "Riyad", "Riyal"},
       };

            Console.WriteLine("----------Ülkeler ve Bilgileri ---------:");
            for (int ulkeIndex = 0; ulkeIndex < ulkeler.GetLength(0); ulkeIndex++)
            {
                Console.WriteLine("Ülke Adı: " + ulkeler[ulkeIndex, 0]);
                Console.WriteLine("Başkent: " + ulkeler[ulkeIndex, 1]);
                Console.WriteLine("Para Birimi: " + ulkeler[ulkeIndex, 2]);
                
            }

        }
    }
}