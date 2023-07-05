using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GradPro.CORE.Data
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Majorgrad> Majorgrads { get; set; }
        public virtual DbSet<Projectgrad> Projectgrads { get; set; }
        public virtual DbSet<Roleusergrad> Roleusergrads { get; set; }
        public virtual DbSet<UserProject> UserProjects { get; set; }
        public virtual DbSet<Usergrad> Usergrads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=Tah14_User60;PASSWORD=Test321;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TAH14_USER60")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Majorgrad>(entity =>
            {
                entity.HasKey(e => e.Majorid)
                    .HasName("SYS_C00373234");

                entity.ToTable("MAJORGRAD");

                entity.Property(e => e.Majorid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MAJORID");

                entity.Property(e => e.Majorname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAJORNAME");
            });

            modelBuilder.Entity<Projectgrad>(entity =>
            {
                entity.HasKey(e => e.Projectid)
                    .HasName("SYS_C00373261");

                entity.ToTable("PROJECTGRAD");

                entity.Property(e => e.Projectid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PROJECTID");

                entity.Property(e => e.Majorid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("MAJORID");

                entity.Property(e => e.Projectdescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROJECTDESCRIPTION");

                entity.Property(e => e.Projectimage)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PROJECTIMAGE");

                entity.Property(e => e.Projectmajor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PROJECTMAJOR");

                entity.Property(e => e.Projectname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROJECTNAME");

                entity.Property(e => e.Projectperiod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROJECTPERIOD");

                entity.Property(e => e.Projectprice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PROJECTPRICE");

                entity.Property(e => e.UserProject)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_PROJECT");

                entity.HasOne(d => d.Major)
                    .WithMany(p => p.Projectgrads)
                    .HasForeignKey(d => d.Majorid)
                    .HasConstraintName("SYS_C00373262");

                entity.HasOne(d => d.UserProjectNavigation)
                    .WithMany(p => p.Projectgrads)
                    .HasForeignKey(d => d.UserProject)
                    .HasConstraintName("SYS_C00373267");
            });

            modelBuilder.Entity<Roleusergrad>(entity =>
            {
                entity.HasKey(e => e.Roleid)
                    .HasName("SYS_C00373216");

                entity.ToTable("ROLEUSERGRAD");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Rolename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLENAME");
            });

            modelBuilder.Entity<UserProject>(entity =>
            {
                entity.HasKey(e => e.UserProject1)
                    .HasName("SYS_C00373264");

                entity.ToTable("USER_PROJECT");

                entity.Property(e => e.UserProject1)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USER_PROJECT");

                entity.Property(e => e.Projectid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PROJECTID");

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USERID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.UserProjects)
                    .HasForeignKey(d => d.Projectid)
                    .HasConstraintName("SYS_C00373266");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProjects)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("SYS_C00373265");
            });

            modelBuilder.Entity<Usergrad>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("SYS_C00373252");

                entity.ToTable("USERGRAD");

                entity.HasIndex(e => e.Username, "SYS_C00373253")
                    .IsUnique();

                entity.Property(e => e.Userid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USERID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phonenumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.UserProject)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_PROJECT");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Usergrads)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("SYS_C00373254");

                entity.HasOne(d => d.UserProjectNavigation)
                    .WithMany(p => p.Usergrads)
                    .HasForeignKey(d => d.UserProject)
                    .HasConstraintName("SYS_C00373268");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
