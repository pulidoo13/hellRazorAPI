using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractTormund.Comercial.Services
{
    [DataContract]
    public class ServiceDC
    {

        [DataMember]
        public int service_id;
        [DataMember]
        public string name;
        [DataMember]
        public int branch_id;
        [DataMember]
        public string branchName;
        [DataMember]
        public string event_key;
        [DataMember]
        public string Description;
        [DataMember]
        public double cost;
        [DataMember]
        public double price;
        [DataMember]
        public DateTime creationDate;


    }
}
