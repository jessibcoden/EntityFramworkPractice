using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice.Models
{
    public class Class
    {
        public virtual int Id { get; set; }
        public virtual string ClassName { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual string Technology { get; set; }
        public virtual string Teacher {get; set;}
    }
}