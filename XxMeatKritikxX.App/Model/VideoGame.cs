using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model
{
    /// <summary>
    /// Jeux vidéo
    /// </summary>
    internal class VideoGame
    {
        /// <summary>
        /// Titre
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Genre
        /// </summary>
        public Genre Genre { get; set; }
        
        /// <summary>
        /// Studio
        /// </summary>
        public Studio Studio { get; set; }

        /// <summary>
        /// Date de parution
        /// </summary>
        public DateOnly ParutionDate { get; set; }

        /// <summary>
        /// Prix
        /// </summary>
        public double Price { get; set; }

        /// <summwary>
        /// Liste de ses notations
        /// </summary>
        public List<VideoGameUser> VideoGameUsers { get; set; }

        /// <summary>
        /// Url de l'image
        /// </summary>
        public string? UrlImg { get;set; }

        /// <summary>
        /// Jeu video
        /// </summary>
        /// <param name="title">Titre</param>
        /// <param name="genre">Genre</param>
        /// <param name="studio">Studio</param>
        /// <param name="parutionDate">Date de parution</param>
        /// <param name="price">Prix</param>
        public VideoGame(
            string title, 
            Genre genre, 
            Studio studio, 
            DateOnly parutionDate, 
            double price,
            string? urlImg = null)
        {
            Title = title;
            Genre = genre;
            Studio = studio;
            ParutionDate = parutionDate;
            Price = price;
            VideoGameUsers = new();
            UrlImg = urlImg;
        }

    }
}
