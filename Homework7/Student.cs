using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    internal class Student
    {
        public string Fullname;
        public string GroupNo;
        public double Point;

        public bool IsGraduated()
        {
            if (Point >= 65)
                return true;
            return false;
        }
    }
}
