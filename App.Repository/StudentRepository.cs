using App.Data.Models;
using App.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        private readonly AppDbContext _DbContext;
        public StudentRepository(AppDbContext context) : base(context)
        {
            _DbContext = context;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _DbContext.Students.ToList();
        }
    }
}
