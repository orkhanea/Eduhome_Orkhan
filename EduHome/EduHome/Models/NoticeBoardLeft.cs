﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class NoticeBoardLeft
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }


    }
}
