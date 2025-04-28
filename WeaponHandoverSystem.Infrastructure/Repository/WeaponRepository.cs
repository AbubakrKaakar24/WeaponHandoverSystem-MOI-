using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Infrastructure.Repository.Base;
using WeaponHandoverSystem.Core.Domain.Entities;
using WeaponHandoverSystem.Core.Domain.RepositoryContracts;
using WeaponHandoverSystem.Infrastructure.dbContext;
namespace WeaponHandoverSystem.Infrastructure.Repository
{
    public  class WeaponRepository: GenericRepository<Weapon>, IWeaponRepository
    {
        private readonly AppDbContext _dbContext;
        public WeaponRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
    
}
