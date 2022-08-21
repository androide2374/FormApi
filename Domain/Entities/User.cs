using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class User
    {
        public User()
        {
            FormCreatedByNavigations = new HashSet<Form>();
            FormLastUpdateByNavigations = new HashSet<Form>();
            UserFormPermisionCreateByNavigations = new HashSet<UserFormPermision>();
            UserFormPermisionUpdateByNavigations = new HashSet<UserFormPermision>();
            UserFormPermisionUserNavigations = new HashSet<UserFormPermision>();
        }

        public Guid User1 { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Legajo { get; set; } = null!;
        public bool Active { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual ICollection<Form> FormCreatedByNavigations { get; set; }
        public virtual ICollection<Form> FormLastUpdateByNavigations { get; set; }
        public virtual ICollection<UserFormPermision> UserFormPermisionCreateByNavigations { get; set; }
        public virtual ICollection<UserFormPermision> UserFormPermisionUpdateByNavigations { get; set; }
        public virtual ICollection<UserFormPermision> UserFormPermisionUserNavigations { get; set; }
    }
}
