using System.Collections.Generic;
using System.Runtime.Serialization;

#warning 把Info字段去掉，把里面的成员放出来，可以节约网络

namespace FindCard.Lib
{
    [DataContract]
    public class StudentInfo
    {
        [DataContract]
        public class StudentInfoWithoutId
        {
            private string name;
            [DataMember]
            public string Name { get { return name; } set { name = value; } }
            private string classId;
            [DataMember]
            public string ClassId { get { return classId; } set { classId = value; } }
        }

        private string studentId;
        [DataMember]
        public string StudentId { get { return studentId; } set { studentId = value; } }
        private StudentInfoWithoutId info;
        [DataMember]
        public StudentInfoWithoutId Info { get { return info; } set { info = value; } }
        private List<StudentInfoWithoutId> hisoricalInfo;
        [DataMember]
        public List<StudentInfoWithoutId> HisoricalInfo { get { return hisoricalInfo; } set { hisoricalInfo = value; } }
    }
}