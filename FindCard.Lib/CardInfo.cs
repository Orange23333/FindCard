using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FindCard.Lib
{
    [DataContract]
    public class CardInfo
    {
        [DataContract]
        public class CardInfoWithoutId
        {
            private string studentId;
            [DataMember]
            public string StudentId { get { return studentId; } set { studentId = value; } }
        }
        
        private string cardId;
        [DataMember]
        public string CardId { get { return cardId; } set { cardId = value; } }
        private CardInfoWithoutId info;
        [DataMember]
        public CardInfoWithoutId Info { get { return info; } set { info = value; } }
        private List<CardInfoWithoutId> hisoricalInfo;
        [DataMember]
        public List<CardInfoWithoutId> HisoricalInfo { get { return hisoricalInfo; } set { hisoricalInfo = value; } }
    }
}