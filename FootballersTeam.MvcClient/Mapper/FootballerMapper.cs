using FastReport.DevComponents.DotNetBar.Metro;
using FootballersTeam.MvcClient.Models;
using FootballProject.Entities;
using Microsoft.AspNetCore.Builder;

namespace FootballersTeam.MvcClient.Mapper
{
    public interface IMapper<in TEntity, out TModel>
    {
        TModel MapToModel(TEntity ent);
    }
    public class FootballerMapper:IMapper<Footballer,FootballerViewModel>
    {
        public FootballerViewModel MapToModel(Footballer ent)
        {
            return new FootballerViewModel()
            {
                DataOfBirth = ent.DataOfBirth,
                PersonId = ent.PersonId,
                FirstName = ent.FirstName,
                Height = ent.Height,
                Weight = ent.Weight,
                MiddleName = ent.MiddleName,
                Nationality = ent.Nationality,
                PlaceOfBirth = ent.PlaceOfBirth,
                RoleId = ent.Role?.RoleId,
                RoleName = ent.Role?.RoleName,
            };
        }
    }
}