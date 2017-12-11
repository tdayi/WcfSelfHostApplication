namespace TestService
{
    public class TransactionService : ITransactionService
    {
        public CollectResponse Collect(CollectRequest request)
        {
            return new CollectResponse
            {
                Total = request.Param1 + request.Param2
            };
        }
    }
}
