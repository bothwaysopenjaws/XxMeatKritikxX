﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model;

/// <summary>
/// Notation d'un utilisateur sur un jeu
/// </summary>
public class VideoGameUser : IdentityObject
{
    #region Properties

    /// <summary>
    /// Utilisateur
    /// </summary>
    public User User { get; set; }
    
    /// <summary>
    /// Jeu vidéo
    /// </summary>
    public VideoGame VideoGame { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public int Note { get; set; }

    /// <summary>
    /// Comment
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Nom complet
    /// </summary>
    public string FullName => $"[{User.Pseudo}] - {Note}/10 - {Comment}";

    #endregion

    #region Constructors

    /// <summary>
    /// Constructeur d'une notation
    /// </summary>
    /// <param name="user">Utilisateur</param>
    /// <param name="videoGame">Jeu </param>
    /// <param name="note">Note</param>
    /// <param name="comment">Comment</param>
    public VideoGameUser(User user, VideoGame videoGame, int note, string? comment = null)
    {
        User = user;
        VideoGame = videoGame;
        Note = note;
        Comment = comment;

        User.VideoGameUsers.Add(this);
        VideoGame.VideoGameUsers.Add(this);
        
    }
    #endregion

}
