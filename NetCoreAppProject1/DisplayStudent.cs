using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using NetCoreAppProject1.Interface;

namespace NetCoreAppProject1
{
    public class DisplayStudent : SQLConn, IDisplayAll
    {


        private static DisplayStudent displayInstance = null;
        private static readonly object key = new object();

        public static DisplayStudent DisplayInstance {
            get
            {
                lock (key)
                {
                    if (displayInstance == null)
                    {
                        displayInstance = new DisplayStudent();
                    }
                    return displayInstance;
                }
            }
        }

        private DisplayStudent() { }
        public List<Student> DisplayAllStudent()  
        {
            Con.Open();
            List<Student> students = new List<Student>();
            SqlDataReader reader;
            SqlCommand command = new SqlCommand("select * from StudentInfo", Con);
            reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    Console.WriteLine();
                    students.Add(new Student((int)reader[0],reader[1].ToString(), (int)reader[2], reader[3].ToString(), reader[4].ToString()));
                }
            }

            
            Con.Close();
            command.Dispose();
            reader.Close();
            return students;
        }
    }
}
