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
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CreatorNavigation")]
        public int CreatorId { get; set; }
        [StringLength(50, MinimumLength =3)]
        public string Name { get; set; }
        [MinLength(3)]
        public string? Description { get; set; }
        [StringLength(500, MinimumLength =3)]
        public string Location { get; set; }
        [Range(0, int.MaxValue)]
        public int AttendanceNumber { get; set; }
        [StringLength(5000, MinimumLength =3)]
        public string? GoogleMapsLocation { get; set; }
        [Range(0, int.MaxValue)]
        public int Budget { get; set; }
        public EventType EventType { get; set; }
        public DateTime EventDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateOfCreation { get; set;}
        public User CreatorNavigation { get; set; }
        public virtual List<Invite> PeopleInvitesNavigation { get; set; } = new List<Invite>();
        public virtual List<ToDoList> ToDoListsNavigation { get; set; } = new List<ToDoList>();   
        public virtual List<Emails> EventEmailsNavigation { get; set; } = new List<Emails>();   

    }
}
