using System.Runtime.Serialization;

namespace TestService
{
    [DataContract]
    public class CollectResponse
    {
        [DataMember]
        public int Total { get; set; }
    }
}
