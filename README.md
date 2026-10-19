# KingOfLINQ

A small **Windows Forms (.NET 6) playground** for learning LINQ by running it. A form with a button per exercise (about 37 click handlers) runs queries over a small set of `Pet` and `PetOwner` objects and prints the results.

## What it demonstrates
- Filtering and projection: `Where`, `Select`, `SelectMany`, `Take`, `Skip`, `OrderBy`
- Joining: `Join`, `GroupJoin`, `DefaultIfEmpty` (left join), `ToLookup`, `GroupBy`
- Set operations: `Union`, `Intersect`, `Except`, `Concat`, `Distinct`, `Zip`
- Quantifiers and aggregation: `Any`, `All`, `First`/`FirstOrDefault`, `Aggregate`
- A custom `IEqualityComparer<Pet>` (`PetComparerById`), an `IComparer<Pet>` (`PetByTypeComparer`) and an extension method (`Helper/ExtensionMethods.cs`)

## Run
Requires Windows and the .NET 6 SDK (or newer with the .NET 6 targeting pack).
```bash
cd KingOfLINQ/KingOfLINQ/KingOfLINQ
dotnet run
```

## Layout
```
KingOfLINQ/KingOfLINQ/KingOfLINQ/
  Form1.cs            the exercises (button click handlers)
  Helper/             Pet, PetOwner, comparers, extension methods, Printer
```
Licensed under MPL-2.0 (see `LICENSE`). Educational code from 2023; it is meant to be read next to the Microsoft LINQ documentation.
