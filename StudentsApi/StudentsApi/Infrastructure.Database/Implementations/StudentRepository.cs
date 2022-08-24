using Core.Application.Interfaces.Repositories;
using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Database.Implementations
{
   internal class StudentRepository: Repository<Student>,IStudentRepository
    {
        public StudentRepository(StudentsDbContext context) : base(context)
        {

        }
    }
}
