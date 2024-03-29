﻿using HC_DOMAIN.Entities.Concrete;
using HC_DOMAIN.Repositories.EntityRepository;
using HC_INFRASTRUCTURE.Context;
using HC_INFRASTRUCTURE.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_INFRASTRUCTURE.Repositories.Concrete
{
    public class AppUserRoleRepository: GenericRepository<AppUserRole>, IRoleRepository
    {
        public AppUserRoleRepository(HC_DbContext db) : base(db)
        {

        }
    }
}
