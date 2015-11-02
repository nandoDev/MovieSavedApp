using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class MovieGenreMap : EntityTypeConfiguration<MovieGenre>
    {
        public MovieGenreMap()
        {
            // Primary Key
            this.HasKey(t => t.MovieGenreId);

            // Properties
            this.Property(t => t.MovieGenreId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MovieGenre");
            this.Property(t => t.MovieGenreId).HasColumnName("MovieGenreId");
            this.Property(t => t.Genre_Id).HasColumnName("Genre_Id");
            this.Property(t => t.Movie_Id).HasColumnName("Movie_Id");

            // Relationships
            this.HasRequired(t => t.Genre)
                .WithMany(t => t.MoviesGenres)
                .HasForeignKey(d => d.Genre_Id);
            this.HasRequired(t => t.Movie)
                .WithMany(t => t.MoviesGenres)
                .HasForeignKey(d => d.Movie_Id);

        }
    }
}
