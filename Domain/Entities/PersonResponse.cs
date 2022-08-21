using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class PersonResponse
    {
        public PersonResponse()
        {
            ResponseForms = new HashSet<ResponseForm>();
        }

        public Guid User { get; set; }
        public string Name { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Document { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<ResponseForm> ResponseForms { get; set; }
    }
}
