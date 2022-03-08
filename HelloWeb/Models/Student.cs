using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelloWeb.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Display(Name = "BirthDay")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}
