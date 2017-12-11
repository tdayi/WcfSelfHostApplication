using System.ServiceModel;

namespace TestService
{
    [ServiceContract]
    public interface ITransactionService
    {
        [OperationContract]
        CollectResponse Collect(CollectRequest request);
    }
}
