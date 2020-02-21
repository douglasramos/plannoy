# Plannoy

This is a simple expense planner app (currently only tracking transactions) that aims to show a simple, yet consistent, project using **Hexagonal Architect**, **Domain Driven Design** and several interesting patterns such as **CQRS**.

The App consist in generate a report on a given Race. The data input is a template file .txt in which each line correspond to a Race Event containing some useful information. This file can be found on the PresenterWeb Folder (That Folder is the Start of the application)

## Using The App

The Plannoy Api is deployed on the cloud. You can access the api on the following link:

- App Api (Azure): <https://plannoy.azurewebsites.net/>

The api root presents the swagger documentation. You can use currently 3 endpoints:

- Post Transaction API (API de lançamento)
- Get Transaction API (API de extrato)
- Establishment API (API de estabelecimento)

We believe that the swagger documentation is self-explanatory to the user be able to interact with the api. Therefore we won't discuss details on how to do this in this document.

## Running The App on local environment

The Web Api (Backend) for the applications was made wih C#/ASP.NET Core. To publish the api locally run the following command on the root folder:

```bash
dotnet run --project src/WebApi
```

You can test the endpoints using a rest API software of your choice or even via console through the **curl**. Example:

```bash
curl https://localhost:5000/api/v1/transactions/
```

## Project Structure

```bash
Plannoy src
├── WebApi                    # endpoints for the rest api
├── Application               # UseCases project.
├── Domain                    # Module with all the business logic, entity (domain) models and its services
├── Persistance               # All persistance related stuff goes here.

Plannoy tests
├── WebApi.IntegrationTests   # Integrations tests using a client that makes real calls to the rest api
```

## Features

### Business

- Transactions API
- Establishments API

### Technology

- WebApi monitoring with Prometheus
- Swagger Documentation

## Patterns and design principles

- Hexagonal Architecture (Ports and Adapters)
- Test Driven Development
- Domain Driven Design
- CQRS
- Inversion of Control
- Mediator Pattern
- Repository and Unit of Work Pattern

## Improvements (To be done)

### New Features

- Users (Authentication and Authorization)

### Scalability

- Load Balancer with multiple api server instances
- Two Databases. One for each domain boundary (Establishments and Transactions)

### Code Design

- Api Conventions
- Code refactoring to generalize CRUD Logic operation
- Fluent Validation instead of DataAnnotations
- Domain Events
