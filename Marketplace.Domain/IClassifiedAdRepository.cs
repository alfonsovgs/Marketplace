﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Domain
{
    public interface IClassifiedAdRepository
    {
        Task<ClassifiedAd> Load(ClassifiedAdId id);
        Task Add(ClassifiedAd entity);
        Task<bool> Exists(ClassifiedAdId id);
    }
}
