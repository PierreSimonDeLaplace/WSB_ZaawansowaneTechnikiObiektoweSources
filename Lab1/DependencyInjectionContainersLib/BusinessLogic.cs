using DependencyInjectionContainersLib.Common;
using DependencyInjectionContainersLib.DataProvider;

namespace DependencyInjectionContainersLib
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger logger;
        IDataProvider dataProvider;

        public BusinessLogic(ILogger logger, IDataProvider dataProvider)
        {
            this.logger = logger;
            this.dataProvider = dataProvider;
        }

        public void ProcessData()
        {
            this.logger.Log("Start data processing");
            this.dataProvider.GetData();
            this.dataProvider.SetData();
            this.logger.Log("The processing has finished");
        }
    }
}
