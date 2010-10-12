using System.Runtime.Serialization;

namespace com.devrockit.wcfsample1.Model
{
    [DataContract]
    public class Policy
    {
        [DataMember]
        public string Number { get; set; }
        
        [DataMember]
        public string InsuredName { get; set; }

        public Policy(string number, string insuredname)
        {
            Number = number;
            InsuredName = insuredname;
        }
    }
}
