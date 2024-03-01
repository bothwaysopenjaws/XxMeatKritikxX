using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model;

/// <summary>
/// Studio
/// </summary>
public class Studio
{
    #region Properties

    /// <summary>
    /// Nom
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Liste des jeux vidéos du studio
    /// </summary>
    public List<VideoGame> VideoGames { get; set; }

    #endregion


    #region Constructors

    /// <summary>
    /// Instancie un studio
    /// </summary>
    /// <param name="name">nom du studio</param>
    public Studio(string name)
    {
        Name = name;
        VideoGames = new();
    }

    #endregion

}
