﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Core.Domain.Entities;
namespace WeaponHandoverSystem.Core.DTOs.weapon
{
    public  class WeaponResponseDTo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime InDate { get; set; }
        public DateTime? OutDate { get; set; }
        public string OfficerBadgeNo { get; set; } // FK to Officer's BadgeNo

    }
    public static class WeaponExtensions
    {
        public static WeaponResponseDTo ToWeaponResponseDTo(this Weapon weapon)
        {
            return new WeaponResponseDTo
            {
                Id = weapon.Id,
                Name = weapon.Name,
                Type = weapon.Type,
                InDate = weapon.InDate,
                OutDate = weapon.OutDate,
                OfficerBadgeNo = weapon.OfficerBadgeNo
            };
        }
    }
}
