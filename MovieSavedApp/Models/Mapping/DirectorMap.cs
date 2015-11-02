using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class DirectorMap : EntityTypeConfiguration<Director>
    {
        public DirectorMap()
        {
            // Primary Key
            this.HasKey(t => t.DirectorId);

            // Properties
            this.Property(t => t.DirectorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Director");
            this.Property(t => t.DirectorId).HasColumnName("DirectorId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
