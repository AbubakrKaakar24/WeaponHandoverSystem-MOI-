﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponHandoverSystem.Core.Domain.RepositoryContracts;
using WeaponHandoverSystem.Core.Domain.RepositoryContracts.Base;
using WeaponHandoverSystem.Infrastructure.dbContext;
namespace WeaponHandoverSystem.Infrastructure.Repository.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            User = new UserRepository(_dbContext);
            Weapon = new WeaponRepository(_dbContext);
            Officer = new OfficerRepository(_dbContext);
            WeaponHandover = new WeaponHandoverRepository(_dbContext);

        }
        public IUserRepository User { get; private set; }

        public IWeaponHandoverRepository WeaponHandover { get; private set; }

        public IWeaponRepository Weapon { get; private set; }

        public IOfficerRepository Officer { get; private set; }

        public Task SaveChanges(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
