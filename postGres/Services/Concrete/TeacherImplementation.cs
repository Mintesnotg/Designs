using postGres.Models;
using postGres.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Services.Concrete
{
    public class TeacherImplementation : ITeacher
    {
        private readonly PContext context;
        public TeacherImplementation(PContext _context)
        {
            context = _context;
        }
        public async Task insertTeacher(Teachers teacher)
        {
            await Task.Run(() => context.teachers.Add(teacher));
            context.SaveChanges();
        }
        public async Task updateTeacher(Teachers teacher)
        {
            await Task.Run(() => context.teachers.Update(teacher));
            context.SaveChanges();
        }
        public async Task deleteTeacher(Teachers teacher)
        {
            await Task.Run(() => context.teachers.Remove(teacher));
            context.SaveChanges();
        }
        public async Task<Teachers> getTeacher(int id)
        {
            return await Task.Run(() => context.teachers.Where(teacher => teacher.id == id).FirstOrDefault());
        }
        public async Task<List<Teachers>> getTeacher()
        {
            return await Task.Run(() => context.teachers.ToList());
        }
    }
}
