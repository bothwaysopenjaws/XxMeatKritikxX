﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model
{
    /// <summary>
    /// Utilisateur
    /// </summary>
    public class User : IdentityObject
    {

        /// <summary>
        /// Nom de la classe
        /// </summary>
        public string className => nameof(User);

        /// <summary>
        /// Nom de la clase pluralisée
        /// </summary>
        public string pluralizedClassName => nameof(User) + "s";


        public string Pseudo { get; set; }

        /// <summary>
        /// Liste de ses notations
        /// </summary>
        public List<VideoGameUser> VideoGameUsers { get; set; }


        public User(string pseudo)
        {
            Pseudo = pseudo;
            VideoGameUsers = new ();
        }

    }
}
