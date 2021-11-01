using Microsoft.AspNetCore.Mvc;
using postGres.Services.Process_Manager;
using postGres.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Controllers
{
    public class TeachersController : Controller
    {
        private readonly TeacherPM _teacherProcessManager;

        public TeachersController(TeacherPM teacherProcessManager)
        {
            _teacherProcessManager = teacherProcessManager;

        }
        public async Task<IActionResult> Index()
        {
            List<TeachersModel> teachers = await _teacherProcessManager.getTeacher();
            return View(teachers);
        }

        [HttpPost]
        public async Task<IActionResult> addTeacher(TeachersModel model)
        {
            await _teacherProcessManager.insertTeacher(model);
            return Redirect("/Teachers/Index");
        }

        [HttpPost]
        public async Task<IActionResult> AlterTeacher(TeachersModel model, string Delete)
        {
            if (string.IsNullOrEmpty(Delete))
                return View(model);
            await _teacherProcessManager.deleteTeacher(model);
            return Redirect("/Teachers/Index");

        }
        [HttpPost]
        public async Task<IActionResult> UpdateTeacher(TeachersModel model)
        {
            await _teacherProcessManager.updateTeacher(model);
            return Redirect("/Teachers/Index");
        }
    }
}
