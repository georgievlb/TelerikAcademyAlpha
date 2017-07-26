using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPartOne
{
    public class Group
    {
        private Student Student;
        private string GroupId;

        public Group()
        {

        }
        public Group(Student student)
        {
            this.Student = student;
        }
        public Group(string groupId)
        {
            this.GroupId = groupId;
        }
        public Group(string groupId, Student student)
            :this(groupId)
        {
            this.Student = student;
        }

        public Student GetStudent   
        {
            get { return this.Student; }
        }
        public string GetGroupId
        {
            get { return this.GroupId; }
            set { GroupId = value; }
        }

    }
}
