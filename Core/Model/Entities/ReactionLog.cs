using Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Entities {
    public class ReactionLog {
        public long id { get; protected set; }
        public long postID { get; protected set; }
        public long spaceID { get; protected set; }
        public PostReaction reaction { get; protected set; }
        public long date { get; protected set; }
        public long userID { get; protected set; }
    }
}
