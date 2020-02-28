using Exam.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exam
{
    public class ExamDbContext : DbContext
    {
        public ExamDbContext() : base("Exam")
        { }

        public DbSet<Table> Tables { get; set; }
    }
}