using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Navigator(new PublicTransportStrategy());
            context.Navigate();

            //change the strategies used and call the Navigate method

            Console.ReadLine();
        }
    }
}
