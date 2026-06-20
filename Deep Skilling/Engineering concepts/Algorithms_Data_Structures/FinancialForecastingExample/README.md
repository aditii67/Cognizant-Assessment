# Financial Forecasting Example

## Overview

This project demonstrates a Financial Forecasting System implemented in C#. The application predicts future financial values based on an initial investment amount, annual growth rate, and number of years using a recursive algorithm.

---

## Objective

To understand and implement recursion by forecasting future financial values based on historical growth rates.

---

## Concepts Used

- Recursion
- Object-Oriented Programming (OOP)
- Classes and Objects
- Time Complexity Analysis
- Financial Forecasting

---

## Project Structure

```text
FinancialForecastingExample
│
├── Models
│   └── ForecastData.cs
│
├── Services
│   └── ForecastService.cs
│
├── Program.cs
├── README.md
└── FinancialForecastingExample.csproj
```

---

## How Recursion Works

The recursive function calculates the future value year by year.

### Recursive Formula

Future Value = Current Value × (1 + Growth Rate)

The function calls itself until the number of years becomes 0.

### Base Case

```csharp
if (years == 0)
{
    return currentValue;
}
```

### Recursive Call

```csharp
return PredictFutureValue(
    currentValue * (1 + growthRate / 100),
    growthRate,
    years - 1);
```

---

## Sample Input

```text
Initial Value : 10000
Growth Rate   : 10
Years         : 5
```

## Sample Output

```text
Future Value : 16105.10
```

---

## Time Complexity Analysis

### Recursive Approach

| Complexity Type | Value |
|-----------------|--------|
| Time Complexity | O(n) |
| Space Complexity | O(n) |

Where n = Number of Years

---

## Optimization

Instead of recursion, the future value can be calculated directly using:

```csharp
futureValue = initialValue * Math.Pow(1 + growthRate / 100, years);
```

### Optimized Complexity

| Complexity Type | Value |
|-----------------|--------|
| Time Complexity | O(1) |
| Space Complexity | O(1) |

---

## How to Run

### Build Project

```bash
dotnet build
```

### Run Project

```bash
dotnet run
```

---

## Technologies Used

- C#
- .NET Console Application
- Visual Studio Code

---

## Conclusion

This project demonstrates how recursion can be used to solve financial forecasting problems. While recursion provides a simple and intuitive solution, mathematical formulas such as `Math.Pow()` offer a more efficient approach for large datasets.

