using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class TeacherSkill
    {
        [Key]
        public int Id { get; set; }

        public byte Language { get; set; }

        public byte Design { get; set; }

        public byte TeamLeader { get; set; }

        public byte Inovation { get; set; }

        public byte Development { get; set; }

        public byte Communication { get; set; }

        public Teacher Teacher { get; set; }

       


    }
}
