using AutoMapper;
using DormitoryApi.Application.DTOs.BedDTOs;
using DormitoryApi.Application.DTOs.DormitoryDTOs;
using DormitoryApi.Application.DTOs.FacultyDTOs;
using DormitoryApi.Application.DTOs.FloorDTOs;
using DormitoryApi.Application.DTOs.RoomDTOs;
using DormitoryApi.Application.DTOs.StaffDTOs;
using DormitoryApi.Application.DTOs.StudentDTOs;
using DormitoryApi.Domain.Entities.Autho;
using DormitoryApi.Domain.Entities.Context;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.AutoMapper
{
    public class MyProfile:Profile
    {
        public MyProfile()
        {
            CreateMap<Bed, BedGetDTO>().ReverseMap();
            //CreateMap<AppUser, UserGetDTO>();
            CreateMap<Dormitory, DormitoryGetDTO>().ReverseMap();
            CreateMap<Faculty, FacultyGetDTO>().ReverseMap();
            CreateMap<Room, RoomGetDTO>().ReverseMap();
            CreateMap<Staff, StaffGetDTO>().ReverseMap();
            CreateMap<Student, StudentGetDTO>().ReverseMap();
            CreateMap<Floor, FloorGetDTO>().ReverseMap();
                //.ForMember(dest => dest.FacultyName, opt => opt.MapFrom(src => src.Faculty.CategoryName));
        }
    }
}
