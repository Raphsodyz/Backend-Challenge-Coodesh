﻿using Data.Interface;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IJobBusiness : IBusinessBase<Launch, ILaunchRepository>
    {
        Task<bool> UpdateDataSet();
        void GenerateJobLog(bool success, string message);
    }
}
