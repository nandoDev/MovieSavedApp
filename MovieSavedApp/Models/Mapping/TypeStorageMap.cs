using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class TypeStorageMap : EntityTypeConfiguration<TypeStorage>
    {
        public TypeStorageMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeStorageId);

            // Properties
            this.Property(t => t.TypeStorageId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TypeStorageName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TypeStorage");
            this.Property(t => t.TypeStorageId).HasColumnName("TypeStorageId");
            this.Property(t => t.TypeStorageName).HasColumnName("TypeStorageName");
        }
    }
}
