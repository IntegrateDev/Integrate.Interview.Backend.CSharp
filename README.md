# Integrate Back-End Interview Exercise
The center of Integrate's product is the __Demand Acceleration Platform (DAP)__. DAP allows users to interact with marketing lead data. A __marketing lead__ is a person who shows interest in a company's products or services. Our customers need marketing leads that are correct and likely to generate business. 

We are striving to build a world-class application with microservices that expose their functionality through RESTful APIs. For this exercise, you will be asked to create a simple RESTful API using C#. This repo provides a working solution for you to use as a base.

1. The RESTful API should include a data model that consists of a Person class with the following properties:
    * First Name (mandatory)
    * Last Name (mandatory)
    * Email (mandatory)
    * Company (optional)
    * ZIP Code (optional)
    * Phone Number (mandatory)
    * Date Created

2. The API should allow the user to add a new person to the dataset.
    * A persistent datastore isn't required. The datastore can instead be memory-based. But, the code should be designed in such a way that a persistent datastore could be substituted later.
3. The API should allow the user to retrieve all people in the dataset.
    

## Dependencies
You must have the following dependencies installed:
* [.NET 5](https://dotnet.microsoft.com/download)

## Running in Visual Studio
* Open `Integrate.Interview.Backend.sln` in Visual Studio.
* Run the solution.

## Running from the command line
In a command line, run these commands from the root of the repo:
```
cd Integrate.Interview.Backend
dotnet run
```

## Writing code
This solution has a file called `PeopleController.cs` that will help you get started. A single GET endpoint has been provided. 

## Testing your code
With your solution running, navigate to https://localhost:44390/index.html to view the Swagger documentation.

Each endpoint has a "Try It Out" section that allows you to test.
