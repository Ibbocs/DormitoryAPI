using DormitoryApi.Domain.Entities.Autho;
using DormitoryApi.Domain.Entities.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Domain.Entities.Context
{
    public class Dormitory : BaseEntity
    {
        //public int DormitoryID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }

        public ICollection<Staff> Staff { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public List<Student> Students { get; set; }
        public List<Floor> Floors { get; set; }
    }

    public class Student : BaseEntity
    {
        //public int StudentID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Gender { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public string Email { get; set; }
        //public string PhoneNumber { get; set; }

        public AppUser User { get; set; }
        public string UserId { get; set; }

        public Dormitory Dormitory { get; set; }
        public Guid DormitoryID { get; set; }

        public Room Room { get; set; }
        public Guid RoomID { get; set; }

        public Faculty Faculty { get; set; }
        public Guid FacultyId { get; set; }


    }

    // Yatak (Beds) Tablosu
    public class Bed : BaseEntity
    {
        //public int BedID { get; set; }
        public bool Occupied { get; set; }

        //public Dormitory Dormitory { get; set; }
        //public Guid DormitoryID { get; set; }

        public Room Room { get; set; }
        public Guid RoomId { get; set; }

    }

    // Personel (Staff) Tablosu
    public class Staff : BaseEntity
    {
        //public int StaffID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public string Position { get; set; }

        public AppUser User { get; set; }
        public string UserId { get; set; }

        public Dormitory Dormitory { get; set; }
        public Guid DormitoryID { get; set; }
    }

    // Oda (Rooms) Tablosu
    public class Room : BaseEntity
    {
        //public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }

        public Guid DormitoryID { get; set; }
        public Dormitory Dormitory { get; set; }

        public Floor Floor { get; set; }
        public Guid FloorId { get; set; }

        public ICollection<Bed> Beds { get; set; }
        public ICollection<Student> Students { get; set; }
    }

    // Fakülteler (Faculties) Tablosu
    public class Faculty : BaseEntity
    {
        //public int FacultyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }
    }

    // Katlar (Floors) Tablosu
    public class Floor : BaseEntity
    {
        //public int FloorID { get; set; }
        public string FloorNumber { get; set; }
        public string Description { get; set; }

        public Guid DormitoryID { get; set; }
        public Dormitory Dormitory { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }

}
