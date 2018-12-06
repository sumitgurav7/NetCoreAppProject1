using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreAppProject1
{
    public class Student
    {
        private static Student studentInstance = null;
        private static readonly object key = new object();
        public int Id { get; set; }
        public string name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string xmlInfo { get; set; }
        internal static Student StudentInstance {

            get
            {
                lock (key)
                {
                    if (studentInstance == null)
                    {
                        studentInstance = new Student();
                    }
                    return studentInstance;
                }
            }
        }

        public Student(int id,string name, int age, string address, string xmlInfo)
        {
            this.Id = id;
            this.name = name;
            this.Age = age;
            this.Address = address;
            this.xmlInfo = xmlInfo;
        }

        private Student() { }


        

    }
}
