using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractTormund.Comercial.Products
{
    [DataContract]
    public class ProductDC
    {

        [DataMember]
        public int product_id;
        [DataMember]
        public string productName;
        [DataMember]
        public int branch_id;
        [DataMember]
        public string branchName;
        [DataMember]
        public string event_key;
        [DataMember]
        public string description;
        [DataMember]
        public double costo;
        [DataMember]
        public double precio;
        [DataMember]
        public DateTime creationDate;


    }
}