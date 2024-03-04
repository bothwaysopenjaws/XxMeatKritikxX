using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model.DAO;

internal class StudioDAO : EntityDAO<Studio>, IEntityDAO<Studio>
{
    public void Create(Studio entity) => base.CreateFromParameters([new SqlParameter(nameof(Studio.Name), entity.Name)]);
    
    public void Update(Studio entity)  => base.UpdateFromParameters([new SqlParameter(nameof(entity.Name), entity.Name)]);

    public StudioDAO() => AddManagedAttributes(nameof(Studio.Name));

    protected override Studio? SqlDataReaderToEntity(SqlDataReader reader)
    {
        Studio? entity = null;

        while (reader.Read())
        {
            entity = new((string)reader[reader.GetOrdinal(nameof(Studio.Name))])
            {
                Id = (int)reader[reader.GetOrdinal(nameof(Studio.Id))]
            };
        }
        return entity;
    }

    protected override List<Studio> SqlDataReaderToEntities(SqlDataReader reader)
    {
        List<Studio> entities = new();

        while (reader.Read())
        {
            Studio entity = new((string)reader[reader.GetOrdinal(nameof(Studio.Name))])
            {
                Id = (int)reader[reader.GetOrdinal(nameof(User.Id))]
            };
            entities.Add(entity);
        }
        return entities;
    }

    public Studio GetByName(string name)
    {
        Studio? entity = null;

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
    {pluralizedClassName}.{nameof(Studio.Name)} = @{nameof(Studio.Name)}
""";

                command.Parameters.Add(new SqlParameter(nameof(Studio.Name), name));
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
