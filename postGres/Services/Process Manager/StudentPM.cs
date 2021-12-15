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
        private readonly IStudent _students;
        private readonly IMapper mapper;

        public  StudentPM(IStudent _student,IMapper _mapper)
        {
            _students = _student;
            mapper = _mapper;

        }
        public async Task insertStudent(StudentsModel studentToInsert)
        {
            var student= mapper.Map<Students>(studentToInsert);
            await _students.insertStudent(student);
        }
        public async Task updateStudent(StudentsModel studentToUpdate)
        {
            Students student = mapper.Map<Students>(studentToUpdate);
            await _students.updateStudent(student);
        }
        public async Task deleteStudent(StudentsModel studentToDelete)
        {
            Students student = mapper.Map<Students>(studentToDelete);
            await _students.deleteStudent(student);

        }
        public async Task<StudentsModel> getStudent(int studentId)
        {
            return mapper.Map<StudentsModel>(await _students.getStudent(studentId));
        }
        public async Task<List<StudentsModel>> getStudent()
        {
            return mapper.Map<List<StudentsModel>>(await _students.getStudent());
        }

    }
}
