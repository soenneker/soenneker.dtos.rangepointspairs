[![](https://img.shields.io/nuget/v/soenneker.dtos.rangepointspairs.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.rangepointspairs/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.rangepointspairs/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.rangepointspairs/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.rangepointspairs.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.rangepointspairs/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.rangepointspairs/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.rangepointspairs/actions/workflows/codeql.yml)

# Soenneker.Dtos.RangePointsPairs

A DTO for associating decimal bounds with an integer point value, suitable for scoring tiers, pricing bands, and similar API payloads.

## Install

```bash
dotnet add package Soenneker.Dtos.RangePointsPairs
```

## Usage

```csharp
using Soenneker.Dtos.MinMax;
using Soenneker.Dtos.RangePointsPairs;

var tier = new RangePointsPair
{
    Range = new MinMax
    {
        Min = 80m,
        Max = 89.99m
    },
    Points = 4
};
```

It serializes with the same shape under `System.Text.Json` and Newtonsoft.Json:

```json
{
  "range": {
    "min": 80,
    "max": 89.99
  },
  "points": 4
}
```

`Range` is required during initialization. The DTO does not decide whether bounds are inclusive, enforce `Min <= Max`, prevent overlapping tiers, or constrain negative point values; those are rules for the consuming application.
