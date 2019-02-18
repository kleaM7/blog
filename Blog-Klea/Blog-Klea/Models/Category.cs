using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Klea.Models
{
    public class Category
    {
        public Category()
        {

        }
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        [Required]
        public string catname { get; set; }

        public string description { get; set; }

        public Boolean ischecked { get; set; }

    }
}
