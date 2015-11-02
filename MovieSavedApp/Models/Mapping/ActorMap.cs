using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class ActorMap : EntityTypeConfiguration<Actor>
    {
        public ActorMap()
        {
            // Primary Key
            this.HasKey(t => t.ActorId);

            // Properties
            this.Property(t => t.ActorId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Actor");
            this.Property(t => t.ActorId).HasColumnName("ActorId");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
