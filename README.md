<img width="100%" src="https://capsule-render.vercel.app/api?type=waving&color=9df2ea&animation=fadeIn&height=120&section=header"/>

## Descripción del Proyecto

Bienvenido a **BankApiRESTful**, mi primera toma de contacto con arquitecturas limpias y patrones de diseño, un proyecto de API RESTful diseñado para gestionar operaciones bancarias básicas. Este proyecto es una excelente oportunidad para explorar y experimentar con la arquitectura hexagonal y varias tecnologías modernas en el ecosistema .NET.  
Disfrutadlo tanto como he llorado yo 😅🤣

### Arquitectura Hexagonal

Este proyecto utiliza la **arquitectura hexagonal** (también conocida como arquitectura de puertos y adaptadores). Esta arquitectura busca separar las reglas de negocio del código que interactúa con el mundo exterior, como la base de datos y las interfaces de usuario. El objetivo es crear un sistema flexible y mantenible, donde las reglas de negocio están encapsuladas en el núcleo de la aplicación y los adaptadores se encargan de interactuar con servicios externos.

### Tecnologías Utilizadas

- **.NET**: Plataforma de desarrollo para crear aplicaciones modernas, seguras y eficientes.
- **Entity Framework Core**: ORM (Object-Relational Mapper) para interactuar con bases de datos de manera eficiente y sencilla.
- **FluentValidation**: Biblioteca para la validación de datos con una sintaxis fluida y expresiva.
- **AutoMapper**: Biblioteca que simplifica el mapeo entre objetos de diferentes tipos.
- **MediatR**: Implementación del patrón Mediator para manejar solicitudes y notificaciones en la aplicación de manera desacoplada
- **Swagger**: Herramienta para generar documentación interactiva y explorar la API RESTful.
- **Docker-Compose**: Herramienta para definir y ejecutar aplicaciones Dockerizadas, utilizada aquí para dockerizar la base de datos SQL Server.

## Estructura del Proyecto

El proyecto sigue una estructura basada en la arquitectura hexagonal:

- **`Application`**: Contiene la lógica de negocio, servicios, interfaces y comandos.
- **`Domain`**: Define las entidades y las reglas de negocio.
- **`Persistence`**: Implementa la persistencia de datos utilizando Entity Framework Core.
- **`API`**: Proporciona las rutas de la API y maneja las solicitudes HTTP.

## Instalación y Ejecución

### Requisitos Previos

- [.NET 7 SDK o superior](https://dotnet.microsoft.com/download)
- [Docker y Docker-Compose](https://docs.docker.com/get-docker/)

<img src="https://raw.githubusercontent.com/matfantinel/matfantinel/master/waves.svg" width="100%" height="100">
