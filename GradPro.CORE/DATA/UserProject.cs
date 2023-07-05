using System;
using System.Collections.Generic;

#nullable disable

namespace GradPro.CORE.Data
{
    public partial class UserProject
    {
        public UserProject()
        {
            Projectgrads = new HashSet<Projectgrad>();
            Usergrads = new HashSet<Usergrad>();
        }

        public decimal UserProject1 { get; set; }
        public decimal? Userid { get; set; }
        public decimal? Projectid { get; set; }

        public virtual Projectgrad Project { get; set; }
        public virtual Usergrad User { get; set; }
        public virtual ICollection<Projectgrad> Projectgrads { get; set; }
        public virtual ICollection<Usergrad> Usergrads { get; set; }
    }
}
