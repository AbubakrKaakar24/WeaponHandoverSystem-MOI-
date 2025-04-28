using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Core.Domain.Entities;
using WeaponHandoverSystem.Core.Domain.RepositoryContracts.Base;
namespace WeaponHandoverSystem.Core.Domain.RepositoryContracts
{
    public  interface IWeaponRepository : IGenericRepository<Weapon>
    {
    }
}
