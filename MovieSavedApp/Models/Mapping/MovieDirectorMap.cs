using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class MovieDirectorMap : EntityTypeConfiguration<MovieDirector>
    {
        public MovieDirectorMap()
        {
            // Primary Key
            this.HasKey(t => t.MovieDirectorId);

            // Properties
            this.Property(t => t.MovieDirectorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MovieDirector");
            this.Property(t => t.MovieDirectorId).HasColumnName("MovieDirectorId");
            this.Property(t => t.Movie_Id).HasColumnName("Movie_Id");
            this.Property(t => t.Director_Id).HasColumnName("Director_Id");

            // Relationships
            this.HasRequired(t => t.Director)
                .WithMany(t => t.MoviesDirectors)
                .HasForeignKey(d => d.Director_Id);
            this.HasRequired(t => t.Movie)
                .WithMany(t => t.MoviesDirectors)
                .HasForeignKey(d => d.Movie_Id);

        }
    }
}
