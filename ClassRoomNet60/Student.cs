﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        public string Name { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }

        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }
    }
}
