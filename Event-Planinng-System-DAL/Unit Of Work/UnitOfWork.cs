using Event_Planinng_System_DAL.Models;
using Event_Planinng_System_DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Planinng_System_DAL.Unit_Of_Work
{
    public class UnitOfWork
    {
        GenericRepo<User> userRepository;
        GenericRepo<Attendance> attendanceRepository;
        GenericRepo<Comments> commentsRepo;
        GenericRepo<Emails> emailRepo;
        GenericRepo<Event> eventRepo;
        GenericRepo<EventImages> eventimagesRepo;
        GenericRepo<Invite> inviteRepo;
        GenericRepo<Role> roleRepo;
        GenericRepo<ToDoList> todolistRepo;
        GenericRepo<UserRole> userrroleRepo;

        private readonly dbContext db;
        public UnitOfWork(dbContext _db)
        {
            db = _db;
        }

        public GenericRepo<User> UserRepo
        {
            get => userRepository ??= new GenericRepo<User>(db);              
        }
        public GenericRepo<Attendance> AttendanceRepo
        {
            get => attendanceRepository ??= new GenericRepo<Attendance>(db);
        }
        public GenericRepo<Comments> CommentsRepo
        {
            get => commentsRepo ??= new GenericRepo<Comments>(db);
        }
        public GenericRepo<Emails> EmailsRepo
        {
            get => emailRepo ??= new GenericRepo<Emails>(db);
        }
        public GenericRepo<Event> EventRepo
        {
            get => eventRepo ??= new GenericRepo<Event>(db);
        }
        public GenericRepo<EventImages> EventImagesRepo
        {
            get => eventimagesRepo ??= new GenericRepo<EventImages>(db);
        }
        public GenericRepo<Invite> InviteRepo
        {
            get => inviteRepo ??= new GenericRepo<Invite>(db);
        }
        public GenericRepo<Role> RoleRepo
        {
            get => roleRepo ??= new GenericRepo<Role>(db);
        }
        public GenericRepo<ToDoList> ToDoListRepo
        {
            get => todolistRepo ??= new GenericRepo<ToDoList>(db);
        }
        public GenericRepo<UserRole> UserRoleRepo
        {
            get => userrroleRepo ??= new GenericRepo<UserRole>(db);
        }

        public void save()
        {
            db.SaveChanges();
        }
    }
}
