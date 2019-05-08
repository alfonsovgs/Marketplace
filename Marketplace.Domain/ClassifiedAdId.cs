using System;
using System.Collections.Generic;
using System.Text;
using Marketplace.Framework;

namespace Marketplace.Domain
{
    public class ClassifiedAdId : Value<ClassifiedAdId>
    {
        private readonly Guid _value;

        public ClassifiedAdId(Guid value)
        {
            if(value == default) throw new ArgumentNullException(nameof(value), "Classified Ad id cannot be empty");
            _value = value;
        }
    }
}
