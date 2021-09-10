using GraphQLBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBasic.IService
{
    public class StudentService : IStudentService
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            for (int i = 1; i < 9; i++)
            {
                students.Add(new Student
                {
                    StudentId = i,
                    Name = "stu" + i,
                    Roil = "100" + i
                });
            }
            return students;
        }
    }
}
