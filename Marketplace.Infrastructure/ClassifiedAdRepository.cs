﻿using Marketplace.Domain;
using Raven.Client.Documents.Session;
using System;
using System.Threading.Tasks;

namespace Marketplace.Infrastructure
{
    public class ClassifiedAdRepository : IClassifiedAdRepository
    {
        private readonly IAsyncDocumentSession _session;

        public ClassifiedAdRepository(IAsyncDocumentSession session) => _session = session;

        public Task<ClassifiedAd> Load(ClassifiedAdId id)
            => _session.LoadAsync<ClassifiedAd>(EntityId(id));

        public Task Add(ClassifiedAd entity)
            => _session.StoreAsync(entity, EntityId(entity.Id));

        public Task<bool> Exists(ClassifiedAdId id)
            => _session.Advanced.ExistsAsync(EntityId(id));

        private static string EntityId(ClassifiedAdId id)
            => $"ClassifiedAd/{id}";
    }
}
