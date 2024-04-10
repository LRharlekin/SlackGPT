## Clean Architecture

### Domain Layer

**Responsiblities**: Entity definitions, business rules about chats

- .Domain (classlib project)

### Application Layer

**Responsiblities**: Interfaces for interacting with infrastructure, interfaces for data access (IRepository)

- .Application (classlib project)

### Presentation Layer

**Responsiblities**: Controllers that receive the requests to create resources, invoke logic in Application layer, "window to the outside world"

- .Contracts (classlib project)
- .API (webapi project)

### Infrastructure Layer

**Responsibilities**: Data persistence, implementing repositories

- .Persistence (classlib project)

### Database

- SQL Server
