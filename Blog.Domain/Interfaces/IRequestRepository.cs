﻿using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Interfaces
{
    public interface IRequestRepository: IDisposable
    {
        Request Create(Request request);

        IEnumerable<Request> GetAllRequests();
    }
}
