using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model.DAO;

/// <summary>
/// Couche d'accès à l'utilisateur en base de données
/// </summary>
internal class UserDAO : IEntityDAO<User>
{

    /// <summary>
    /// Créé un utilisateur en base de données
    /// </summary>
    /// <param name="entity">L'utilisateur à créer</param>
    public void Create(User entity)
    {
        //ConfigurationManager.ConnectionStrings["DbMeatKritikCs"].ConnectionString
        
        // On initialise la connexion à la base de données
        using (SqlConnection connection = new (ConfigurationManager.ConnectionStrings["DbMeatKritikCs"].ConnectionString))
        {
            // On ouvre la connexion
            connection.Open();
            // On prépare la commande à exécuter
            using (SqlCommand command = connection.CreateCommand())
            {
                // Instruction SQL
                command.CommandText = $"""
INSERT INTO Users(
    {nameof(User.Pseudo)}
) 
VALUES(
    @{nameof(User.Pseudo)}
)
""";
                // On prépare le paramètre
                SqlParameter parameter = new SqlParameter();
                parameter.Value = entity.Pseudo;
                parameter.ParameterName = $"@{nameof(User.Pseudo)}";
                parameter.DbType = System.Data.DbType.String;
                command.Parameters.Add(parameter);

                command.ExecuteNonQuery();
            }
            // On ferme la connexion
            connection.Close();
            // On dispose la connexion (fait automatiquement avec le Using

        }
    }

    /// <summary>
    /// Supprime un utilisateur en base de données
    /// </summary>
    /// <param name="entity">Utilisateur à supprimer</param>
    public void Delete(User entity)
    {

        // On initialise la connexion à la base de données
        using (SqlConnection connection = new(ConfigurationManager.ConnectionStrings["DbMeatKritikCs"].ConnectionString))
        {
            // On ouvre la connexion
            connection.Open();
            // On prépare la commande à exécuter
            using (SqlCommand command = connection.CreateCommand())
            {
                // Instruction SQL
                command.CommandText = $"DELETE FROM Users WHERE ({nameof(User.Id)}= @{nameof(User.Id)}) ";
                // On prépare le paramètre
                SqlParameter parameter = new SqlParameter();
                parameter.Value = entity.Id;
                parameter.ParameterName = $"@{nameof(User.Id)}";
                parameter.DbType = System.Data.DbType.Int32;
                command.Parameters.Add(parameter);

                // On attend pas de valeur de retour, donc :
                command.ExecuteNonQuery();
            }
            // On ferme la connexion
            connection.Close();
            // On dispose la connexion (fait automatiquement avec le Using

        }
    }

    /// <summary>
    /// Listing des utilisateur en base
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public List<User> Read()
    {
        List<User> users = new List<User>();

        // On initialise la connexion à la base de données
        using (SqlConnection connection = new(ConfigurationManager.ConnectionStrings["DbMeatKritikCs"].ConnectionString))
        {
            // On ouvre la connexion
            connection.Open();
            // On prépare la commande à exécuter
            using (SqlCommand command = connection.CreateCommand())
            {
                // Instruction SQL
                command.CommandText =
$"""
SELECT 
        {nameof(User.Id)}
        ,{nameof(User.Pseudo)} 
    FROM 
        Users
""";

                // On attend un jeu de données en retour, donc :
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // On créé l'utilisateur de l'enregistrement
                        User user = new((string)reader[reader.GetOrdinal(nameof(User.Pseudo))])
                        {
                            Id = (int)reader[reader.GetOrdinal(nameof(User.Id))]
                        };
                        // On l'ajoute à la liste
                        users.Add(user);


                    }
                }
            }
            // On ferme la connexion
            connection.Close();
            // On dispose la connexion (fait automatiquement avec le Using
            return users;
        }
    }

        /// <summary>
        /// La mise à jour de l'utilisateur en base
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Update(User entity)
    {
        //ConfigurationManager.ConnectionStrings["DbMeatKritikCs"].ConnectionString
        
        // On initialise la connexion à la base de données
        using (SqlConnection connection = new (ConfigurationManager.ConnectionStrings["DbMeatKritikCs"].ConnectionString))
        {
            // On ouvre la connexion
            connection.Open();
            // On prépare la commande à exécuter
            using (SqlCommand command = connection.CreateCommand())
            {
                // Instruction SQL
                command.CommandText = $"""
UPDATE Users
SET
    Users.{nameof(User.Pseudo)} = @{nameof(User.Pseudo)}
WHERE
    Users.{nameof(User.Id)} = @{nameof(User.Id)}
""";
                // On prépare le paramètre
                
                command.Parameters.Add(new SqlParameter(nameof(entity.Pseudo), entity.Pseudo));
                command.Parameters.Add(new SqlParameter(nameof(entity.Id), entity.Id));

                command.ExecuteNonQuery();
            }
            // On ferme la connexion
            connection.Close();
            // On dispose la connexion (fait automatiquement avec le Using

        }
    }
}
}