using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Models
{
    public class BlogCategory:BaseEntity
    {
        /// <summary>
        /// my article's category
        /// </summary>
        public string CategoryName { get; set; }
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
