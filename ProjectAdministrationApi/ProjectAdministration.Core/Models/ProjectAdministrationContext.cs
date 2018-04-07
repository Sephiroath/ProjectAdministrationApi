using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjectAdministration.Core.Models
{
    public partial class ProjectAdministrationContext : DbContext
    {
        public virtual DbSet<HumanPerson> HumanPerson { get; set; }
        public virtual DbSet<HumanPersonInProject> HumanPersonInProject { get; set; }
        public virtual DbSet<HumanPersonRole> HumanPersonRole { get; set; }
        public virtual DbSet<ImpedimentComment> ImpedimentComment { get; set; }
        public virtual DbSet<Phase> Phase { get; set; }
        public virtual DbSet<Priority> Priority { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectImpediment> ProjectImpediment { get; set; }
        public virtual DbSet<ProjectTask> ProjectTask { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-V05B90J\SQLEXPRESS;Database=ProjectAdministration;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HumanPerson>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("eMail")
                    .HasMaxLength(50);

                entity.Property(e => e.EditedAt).HasColumnType("datetime");

                entity.Property(e => e.EditedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HumanPersonInProject>(entity =>
            {
                entity.Property(e => e.HumanPersonInProjectId).ValueGeneratedNever();

                entity.HasOne(d => d.HumanPersonNavigation)
                    .WithMany(p => p.HumanPersonInProject)
                    .HasForeignKey(d => d.HumanPerson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HumanPersonInProject_HumanPerson");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.HumanPersonInProject)
                    .HasForeignKey(d => d.Project)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HumanPersonInProject_Project");
            });

            modelBuilder.Entity<HumanPersonRole>(entity =>
            {
                entity.HasOne(d => d.HumanPersonNavigation)
                    .WithMany(p => p.HumanPersonRole)
                    .HasForeignKey(d => d.HumanPerson)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HumanPersonRole_HumanPerson");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.HumanPersonRole)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HumanPersonRole_Role");
            });

            modelBuilder.Entity<ImpedimentComment>(entity =>
            {
                entity.Property(e => e.ImpedimentCommentId).ValueGeneratedNever();

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.CommentedByNavigation)
                    .WithMany(p => p.ImpedimentComment)
                    .HasForeignKey(d => d.CommentedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImpedimentComment_HumanPersonInProject");

                entity.HasOne(d => d.ImpedimentNavigation)
                    .WithMany(p => p.ImpedimentComment)
                    .HasForeignKey(d => d.Impediment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImpedimentComment_ProjectImpediment");
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EditedAt).HasColumnType("datetime");

                entity.Property(e => e.EditedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.PhaseNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.Phase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Phase");

                entity.HasOne(d => d.PriorityNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.Priority)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Priority");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Status");
            });

            modelBuilder.Entity<ProjectImpediment>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PhaseNavigation)
                    .WithMany(p => p.ProjectImpediment)
                    .HasForeignKey(d => d.Phase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectImpediment_Phase");

                entity.HasOne(d => d.ReportedAtNavigation)
                    .WithMany(p => p.ProjectImpedimentReportedAtNavigation)
                    .HasForeignKey(d => d.ReportedAt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectImpediment_HumanPersonInProject1");

                entity.HasOne(d => d.ReportedByNavigation)
                    .WithMany(p => p.ProjectImpedimentReportedByNavigation)
                    .HasForeignKey(d => d.ReportedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectImpediment_HumanPersonInProject");
            });

            modelBuilder.Entity<ProjectTask>(entity =>
            {
                entity.Property(e => e.ActualEndDate).HasColumnType("date");

                entity.Property(e => e.ActualStartDate).HasColumnType("date");

                entity.Property(e => e.CreatedAt).HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EditedAt).HasColumnType("date");

                entity.Property(e => e.EditedBy)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.ActorNavigation)
                    .WithMany(p => p.ProjectTask)
                    .HasForeignKey(d => d.Actor)
                    .HasConstraintName("FK_ProjectTask_HumanPersonInProject");

                entity.HasOne(d => d.PhaseNavigation)
                    .WithMany(p => p.ProjectTask)
                    .HasForeignKey(d => d.Phase)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTask_Phase");

                entity.HasOne(d => d.ProjectNavigation)
                    .WithMany(p => p.ProjectTask)
                    .HasForeignKey(d => d.Project)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTask_Project");

                entity.HasOne(d => d.RoleNavigation)
                    .WithMany(p => p.ProjectTask)
                    .HasForeignKey(d => d.Role)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTask_Role");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.ProjectTask)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTask_Status");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
        }
    }
}
