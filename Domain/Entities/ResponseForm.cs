using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ResponseForm
    {
        public Guid Response { get; set; }
        public Guid UserId { get; set; }
        public Guid FormId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid ResponseQuestion { get; set; }

        public virtual Form Form { get; set; } = null!;
        public virtual ResponseQuestion ResponseQuestionNavigation { get; set; } = null!;
        public virtual PersonResponse User { get; set; } = null!;
    }
}
