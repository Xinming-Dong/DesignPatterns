using FactoryMethods;
using System.Security.Cryptography.X509Certificates;

namespace FactoryMethods
{
    public static class Go
    {
        private static Calculator calculator;
        static void Main()
        {
            System.Console.WriteLine("press 1 for summer");
            System.Console.WriteLine("press 2 for multiplier");
            var key = System.Console.ReadKey();

            if (key.KeyChar == '1')
            {
                calculator = new SummerCalculator();
            }
            else if (key.KeyChar == '2')
            {
                calculator = new MultiplierCalculator();
            }
            else
            {
                Console.WriteLine("invalid input.");
                return;
            }

            calculator.calculate();
        }
    }
}
/*Calculator
{
    Operator op;

    public Calculator (Operator op)
    {
        this.op = op;
    }

    public void calculate()
    {
        op.Operate();
    }
}*/