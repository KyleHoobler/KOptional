# KOptional

KOptional is a modern, lightweight C# library for representing optional values, inspired by functional programming paradigms. It provides a robust and expressive way to handle values that may or may not be present, reducing the risk of null reference errors and improving code clarity.

## Features

- **Strongly-Typed Optional Values:** Encapsulate the presence or absence of a value with `Optional<T>`.
- **Safe Value Access:** Use `HasValue`, `TryGetValue`, and `Coalesce` to safely interact with values.
- **Implicit Conversion:** Seamlessly convert values to optionals.
- **Equality and Hashing:** Built-in support for equality checks and hash codes.
- **Clear String Representation:** Easy debugging with meaningful `ToString()` output.
- **.NET 8 & C# 12 Ready:** Leverages the latest language and runtime features.

## Installation

Install via NuGet:

```
dotnet add package KOptional
```

Or via the NuGet Package Manager:
```
Install-Package KOptional
```

