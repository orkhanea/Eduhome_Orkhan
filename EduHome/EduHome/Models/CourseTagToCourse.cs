using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseTagToCourse
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CourseTag")]
        public int CourseTagId { get; set; }
        public CourseTag CourseTag { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

       


    }
}
