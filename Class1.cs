﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBashPractice
{
    internal class Class1
    {
        public Class1(string name, int age, string position)
        {
            Console.WriteLine("Hello git again");
            Name = name;
            Age = age;
            Position = position;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Position { get; private set; }
        public int Salary { get; private set; }

        public string GetInfo()
        {
            return $"Имя {Name}, возраст {Age}, Должность {Position}, Зарплата {Salary}";
        }
    }
}
