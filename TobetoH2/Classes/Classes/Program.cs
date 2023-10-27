using Classes.Model;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();


            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Ahmet";
            customer.Surname = "Güzeller";


            manager.Add(customer);
            manager.Update(customer);

            
        }



    }

   
}
