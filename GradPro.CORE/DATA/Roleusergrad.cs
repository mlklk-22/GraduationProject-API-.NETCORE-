using System;
using System.Collections.Generic;

#nullable disable

namespace GradPro.CORE.Data
{
    public partial class Roleusergrad
    {
        public Roleusergrad()
        {
            Usergrads = new HashSet<Usergrad>();
        }

        public decimal Roleid { get; set; }
        public string Rolename { get; set; }

        public virtual ICollection<Usergrad> Usergrads { get; set; }
    }
}
