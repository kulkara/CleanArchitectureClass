using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArch.Mvc.Controllers.Course
{
    //[Authorize]
    //This attribute will force user to login so that only vaided user will be able to see Courses
    public class CourseController : Controller
    {

        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
          CourseViewModel model1 =  _courseService.GetCourses();
            return View(model1);
        }
    }
}
