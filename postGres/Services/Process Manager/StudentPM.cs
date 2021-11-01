using AutoMapper;
using postGres.Models;
using postGres.Services.Concrete;
using postGres.Services.Interface;
using postGres.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Services.Process_Manager
{
    public class StudentPM
    {
        private readonly IStudent students;
        private readonly IMapper mapper;

        public  StudentPM(IStudent _students,IMapper _mapper)
        {
            students = _students;
            mapper = _mapper;

        }
        public async Task insertStudent(StudentsModel studentToInsert)
        {
            Students student = mapper.Map<Students>(studentToInsert);
            await students.insertStudent(student);
        }
        public async Task updateStudent(StudentsModel studentToUpdate)
        {
            Students student = mapper.Map<Students>(studentToUpdate);
            await students.updateStudent(student);
        }
        public async Task deleteStudent(StudentsModel studentToDelete)
        {
            Students student = mapper.Map<Students>(studentToDelete);
            await students.deleteStudent(student);

        }
        public async Task<StudentsModel> getStudent(int studentId)
        {
            return mapper.Map<StudentsModel>(await students.getStudent(studentId));
        }
        public async Task<List<StudentsModel>> getStudent()
        {
            return mapper.Map<List<StudentsModel>>(await students.getStudent());
        }

    }
}
