﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacherTest
{
    class Person
    {
        protected int age;
        
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int n) // method
        {
            age = n;
        }
    }
}




