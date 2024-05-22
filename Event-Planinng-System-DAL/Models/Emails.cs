using Event_Planinng_System_DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planinng_System_DAL.Models
{
    public class Emails
    {
        [StringLength(50, MinimumLength =3)]
        public string subject { get; set; }
        [MinLength(1)]
        public string body { get; set; }
        public EmailType type { get; set; }
        [ForeignKey("EventNavigation")]
        public int EventId { get; set; }
        public virtual Event EventEmailsNavigation { get; set; }  
    }
}
