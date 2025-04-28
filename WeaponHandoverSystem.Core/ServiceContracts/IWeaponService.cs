using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Core.DTOs.user;
using WeaponHandoverSystem.Core.DTOs.weapon;
namespace WeaponHandoverSystem.Core.ServiceContracts
{
    public  interface IWeaponService
    {
        public Task<WeaponAddDTo> AddWeapon(WeaponAddDTo weaponAddDTo);
        public Task<WeaponResponseDTo> GetWeaponById(int? WeaponId);

        public Task<IEnumerable<WeaponResponseDTo>> GetWeaponList();

        public Task<WeaponResponseDTo> DeleteWeapon(int? weaponId);

    }
}
