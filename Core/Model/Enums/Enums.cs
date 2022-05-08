using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model.Enums {
    public enum PostStatus {
        ACTIVE,
        DELETED,
        SUSPENDED,
        BLACKLISTED
    }

    public enum PostReaction {
        LIKE,
        LOVE,
        HELPFUL,
        MISLEADING, 
    }
    public enum Privilege {
        CREATOR,
        MODERATOR
    }

    public enum ReportClass {
        MISLEADING,
        HATEFUL
    }

    public enum ReportStatus {
        PENDING,
        INVESTIGATION
    }
    public enum NotificationType {
        COMMENT,
        SECURIT
    }
}
