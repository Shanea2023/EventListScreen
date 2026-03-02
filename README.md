\# Campus Activity Manager — Team 2 (Event List Screen)



\## Project Overview



This module implements the Event List Screen for the Campus Activity Manager mobile application using .NET MAUI.



The screen displays a list of campus events using:



\- MVVM architecture

\- XAML UI

\- CollectionView

\- Data binding

\- Mock data service



No database or API is used.



---



\## Team Members and Responsibilities



\### Member 1 — Event Model \& Data Service

Branch: event-model-service



Responsibilities:



\- Create Models/Event.cs

\- Define event properties:

&nbsp; - Id

&nbsp; - Title

&nbsp; - Description

&nbsp; - Date

&nbsp; - Location

&nbsp; - Image

&nbsp; - Category

&nbsp; - IsRegistered



\- Create Services/EventService.cs

\- Provide mock event data



---



\### Member 2 — UI Design \& Event Card Component

Branch: event-list-ui



Responsibilities:



\- Create Views/EventListPage.xaml

\- Design UI using CollectionView

\- Create reusable component:



Components/EventCard.xaml



Display:



\- Event image

\- Title

\- Date

\- Location



---



\### Member 3 — ViewModel \& Binding (Team Leader)

Branch: event-list-viewmodel



Responsibilities:



\- Create ViewModels/EventListViewModel.cs

\- Create ObservableCollection<Event>

\- Connect EventService

\- Bind data to UI

\- Implement event selection command



---



\## Project Structure





