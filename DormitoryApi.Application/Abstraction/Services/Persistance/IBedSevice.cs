using DormitoryApi.Application.DTOs.BedDTOs;
using DormitoryApi.Application.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.Abstraction.Services.Persistance
{
    public interface IBedSevice
    {
        Task<Response<BedCreateDTO>> AddBed(BedCreateDTO model);
        Task<Response<bool>> DeleteBed(string Id);
        Task<Response<bool>> UpdateBed(BedUpdateDTO model);

        Task<Response<List<BedGetDTO>>> GetAllBed();
        Task<Response<BedGetDTO>> GetBedById(string Id);
        Task<Response<List<BedGetDTO>>> GetAllBedByUserId(string Id);
    }
}
