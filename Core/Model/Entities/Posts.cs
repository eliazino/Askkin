using Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Entities {
    public class Posts {
        public long id { get; protected set; }
        public long parent { get; protected set; }
        public long userID { get; protected set; }
        public long spaceID { get; protected set; }
        public string content { get; protected set; }
        public string title { get; protected set; }
        public int heirarchy { get; protected set; } = 0;
        public long transDate { get; protected set; }
        public PostStatus status { get; protected set; }
        public string APIKey { get; protected set; }
        public bool postIsVideo { get; protected set; }
        public bool threadClosed { get; protected set; }
        public string closingRemarks { get; protected set; }
    }
}
