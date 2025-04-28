using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponHandoverSystem.Core.Domain.RepositoryContracts.Base
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IWeaponHandoverRepository WeaponHandover { get; }
        IWeaponRepository Weapon { get; }
        IOfficerRepository Officer { get; }

        Task SaveChanges(CancellationToken cancellationToken);
        
    }
}
