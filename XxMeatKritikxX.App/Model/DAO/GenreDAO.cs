using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model.DAO;

internal class GenreDAO : EntityDAO<Genre>, IEntityDAO<Genre>
{
    public void Create(Genre entity) => base.CreateFromParameters([new SqlParameter(nameof(Genre.Name), entity.Name)]);
    
    public void Update(Genre entity)  => base.UpdateFromParameters([new SqlParameter(nameof(entity.Name), entity.Name)]);

    public GenreDAO() => AddManagedAttributes(nameof(Genre.Name));

    protected override Genre? SqlDataReaderToEntity(SqlDataReader reader)
    {
        Genre? entity = null;

        while (reader.Read())
        {
            entity = new((string)reader[reader.GetOrdinal(nameof(Genre.Name))])
            {
                Id = (int)reader[reader.GetOrdinal(nameof(Genre.Id))]
            };
        }
        return entity;
    }

    protected override List<Genre> SqlDataReaderToEntities(SqlDataReader reader)
    {
        List<Genre> entities = new();

        while (reader.Read())
        {
            Genre entity = new((string)reader[reader.GetOrdinal(nameof(Genre.Name))])
            {
                Id = (int)reader[reader.GetOrdinal(nameof(User.Id))]
            };
            entities.Add(entity);
        }
        return entities;
    }

    public Genre GetByName(string name)
    {
        Genre? entity = null;

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
    {pluralizedClassName}.{nameof(Genre.Name)} = @{nameof(Genre.Name)}
""";

                command.Parameters.Add(new SqlParameter(nameof(Genre.Name), name));
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
}

