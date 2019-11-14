using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    public class Article:BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required,Column(TypeName = "ntext")]
        public string Content { get; set; }
        /// <summary>
        /// have a look at who publish this article
        /// </summary>
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }
        /// <summary>
        /// the number finding the article is good
        /// </summary>
        public int GoodCount { get; set; }
        /// <summary>
        /// the number finding the article is good
        /// </summary>
        public int BadCount { get; set; }
    }
}

