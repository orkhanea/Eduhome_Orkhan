using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseCategory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string CategoryName { get; set; }

        public List<Course> Course { get; set; }

        


    }
}
