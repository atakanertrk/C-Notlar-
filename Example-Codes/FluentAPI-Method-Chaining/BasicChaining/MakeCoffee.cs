using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MakeCoffee
    {
        private string _customerName;
        private Coffee _coffee;
        public MakeCoffee ForCustomer(string customerName)
        {
            _customerName = customerName;
            _coffee = new Coffee();
            Console.WriteLine($"making coffee for {customerName}");
            return this;
        }

        public MakeCoffee WithSuggar(int sugarAmount)
        {
            _coffee.SugarAmount = sugarAmount;
            Console.WriteLine($"with {sugarAmount} sugar");
            return this;
        }

        public MakeCoffee WithIntensity(int intensity)
        {
            _coffee.Intensity = intensity;
            Console.WriteLine($"with {intensity} intensity");
            return this;
        }

        public Coffee Serve()
        {
            Console.WriteLine($"Coffee is prepared for {_customerName} with {_coffee.Intensity} intensity and {_coffee.SugarAmount} sugar.");
            return _coffee;
        }
    }
}
