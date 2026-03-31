using Campus.Models;

namespace Campus.Services
{
    public interface IEventService
    {
        Task<IEnumerable<Event>> GetEventsAsync();
    }
}
