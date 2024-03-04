using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model;

/// <summary>
/// Genre
/// </summary>
public class Genre : IdentityObject
{
    #region Properties

    public int Id { get; set; }

    /// <summary>
    /// Nom
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Jeux vidéos du genre
    /// </summary>
    public List<VideoGame> VideoGames { get; set; }

    #endregion

    #region Constructors
            
    /// <summary>
    /// Instancie un genre
    /// </summary>
    /// <param name="name">Nom</param>
    public Genre(string name)
    {
        Name = name;
        VideoGames = new();
    }

    #endregion

}
