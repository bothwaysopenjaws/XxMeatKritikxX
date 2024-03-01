﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model
{
    /// <summary>
    /// Contexte de données
    /// </summary>
    internal class MeatKritikContext
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
        }


        #region Methods

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
                    0));
            VideoGames.Add(new VideoGame(
                    "Fortnite",
                    Genres.First(g => g.Name == "FPS"),
                    Studios.First(s => s.Name == "Epic Games"),
                    new DateOnly(2017, 07, 21),
                    0));
            VideoGames.Add(new VideoGame(
                    "Genshin Impact",
                    Genres.First(g => g.Name == "RPG"),
                    Studios.First(s => s.Name == "Holoverse"),
                    new DateOnly(2020, 9, 28),
                    0));
            VideoGames.Add(new VideoGame(
                    "Overwatch",
                    Genres.First(g => g.Name == "FPS"),
                    Studios.First(s => s.Name == "Blizzard"),
                    new DateOnly(2016, 5, 2),
                    0));
            VideoGames.Add(new VideoGame(
                "Les lapins crétins",
                Genres.First(g => g.Name == "RPG"),
                Studios.First(s => s.Name == "Ubisoft"),
                new DateOnly(2006, 11, 14),
                27.39));
            VideoGames.Add(new VideoGame(
                "Dofus",
                Genres.First(g => g.Name == "MMORPG"),
                Studios.First(s => s.Name == "Ankama"),
                new DateOnly(2004, 9, 1),
                60));
        }


        #endregion

    }
}