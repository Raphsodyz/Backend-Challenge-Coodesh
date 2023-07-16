﻿using Data.Context;
using Data.Interface;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UpdateLogRepository : GenericRepository<UpdateLog>, IUpdateLogRepository
    {
        public UpdateLogRepository(FutureSpaceContext context):base(context)
        {
            
        }
    }
}
