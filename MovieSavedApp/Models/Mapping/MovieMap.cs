using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            // Primary Key
            this.HasKey(t => t.MovieId);

            // Properties
            this.Property(t => t.MovieId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(70);

            this.Property(t => t.PosterUrl)
                .HasMaxLength(200);

            this.Property(t => t.ImdbId)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Movie");
            this.Property(t => t.MovieId).HasColumnName("MovieId");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.PosterUrl).HasColumnName("PosterUrl");
            this.Property(t => t.ImdbId).HasColumnName("ImdbId");
        }
    }
}
