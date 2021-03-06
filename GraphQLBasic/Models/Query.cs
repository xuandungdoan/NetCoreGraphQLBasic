using GraphQLBasic.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLBasic.Models
{
    public class Query
    {
        IStudentService studentService = null;
        public Query(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        public List<Student> Students => studentService.GetStudents();
    }
}
