using System;

namespace DependencyInjectionContainersLib.DataProvider
{
    public class DataProvider : IDataProvider
    {
        public void GetData() => Console.WriteLine("Loading the data");
        public void SetData() => Console.WriteLine("Saving the data");
    }
}
