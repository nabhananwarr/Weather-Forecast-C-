Weather Forecast Application

The Weather Forecast Application is a web-based tool developed using ASP.NET Core MVC, designed to provide real-time weather updates from a third-party API. It offers a clean, responsive user interface that allows users to quickly and efficiently check the current weather conditions of any city entered.

Features

Real-Time Weather Data: Fetch and display the weather conditions, including temperature, humidity, and atmospheric pressure, of any specified city.
Responsive Design: Ensures that the web application is accessible and functional on a variety of devices and screen sizes.
Error Handling: Robust error management to handle and display informative messages when the weather data cannot be retrieved.

Technologies Used
ASP.NET Core MVC: For creating the server-side application.
C#: Programming language for backend logic.
IHttpClientFactory: For managing HTTP requests to external weather data services.
Handling third-party API
Git: For version control.

Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

Prerequisites

What things you need to install the software and how to install them:
.NET 5.0 SDK or higher
Visual Studio with the ASP.NET and web development workload

Installation

Clone the repo:
git clone https://github.com/yourusername/weather-forecast-app.git
Open the folder in Visual Studio.

Restore NuGet packages:
dotnet restore

Build the solution:
dotnet build

Run the application:
dotnet run

After it opens on your browser:
Navigate to the home page.
Enter the name of the city in the input field.
Press "Get Weather" to display the current weather data.
