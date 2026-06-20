# E-Commerce Platform Search Function

## Overview
This project demonstrates the implementation of Linear Search and Binary Search algorithms for searching products in an e-commerce platform.

## Features
- Product class with:
  - Product ID
  - Product Name
  - Category
- Linear Search implementation
- Binary Search implementation
- Time Complexity Analysis

## Project Structure

```text
EcommerceSearchFunctionExample
│
├── Models
│   └── Product.cs
│
├── Services
│   └── SearchService.cs
│
├── Program.cs
└── README.md
```

## Algorithms Used

### Linear Search
Searches products one by one.

**Time Complexity**
- Best Case: O(1)
- Average Case: O(n)
- Worst Case: O(n)

### Binary Search
Searches products in a sorted array by repeatedly dividing the search space.

**Time Complexity**
- Best Case: O(1)
- Average Case: O(log n)
- Worst Case: O(log n)

## Sample Products

| Product ID | Product Name | Category |
|------------|-------------|----------|
| 101 | Laptop | Electronics |
| 102 | Mobile | Electronics |
| 103 | Shoes | Fashion |
| 104 | Watch | Accessories |
| 105 | Headphones | Electronics |

## How to Run

```bash
dotnet run
```

## Conclusion

Binary Search is more efficient for large datasets because it has O(log n) complexity, whereas Linear Search has O(n) complexity.