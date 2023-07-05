using System;
using System.Collections.Generic;

#nullable disable

namespace GradPro.CORE.Data
{
    public partial class Projectgrad
    {
        public Projectgrad()
        {
            UserProjects = new HashSet<UserProject>();
        }

        public decimal Projectid { get; set; }
        public string Projectname { get; set; }
        public string Projectdescription { get; set; }
        public string Projectprice { get; set; }
        public string Projectmajor { get; set; }
        public string Projectperiod { get; set; }
        public string Projectimage { get; set; }
        public decimal? Majorid { get; set; }
        public decimal? UserProject { get; set; }

        public virtual Majorgrad Major { get; set; }
        public virtual UserProject UserProjectNavigation { get; set; }
        public virtual ICollection<UserProject> UserProjects { get; set; }
    }
}
