using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Application.Models.ResponseModel
{
    public class Response<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
    }
}
