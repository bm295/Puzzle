# Puzzle

This solution has been modernized to **C# 14** on **.NET 10**.

## Prerequisites

- .NET 10 SDK
- Node.js (only required if you want to run the React client in development)

## Run the web app

From the repository root:

```bash
dotnet run --project WebApplication/WebApplication.csproj
```

## Run the Equality demo

A new `EqualityDemo` class demonstrates value-based equality semantics with:

- `IEquatable<T>`
- overridden `Equals` and `GetHashCode`
- `==` and `!=` operators

Run it from the repository root:

```bash
dotnet run --project WebApplication/WebApplication.csproj -- --demo-equality
```

Expected output includes comparisons and distinct item counting in a `HashSet`.
