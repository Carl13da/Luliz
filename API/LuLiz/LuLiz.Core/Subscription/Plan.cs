using LuLiz.Core.Enum;
using System;

namespace LuLiz.Core.Subscription
{
    public class Plan
    {
        public Profile Profile { get; set; }
        public string Description { get; set; }
        public DateTime? ExpiratedDate { get; set; }
    }
}
