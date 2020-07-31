using App.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Repository.Contracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
    }
}
