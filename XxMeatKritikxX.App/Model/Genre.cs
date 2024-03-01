using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model
{
    /// <summary>
    /// Genre
    /// </summary>
    internal class Genre
    {
        /// <summary>
        /// Nom
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Jeux vidéos du genre
        /// </summary>
        public List<VideoGame> VideoGames { get; set; }

        /// <summary>
        /// Instancie un genre
        /// </summary>
        /// <param name="name">Nom</param>
        public Genre(string name)
        {
            Name = name;
            VideoGames = new();
        }
    }
}
