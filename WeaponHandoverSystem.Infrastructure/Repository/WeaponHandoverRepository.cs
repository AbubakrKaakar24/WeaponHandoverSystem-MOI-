using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Core.Domain.Entities;
using WeaponHandoverSystem.Core.Domain.RepositoryContracts;
using WeaponHandoverSystem.Infrastructure.dbContext;
using WeaponHandoverSystem.Infrastructure.Repository.Base;
namespace WeaponHandoverSystem.Infrastructure.Repository
{
    public class WeaponHandoverRepository: GenericRepository<WeaponHandover>, IWeaponHandoverRepository
    {
        private readonly AppDbContext _dbContext;
        public WeaponHandoverRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
    
    
}
