using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class EventTagToEvent
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("EventTag")]
        public int EventTagId { get; set; }
        public EventTag EventTag { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }

       


    }
}
