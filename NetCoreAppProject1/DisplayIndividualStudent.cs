using NetCoreAppProject1.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NetCoreAppProject1
{
    public class DisplayIndividualStudent : SqlConn, IDisplayOne
    {


        private static DisplayIndividualStudent _displayIndividualStudentInstance = null;
        private static readonly object Key = new object();

        public static DisplayIndividualStudent DisplayIndividualStudentInstance
        {
            get
            {
                lock (Key)
                {
                    if (_displayIndividualStudentInstance == null)
                    {
                        _displayIndividualStudentInstance = new DisplayIndividualStudent();
                    }
                    return _displayIndividualStudentInstance;
                }
            }
        }



        private DisplayIndividualStudent() { }

        public Student DisplaySTudentById(int id)
        {
            Con.Open();
            Student student = null;
            SqlDataReader reader;
            SqlCommand command = new SqlCommand("select * from StudentInfo where Id = @ID", Con);
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = id;
            command.Parameters.Add(parameter);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //Console.WriteLine("Id : " + reader[0] + " Name : " + reader[1] + " Age: " + reader[2] + " Address: " + reader[3]);
                    student = Student.StudentInstance;
                    student.Id = (int)reader[0];
                    student.Name = reader[1].ToString();
                    student.Age = (int)reader[2];
                    student.Address = reader[3].ToString();
                    student.XmlInfo = reader[4].ToString();
                }

                Con.Close();
                command.Dispose();
                reader.Close();
                return student;
            }
            else
            {
                Console.WriteLine("no rows found");
                
                Con.Close();
                command.Dispose();
                reader.Close();
                return student;
            }

            
        }
    }
}
