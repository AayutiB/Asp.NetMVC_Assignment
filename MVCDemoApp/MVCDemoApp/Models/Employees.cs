using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public class Employees
    {
        [Required(ErrorMessage ="empid is compulsry")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="enter 4 digit no")]
        public int? EmpId { get; set; }

        [Required(ErrorMessage = "empname is compulsry")]
        [StringLength(10,ErrorMessage ="max emp lenghtis 10")]
        public string EmpName { get; set; }


        [Required(ErrorMessage = "salary is compulsry")]
        public double Salary { get; set; }


    }
}
