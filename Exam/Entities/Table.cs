using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam.Entities
{
    public partial class Table : BaseEntity
    {
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}