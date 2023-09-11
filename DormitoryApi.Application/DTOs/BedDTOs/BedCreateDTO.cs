using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.DTOs.BedDTOs
{
    public class BedCreateDTO
    {

    }

    public class BedGetDTO
    {
        public Guid Id { get; set; }
    }

    public class BedUpdateDTO
    {
        public string? Id { get; set; }
    }
}
