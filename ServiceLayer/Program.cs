using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Microsoft.ServiceModel.Samples
{
    class Program
    {
        public static IBLEmployees blHandler;

        static void Main(string[] args)
        {
            SetupDependencies();
            SetupService();
        }

        private static void SetupDependencies()
        {
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration();

            IBLEmployees blHandler = container.Resolve<IBLEmployees>();

            blHandler.GetAllEmployees();

            //blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
        }

        private static void SetupService()
        {
            
        }
    }
}
