using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Subject { get; set; }

        [MaxLength(2000)]
        public string MessageContext { get; set; }

        public DateTime CreatedDate { get; set; }


    }
}
