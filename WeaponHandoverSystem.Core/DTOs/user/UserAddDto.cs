﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Core.Domain.Entities;
namespace WeaponHandoverSystem.Core.DTOs.user
{
    public  class UserAddDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Gate { get; set; }
        public User ToUser()
        {
            return new User
            {
                Name = Name,
                LastName = LastName,
                Phone = Phone,
                Email = Email,
                Role = Role,
                Gate = Gate
            };
        }
    }
}
