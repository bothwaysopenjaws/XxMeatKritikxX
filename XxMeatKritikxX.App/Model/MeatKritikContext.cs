using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XxMeatKritikxX.App.Repository;

namespace XxMeatKritikxX.App.Model;

/// <summary>
/// Contexte de données
/// </summary>
public class MeatKritikContext
{
    #region Properties

    /// <summary>
    /// Liste des genres
    /// </summary>
    public List<Genre> Genres { get; set; }
    
    /// <summary>
    /// Liste des studios
    /// </summary>
    public List<Studio> Studios { get; set; }
    
    /// <summary>
    /// Liste des jeux vidéos
    /// </summary>
    public List<VideoGame> VideoGames { get; set; }
    
    /// <summary>
    /// Liste des utilisateurs
    /// </summary>
    public List<User> Users { get; set; }

    /// <summary>
    /// Accès à la base de données
    /// </summary>
    public UserRepository UserRepository { get; init; }
    public GenreRepository GenreRepository { get; init; }
    public StudioRepository StudioRepository { get; init; }
    public VideoGameRepository VideoGameRepository { get; init; }

    #endregion


    /// <summary>
    /// Constructeur <see cref="MeatKritikContext"/>
    /// </summary>
    public MeatKritikContext()
    {
        Genres = new();
        Studios = new ();
        VideoGames = new();
        Users = new();
        UserRepository = new();
        GenreRepository = new();
        StudioRepository = new();
        VideoGameRepository = new();
        //MockupData();
        //Ajout de données de tests si aucune n'est présente en base
        if (UserRepository.Read().Count == 0)
            AddUsersInDB();
        if (GenreRepository.Read().Count == 0)
            AddGenresInDB();
        if (StudioRepository.Read().Count == 0)
            AddStudiosInDB();
        if (VideoGameRepository.Read().Count == 0)
            AddVideoGamesInDB();
    }


    #region Methods

    /// <summary>
    /// Génération de données de test
    /// </summary>
    internal void MockupData()
    {
        GenerateGenres();
        GenerateStudios();
        GenerateUsers();
        GenerateVideoGames();
    }

    /// <summary>
    /// Génère des genres
    /// </summary>
    private void GenerateGenres()
    {
        Genres.Add(new Genre("Horreur"));
        Genres.Add(new Genre("FPS"));
        Genres.Add(new Genre("MMORPG"));
        Genres.Add(new Genre("RPG"));
        Genres.Add(new Genre("MOBA"));
    }

    /// <summary>
    /// Génère des studios
    /// </summary>
    private void GenerateStudios()
    {
        Studios.Add(new Studio("Rito"));
        Studios.Add(new Studio("Blizzard"));
        Studios.Add(new Studio("Epic Games"));
        Studios.Add(new Studio("Ankama"));
        Studios.Add(new Studio("Holoverse"));
        Studios.Add(new Studio("Ubisoft"));
    }

    /// <summary>
    /// Génère des utilisateurs
    /// </summary>
    private void GenerateUsers()
    {
        Users.Add(new User("Oo-DarQ-Sasuuke-oO"));
        Users.Add(new User("Teemo-en-bush"));
        Users.Add(new User("Xx-Kev1n69-xX"));
        Users.Add(new User("Kr1t1k4L1f3"));
    }

    /// <summary>
    /// Génère des jeux vidéos
    /// </summary>
    private void GenerateVideoGames()
    {
        VideoGames.Add(new VideoGame(
                "Ligue of lesgens",
                Genres.First(g => g.Name == "MOBA"),
                Studios.First(s => s.Name == "Rito"),
                new DateOnly(2009, 10, 27),
                0,
                "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/League_of_Legends_2019_vector.svg/langfr-330px-League_of_Legends_2019_vector.svg.png"));
        VideoGames.Add(new VideoGame(
                "Fortnite",
                Genres.First(g => g.Name == "FPS"),
                Studios.First(s => s.Name == "Epic Games"),
                new DateOnly(2017, 07, 21),
                0,
                "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/FortniteLogo.svg/langfr-390px-FortniteLogo.svg.png"));
        VideoGames.Add(new VideoGame(
                "Genshin Impact",
                Genres.First(g => g.Name == "RPG"),
                Studios.First(s => s.Name == "Holoverse"),
                new DateOnly(2020, 9, 28),
                0,
                "https://upload.wikimedia.org/wikipedia/fr/thumb/5/5d/Genshin_Impact_logo.svg/langfr-330px-Genshin_Impact_logo.svg.png"));
        VideoGames.Add(new VideoGame(
                "Overwatch",
                Genres.First(g => g.Name == "FPS"),
                Studios.First(s => s.Name == "Blizzard"),
                new DateOnly(2016, 5, 2),
                0,
                "https://upload.wikimedia.org/wikipedia/fr/thumb/d/d9/Overwatch_Logo.png/330px-Overwatch_Logo.png"));
        VideoGames.Add(new VideoGame(
            "Les lapins crétins",
            Genres.First(g => g.Name == "RPG"),
            Studios.First(s => s.Name == "Ubisoft"),
            new DateOnly(2006, 11, 14),
            27.39,
            "https://upload.wikimedia.org/wikipedia/fr/thumb/3/39/Rayman_contre_les_lapins_cr%C3%A9tins_Logo.png/330px-Rayman_contre_les_lapins_cr%C3%A9tins_Logo.png"));
        VideoGames.Add(new VideoGame(
            "Dofus",
            Genres.First(g => g.Name == "MMORPG"),
            Studios.First(s => s.Name == "Ankama"),
            new DateOnly(2004, 9, 1),
            60,
            "https://upload.wikimedia.org/wikipedia/fr/3/3d/Dofus_Logo.png"));
    }

    #endregion

    #region PopulateDB

    private void AddUsersInDB()
    {
        foreach (User user in Users)
            UserRepository.Create(user);
    }

    private void AddStudiosInDB()
    {
        foreach (Studio studio in Studios)
            StudioRepository.Create(studio);
    }

    private void AddGenresInDB()
    {
        foreach (Genre genre in Genres)
            GenreRepository.Create(genre);
    }

    private void AddVideoGamesInDB()
    {
        foreach (VideoGame videoGame in VideoGames)
        {
            videoGame.Genre = GenreRepository.GetByName(videoGame.Genre.Name);
            videoGame.Studio = StudioRepository.GetByName(videoGame.Studio.Name);
            VideoGameRepository.Create(videoGame);

        }
    }
    #endregion

}
