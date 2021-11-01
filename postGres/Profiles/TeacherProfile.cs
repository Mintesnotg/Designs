using postGres.Models;
using postGres.View_Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Profiles
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<TeachersModel, Teachers>();
            CreateMap<Teachers, TeachersModel>();
        }
    }
}
