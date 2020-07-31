using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using App.Repository;
using App.Repository.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepository.Controllers
{
    public class AppController : Controller
    {
        private readonly UnitOfWork _UnitOfWork;
        public AppController(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork as UnitOfWork;
        }
        public IActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.Students = _UnitOfWork.StudentRepository.GetAllStudents();
            return View("StudentList", model);
        }
    }
}
