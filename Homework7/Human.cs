using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public int Age;

        public string GetFullname()
        {
            return Name + ' ' + Surname;
        }
    }
}
