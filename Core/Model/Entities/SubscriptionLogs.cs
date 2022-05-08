using Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Entities {
    public class SubscriptionLogs {
        public long id { get; protected set; }
        public long spaceID { get; protected set; }
        public long userID { get; protected set; }
        public Privilege priviledge { get; protected set; }
        public long dateJoined { get; protected set; }
    }
}
