using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class FormType
    {
        public FormType()
        {
            Forms = new HashSet<Form>();
        }

        public int FormType1 { get; set; }
        public string Description { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<Form> Forms { get; set; }
    }
}
