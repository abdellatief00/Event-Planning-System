using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planinng_System_DAL.Models
{
    public class Comments
    {
        [ForeignKey("UserNavigation")]
        public int UserId { get; set; }
        [ForeignKey("EventNavigation")]
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateOnly CommentDate { get; set; }
        public User UserNavigation { get; set; }
        public Event EventNavigation { get; set; }
    }
}
