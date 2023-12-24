using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
    enum StudentComparerType
    {
        Name, Grade
    }

    internal class StudentComparer : IComparer
    {
        private StudentComparerType criterion;
        public StudentComparer(StudentComparerType criterion)
        {
            this.criterion = criterion;
        }

        public int Compare(object _s1, object _s2)
        {
            Student s1 = (Student)_s1;
            Student s2 = (Student)_s2;
            if(this.criterion == StudentComparerType.Name)
            {
                return s1.name.CompareTo(s2.name);
            }
            return s1.grade.CompareTo(s2.grade);
        }
    }
}
