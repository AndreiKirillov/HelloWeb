using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloWeb.Models;

namespace HelloWeb.Data
{
    public class MvcStudentContext : DbContext
    {
        public MvcStudentContext(DbContextOptions<MvcStudentContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}
