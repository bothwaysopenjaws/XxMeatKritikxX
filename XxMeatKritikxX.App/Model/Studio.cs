using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model
{
    /// <summary>
    /// Studio
    /// </summary>
    internal class Studio
    {
        /// <summary>
        /// Nom
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Liste des jeux vidéos du studio
        /// </summary>
        public List<VideoGame> VideoGames { get; set; }

        /// <summary>
        /// Instancie un studio
        /// </summary>
        /// <param name="name">nom du studio</param>
        public Studio(string name)
        {
            Name = name;
            VideoGames = new();
        }
    }
}
