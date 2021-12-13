using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public String HeaderLogo { get; set; }

        [NotMapped]
        public IFormFile HeaderLogoFile { get; set; }

        [MaxLength(250)]
        public String HeaderLogo2 { get; set; }

        [NotMapped]
        public IFormFile HeaderLogo2File { get; set; }

        [MaxLength(250)]
        public String FooterLogo { get; set; }

        [NotMapped]
        public IFormFile FooterLogoFile { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string Phone1 { get; set; }
        
        [MaxLength(50)]
        public string Phone2 { get; set; }

        [MaxLength(50)]
        public string Email1 { get; set; }

        [MaxLength(50)]
        public string Email2 { get; set; }

        [MaxLength(50)]
        public string CopyrightTitle { get; set; }

        [MaxLength(200)]
        public string CopyrightLink { get; set; }

        [MaxLength(500)]
        public string FooterText { get; set; }


    }
}
