using NetCoreAppProject1.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace NetCoreAppProject1
{
    public class DisplayIndividualStudent : SQLConn, IDisplayOne
    {


        private static DisplayIndividualStudent displayIndividualStudentInstance = null;
        private static readonly object key = new object();

        public static DisplayIndividualStudent DisplayIndividualStudentInstance
        {
            get
            {
                lock (key)
                {
                    if (displayIndividualStudentInstance == null)
                    {
                        displayIndividualStudentInstance = new DisplayIndividualStudent();
                    }
                    return displayIndividualStudentInstance;
                }
            }
        }



        private DisplayIndividualStudent() { }

        public Student DisplaySTudentById(int ID)
        {
            Con.Open();
            Student student = null;
            SqlDataReader reader;
            SqlCommand command = new SqlCommand("select * from StudentInfo where Id = @ID", Con);
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@ID";
            parameter.Value = ID;
            command.Parameters.Add(parameter);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //Console.WriteLine("Id : " + reader[0] + " Name : " + reader[1] + " Age: " + reader[2] + " Address: " + reader[3]);
                    student = Student.StudentInstance;
                    student.Id = (int)reader[0];
                    student.name = reader[1].ToString();
                    student.Age = (int)reader[2];
                    student.Address = reader[3].ToString();
                    student.xmlInfo = reader[4].ToString();
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
