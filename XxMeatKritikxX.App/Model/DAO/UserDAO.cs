using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model.DAO;

/// <summary>
/// Couche d'accès à l'utilisateur en base de données
/// </summary>
internal class UserDAO : EntityDAO<User>, IEntityDAO<User>
{
    public void Create(User entity) =>
        base.CreateFromParameters([new SqlParameter(nameof(User.Pseudo), entity.Pseudo)]);
    public void Update(User entity) => base.UpdateFromParameters([new SqlParameter(nameof(User.Pseudo), entity.Pseudo)]);

    public UserDAO() => AddManagedAttributes(nameof(User.Pseudo));

    protected override User? SqlDataReaderToEntity(SqlDataReader reader)
    {
        User? entity = null;

        while (reader.Read())
        {
            // On créé l'utilisateur de l'enregistrement
            entity = new((string)reader[reader.GetOrdinal(nameof(User.Pseudo))])
            {
                Id = (int)reader[reader.GetOrdinal(nameof(User.Id))]
            };


        }
        return entity;
    }

    protected override List<User> SqlDataReaderToEntities(SqlDataReader reader)
    {
        List<User> entities = new();

        while (reader.Read())
        {
            // On créé l'utilisateur de l'enregistrement
            User entity = new((string)reader[reader.GetOrdinal(nameof(User.Pseudo))])
            {
                Id = (int)reader[reader.GetOrdinal(nameof(User.Id))]
            };
            // On l'ajoute à la liste
            entities.Add(entity);


        }
        return entities;
    }

}