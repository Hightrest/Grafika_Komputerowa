using DataBase1stDotNet.Models;

using (var context = new NorthwindContext())
{
    Console.WriteLine($"Numbers of customers: {context.Customers.Count()}");
    Console.ReadLine();

    foreach(var customer in context.Customers.OrderBy(c=>c.CompanyName))
    {
        Console.WriteLine($"{customer.CompanyName} {customer.City}");
    }

}
           