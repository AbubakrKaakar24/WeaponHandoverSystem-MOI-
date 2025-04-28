using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponHandoverSystem.Core.DTOs.weaponHandover
{
    public class WeaponHandoverResponseDTo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime InDate { get; set; }
        public DateTime? OutDate { get; set; }
        public string OfficerBadgeNo { get; set; } // FK to Officer's BadgeNo
    }

    public static class WeaponHandoverExtensions
    {
        public static WeaponHandoverResponseDTo ToWeaponHandoverResponseDTo(this WeaponHandover weaponHandover)
        {
            return new WeaponHandoverResponseDTo
            {
                Id = weaponHandover.Id,
                Name = weaponHandover.Name,
                Type = weaponHandover.Type,
                InDate = weaponHandover.InDate,
                OutDate = weaponHandover.OutDate,
                OfficerBadgeNo = weaponHandover.OfficerBadgeNo
            };
        }
    }
}