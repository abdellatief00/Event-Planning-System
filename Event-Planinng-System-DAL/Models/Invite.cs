using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planinng_System_DAL.Models
{
    public class Invite
    {
        [ForeignKey("EventNavigation")]
        public int EventId { get; set; }
        [ForeignKey("UserNavigation")]
        public int UserId { get; set; }
        public bool IsSent { get; set; }
        public Event EventNavigation { get; set; }
        public User UserNavigation { get; set; }
    }
}
