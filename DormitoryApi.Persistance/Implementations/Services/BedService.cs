using AutoMapper;
using DormitoryApi.Application.Abstraction.Services.Persistance;
using DormitoryApi.Application.DTOs.BedDTOs;
using DormitoryApi.Application.IRepositories.IBedRepos;
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
}
