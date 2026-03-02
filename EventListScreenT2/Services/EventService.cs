using EventListScreenT2.Models;

namespace EventListScreenT2.Services;

public class EventService
{
    public List<Event> GetEvents()
    {
        return new List<Event>
        {
            new Event
            {
                Id = Guid.NewGuid(),
                Title = "Freshman Welcome Night 2026",
                Description = "A grand musical event to welcome all new students to the campus.",
                Date = DateTime.Now.AddDays(5),
                Location = "Main Auditorium A",
                Image = "dotnet_bot.png",
                Category = "Music",
                IsRegistered = false
            },
            new Event
            {
                Id = Guid.NewGuid(),
                Title = "AI & .NET MAUI Workshop",
                Description = "Hands-on session on building smart mobile apps using .NET MAUI and AI.",
                Date = DateTime.Now.AddDays(10),
                Location = "IT Lab 02",
                Image = "dotnet_bot.png",
                Category = "Education",
                IsRegistered = true
            },
            new Event
            {
                Id = Guid.NewGuid(),
                Title = "Campus Marathon 2026",
                Description = "Annual marathon for health and community spirit.",
                Date = DateTime.Now.AddDays(15),
                Location = "Stadium",
                Image = "dotnet_bot.png",
                Category = "Sports",
                IsRegistered = false
            }
        };
    }
}