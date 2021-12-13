using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class VideoTour
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(300)]
        public string VideoLink { get; set; }

        [MaxLength(250)]
        public String VideoImage { get; set; }

        [NotMapped]
        public IFormFile VideoImageFile { get; set; }


    }
}
