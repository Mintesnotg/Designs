using postGres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Services.Interface
{
    public interface ITeacher 
    {
        Task insertTeacher(Teachers teacher);
        Task updateTeacher(Teachers teacher);
        Task deleteTeacher(Teachers teacher);
        Task<Teachers> getTeacher(int id);
        Task<List<Teachers>> getTeacher();
    }
}
