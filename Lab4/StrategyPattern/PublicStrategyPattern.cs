using System;

namespace StrategyPattern
{
    public class PublicTransportStrategy : IRouteStrategy
    {
        public void BuildRoute() => Console.WriteLine("Public transport strategy has been used for travel time estimation.");
    }
}