using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Entities {
    public class Spaces {
        public long id { get; protected set; }
        public string name { get; protected set; }
        public string description { get; protected set; }
        public long dateCreated { get; protected set; }
        public string avatar { get; protected set; }
        public bool postIsPrivate { get; protected set; }
        public bool autoAdmitance { get; protected set; }
        public bool postPublishIsAuto { get; protected set; }
        public long memberLimit { get; protected set; }
    }
}
