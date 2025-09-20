# .NET Enterprise System

Enterprise-grade .NET application with 3-layer architecture, WinForms UI and multiple storage options for managing products, customers, promotions and orders.

## Architecture

- **UI Layer** - WinForms user interface
- **BL (Business Logic)** - Business rules and logic
- **DAL (Data Access Layer)** - Data storage abstraction
  - **DalList** - In-memory storage using Lists
  - **DalXml** - XML file storage

## Key Technical Highlights

- **Clean Architecture** - Proper separation of concerns across 3 layers
- **SOLID Principles** - Dependency inversion with interfaces
- **Design Patterns** - Factory and Singleton implementations
- **Flexible Data Storage** - Easy switching between storage types
- **Scalable Design** - Easy to extend with new features

## Design Patterns Implemented

- **Factory Pattern** - For creating objects and flexible component switching
- **Singleton Pattern** - For optimal memory management and preventing concurrent access

## Features

- Product management with inventory tracking
- Customer management with membership support
- Sales promotions and discounts
- Order processing
- Dual storage options (Lists/XML)

## Requirements

- .NET 7.0 or higher
- Visual Studio 2022 or VS Code

## Getting Started

1. Clone the repository
   ```bash
   git clone https://github.com/MiriAppel/dotnet-enterprise-system.git
   ```
2. Open `DotNet2025_2896_1507.sln` in Visual Studio
3. Set UI project as startup project
4. Build and run

## Project Structure

```
├── BL/                 # Business Logic Layer
├── DalFacade/         # Data Access Interface
├── DalList/           # In-Memory Implementation
├── DalXml/            # XML Storage Implementation
├── UI/                # WinForms User Interface
├── Tools/             # Utilities
└── xml/               # XML data files
```

## Technologies

- C# .NET 7.0
- Windows Forms
- XML Storage
- Layered Architecture Pattern
