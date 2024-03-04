using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model
{
    /// <summary>
    /// Classe Identité
    /// </summary>
    public abstract class IdentityObject
    {
        /// <summary>
        /// Identifiant PK
        /// </summary>
        public virtual int Id { get; set; }
    }
}
