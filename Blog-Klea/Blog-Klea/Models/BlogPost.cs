using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog_Klea.Models

{
    public class BlogPost
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public string Image { get; set; }

        public string Slug { get; set; }

        public bool IsPublished { get; set; } = true;

        public DateTime PubDate { get; set; }

        public IList<Category> Categories { get; set; } = new List<Category>();

        public string cats { get; set; }

        public IList<Comment> Comments { get; set; } = new List<Comment>();

        public string getSlugUrl()
        {
            return $"/Blog/{Slug}";
        }

        public string CreateSlug()
        {
            string title1 = this.Title.ToLowerInvariant().Replace(" ", "-");
            return title1;
        }

    }




}
