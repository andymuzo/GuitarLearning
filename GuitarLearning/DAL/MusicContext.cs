using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using GuitarLearning.Models;

namespace GuitarLearning.DAL
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("MusicContext")
        {
        }

        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Exam> Exams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Exam>()
                        .HasMany<Piece>(e => e.Pieces)
                        .WithMany(p => p.Exams)
                        .Map(ep =>
                            {
                                ep.MapLeftKey("ExamID");
                                ep.MapRightKey("PieceID");
                                ep.ToTable("ExamPiece");
                            });
        }
    }
}