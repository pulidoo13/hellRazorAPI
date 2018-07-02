using DataContractTormund.Comercial.Branches;
using DataContractTormund.Comercial.Customers;
using DataContractTormund.Comercial.Services;
using DataContractTormund.HumanResource.Employees;
using DataContractTormund.Solution.Users;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace DataContractTormund.Dates
{
    [DataContract]
    public class DateDC
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public BranchDC Branch { get; set; }
        [DataMember]
        public int Branch_id { get; set; }
        [DataMember]
        public ServiceDC Service { get; set; }
        [DataMember]
        public EmployeeDC Employee { get; set; }
        [DataMember]
        public int Employee_id { get; set; }
        [DataMember]
        public CustomerDC Customer { get; set; }
        [DataMember]
        public int Customer_id { get; set; }
        [DataMember]
        public DateTime AppointmentDate { get; set; }
        [DataMember]
        public DateTime DueDate { get; set; }
        [DataMember]
        public DateTime CreationDate { get; set; }
        [DataMember]
        public DateTime LastModified { get; set; }
        [DataMember]
        public UserDC CreatedBy { get; set; }
        [DataMember]
        public UserDC ModifiedBy { get; set; }
        [DataMember]
        public byte[] Photo { get; set; }
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public string FromApp { get; set; }
        [DataMember]
        public string event_key { get; set; }


    }
}
