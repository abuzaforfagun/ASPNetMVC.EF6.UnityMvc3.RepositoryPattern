using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Core;
using ASPNetMVC.EF6.UnityMvc3.RepositoryPattern.Presistance;

namespace ASPNetMVC.EF6.UnityMvc3.RepositoryPattern
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IUnitOfWorkRepository, UnitOfWorkRepository>();
            container.RegisterType<IPersonRepository, PersonRepository>();
            

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}