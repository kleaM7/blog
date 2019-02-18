using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Klea.Models
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        public int OwnerID { get; set; }
        public int BlogPostId { get; set; }


        public Comment ()
        {
        }

        public Comment(int _ID, string _Content, DateTime dt)
        {
            ID = _ID;
            Content = _Content;
            PublicationDate = dt;
        }

        public string RenderContent()
        {
            return Content;
        }
    }
}
