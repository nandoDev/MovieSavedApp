using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MovieSavedApp.Models.Mapping
{
    public class MovieUserTypeStorageMap : EntityTypeConfiguration<MovieUserTypeStorage>
    {
        public MovieUserTypeStorageMap()
        {
            // Primary Key
            this.HasKey(t => t.MovieUserTypeStorageId);

            // Properties

            this.Property(t => t.MovieUserTypeStorageId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("MovieUserTypeStorage");
            this.Property(t => t.MovieUserTypeStorageId).HasColumnName("MovieUserTypeStorageId");
            this.Property(t => t.MovieUser_Id).HasColumnName("MovieUser_Id");
            this.Property(t => t.TypeStorage_Id).HasColumnName("TypeStorage_Id");

            // Relationships
            this.HasRequired(t => t.MovieUser)
                .WithMany(t => t.MoviesUsersTypeStorages)
                .HasForeignKey(d => d.MovieUser_Id);
            this.HasRequired(t => t.TypeStorage)
                .WithMany(t => t.MoviesUsersTypeStorages)
                .HasForeignKey(d => d.TypeStorage_Id);

        }
    }
}
