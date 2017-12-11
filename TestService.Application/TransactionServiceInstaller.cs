using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace TestService.Application
{
    public class TransactionServiceInstaller
    {
        public TransactionServiceInstaller()
        {
            Uri uri = new Uri("http://localhost:1520/CollectService");

            ServiceHost serviceHost = new ServiceHost(typeof(TransactionService), uri);
            serviceHost.AddServiceEndpoint(
                typeof(ITransactionService),
                new WSHttpBinding { Security = new WSHttpSecurity { Mode = SecurityMode.None } },
                uri);

            ServiceMetadataBehavior serviceMetadataBehavior = new ServiceMetadataBehavior();
            serviceMetadataBehavior.HttpGetEnabled = true;
            serviceHost.Description.Behaviors.Add(serviceMetadataBehavior);

            serviceHost.Open();
        }
    }
}
