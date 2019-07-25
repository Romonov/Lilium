﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lilium.Net.Event
{
    public interface IServerListener
    {
        void SessionAdded(SessionAddedEvent paramEvent);
        void SessionRemoved(SessionRemovedEvent paramEvent);
    }
}
