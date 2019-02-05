using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ComNotHis.DAL.Entities;

namespace ComNotHis.DAL.EF
{
    public class CommentsContext : DbContext
    {
        public DbSet<Additional> Additionals { get; set; }
        public DbSet<CorrectionStatus> CorrectionStatuss { get; set; }

        public DbSet<Correction> Corrections { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<NoteStatus> NoteStatuss { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<TakeOff> TakeOffs { get; set; }
        public DbSet<TakeOffStatus> TakeOffStatuss { get; set; }
        public DbSet<RequestForCorrection> RequestForCorrections { get; set; }

        public DbSet<RequestForSpecification> RequestForSpecifications { get; set; }
        public DbSet<RequestForTakeOff> RequestForTakeOffs { get; set; }
        public DbSet<RequestForUpdateStatus> RequestForUpdateStatuss { get; set; }

        public DbSet<AnswerToRequestSpecification> AnswerToRequestSpecifications { get; set; }
        public DbSet<AnswerToRequestToTakeOff> AnswerToRequestToTakeOffs { get; set; }
        public CommentsContext(string connectionString) : base(connectionString)
        //() : base("CommentsContext") - было в монолитной архитектуре
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);// автоматическое создание

            modelBuilder.Entity<Note>().HasMany(c => c.Corrections).WithMany(s => s.Notes).Map(t => t.MapLeftKey("NoteId").MapRightKey("CorrectionId").ToTable("NoteCorrection"));
            modelBuilder.Entity<Note>().HasMany(c => c.Specifications).WithMany(s => s.Notes).Map(t => t.MapLeftKey("NoteId").MapRightKey("SpecificationId").ToTable("NoteSpecification"));
            modelBuilder.Entity<Note>().HasMany(c => c.TakeOffs).WithMany(s => s.Notes).Map(t => t.MapLeftKey("NoteId").MapRightKey("TakeOffId").ToTable("NoteTakeOff"));
            modelBuilder.Entity<Additional>().HasMany(c => c.TakeOffs).WithMany(s => s.Additionals).Map(t => t.MapLeftKey("AdditionalId").MapRightKey("TakeOffId").ToTable("AdditionalTakeOff"));
        }

       /* public static CommentsContext Create() - этот метод связан аутоитентификацией
        {
            return new CommentsContext();
        }
        */
    }

}
