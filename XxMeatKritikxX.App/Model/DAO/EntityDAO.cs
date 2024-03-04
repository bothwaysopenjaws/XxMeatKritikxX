using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model.DAO
{
    public abstract class EntityDAO<T>        
        where T : IdentityObject
    {
        #region Properties

        /// <summary>
        /// Liste des propriété de la classe
        /// </summary>
        public List<string> ManagedAttributes { get; private set; }

        /// <summary>
        /// Nom de la classe
        /// </summary>
        public string className => typeof(T).Name;

        /// <summary>
        /// Nom de la clase pluralisée
        /// </summary>
        public string pluralizedClassName => className + "s";

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        protected EntityDAO()
        {
            ManagedAttributes = new List<string>() { nameof(IdentityObject.Id) };
        }

        #endregion

        #region Methods

        #region CRUD

        #endregion
        protected void CreateFromParameters(SqlParameter[] fieldParameters)
        {
            //ConfigurationManager.ConnectionStrings["DbMeatKritikCs"].ConnectionString

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
                        INSERT INTO {pluralizedClassName}
                        (
                        {GetManagedAttributes(ManagedAttributesFormat.Select)}
                        ) 
                        VALUES
                        (
                        {GetManagedAttributes(ManagedAttributesFormat.At)}
                        )
                        """;

                    command.Parameters.AddRange(fieldParameters);
                    command.ExecuteNonQuery();
                }
                // On ferme la connexion
                connection.Close();
                // On dispose la connexion (fait automatiquement avec le Using

            }
        }

        public virtual void Delete(T entity)
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
                    command.CommandText = $"""
DELETE FROM 
{pluralizedClassName} 
WHERE 
({nameof(IdentityObject.Id)}= @{nameof(IdentityObject.Id)}) 
""";
                    // On prépare le paramètre
                    command.Parameters.Add(new SqlParameter(nameof(IdentityObject.Id), entity.Id));

                    // On attend pas de valeur de retour, donc :
                    command.ExecuteNonQuery();
                }
                // On ferme la connexion
                connection.Close();
                // On dispose la connexion (fait automatiquement avec le Using

            }
        }

        /// <summary>
        /// La mise à jour de l'utilisateur en base
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public virtual void UpdateFromParameters(SqlParameter[] fieldParameters)
        {
            //ConfigurationManager.ConnectionStrings["DbMeatKritikCs"].ConnectionString

            // On initialise la connexion à la base de données
            using (SqlConnection connection = new(ConfigurationManager.ConnectionStrings["DbMeatKritikCs"].ConnectionString))
            {
                // On ouvre la connexion
                connection.Open();
                // On prépare la commande à exécuter
                using (SqlCommand command = connection.CreateCommand())
                {
                    // Instruction SQL
                    command.CommandText = $"""
UPDATE 
    {pluralizedClassName}
SET
    {GetManagedAttributes(ManagedAttributesFormat.Update)}
WHERE
    {pluralizedClassName}.{nameof(User.Id)} = @{nameof(User.Id)}
""";
                    // On prépare le paramètre

                    command.Parameters.AddRange(fieldParameters);
                    command.ExecuteNonQuery();
                }
                // On ferme la connexion
                connection.Close();
                // On dispose la connexion (fait automatiquement avec le Using
            }
        }

        public virtual List<T> Read()
        {
            List<T>? entities = null;

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
    {GetManagedAttributes(ManagedAttributesFormat.Select, true)} 
FROM 
    {pluralizedClassName}
""";

                    // On attend un jeu de données en retour, donc :
                    using (SqlDataReader reader = command.ExecuteReader())
                        entities = SqlDataReaderToEntities(reader);
                }
                // On ferme la connexion
                connection.Close();
                // On dispose la connexion (fait automatiquement avec le Using
                return entities;
            }
        }

        public virtual T GetById(int id)
        {
            T? entity = null;

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
    {GetManagedAttributes(ManagedAttributesFormat.Select, true)} 
FROM 
    {pluralizedClassName}
WHERE
    {pluralizedClassName}.{nameof(IdentityObject.Id)} = @{nameof(IdentityObject.Id)}
""";
                    command.Parameters.Add(new SqlParameter(nameof(IdentityObject.Id), id));
                    // On attend un jeu de données en retour, donc :
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        entity = SqlDataReaderToEntity(reader);

                    }
                }
                // On ferme la connexion
                connection.Close();
                // On dispose la connexion (fait automatiquement avec le Using
                if (entity == null)
                    throw new Exception("Aucun enregistrement trouvé");
                return entity;
            }
        }
        #endregion

        #region Helpers

        /// <summary>
        /// Obtient les propriétés sous la forme de chaîne de caractères.
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        protected string GetManagedAttributes(ManagedAttributesFormat format, bool withId = false)
        {
            string result = "";
            bool isFirstLine = true;
            foreach (string attribute in ManagedAttributes)
            {
                if (withId || (!withId && attribute != nameof(IdentityObject.Id)))
                {
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                    }
                    else
                    {
                        result += ", ";
                    }

                    switch (format)
                    {
                        case ManagedAttributesFormat.Select:
                            result += attribute + Environment.NewLine;
                            break;
                        case ManagedAttributesFormat.At:
                            result += "@" + attribute + Environment.NewLine;
                            break;
                        case ManagedAttributesFormat.Update:
                            result += $"{pluralizedClassName}.{attribute} =  @{attribute} {Environment.NewLine}";
                            break;
                        default:
                            break;
                    }
                }

                
            }
            return result;
        }

        /// <summary>
        /// Récupère le résultat d'un DataReader et le transforme en entité
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        protected abstract T? SqlDataReaderToEntity(SqlDataReader reader);

        /// <summary>
        /// Récupère le résultat d'un DataReader et le transforme en une liste d'entité
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        protected abstract List<T> SqlDataReaderToEntities(SqlDataReader reader);

        /// <summary>
        /// Défini les éléments 
        /// </summary>
        protected void AddManagedAttributes(string attribute) => ManagedAttributes.Add(attribute);

        #endregion

    }
}