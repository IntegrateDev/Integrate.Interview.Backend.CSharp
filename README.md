# Integrate Back-End Interview Exercise
## Overview
The center of Integrate's product is the Demand Acceleration Platform (DAP). DAP allows users to interact with marketing lead data. A marketing lead is a person who shows interest in a company's products or services. Our customers need marketing leads that are correct and likely to generate business.

We are striving to build a world-class application with microservices that expose their functionality through RESTful APIs.

## Exercise Definition
It is important to us that your interview exercise is relevant to the kind of work you would be performing at Integrate.

For this exercise, you will be asked to create a simple RESTful API using C#. This repo provides a working solution for you to use as a base.

1. The RESTful API should include a data model that consists of a Person class with the following properties:
    * First Name (mandatory)
    * Last Name (mandatory)
    * Email (mandatory)
    * Company (optional)
    * ZIP Code (optional)
    * Phone Number (mandatory)
    * Date Created

2. A persistent datastore isn't required. The datastore can instead be memory-based. But, the code should be designed in such a way that a persistent datastore could be substituted later.
3. The API should allow the user to retrieve all people stored in the DB.
4. The API should allow the user to add a new person to the DB.

## Collaboration
This interview is about more than just code; we're also hoping to discover the following:

* How comfortable are you with pair/group programming? Our culture is highly collaborative.
* What things are you considering when you are coding? Being able to explain what you're doing and why you're doing it is critical to our continuous improvement as a team.
* Asking questions (for requirements clarity or help) is encouraged.

## Additional Topics for Discussion
In addition to the exercise itself, we will be discussing topics related to well-written, production-ready REST APIs. While you won't explicitly be asked to implement any of these concepts, be prepared to discuss how they could be implemented in your app. (We may not cover every concept, and you may bring up other concepts not on this list.)

* Automated Testing
    - Unit testing
    - Integration testing
* Common design patterns
* SOLID principles
* IOC containers
* Model binding
* Input validation

## Here we go!
Open the [Getting Started Guide](GETTINGSTARTED.md) to get started!
