using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure.Annotations;


namespace MovieSavedApp.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.UserId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                        new IndexAnnotation(
                            new IndexAttribute("Unique_UsuarioIngreso", 1) { IsUnique = true })); ;

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                        new IndexAnnotation(
                            new IndexAttribute("Unique_Contraseña", 1) { IsUnique = true })); ;

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
        }
    }
}
