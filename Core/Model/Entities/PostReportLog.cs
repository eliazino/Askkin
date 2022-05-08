using Core.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Entities {
    public class PostReportLog {
        public long id { get; protected set; }
        public ReportClass reportClass { get; protected set; }
        public long reporterID { get; protected set; }
        public string report { get; protected set; }
        public long dateReported { get; protected set; }
        public ReportStatus status { get; protected set; }
        public long spaceID { get; protected set; }
        public long postID { get; protected set; }
    }
}
