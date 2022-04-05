using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DTO {
    public class QueryResult<T> {
        public IEnumerable<T> resultAsObject { get; set; }
        public string resultAsString { get; set; }
    }
}
