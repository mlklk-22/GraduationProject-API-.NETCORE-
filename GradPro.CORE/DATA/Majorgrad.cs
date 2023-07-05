using System;
using System.Collections.Generic;

#nullable disable

namespace GradPro.CORE.Data
{
    public partial class Majorgrad
    {
        public Majorgrad()
        {
            Projectgrads = new HashSet<Projectgrad>();
        }

        public decimal Majorid { get; set; }
        public string Majorname { get; set; }

        public virtual ICollection<Projectgrad> Projectgrads { get; set; }
    }
}
