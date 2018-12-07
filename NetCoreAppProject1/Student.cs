namespace NetCoreAppProject1
{
    public class Student
    {
        private static Student _studentInstance;
        private static readonly object Key = new object();
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string XmlInfo { get; set; }
        internal static Student StudentInstance {

            get
            {
                lock (Key)
                {
                    return _studentInstance ?? (_studentInstance = new Student());
                }
            }
        }

        public Student(int id,string name, int age, string address, string xmlInfo)
        {
            Id = id;
            Name = name;
            Age = age;
            Address = address;
            XmlInfo = xmlInfo;
        }

        private Student() { }


        

    }
}
