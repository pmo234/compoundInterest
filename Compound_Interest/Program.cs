using System;
using Compound_Interest;
namespace Compound_Interest
{
    public class Program
    {
        static void Main(string[] args)
        {

            double product1Interest = Compound_Interest_Calculator.InterestProductA(10000);
            double product2Interest = Compound_Interest_Calculator.InterestProductB(24, 10000);

            Console.WriteLine(ProductComparer.CompareProducts("Emma", product1Interest, product2Interest));

            double product3Interest = Compound_Interest_Calculator.InterestProductC(3, 10000, 10);
            double product4Interest = Compound_Interest_Calculator.InterestProductC(1, 10000, 33.1);

            Console.WriteLine(ProductComparer.CompareProducts("Steven", product3Interest, product4Interest));


        }


    }
}




