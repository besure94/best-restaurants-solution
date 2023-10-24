## Best Restaurants

#### A web application that allows users to create a list of cuisines, and add restaurants to their respective cuisines.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* ASP.NET MVC
* EF Core
* MySQL

## Description

This application presents users with a home page where they are presented with a link to a list of restaurants, a link to a list of cuisines, and a link to a page where they can search for cuisines. Users add a cuisine to a list, and then add a restaurant that belongs to that type of cuisine. Users can also edit or delete each restaurant or cuisine type. Users can search for a type of cuisine, and if such a cuisine exists in the database, they will be directed to that cuisine. There they can see all restaurants belonging to that particular cuisine.

## Setup Instructions

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-1-5-getting-started-with-c/3-0-0-01-welcome-to-c).

### Set up Project Database

Follow the instructions in the LearnHowToProgram.com lesson ["Introduction to MySQL Workbench: Creating a Database"](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-3-database-basics/3-3-0-04-introduction-to-mysql-workbench-creating-a-database) to create a `best_restaurants_with_ef_core` database with a `cuisines` and `restaurants` table.

For the `cuisines` table, create columns for "CuisineId" and "Type". For the `restaurants` table, create columns for "CuisineId", "RestaurantId", "Name", and "Description". Refer to the lesson directly above for more detailed instructions on how to do this.

### Set up and Run Project

1. Select the green button that says `Code`, and clone this repository.
2. Open your terminal and navigate to this project's production directory called `BestRestaurants`.
3. In the production directory `BestRestaurants`, create a new file called `appsettings.json`.
4. In `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, always assume the `uid` is `root` and the `pwd` is `epicodus`. Example below:

{

    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=music_organizer_with_mysqlconnector;uid=root;pwd=epicodus;",
      "TestConnection": "Server=localhost;Port=3306;database=music_organizer_with_mysqlconnector_test;uid=root;pwd=epicodus;"
    }

}

5. In the production directory `BestRestaurants`, run the command `dotnet watch run` to launch the project in development mode with a watcher.
6. Open the browser to [https://localhost:5001](https://localhost:5001). If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this LearnHowToProgram lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-2-basic-web-applications/3-2-0-17-redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

Application is functioning fully as intended. I would like to add some CSS styling later on, though.

## License

MIT

Copyright(c) 2023 Brian Scherner