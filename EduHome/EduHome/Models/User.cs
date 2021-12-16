using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class User : IdentityUser
    {

        [MaxLength(250)]
        public String Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(30)]
        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime CreatedDate { get; set; }


    }
}
