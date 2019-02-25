using System.Runtime.Serialization;

namespace AttendanceRegisterService
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Ward
    {
        [DataMember]
        public int WardId { get; set; }
        [DataMember]
        public string WardName { get; set; }
    }
}
