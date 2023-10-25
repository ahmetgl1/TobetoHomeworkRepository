namespace PrimitiveNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


        }

        public bool isPrimitive(int number)
        {
            bool result = true;

            for(int i= 2; i<number-1; i++)
            {

                if(number % i == 0)
                {
                    result = false;
                    i = number;

                }
            }
            return result;
        }
    }
}