using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractTormund.Solution.Users
{
    [DataContract]
    public class UserDC
    {

        [DataMember]
        public int user_id;
        [DataMember]
        public string name;
        [DataMember]
        public string userName;
        [DataMember]
        public int user_type;

        [DataMember]
        public string facebook_user_id;
        [DataMember]
        public string facebook_mail;
        [DataMember]
        public string google_user_id;
        [DataMember]
        public string google_mail;
        [DataMember]
        public string password;       

        [DataMember]
        public string event_key;
        [DataMember]
        public string principalPhone;
        [DataMember]
        public DateTime birthDate;
        [DataMember]
        public DateTime creationDate;
        [DataMember]
        public string fromApplication;


    }
}
