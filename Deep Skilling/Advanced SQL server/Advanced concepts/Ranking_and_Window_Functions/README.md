# Exercise 1: Ranking and Window Functions

## Goal

Use SQL Window Functions:

- ROW_NUMBER()
- RANK()
- DENSE_RANK()
- OVER()
- PARTITION BY

## Scenario

Find the top 3 most expensive products in each category.

## Files

### SampleData.sql

Creates the database, table, and sample records.

### Exercise1_Ranking_Window_Functions.sql

Contains solutions for:

- ROW_NUMBER()
- RANK()
- DENSE_RANK()
- PARTITION BY
- Top 3 products in each category

## SQL Concepts Used

### ROW_NUMBER()

Assigns a unique sequence number.

### RANK()

Assigns ranks with gaps for ties.

### DENSE_RANK()

Assigns ranks without gaps.

### PARTITION BY

Groups records by category.

### ORDER BY

Sorts products by descending price.

## Expected Result

Displays the highest-priced products in each category using different ranking techniques.