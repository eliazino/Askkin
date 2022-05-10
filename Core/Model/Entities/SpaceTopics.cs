using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Entities {
    public class SpaceTopics {
        public long id { get; protected set; }
        public long spaceID { get; protected set; }
        public long topicID { get; protected set; }
    }
}
