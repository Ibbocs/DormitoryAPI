using AutoMapper;
using DormitoryApi.Application.Abstraction.Services.Persistance;
using DormitoryApi.Application.DTOs.BedDTOs;
using DormitoryApi.Application.DTOs.DormitoryDTOs;
using DormitoryApi.Application.DTOs.FacultyDTOs;
using DormitoryApi.Application.DTOs.FloorDTOs;
using DormitoryApi.Application.DTOs.RoomDTOs;
using DormitoryApi.Application.DTOs.StaffDTOs;
using DormitoryApi.Application.DTOs.StudentDTOs;
using DormitoryApi.Application.IRepositories.IBedRepos;
using DormitoryApi.Application.IRepositories.IDormitoryRepos;
using DormitoryApi.Application.IRepositories.IFacultyRepos;
using DormitoryApi.Application.IRepositories.IFloorRepos;
using DormitoryApi.Application.IRepositories.IRoomRepos;
using DormitoryApi.Application.IRepositories.IStaffRepos;
using DormitoryApi.Application.IRepositories.IStudentRepos;
using DormitoryApi.Application.Models.ResponseModel;
using DormitoryApi.Application.UnitOfWork;
using DormitoryApi.Domain.Entities.Autho;
using DormitoryApi.Domain.Entities.Context;
using DormitoryApi.Persistance.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Persistance.Implementations.Services
{
    public class BedService : IBedSevice
    {
        private readonly IBedReadRepository bedRead;
        private readonly IBedWriteRepository bedWrite;
        private readonly IUnitOfWork<Bed> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public BedService(IBedReadRepository _bedRead, IBedWriteRepository _bedWrite, IUnitOfWork<Bed> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.bedRead = _bedRead;
            this.bedWrite = _bedWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }


        public Task<Response<BedCreateDTO>> AddBed(BedCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteBed(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<BedGetDTO>>> GetAllBed()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<BedGetDTO>>> GetAllBedByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<BedGetDTO>> GetBedById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateBed(BedUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }

    public class DormitoryService : IDormitorySevice
    {
        private readonly IDormitoryReadRepository dormitoryRead;
        private readonly IDormitoryWriteRepository dormitoryWrite;
        private readonly IUnitOfWork<Dormitory> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public DormitoryService(IDormitoryReadRepository _dormitoryRead, IDormitoryWriteRepository _dormitoryWrite, IUnitOfWork<Dormitory> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.dormitoryRead = _dormitoryRead;
            this.dormitoryWrite = _dormitoryWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<DormitoryCreateDTO>> AddDormitory(DormitoryCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteDormitory(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<DormitoryGetDTO>>> GetAllDormitory()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<DormitoryGetDTO>>> GetAllDormitoryByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<DormitoryGetDTO>> GetDormitoryById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateDormitory(DormitoryUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }

    public class FacultyService : IFacultySevice
    {
        private readonly IFacultyReadRepository facultyRead;
        private readonly IFacultyWriteRepository facultyWrite;
        private readonly IUnitOfWork<Faculty> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public FacultyService(IFacultyReadRepository _facultyRead, IFacultyWriteRepository _facultyWrite, IUnitOfWork<Faculty> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.facultyRead = _facultyRead;
            this.facultyWrite = _facultyWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<FacultyCreateDTO>> AddFaculty(FacultyCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteFaculty(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<FacultyGetDTO>>> GetAllFaculty()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<FacultyGetDTO>>> GetAllFacultyByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<FacultyGetDTO>> GetFacultyById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateFaculty(FacultyUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }

    public class FloorService : IFloorSevice
    {
        private readonly IFloorReadRepository floorRead;
        private readonly IFloorWriteRepository floorWrite;
        private readonly IUnitOfWork<Floor> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public FloorService(IFloorReadRepository _floorRead, IFloorWriteRepository _floorWrite, IUnitOfWork<Floor> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.floorRead = _floorRead;
            this.floorWrite = _floorWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<FloorCreateDTO>> AddFloor(FloorCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteFloor(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<FloorGetDTO>>> GetAllFloor()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<FloorGetDTO>>> GetAllFloorByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<FloorGetDTO>> GetFloorById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateFloor(FloorUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }

    public class RoomService : IRoomSevice
    {
        private readonly IRoomReadRepository roomRead;
        private readonly IRoomWriteRepository roomWrite;
        private readonly IUnitOfWork<Room> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public RoomService(IRoomReadRepository _roomRead, IRoomWriteRepository _roomWrite, IUnitOfWork<Room> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.roomRead = _roomRead;
            this.roomWrite = _roomWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<RoomCreateDTO>> AddRoom(RoomCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteRoom(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<RoomGetDTO>>> GetAllRoom()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<RoomGetDTO>>> GetAllRoomByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<RoomGetDTO>> GetRoomById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateRoom(RoomUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }

    public class StaffService : IStaffSevice
    {
        private readonly IStaffReadRepository staffRead;
        private readonly IStaffWriteRepository staffWrite;
        private readonly IUnitOfWork<Staff> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public StaffService(IStaffReadRepository _staffRead, IStaffWriteRepository _staffWrite, IUnitOfWork<Staff> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.staffRead = _staffRead;
            this.staffWrite = _staffWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<StaffCreateDTO>> AddStaff(StaffCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteStaff(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<StaffGetDTO>>> GetAllStaff()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<StaffGetDTO>>> GetAllStaffByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<StaffGetDTO>> GetStaffById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateStaff(StaffUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }

    public class StudentService : IStudentSevice
    {
        private readonly IStudentReadRepository studentRead;
        private readonly IStudentWriteRepository studentWrite;
        private readonly IUnitOfWork<Student> unitOfWork;
        private readonly IMapper mapper;
        private readonly DormitoryDbContext context;


        public StudentService(IStudentReadRepository _studentRead, IStudentWriteRepository _studentWrite, IUnitOfWork<Student> _unitOfWork, IMapper _mapper, DormitoryDbContext _context)
        {
            this.studentRead = _studentRead;
            this.studentWrite = _studentWrite;
            this.unitOfWork = _unitOfWork;
            this.mapper = _mapper;
            this.context = _context;
        }

        public Task<Response<StudentCreateDTO>> AddStudent(StudentCreateDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteStudent(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<StudentGetDTO>>> GetAllStudent()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<StudentGetDTO>>> GetAllStudentByUserId(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<StudentGetDTO>> GetStudentById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateStudent(StudentUpdateDTO model)
        {
            throw new NotImplementedException();
        }
    }
}
