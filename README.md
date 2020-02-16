# Plannoy

This is a simple expense planner app (currently only tracking transactions) that aims to show a simple, yet consistent, project using **Hexagonal Architect**, **Domain Driven Design** and several interesting patterns such as **CQRS**.

The App consist in generate a report on a given Race. The data input is a template file .txt in which each line correspond to a Race Event containing some useful information. This file can be found on the PresenterWeb Folder (That Folder is the Start of the application)

## Using The App

The Plannoy App is deployed on the cloud. You can access the app on the following links

- App Api (Azure): <https://plannoy.azurewebsites.net/api/v1/transactions/>

### Post Transaction API (API de lançamento)

### Get Transaction API (API de extrato)

### Establishment API (API de estabelecimento)

## Running The App on local environment

The Web Api (Backend) for the applications was made wih C#/ASP.NET Core. To publish the api locally run the following command on the root folder:

```bash
dotnet run --project WebApi
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
├── Infrastructure            # All persistance related stuff goes here.

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
- Mediator Pattern
- Repository and Unit of Work Pattern
