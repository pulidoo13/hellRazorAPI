using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractTormund.Comercial.Branches
{
    [DataContract]
    public class BranchDC
    {

        [DataMember]
        public int branch_id;
        [DataMember]
        public string branchName;
        [DataMember]
       
        public string Address;
        [DataMember]
        public string event_key;
        [DataMember]
        public string principalPhone;
        [DataMember]
        public string horary;
        [DataMember]
        public DateTime creationDate;


    }
}
