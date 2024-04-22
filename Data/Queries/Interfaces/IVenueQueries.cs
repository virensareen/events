using Data.Tables;

namespace Data.Queries.Interfaces;

public interface IVenueQueries
{
    public Task<List<Venue>> GetVenuesByCity(string city);
    public Task<List<Venue>> GetAllVenues();
}