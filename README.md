# Example .NET Core 2.2 Microservice - Boilerplate
This is a repository containing a mostly empty C# / ASP.NET Core 2.2 microservice that's ready to be connected to the CDC's [Foundation Services](https://github.com/CDCGov/fdns). It includes implementations for:

* Logging
* [FDNS .NET Core SDK](https://github.com/erik1066/fdns-dotnet-sdk)
* OAuth2 scope-based authorization
* [FDNS Object microservice](https://github.com/CDCGov/fdns-ms-object) for all database CRUD operations
* [FDNS Storage microservice](https://github.com/CDCGov/fdns-ms-storage) for storing CSV files used for bulk record imports
* Auto-generated, live API documentation via Swagger pages and C# XML code comments
* Cross-origin resource sharing
* Easy containerization via a `Dockerfile` and `Makefile`
* Two-stage Docker builds
* Health checks

## Modifying this microservice
Open `BoilerplateController.cs` and add begin adding your own logic.

For guidance on how to work with CDC's Foundation Services, see the documentation on using the [FDNS .NET Core SDK](https://github.com/erik1066/fdns-dotnet-sdk/tree/master/docs).

For guidance on how to run and debug this microservice, see the [usage guide](docs/USAGE.md).

## License
The repository utilizes code licensed under the terms of the Apache Software License and therefore is licensed under ASL v2 or later.

This source code in this repository is free: you can redistribute it and/or modify it under
the terms of the Apache Software License version 2, or (at your option) any later version.

This source code in this repository is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A
PARTICULAR PURPOSE. See the Apache Software License for more details.

You should have received a copy of the Apache Software License along with this program. If not, see https://www.apache.org/licenses/LICENSE-2.0.html.

The source code forked from other open source projects will inherit its license.