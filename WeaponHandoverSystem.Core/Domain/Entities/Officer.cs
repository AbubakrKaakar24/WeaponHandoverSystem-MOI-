﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponHandoverSystem.Core.Domain.Entities
{
    public class Officer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Base { get; set; } // Base where the officer is stationed
        public string Moeenyat { get; set; } // Moeenyat where the officer is stationed
        public string Directorate { get; set; } // Directorate where the officer is stationed
        public string Administration { get; set; } // Administration where the officer is stationed
        public string BadgeNo { get; set; }
        
        
    }

}
