﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponHandoverSystem.Core.Domain.Entities
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime InDate { get; set; }
        public DateTime? OutDate { get; set; }
        public string OfficerBadgeNo { get; set; } // FK to Officer's BadgeNo

        // Navigation property
        public Officer Officer { get; set; }
    }

}
