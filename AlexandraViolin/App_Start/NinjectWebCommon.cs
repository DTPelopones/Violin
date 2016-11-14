[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(AlexandraViolin.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(AlexandraViolin.App_Start.NinjectWebCommon), "Stop")]

namespace AlexandraViolin.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    
    using Ninject;
    using Ninject.Web.Common;
    using Violin.Domain;
    using System.Configuration;
    using System.Data.SqlClient;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            SqlConnectionStringBuilder connectStringBuilder = new SqlConnectionStringBuilder();

            connectStringBuilder.DataSource = "SKYLAKE";
            connectStringBuilder.InitialCatalog = "AlexandraViolin";
            connectStringBuilder.UserID = "avi";
            connectStringBuilder.Password = "test1";


            connectStringBuilder.ConnectTimeout = 30;
            connectStringBuilder.AsynchronousProcessing = true;
            connectStringBuilder.MultipleActiveResultSets = true;

            System.Web.Mvc.DependencyResolver.SetResolver(new Infrastructure.NinjectDependencyResolver(kernel));
            kernel.Bind<LessonDataContext>().ToMethod(c => new LessonDataContext(connectStringBuilder.ConnectionString));
            kernel.Bind<IRepository>().To<SqlRepository>().InRequestScope();
        }        
    }
}
