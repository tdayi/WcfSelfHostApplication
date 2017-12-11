using System.ServiceProcess;

namespace TestService.Application
{
    public partial class Service : ServiceBase
    {
        public Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            TransactionServiceInstaller transactionServiceInstaller = new TransactionServiceInstaller();
        }

        protected override void OnStop()
        {
        }
    }
}
