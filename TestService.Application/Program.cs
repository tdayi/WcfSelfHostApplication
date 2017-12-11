using System;
using System.ServiceProcess;

namespace TestService.Application
{
    static class Program
    {
        static void Main()
        {
            if (!Environment.UserInteractive)
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                    new Service()
                };
                ServiceBase.Run(ServicesToRun);
            }
            else
            {
                TransactionServiceInstaller transactionServiceInstaller = new TransactionServiceInstaller();
                Console.WriteLine("TransactionService Started...");
                Console.ReadKey();
            }
        }
    }
}
