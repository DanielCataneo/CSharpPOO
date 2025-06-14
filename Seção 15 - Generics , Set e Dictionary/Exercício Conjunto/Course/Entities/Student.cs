using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Student
    {
        public int ID { get; set; }

        public Student(int ID)
        {
            this.ID = ID;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student)) return false;

            Student other = obj as Student;
            return ID.Equals(other.ID);
        }

    }
}
