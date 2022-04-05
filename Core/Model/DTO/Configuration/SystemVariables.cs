using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.DTO.Configuration {
    public class SystemVariables {
        public DBConfig MySQL { get; set; }
        public DBConfig SQLite { get; set; }
        public DBConfig MongoDB { get; set; }
    }
    public class DBConfig {
        public string server { get; set; }
        public string port { get; set; }
        public string database { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
