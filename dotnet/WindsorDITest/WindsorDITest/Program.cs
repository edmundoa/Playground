using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindsorDITest.Business.Contracts;
using WindsorDITest.Business.Services;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.Windsor.Installer;
using WindsorDITest.Business.Installers;

namespace WindsorDITest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string n1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string n2 = Console.ReadLine();

            IWindsorContainer container = new WindsorContainer();
            container.Install(new OperationInstaller());

            IOperation service = container.Resolve<IOperation>();

            int result = service.Operation(int.Parse(n1), int.Parse(n2));
            Console.WriteLine("Result is: {0}", result);
            Console.ReadLine();
        }
    }
}
