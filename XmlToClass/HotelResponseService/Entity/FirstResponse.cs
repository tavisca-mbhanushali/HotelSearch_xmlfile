using System.Runtime.Serialization;

namespace HotelResponseService
{
    [DataContract]
    public class FirstResponse
    {
        [DataMember]
        public string location { get; set; }
        [DataMember]
        public string NumOfRoom { get; set; }
        [DataMember]
        public string RoomTypes { get; set; }
        [DataMember]
        public string bestValue { get; set; }
        [DataMember]
        public string minAverPrice { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string hotelId { get; set; }

       


    }
}