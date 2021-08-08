using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp1.MakeCoffeeInOrder;

namespace ConsoleApp1
{
    public class MakeCoffeeInOrder :  ICustomerSelectionStage, IIntensitySelectionStage, ISugarSelectionStage, IServerStage
    {
        private string _customerName;
        private Coffee _coffee;
        private MakeCoffeeInOrder()
        {
            _coffee = new Coffee();
        }

        public static ICustomerSelectionStage StartCustomizingTheCoffee()
        {
            return new MakeCoffeeInOrder();
        }

        public IIntensitySelectionStage ForCustomer(string customerName)
        {
            _customerName = customerName;
            return this;
        }

        public ISugarSelectionStage WithIntensity(int intensity)
        {
            _coffee.Intensity = intensity;
            return this;
        }
        public ISugarSelectionStage LowIntensityWithMilk()
        {
            _coffee.Intensity = 1;
            _coffee.Milk = true;
            return this;
        }

        public IServerStage WithSugar(int sugarAmount)
        {
            _coffee.SugarAmount = sugarAmount;
            return this;
        }
        public IServerStage WithoutSugar()
        {
            _coffee.SugarAmount = 0;
            return this;
        }

        public Coffee Serve()
        {
            Console.WriteLine($"Coffee is prepared for {_customerName} with {_coffee.Intensity} intensity, {_coffee.SugarAmount} sugar, milk : {_coffee.Milk}.");
            return _coffee;
        }


        public interface ICustomerSelectionStage
        {
            public IIntensitySelectionStage ForCustomer(string customerName);
        }

        public interface IIntensitySelectionStage
        {
            public ISugarSelectionStage WithIntensity(int intensity);
            public ISugarSelectionStage LowIntensityWithMilk();
        }

        public interface ISugarSelectionStage
        {
            public IServerStage WithoutSugar();
            public IServerStage WithSugar(int sugarAmount);
        }

        public interface IServerStage
        {
            public Coffee Serve();
        }

    }
}
