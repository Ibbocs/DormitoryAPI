﻿using DormitoryApi.Domain.Entities.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryApi.Domain.Entities.Autho
{
    public class AppUser : IdentityUser<string>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndTime { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Staff> Staffs { get; set; }
    }

    public class AppRole : IdentityRole<string>
    {
    }

    public class AppUserRole : IdentityUserRole<string>
    {
    }
}
