using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor.Installer;
using WindsorDITest.Business.Contracts;
using WindsorDITest.Business.Services;

namespace WindsorDITest.Business.Installers
{
    public class OperationInstaller: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IOperation>().ImplementedBy<AddOperation>());
            //We could use SubtractOperation with this line of code:
            //container.Register(Component.For<IOperation>().ImplementedBy<SubtractOperation>());
        }
    }
}
