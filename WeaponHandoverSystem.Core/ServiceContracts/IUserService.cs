using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Core.DTOs.user;
namespace WeaponHandoverSystem.Core.ServiceContracts
{
    public  interface IUserService
    {
        public Task<UserAddDto> AddUser(UserAddDto userAddDto);
        public Task<UserResponseDTo> GetUserById(int? userId);

        public Task<IEnumerable<UserResponseDTo>> GetUserList();

        public Task<UserResponseDTo> DeleteUser(int? UserId);

    }
}
