using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class MovieUserMap : EntityTypeConfiguration<MovieUser>
    {
        public MovieUserMap()
        {
            // Primary Key
            this.HasKey(t => t.MovieUserId);

            // Properties
            this.Property(t => t.MovieUserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MovieUser");
            this.Property(t => t.MovieUserId).HasColumnName("MovieUserId");
            this.Property(t => t.User_Id).HasColumnName("User_Id");
            this.Property(t => t.Movie_Id).HasColumnName("Movie_Id");
            this.Property(t => t.Seen).HasColumnName("Seen");
            this.Property(t => t.Favorite).HasColumnName("Favorite");
            this.Property(t => t.PersonalScore).HasColumnName("PersonalScore");

            // Relationships
            this.HasRequired(t => t.Movie)
                .WithMany(t => t.MoviesUsers)
                .HasForeignKey(d => d.Movie_Id);
            this.HasRequired(t => t.User)
                .WithMany(t => t.MoviesUsers)
                .HasForeignKey(d => d.User_Id);

        }
    }
}
