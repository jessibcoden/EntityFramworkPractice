using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice.Models
{
    public class Student
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName {get; set;}
        public virtual int ClassId { get; set; }
        public virtual bool Passed {get; set;}

    }

}
