using Data.Commands.Interfaces;
using Data.Tables;

namespace Data.Commands;

public class VenueCommands : IVenueCommands
{
    public VenueCommands()
    {
        
    }
    
    public Task AddVenues(List<Venue> venues)
    {
        throw new NotImplementedException();
    }

    public Task EditVenue(string venueName)
    {
        throw new NotImplementedException();
    }

    public Task DeleteVenue(string venueName)
    {
        throw new NotImplementedException();
    }
}