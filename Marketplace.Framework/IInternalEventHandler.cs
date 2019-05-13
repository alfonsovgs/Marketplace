using System;
using System.Collections.Generic;
using System.Text;

namespace Marketplace.Framework
{
    public interface IInternalEventHandler
    {
        void Handle(object @event);
    }
}
