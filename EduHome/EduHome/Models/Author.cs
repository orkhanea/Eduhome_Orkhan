using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Surname { get; set; }
        
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(250)]
        public string Password { get; set; }

        [MaxLength(50)]
        public string UserName { get; set; }

        public List<Blog> Blog { get; set; }


    }
}
