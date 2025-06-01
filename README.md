# Solidex.Core.Base

`Solidex.Core.Base` is a foundational .NET library providing core abstractions, complex types, enumerations, infrastructure components, and response models for building robust applications.

## Features

This library includes:

- **Abstractions**: Interfaces and abstract classes for common entities and calendar functionalities.
- **Complex Types**: Reusable data structures like `Money`, `MonthYear`, `DayWeek`, `MskPhoto`, `SystemUsersEnumeration`, and `TypeEnumeration`.
- **Enums**: A comprehensive set of enumerations for various statuses and types, including `AccessStatus`, `CallType`, `CashProvider`, `ClientType`, `Currency`, `EventActivityState`, `EventState`, `FileEntryType`, `MessageStatus`, `PriceType`, `QuotationStatus`, `RecordState`, `RuleType`, `ServiceCategoryState`, `ServiceState`, `SmsStatus`, `SpecialistState`, and `TratsactionType`.
- **Infrastructure**: Core components for currency conversion, pagination (`PageView`), and generic response view models.
- **Querying**: Request models for filtering and searching data, such as `FieldRequest`, `FilterRequest`, `IdsSearchRequest`, and `StringFieldRequest`.
- **Responses**: Standardized response models for API operations, including `DeleteResponse`, `ItemResponse`, and `PageViewResponse`.

## Installation

### NuGet Package

To install `Solidex.Core.Base` via NuGet, use the .NET CLI:

```bash
dotnet add package Solidex.Core.Base --version 1.0.4
 or 

Install-Package Solidex.Core.Base -Version 1.0.4
```

```plaintext
Solidex.Core.Base/
├── Abstraction/             # Core interfaces and abstract classes
├── ComplexTypes/            # Reusable data structures
├── Enums/                   # Enumerations for various types and statuses
├── Extensions/              # Extension methods
├── Infrastructure/          # Core infrastructure components and querying models
├── Localization/            # Localization related interfaces and classes
├── Responses/               # Standardized response models
├── Translate/               # Translation utilities
└── Solidex.Core.Base.csproj # Project file
```