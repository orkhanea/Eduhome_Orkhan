using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        public DateTime Time { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(2000)]
        public string Text { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [ForeignKey("EventCategory")]
        public int EventCategoryId { get; set; }

        public EventCategory EventCategory { get; set; }

        public List<EventTagToEvent> EventTagToEvent { get; set; }
        public List<SpeakerToEvent> SpeakerToEvent { get; set; }


    }
}
