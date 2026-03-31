using Campus.Services;
using System.Diagnostics;

namespace Campus;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        TestService();
    }

    private async void TestService()
    {
        var service = new MockEventService();
        var events = await service.GetEventsAsync();

        foreach (var ev in events)
        {
            Debug.WriteLine($"[TEAM 2] Event: {ev.Title} | Location: {ev.Location} | Category: {ev.Category}");
        }
    }
}
