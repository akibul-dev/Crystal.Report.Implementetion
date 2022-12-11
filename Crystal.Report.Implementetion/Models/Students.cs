using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystal.Report.Implementetion.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string StudentID { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }


    }
}
