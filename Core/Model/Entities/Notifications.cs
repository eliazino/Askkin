using Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Entities {
    public class Notifications {
        public long id { get; protected set; }
        public NotificationType type { get; protected set; }
        public string comment { get; protected set; }
        public int status { get; protected set; }
        public long date { get; protected set; }
    }
}
