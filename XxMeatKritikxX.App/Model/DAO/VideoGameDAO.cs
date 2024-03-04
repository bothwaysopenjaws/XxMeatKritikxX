using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XxMeatKritikxX.App.Model.DAO;

internal class VideoGameDAO : EntityDAO<VideoGame>, IEntityDAO<VideoGame>
{
    public void Create(VideoGame entity)
        => base.CreateFromParameters([
        new SqlParameter(nameof(VideoGame.Title), entity.Title)
        ,new SqlParameter(nameof(VideoGame.ParutionDate), entity.ParutionDate.ToDateTime(new TimeOnly()))
        ,new SqlParameter(nameof(VideoGame.Studio) + "Id", entity.Studio.Id)
        ,new SqlParameter(nameof(VideoGame.Genre) + "Id", entity.Genre.Id)
        ,new SqlParameter(nameof(VideoGame.Price), entity.Price)
        ,new SqlParameter(nameof(VideoGame.UrlPicture), entity.UrlPicture)]);

    public void Update(VideoGame entity)
        => base.UpdateFromParameters([
        new SqlParameter(nameof(VideoGame.Title), entity.Title)
        ,new SqlParameter(nameof(VideoGame.ParutionDate), entity.ParutionDate.ToDateTime(new TimeOnly()))
        ,new SqlParameter(nameof(VideoGame.Studio) + "Id", entity.Studio.Id)
        ,new SqlParameter(nameof(VideoGame.Genre) + "Id", entity.Genre.Id)
        ,new SqlParameter(nameof(VideoGame.Price), entity.Price)
        ,new SqlParameter(nameof(VideoGame.UrlPicture), entity.UrlPicture)]);

    public VideoGameDAO()
    {
        AddManagedAttributes(nameof(VideoGame.Title));
        AddManagedAttributes(nameof(VideoGame.ParutionDate));
        AddManagedAttributes(nameof(VideoGame.Price));
        AddManagedAttributes(nameof(VideoGame.Studio) + "Id");
        AddManagedAttributes(nameof(VideoGame.Genre) + "Id");
        AddManagedAttributes(nameof(VideoGame.UrlPicture));
    }

    protected override VideoGame? SqlDataReaderToEntity(SqlDataReader reader )
    {
        VideoGame? entity = null;

        StudioDAO studioDAO = new StudioDAO();
        GenreDAO genreDAO = new();

        while (reader.Read())
        {
            Genre genre = genreDAO.GetById(reader.GetInt32(reader.GetOrdinal(nameof(VideoGame.Genre) + "Id")));
            Studio studio = studioDAO.GetById(reader.GetInt32(reader.GetOrdinal(nameof(VideoGame.Studio) + "Id")));
            entity = new
                (
                    reader.GetString(reader.GetOrdinal(nameof(VideoGame.Title)))
                    ,genre
                    ,studio
                    ,DateOnly.FromDateTime( reader.GetDateTime(reader.GetOrdinal(nameof(VideoGame.ParutionDate))))
                    ,reader.GetDouble(reader.GetOrdinal(nameof(VideoGame.Price))))
            {
                Id = reader.GetInt32(reader.GetOrdinal(nameof(VideoGame.Id)))
                ,UrlPicture = reader.GetString(reader.GetOrdinal(nameof(VideoGame.UrlPicture)))
            };
        }
        return entity;
    }

    protected override List<VideoGame> SqlDataReaderToEntities(SqlDataReader reader)
    {
        List<VideoGame> entities = new();
        StudioDAO studioDAO = new StudioDAO();
        GenreDAO genreDAO = new();

        while (reader.Read())
        {

            Genre genre = genreDAO.GetById(reader.GetInt32(reader.GetOrdinal(nameof(VideoGame.Genre) + "Id")));
            Studio studio = studioDAO.GetById(reader.GetInt32(reader.GetOrdinal(nameof(VideoGame.Studio) + "Id")));
            VideoGame entity = new
                (
                    reader.GetString(reader.GetOrdinal(nameof(VideoGame.Title)))
                    , genre
                    , studio
                    , DateOnly.FromDateTime(reader.GetDateTime(reader.GetOrdinal(nameof(VideoGame.ParutionDate))))
                    , reader.GetDouble(reader.GetOrdinal(nameof(VideoGame.Price))))
            {
                Id = reader.GetInt32(reader.GetOrdinal(nameof(VideoGame.Id)))
                ,
                UrlPicture = reader.GetString(reader.GetOrdinal(nameof(VideoGame.UrlPicture)))
            };
            entities.Add(entity);
        }
        return entities;
    }
}
