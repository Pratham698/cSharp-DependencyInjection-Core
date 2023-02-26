using FirstCoreMVCWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstCoreMVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        //public JsonResult Index()
        //{
        //    TestStudentRepository repository = new TestStudentRepository();
        //    List<Student> allStudentDetails = repository.GetAllStudent();
        //    return Json(allStudentDetails);
        //}
        //public JsonResult GetStudentDetails(int Id)
        //{
        //    TestStudentRepository repository = new TestStudentRepository();
        //    Student studentDetails = repository.GetStudentById(Id);
        //    return Json(studentDetails);
        //}


        //Through Constructor Injection
        private readonly IStudentRepository _repository = null;
        //Initialize the variable through constructor
        public HomeController(IStudentRepository repository)
        {
            _repository = repository;
        }
        public JsonResult Index()
        {
            List<Student> allStudentDetails = _repository.GetAllStudent();
            return Json(allStudentDetails);
        }
        public JsonResult GetStudentDetails(int Id)
        {
            Student studentDetails = _repository.GetStudentById(Id);
            return Json(studentDetails);
        }

        //Action Method Injection
        public HomeController()
        {
        }
        public JsonResult Index([FromServices] IStudentRepository repository)
        {
            List<Student> allStudentDetails = repository.GetAllStudent();
            return Json(allStudentDetails);
        }
    }
}
