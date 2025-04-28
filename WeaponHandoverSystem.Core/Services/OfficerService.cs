using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Core.DTOs.officer;
using WeaponHandoverSystem.Core.ServiceContracts;
using WeaponHandoverSystem.Core.Domain.RepositoryContracts.Base;
namespace WeaponHandoverSystem.Core.Services
{
    public class OfficerService : IOfficerService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OfficerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<OfficerAddDTo> AddOfficer(OfficerAddDTo officerAddDTo)
        {
          await  _unitOfWork.Officer.Add(officerAddDTo.toOfficer());
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return officerAddDTo;
        }

        public async Task<OfficerResponseDTo> DeleteOfficer(int? officerId)
        {
            var officer = await _unitOfWork.Officer.GetById(officerId.Value);
            if (officer == null)
            {
                return null;
            }
            await _unitOfWork.Officer.Remove(officer);
            await _unitOfWork.SaveChanges(CancellationToken.None);
            return officer.ToOfficerResponseDTo();

        }

        public async Task<OfficerResponseDTo> GetOfficerById(int? officerId)
        {
          var officer= await _unitOfWork.Officer.GetById(officerId.Value);
            if (officer == null)
            {
                return null;
            }
            return officer.ToOfficerResponseDTo();
        }

        public async Task<IEnumerable<OfficerResponseDTo>> GetOfficerList()
        {
           var officers= await _unitOfWork.Officer.GetAll();
            return officers.Select(x => x.ToOfficerResponseDTo());
        }
    }
}
