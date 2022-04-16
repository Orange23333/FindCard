using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FindCard.Lib
{
    [DataContract]
    public class FoundInfo
    {
        [DataContract]
        public class FoundInfoWithoutId
        {
            //private string seekerInfo;
            private string seekerStudentId;
            [DataMember]
            public string SeekerStudentId { get { return seekerStudentId; } set { seekerStudentId = value; } }
            private string cardId;
            [DataMember]
            public string CardId { get { return cardId; } set { cardId = value; } }
        }

        private string foundId;
        [DataMember]
        public string FoundId { get { return foundId; } set { foundId = value; } }
        private FoundInfoWithoutId info;
        [DataMember]
        public FoundInfoWithoutId Info { get { return info; } set { info = value; } }
        private List<FoundInfoWithoutId> hisoricalInfo;
        [DataMember]
        public List<FoundInfoWithoutId> HisoricalInfo { get { return hisoricalInfo; } set { hisoricalInfo = value; } }
    }
}