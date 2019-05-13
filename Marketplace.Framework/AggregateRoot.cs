using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Marketplace.Framework
{
    public abstract class AggregateRoot<TId> where TId : Value<TId>
    {
        public TId Id { get; protected set; }
        private readonly List<object> _changes;

        protected abstract void When(object @event);
        protected abstract void EnsureValidState();

        protected void Apply(object @event)
        {
            When(@event);
            EnsureValidState();
            _changes.Add(@event);
        }

        public IEnumerable<object> GetChanges() => _changes.AsEnumerable();

        public void ClearChanges() => _changes.Clear();

    }
}
