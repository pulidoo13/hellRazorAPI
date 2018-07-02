using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractTormund.HumanResource.Employees
{
    [DataContract]
    public class EmployeeDC
    {

        [DataMember]
        public int employee_id;
        [DataMember]
        public string employeeName;
        [DataMember]
        public int branch_id;
        [DataMember]
        public string branchName;
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
