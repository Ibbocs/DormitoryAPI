﻿using DormitoryApi.Application.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.Abstraction.Services.Persistance
{
    public interface IRoleService
    {
        Task<Response<object>> GetAllRoles();
        Task<Response<object>> GetRoleById(string id);
        Task<Response<bool>> CreateRole(string name);
        Task<Response<bool>> DeleteRole(string id);
        Task<Response<bool>> UpdateRole(string id, string name);
    }
}
