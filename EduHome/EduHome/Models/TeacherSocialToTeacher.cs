using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TeacherSocialToTeacher
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }


        [ForeignKey("TeacherSocial")]
        public int TeacherSocialId { get; set; }

        public TeacherSocial TeacherSocial { get; set; }


    }
}
