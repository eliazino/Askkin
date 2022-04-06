using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Entities {
    public class Users {
        public long id { get; protected set; }
        public string email { get; protected set; }
        public string username { get; protected set; }
        public string password { get; protected set; }
        public string avatar { get; protected set; }
        public string fullname { get; protected set; }
        public long lastlogin { get; protected set; }
    }
}
