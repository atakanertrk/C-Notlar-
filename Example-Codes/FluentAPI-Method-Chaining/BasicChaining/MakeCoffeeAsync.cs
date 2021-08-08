using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MakeCoffeeAsync
    {
        private string _customerName;
        private Coffee _coffee;
        public async Task<MakeCoffeeAsync> ForCustomerAsync(string customerName)
        {
            await Task.Delay(1000);
            _customerName = customerName;
            _coffee = new Coffee();
            Console.WriteLine($"making coffee for {customerName}");
            return this;
        }

        public async Task<MakeCoffeeAsync> WithSuggarAsync(int sugarAmount)
        {
            await Task.Delay(1000);
            _coffee.SugarAmount = sugarAmount;
            Console.WriteLine($"with {sugarAmount} sugar");
            return this;
        }

        public async Task<MakeCoffeeAsync> WithIntensityAsync(int intensity)
        {
            await Task.Delay(1000);
            _coffee.Intensity = intensity;
            Console.WriteLine($"with {intensity} intensity");
            return this;
        }

        public async Task<Coffee> ServeAsync()
        {
            await Task.Delay(3000);
            Console.WriteLine($"Coffee is prepared for {_customerName} with {_coffee.Intensity} intensity and {_coffee.SugarAmount} sugar.");
            return _coffee;
        }
    }
}
