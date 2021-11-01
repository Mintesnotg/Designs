using postGres.Models;
using postGres.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Services.Interface
{
   public interface IStudent
    {
        Task insertStudent(Students student);
        Task updateStudent(Students student);
        Task deleteStudent(Students student);
        Task<Students> getStudent(int id);
        Task<List<Students>> getStudent();
    }
}
