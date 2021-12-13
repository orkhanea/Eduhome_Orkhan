using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string CourseTitle { get; set; }

        [MaxLength(1000)]
        public string CourseText { get; set; }

        [MaxLength(500)]
        public string AboutCourse { get; set; }

        [MaxLength(500)]
        public string HowToApply { get; set; }

        [MaxLength(500)]
        public string Certification { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [ForeignKey("CourseFeature")]
        public int CourseFeatureId { get; set; }

        public CourseFeature CourseFeature { get; set; }

        [ForeignKey("CourseCategory")]
        public int CourseCategoryId { get; set; }

        public CourseCategory CourseCategory { get; set; }

        public List<CourseTagToCourse> CourseTagToCourse { get; set; }


    }
}
