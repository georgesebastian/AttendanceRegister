using System.Runtime.Serialization;

namespace AttendanceRegisterService
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Parishioner
    {
        [DataMember]
        public int ParishionerId { get; set; }
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string ResidentialAddress { get; set; }
    }
}