namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");


            Add();
            Delete();
            Add(4, 9);
            Result(71);
            Console.WriteLine(Multiply(1, 2));

            Console.WriteLine(Multiply(1,2,3));


        }
        //parametresiz method
        public static void Add()
        {
            Console.WriteLine("Added !");

        }
        public static void Delete()
        {
            Console.WriteLine("Deleted !");

        }

        //parametreli method
        public  static int Add(int num1, int num2)
        {
            int total = num1 + num2;

           return total;

        }

        //default parametreli method

        public static int Result(int num1, int num2 =24)
        {
            int total = num1 + num2;

            return total;

        }

        //method overloading

        static int Multiply(int num1, int num2)
        {
            int total = num1 * num2;
            return total;
        }
        static int Multiply(int num1, int num2,int num3)
        {
            int total = num1 * num2 * num3;
            return total;
        }

        static int Sum(params int[] numbers)
        {
            int total = numbers.Sum();
            return total;

        }
    }
}