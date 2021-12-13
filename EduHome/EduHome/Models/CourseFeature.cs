using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class CourseFeature
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime StartTime { get; set; }

        [MaxLength(10)]
        public string Duration { get; set; }

        [MaxLength(10)]
        public string ClassDuration { get; set; }

        [MaxLength(20)]
        public string SkillLevel { get; set; }

        [MaxLength(100)]
        public string Language { get; set; }

        public Int16 Students { get; set; }

        [MaxLength(10)]
        public string Assesment { get; set; }

        public Course Course { get; set; }     

    }
}
