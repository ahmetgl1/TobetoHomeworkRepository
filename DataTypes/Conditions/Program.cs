using System.Drawing;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");



            //if-else


            int number = 0;

            if(number == 10)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

//or
   Console.WriteLine(number ==10 ? "True" : "False");


            //çoklu conditions
            int point = 75;

            if (point >= 90)
            {
                Console.WriteLine("perfect");
            }
            else if (point >= 80)
            {
                Console.WriteLine("Very Good !");
            }
            else if (point >= 70)
            {
                Console.WriteLine("Good");
            }
            else if (point >= 60)
            {
                Console.WriteLine("Mid");
            }
            else
            {
                Console.WriteLine("unsuccessful");
            }




            //switch-case

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is" + 10);
                    break;

                case 20:
                    Console.WriteLine("Number is" + 20);
                    break;

                    default: Console.WriteLine("Number is" + 0);
                    break;

            }


        }
    }
}