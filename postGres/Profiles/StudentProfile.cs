using AutoMapper;
using postGres.Models;
using postGres.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentsModel, Students>();
            CreateMap<Students, StudentsModel>();
        }
        
    }
}
