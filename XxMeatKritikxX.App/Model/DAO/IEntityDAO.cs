using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model.DAO
{
    /// <summary>
    /// Interface correspondant à la couche d'accès aux données.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IEntityDAO<T>
    {
        /// <summary>
        /// Créé une entité de type <see cref="T"/>
        /// </summary>
        /// <param name="entity">entité à créer en base de données</param>
        void Create(T entity);

        /// <summary>
        /// Supprime une entité de type <see cref="T"/>
        /// </summary>
        /// <param name="entity">entité à supprimer en base de données</param>
        void Delete(T entity);

        /// <summary>
        /// Met à jour une entité de type <see cref="T"/>
        /// </summary>
        /// <param name="entity">entité à modifier en base de données</param>
        void Update(T entity);

        /// <summary>
        /// Met à jour une entité de type <see cref="T"/>
        /// </summary>
        List<T> Read();
    }
}
