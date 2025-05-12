using System;

public class Program
{
    public static void Main(string[] args)
    {
        ICustomerRepository realRepo = new CustomerRepository();
        CustomerService serviceProd = new CustomerService(realRepo);
        Console.WriteLine(serviceProd.GetCustomer(1));
    }
}
