using System;
using System.Collections.Generic;

#nullable disable

namespace GradPro.CORE.Data
{
    public partial class Usergrad
    {
        public Usergrad()
        {
            UserProjects = new HashSet<UserProject>();
        }

        public decimal Userid { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public decimal? Roleid { get; set; }
        public decimal? UserProject { get; set; }

        public virtual Roleusergrad Role { get; set; }
        public virtual UserProject UserProjectNavigation { get; set; }
        public virtual ICollection<UserProject> UserProjects { get; set; }
    }
}
