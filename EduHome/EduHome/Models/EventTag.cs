﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class EventTag
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string TagName { get; set; }

        public List<EventTagToEvent> EventTagToEvent { get; set; }

        


    }
}
