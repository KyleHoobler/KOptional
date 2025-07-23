# KOptional

KOptional is a modern, lightweight C# library for representing optional values, inspired by functional programming paradigms. It provides a robust and expressive way to handle values that may or may not be present, reducing the risk of null reference errors and improving code clarity.

## Features

- **Strongly-Typed Optional Values:** Encapsulate the presence or absence of a value with `Optional<T>`.
- **Safe Value Access:** Use `HasValue`, `TryGetValue`, and `Coalesce` to safely interact with values.
- **Implicit Conversion:** Seamlessly convert values to optionals.
- **Equality and Hashing:** Built-in support for equality checks and hash codes.
- **Clear String Representation:** Easy debugging with meaningful `ToString()` output.
- **.NET 8 & C# 12 Ready:** Leverages the latest language and runtime features.

## Why KOptional?

Handling optional values is a common challenge in software development. KOptional helps you:

- Avoid null reference exceptions.
- Write more readable and maintainable code.
- Embrace functional programming patterns in C#.

## Getting Started

### Installation

Add the KOptional project to your solution or reference it as a library.

### Usage
using KOptional;
// Create an optional with a value var opt = new Optional<int>(42);
// Check if a value is present if (opt.HasValue) { Console.WriteLine($"Value: {opt.Value}"); }
// Use implicit conversion Optional<string> name = "Alice";
// Safe value extraction if (name.TryGetValue(out var value)) { Console.WriteLine($"Name: {value}"); }
// Provide a default value var result = name.Coalesce("Unknown");


## API Overview

- `Optional<T>`: The core struct representing an optional value.
- `HasValue`: Indicates if a value is present.
- `Value`: Gets or sets the value.
- `TryGetValue(out T value)`: Safely extracts the value.
- `Coalesce(T defaultValue)`: Returns the value or a default.
- Implicit conversion from `T` to `Optional<T>`.
- Overridden `Equals`, `GetHashCode`, and `ToString`.

## Unit Tests

KOptional includes comprehensive unit tests to ensure reliability and correctness. See `KOptionalTests/OptionalTests.cs` for examples.

## License

This project is licensed under the terms of the license found in `LICENSE.txt`.

## Contributing

Contributions are welcome! Please open issues or submit pull requests to help improve KOptional.

---

**KOptional**: Make your C# code safer, clearer, and more expressive.