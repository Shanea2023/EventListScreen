using Campus.Models;

namespace Campus.Services
{
    public class MockEventService : IEventService
    {
        public async Task<IEnumerable<Event>> GetEventsAsync()
        {
            await Task.Delay(100);

            return new List<Event>
            {
                new Event
                {
                    Title = "Welcome Party 2026",
                    Description = "A grand welcome event for all new students.",
                    Location = "Main Hall",
                    DateTime = DateTime.Now.AddDays(2),
                    Category = "Social"
                },
                new Event
                {
                    Title = "IT Workshop: .NET MAUI",
                    Description = "Learn to build cross-platform apps with .NET MAUI.",
                    Location = "Tech Building - Room 101",
                    DateTime = DateTime.Now.AddDays(5),
                    Category = "Education"
                },
                new Event
                {
                    Title = "Campus Marathon",
                    Description = "Annual running event for health and community.",
                    Location = "University Stadium",
                    DateTime = DateTime.Now.AddDays(10),
                    Category = "Sports"
                }
            };
        }
    }
}
