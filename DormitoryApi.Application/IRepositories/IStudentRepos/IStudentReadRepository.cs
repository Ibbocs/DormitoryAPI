﻿using DormitoryApi.Domain.Entities.Context;
using RestaurantFinalAPI.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.IRepositories.IStudentRepos
{
    public interface IStudentReadRepository : IRepositoryRead<Student>
    {
    }

    public interface IStudentWriteRepository : IRepositoryWrite<Student>
    {
    }
}
