using Data.Tables;

namespace Data.Commands.Interfaces;

public interface IVenueCommands
{
    public Task AddVenues(List<Venue> venues);

    public Task EditVenue(string venue);

    public Task DeleteVenue(string venue);
}