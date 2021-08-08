using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // In Order sync
            var coffee1 = MakeCoffeeInOrder.StartCustomizingTheCoffee().ForCustomer("atakan").LowIntensityWithMilk().WithoutSugar().Serve();
            var coffee2 = MakeCoffeeInOrder.StartCustomizingTheCoffee().ForCustomer("ata").WithIntensity(2).WithSugar(2).Serve();

            //// (basic) sync
            //MakeCoffee makeCoffee = new MakeCoffee().ForCustomer("atakan").WithSuggar(2).WithIntensity(1);
            //var syncCoffee =  makeCoffee.Serve();

            //// (basic) async
            //MakeCoffeeAsync makeCoffeeAsync = new MakeCoffeeAsync();
            //var asyncCoffee = await makeCoffeeAsync.ForCustomerAsync("ata").Result.WithIntensityAsync(2).Result.WithSuggarAsync(2).Result.ServeAsync();

            Console.ReadLine();
        }

       
    }
}


