using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ResponseQuestion
    {
        public ResponseQuestion()
        {
            ResponseForms = new HashSet<ResponseForm>();
        }

        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public Guid OptionId { get; set; }

        public virtual Option Option { get; set; } = null!;
        public virtual Question Question { get; set; } = null!;
        public virtual ICollection<ResponseForm> ResponseForms { get; set; }
    }
}
