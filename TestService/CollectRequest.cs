﻿using System.Runtime.Serialization;

namespace TestService
{
    [DataContract]
    public class CollectRequest
    {
        [DataMember]
        public int Param1 { get; set; }

        [DataMember]
        public int Param2 { get; set; }
    }
}
