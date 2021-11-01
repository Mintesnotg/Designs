using postGres.Services.Interface;
using postGres.View_Models;
using postGres.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Services.Process_Manager
{
    public class TeacherPM
    {
        private readonly ITeacher teachers;
        private readonly IMapper mapper;
        public TeacherPM(IMapper _mapper, ITeacher _teachers)
        {
            teachers = _teachers;
            mapper = _mapper;
        }
        public async Task insertTeacher(TeachersModel teacherToInsert)
        {
            Teachers teacher = mapper.Map<Teachers>(teacherToInsert);
            await teachers.insertTeacher(teacher);
        }
        public async Task updateTeacher(TeachersModel teacherToUpdate)
        {
            Teachers teacher = mapper.Map<Teachers>(teacherToUpdate);
            await teachers.updateTeacher(teacher);
        }
        public async Task deleteTeacher(TeachersModel teacherToDelete)
        {
            Teachers teacher = mapper.Map<Teachers>(teacherToDelete);
            await teachers.deleteTeacher(teacher);

        }
        public async Task<TeachersModel> getTeacher(int teacherId)
        {
            return mapper.Map<TeachersModel>(await teachers.getTeacher(teacherId));
        }
        public async Task<List<TeachersModel>> getTeacher()
        {
            return mapper.Map<List<TeachersModel>>(await teachers.getTeacher());
        }
    }
}
