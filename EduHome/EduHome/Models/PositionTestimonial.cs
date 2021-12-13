using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class PositionTestimonial
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Text { get; set; }

        [MaxLength(30)]
        public string Position { get; set; }

        [MaxLength(250)]
        public String Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }



    }
}
