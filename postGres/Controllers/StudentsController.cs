using Microsoft.AspNetCore.Mvc;
using postGres.Services.Process_Manager;
using postGres.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentPM _studentProcessManager;

        public StudentsController(StudentPM studentProcessManager)
        {
            _studentProcessManager = studentProcessManager;

        }
        public async Task<IActionResult> Index()
        {
            List<StudentsModel> students=await _studentProcessManager.getStudent();
            return View(students);
        }

        [HttpPost]
        public async Task<IActionResult> addStudent(StudentsModel model)
        {
            await _studentProcessManager.insertStudent(model);
            return Redirect("/Students/Index");
        }

        [HttpPost]
        public async Task<IActionResult> AlterStudent(StudentsModel model,string Delete)
        {
            if(string.IsNullOrEmpty(Delete))
            return View(model);
            await _studentProcessManager.deleteStudent(model);
            return Redirect("/Students/Index");

        }
        [HttpPost]
        public async Task<IActionResult> UpdateStudent(StudentsModel model)
        {
            await _studentProcessManager.updateStudent(model);
            return Redirect("/Students/Index");
        }
    }
}
