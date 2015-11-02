using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class GenreMap : EntityTypeConfiguration<Genre>
    {
        public GenreMap()
        {
            // Primary Key
            this.HasKey(t => t.GenreId);

            // Properties
            this.Property(t => t.GenreId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Genre");
            this.Property(t => t.GenreId).HasColumnName("GenreId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
