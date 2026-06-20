USE OnlineRetailStore;
GO

------------------------------------------------
-- ROW_NUMBER()
------------------------------------------------

SELECT
    ProductID,
    ProductName,
    Category,
    Price,

    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber
FROM Products;

------------------------------------------------
-- TOP 3 PRODUCTS PER CATEGORY
------------------------------------------------

SELECT *
FROM
(
    SELECT
        ProductID,
        ProductName,
        Category,
        Price,

        ROW_NUMBER() OVER
        (
            PARTITION BY Category
            ORDER BY Price DESC
        ) AS RowNumber

    FROM Products
) RankedProducts
WHERE RowNumber <= 3;

------------------------------------------------
-- RANK()
------------------------------------------------

SELECT
    ProductName,
    Category,
    Price,

    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS ProductRank

FROM Products;

------------------------------------------------
-- DENSE_RANK()
------------------------------------------------

SELECT
    ProductName,
    Category,
    Price,

    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRank

FROM Products;

------------------------------------------------
-- COMPARISON OF ALL FUNCTIONS
------------------------------------------------

SELECT
    ProductName,
    Category,
    Price,

    ROW_NUMBER() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RowNumber,

    RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS RankNumber,

    DENSE_RANK() OVER
    (
        PARTITION BY Category
        ORDER BY Price DESC
    ) AS DenseRankNumber

FROM Products;