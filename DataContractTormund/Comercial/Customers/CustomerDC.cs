using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using DataContractTormund.Comercial.Branches;

namespace DataContractTormund.Comercial.Customers
{
    [DataContract]
    public class CustomerDC
    {
      
        [DataMember]
        public int customer_id;
        [DataMember]
        public int user_id;
        [DataMember]
        public string customerName;
        [DataMember]
        public BranchDC branch;
       
        [DataMember]
        public string event_key;
        [DataMember]
        public string principalPhone;
        [DataMember]
        public DateTime birthDate;
        [DataMember]
        public DateTime creationDate;


    }
}
