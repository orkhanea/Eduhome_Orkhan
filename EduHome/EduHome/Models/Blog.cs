using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Text { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public DateTime CreatedDate { get; set; }


        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }
        public BlogCategory BlogCategory { get; set; }

        public List<BlogTagToBlog> BlogTagToBlog { get; set; }


    }
}
