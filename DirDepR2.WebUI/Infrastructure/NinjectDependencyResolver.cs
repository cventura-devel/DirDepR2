using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using DirDepR2.Domain.Concrete;
using DirDepR2.Domain.Abstract;
using DirDepR2.Domain.Entities;

namespace DirDepR2.WebUI.Infrastructure
{
    public class NinjectDependencyResolver:IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IProfesorRepository>().To<EFProfesorRepository>();
            kernel.Bind<IStoreProcedures>().To<EFStoreProcedure>();
        }
    }
}