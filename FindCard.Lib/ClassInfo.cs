using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FindCard.Lib
{
    [DataContract]
    public class ClassInfo
    {
        [DataContract]
        public class ClassInfoWithoutId
        {
            private string name;
            [DataMember]
            public string Name { get { return name; } set { name = value; } }
        }

        private string classId;
        [DataMember]
        public string ClassId { get { return classId; } set { classId = value; } }
        private ClassInfoWithoutId info;
        [DataMember]
        public ClassInfoWithoutId Info { get { return info; } set { info = value; } }
        private List<ClassInfoWithoutId> hisoricalInfo;
        [DataMember]
        public List<ClassInfoWithoutId> HisoricalInfo { get { return hisoricalInfo; } set { hisoricalInfo = value; } }
    }
}