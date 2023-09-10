using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.Entities.Context
{
    public class Dormitory
    {
        public int DormitoryID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public int StaffID { get; set; }

        public Staff DormitoryManager { get; set; }
        public List<Student> Students { get; set; }
        public List<Room> Rooms { get; set; }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int DormitoryID { get; set; }
        public int RoomID { get; set; }

        public Dormitory Dormitory { get; set; }
        public Room Room { get; set; }
    }

    // Yatak (Beds) Tablosu
    public class Bed
    {
        public int BedID { get; set; }
        public int DormitoryID { get; set; }
        public bool Occupied { get; set; }

        public Dormitory Dormitory { get; set; }
    }

    // Personel (Staff) Tablosu
    public class Staff
    {
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int DormitoryID { get; set; }

        public Dormitory Dormitory { get; set; }
    }

    // Oda (Rooms) Tablosu
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public int DormitoryID { get; set; }

        public Dormitory Dormitory { get; set; }
    }

    // Fakülteler (Faculties) Tablosu
    public class Faculty
    {
        public int FacultyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    // Katlar (Floors) Tablosu
    public class Floor
    {
        public int FloorID { get; set; }
        public string FloorNumber { get; set; }
        public string Description { get; set; }
        public int DormitoryID { get; set; }

        public Dormitory Dormitory { get; set; }
    }

    
    
}
