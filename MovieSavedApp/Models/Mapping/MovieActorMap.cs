using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class MovieActorMap : EntityTypeConfiguration<MovieActor>
    {
        public MovieActorMap()
        {
            // Primary Key
            this.HasKey(t => t.MovieActorId);

            // Properties
            this.Property(t => t.MovieActorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MovieActor");
            this.Property(t => t.MovieActorId).HasColumnName("MovieActorId");
            this.Property(t => t.Actor_Id).HasColumnName("Actor_Id");
            this.Property(t => t.Movie_Id).HasColumnName("Movie_Id");

            // Relationships
            this.HasRequired(t => t.Actor)
                .WithMany(t => t.MoviesActors)
                .HasForeignKey(d => d.Actor_Id);
            this.HasRequired(t => t.Movie)
                .WithMany(t => t.MoviesActors)
                .HasForeignKey(d => d.Movie_Id);

        }
    }
}
