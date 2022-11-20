using CQRS.Core.Events;

using MongoDB.Driver.Core.Operations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Common.Events
{
    public class MessageUpdateEvent : BaseEvent
    {
        public MessageUpdateEvent() : base(nameof(MessageUpdateEvent))
        { }
        public string Message { get; set; }
    }
}

