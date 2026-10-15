# Simple Movie Manager

A beginner-friendly desktop application built with **C# and Windows Forms** that allows users to manage a simple movie collection.

This project was created as a practical coding exercise to practise fundamental C# programming concepts through a graphical user interface.

## Features

- **Add Movies:** Enter a movie title and release year, then select a processing location.
- **Remove Movies:** Remove a selected movie from the collection.
- **Search Movies:** Search for movies by title.
- **View All Movies:** Display all movies stored in the collection.
- **Input Validation:** Validate movie titles, release years, and required selections.
- **Date and Time Formatting:** Display the date, time, and timestamp when a movie is added.
- **Error Handling:** Use `try`, `catch`, and `finally` to handle errors and manage processing.
- **Decision-Making:** Use `if` statements to validate input and control program behaviour.
- **Loops:** Use `foreach` to search and display movie records.

## Technologies Used

- C#
- Windows Forms
- .NET
- Visual Studio
- Git and GitHub

## Getting Started

### Prerequisites

- Windows operating system
- Visual Studio with the .NET desktop development workload installed
- A compatible .NET SDK

### Installation

1. Clone this repository or download the project.
2. Open `SimpleMovieManager.sln` in Visual Studio.
3. Restore any required dependencies if prompted.
4. Build the solution.
5. Run the application using **F5**.

### How to Use

1. Enter a movie title.
2. Enter the movie's release year.
3. Select a processing location.
4. Click **Add Movie** to add the movie to the collection.
5. Select a movie and click **Remove Selected** to remove it.
6. Enter a title in the search field and click **Search** to find matching movies.
7. Click **Show All** to display the full collection.

## Date and Time Information

The application uses `DateTime.Now` to retrieve the computer's local date and time.

Example formats:

- Date: `dd/MM/yyyy`
- Time: `HH:mm:ss`
- Timestamp: `yyyy-MM-dd HH:mm:ss`

The displayed timestamp represents when the movie was added to the application, not the movie's release date.

## Learning Objectives

This project demonstrates:

- Variables and data types
- Lists and collections
- Conditional statements
- Loops and repetition
- Input validation
- Exception handling
- Windows Forms controls and events
- Date and time formatting
- Debugging with Visual Studio

## Limitations

- Movies are stored in memory and are not saved permanently.
- The collection resets when the application closes.
- Processing location is selected manually by the user.
- The current version displays timestamp details when a movie is added but does not permanently store all those details with each movie.

## Future Improvements

- Save movies to a file or database.
- Store each movie's timestamp and processing location with its record.
- Add movie ratings and descriptions.
- Improve the interface and search functionality.
- Add automated tests.

## Author

Created as a practical C# Windows Forms learning project.
