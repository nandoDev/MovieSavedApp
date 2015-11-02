using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class MovieCountryMap : EntityTypeConfiguration<MovieCountry>
    {
        public MovieCountryMap()
        {
            // Primary Key
            this.HasKey(t => t.MovieCountryId);

            // Properties
            this.Property(t => t.MovieCountryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MovieCountry");
            this.Property(t => t.MovieCountryId).HasColumnName("MovieCountryId");
            this.Property(t => t.Country_Id).HasColumnName("Country_Id");
            this.Property(t => t.Movie_Id).HasColumnName("Movie_Id");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.MoviesCountries)
                .HasForeignKey(d => d.Country_Id);
            this.HasRequired(t => t.Movie)
                .WithMany(t => t.MoviesCountries)
                .HasForeignKey(d => d.Movie_Id);

        }
    }
}
