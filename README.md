# Campus Activity Manager — Team 2 (Event List Screen)

## Project Overview

This repository contains the Event List Screen module of the Campus Activity Manager mobile application, developed using .NET MAUI.

The purpose of this module is to display a list of campus events in a clear and user-friendly interface. Each event will show important information such as the title, date, location, and image.

This module follows the MVVM (Model-View-ViewModel) architecture and uses mock data (no database or API required).

---

## Technologies Used

- .NET MAUI
- C#
- XAML
- MVVM Architecture
- CollectionView
- ObservableCollection
- Command Binding
- Git & GitHub for collaboration

---

## Team Members and Responsibilities

Each member must work in their own branch and only on their assigned files.

---

David — Model & Data Service   
Branch name: `event-model-service`

Responsibilities:

- Create folder: `Models`
- Create file: `Models/Event.cs`
- Define Event properties such as:
  - Id
  - Title
  - Description
  - Date
  - Location
  - Image
  - Category
  - IsRegistered

- Create folder: `Services`
- Create file: `Services/EventService.cs`
- Implement mock data
- Return a list of events

This member must push first.

---

Shanea — ViewModel (Team Leader)   
Branch name: `event-list-viewmodel`

Responsibilities:

- Create folder: `ViewModels`
- Create file: `ViewModels/EventListViewModel.cs`
- Create ObservableCollection<Event>
- Connect EventService to ViewModel
- Implement commands
- Handle event selection logic
- Prepare data for UI binding

This member pushes after the Model & Service member.

---

Thao— UI Design & Components   
Branch name: `event-list-ui`

Responsibilities:

- Create folder: `Views`
- Create file: `Views/EventListPage.xaml`

- Create folder: `Components`
- Create reusable component:
  - `Components/EventCard.xaml`

- Use CollectionView to display events
- Bind UI to EventListViewModel
- Display event image, title, date, and location

This member pushes last.

---

## Project Structure 
