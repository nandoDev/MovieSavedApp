using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MovieSavedApp.Models.Mapping;

namespace MovieSavedApp.Models
{
    public partial class MovieSavedDbContext : DbContext
    {
        static MovieSavedDbContext()
        {
            Database.SetInitializer<MovieSavedDbContext>(null);
        }

        public MovieSavedDbContext()
            : base("Name=MovieSavedDbContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieActor> MoviesActors { get; set; }
        public DbSet<MovieCountry> MoviesCountries { get; set; }
        public DbSet<MovieDirector> MoviesDirectors { get; set; }
        public DbSet<MovieUser> MoviesUsers { get; set; }
        public DbSet<MovieGenre> MoviesGenres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieUserTypeStorage> MoviesUsersTypeStorages { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TypeStorage> TypeStorages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ActorMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new DirectorMap());
            modelBuilder.Configurations.Add(new GenreMap());
            modelBuilder.Configurations.Add(new MovieActorMap());
            modelBuilder.Configurations.Add(new MovieCountryMap());
            modelBuilder.Configurations.Add(new MovieDirectorMap());
            modelBuilder.Configurations.Add(new MovieUserMap());
            modelBuilder.Configurations.Add(new MovieGenreMap());
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new MovieUserTypeStorageMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TypeStorageMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
