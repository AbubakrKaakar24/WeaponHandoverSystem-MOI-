using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Core.Domain.Entities;
using WeaponHandoverSystem.Core.DTOs.officer;
namespace WeaponHandoverSystem.Core.ServiceContracts
{
    public interface IOfficerService
    {
        public Task<OfficerAddDTo> AddOfficer(OfficerAddDTo officerAddDTo);
        public Task<OfficerResponseDTo> GetOfficerById(int? officerId);

        public Task<IEnumerable<OfficerResponseDTo>> GetOfficerList();

        public Task<OfficerResponseDTo> DeleteOfficer(int? officerId);

    }
}
