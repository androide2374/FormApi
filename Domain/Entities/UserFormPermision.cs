using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class UserFormPermision
    {
        public Guid UserPermision { get; set; }
        public Guid User { get; set; }
        public Guid Form { get; set; }
        public bool Active { get; set; }
        public Guid CreateBy { get; set; }
        public Guid UpdateBy { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual User CreateByNavigation { get; set; } = null!;
        public virtual Form FormNavigation { get; set; } = null!;
        public virtual User UpdateByNavigation { get; set; } = null!;
        public virtual User UserNavigation { get; set; } = null!;
    }
}
