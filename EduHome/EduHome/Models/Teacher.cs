using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Surname { get; set; }

        [MaxLength(50)]
        public string Position { get; set; }

        [MaxLength(2000)]
        public string About { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(50)]
        public string Degree { get; set; }

        [MaxLength(50)]
        public string Experience { get; set; }

        [MaxLength(100)]
        public string Hobbie { get; set; }

        [MaxLength(100)]
        public string Faculity { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Skype { get; set; }

        [ForeignKey("Teacherskills")]
        public int TeacherSkillsId { get; set; }
        public TeacherSkill Teacherskills { get; set; }

        public List<TeacherSocialToTeacher> TeacherSocialToTeachers { get; set; }


    }
}
