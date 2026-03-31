using System;

namespace Campus.Models
{
    public class Event
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }
        public string ImageUrl { get; set; } = "dotnet_bot.png";
        public string Category { get; set; } = "General"; 
        public bool IsRegistered { get; set; }
    }
}
