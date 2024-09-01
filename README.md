# Health News Web Application

## Overview

The Health News Web Application is a modern, full-stack web application designed to display and categorize health news articles. It features category-based filtering and a user-friendly interface. The application is built using ASP.NET Core for the backend and integrates various services to manage and display news articles effectively.

## Features

- **Category-Based Filtering**: Allows users to filter news articles based on categories like Health, Technology, Sports, and Others.
- **Responsive Design**: The application is designed to be responsive and user-friendly across various devices.
- **Dynamic Content**: Fetches and displays the latest health news articles dynamically.

## Technologies Used

- **Backend**: ASP.NET Core
- **Frontend**: HTML, CSS
- **Database**: In-Memory Data Storage (for any temporary data)
- **Services**: Integration with news APIs to fetch articles

## Installation

1. **Clone the Repository**

   ```bash
   git clone https://github.com/yourusername/health-news-web-application.git
   
2. **Navigate to the Project Directory**

   ```bash
   cd health-news-web-application

3. **Restore NuGet Packages**

   ```bash
   dotnet restore

4. **Build the Application**

   ```bash
   dotnet build

5. **Run the Application**

   ```bash
   dotnet run
   
The application will be available at http://localhost:5000.

## Usage

- **View News Articles**: Navigate to the home page to view the latest health news articles.
- **Filter by Category**: Use the dropdown menu to select a category and view articles related to that category.

## Configuration

- **API Integration**: Configure your news API settings in the appsettings.json file if needed.
