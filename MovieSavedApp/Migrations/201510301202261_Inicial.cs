namespace MovieSavedApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actor",
                c => new
                    {
                        ActorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ActorId);
            
            CreateTable(
                "dbo.MovieActor",
                c => new
                    {
                        MovieActorId = c.Int(nullable: false, identity: true),
                        Actor_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieActorId)
                .ForeignKey("dbo.Actor", t => t.Actor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movie", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Actor_Id)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 70),
                        Year = c.Int(nullable: false),
                        PosterUrl = c.String(maxLength: 200),
                        ImdbId = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.MovieCountry",
                c => new
                    {
                        MovieCountryId = c.Int(nullable: false, identity: true),
                        Country_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieCountryId)
                .ForeignKey("dbo.Country", t => t.Country_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movie", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Country_Id)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.MovieDirector",
                c => new
                    {
                        MovieDirectorId = c.Int(nullable: false, identity: true),
                        Movie_Id = c.Int(nullable: false),
                        Director_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieDirectorId)
                .ForeignKey("dbo.Director", t => t.Director_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movie", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Movie_Id)
                .Index(t => t.Director_Id);
            
            CreateTable(
                "dbo.Director",
                c => new
                    {
                        DirectorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.DirectorId);
            
            CreateTable(
                "dbo.MovieGenre",
                c => new
                    {
                        MovieGenreId = c.Int(nullable: false, identity: true),
                        Genre_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieGenreId)
                .ForeignKey("dbo.Genre", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movie", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GenreId);
            
            CreateTable(
                "dbo.MovieUser",
                c => new
                    {
                        MovieUserId = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                        Seen = c.Boolean(),
                        Favorite = c.Boolean(),
                        PersonalScore = c.Int(),
                    })
                .PrimaryKey(t => t.MovieUserId)
                .ForeignKey("dbo.Movie", t => t.Movie_Id, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Movie_Id);
            
            CreateTable(
                "dbo.MovieUserTypeStorage",
                c => new
                    {
                        MovieUserTypeStorageId = c.Int(nullable: false, identity: true),
                        MovieUser_Id = c.Int(nullable: false),
                        TypeStorage_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MovieUserTypeStorageId)
                .ForeignKey("dbo.MovieUser", t => t.MovieUser_Id, cascadeDelete: true)
                .ForeignKey("dbo.TypeStorage", t => t.TypeStorage_Id, cascadeDelete: true)
                .Index(t => t.MovieUser_Id)
                .Index(t => t.TypeStorage_Id);
            
            CreateTable(
                "dbo.TypeStorage",
                c => new
                    {
                        TypeStorageId = c.Int(nullable: false, identity: true),
                        TypeStorageName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TypeStorageId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.UserId)
                .Index(t => t.Username, unique: true, name: "Unique_UsuarioIngreso")
                .Index(t => t.Password, unique: true, name: "Unique_Contraseña");
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieActor", "Movie_Id", "dbo.Movie");
            DropForeignKey("dbo.MovieUser", "User_Id", "dbo.User");
            DropForeignKey("dbo.MovieUserTypeStorage", "TypeStorage_Id", "dbo.TypeStorage");
            DropForeignKey("dbo.MovieUserTypeStorage", "MovieUser_Id", "dbo.MovieUser");
            DropForeignKey("dbo.MovieUser", "Movie_Id", "dbo.Movie");
            DropForeignKey("dbo.MovieGenre", "Movie_Id", "dbo.Movie");
            DropForeignKey("dbo.MovieGenre", "Genre_Id", "dbo.Genre");
            DropForeignKey("dbo.MovieDirector", "Movie_Id", "dbo.Movie");
            DropForeignKey("dbo.MovieDirector", "Director_Id", "dbo.Director");
            DropForeignKey("dbo.MovieCountry", "Movie_Id", "dbo.Movie");
            DropForeignKey("dbo.MovieCountry", "Country_Id", "dbo.Country");
            DropForeignKey("dbo.MovieActor", "Actor_Id", "dbo.Actor");
            DropIndex("dbo.User", "Unique_Contraseña");
            DropIndex("dbo.User", "Unique_UsuarioIngreso");
            DropIndex("dbo.MovieUserTypeStorage", new[] { "TypeStorage_Id" });
            DropIndex("dbo.MovieUserTypeStorage", new[] { "MovieUser_Id" });
            DropIndex("dbo.MovieUser", new[] { "Movie_Id" });
            DropIndex("dbo.MovieUser", new[] { "User_Id" });
            DropIndex("dbo.MovieGenre", new[] { "Movie_Id" });
            DropIndex("dbo.MovieGenre", new[] { "Genre_Id" });
            DropIndex("dbo.MovieDirector", new[] { "Director_Id" });
            DropIndex("dbo.MovieDirector", new[] { "Movie_Id" });
            DropIndex("dbo.MovieCountry", new[] { "Movie_Id" });
            DropIndex("dbo.MovieCountry", new[] { "Country_Id" });
            DropIndex("dbo.MovieActor", new[] { "Movie_Id" });
            DropIndex("dbo.MovieActor", new[] { "Actor_Id" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.User");
            DropTable("dbo.TypeStorage");
            DropTable("dbo.MovieUserTypeStorage");
            DropTable("dbo.MovieUser");
            DropTable("dbo.Genre");
            DropTable("dbo.MovieGenre");
            DropTable("dbo.Director");
            DropTable("dbo.MovieDirector");
            DropTable("dbo.Country");
            DropTable("dbo.MovieCountry");
            DropTable("dbo.Movie");
            DropTable("dbo.MovieActor");
            DropTable("dbo.Actor");
        }
    }
}
