CREATE TABLE Articles (
    Id INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(255),
    ImageUrl NVARCHAR(255),
    Details NVARCHAR(MAX),
    Preview NVARCHAR(MAX),
    PublishedDate DATETIME,
    Author NVARCHAR(255)
);
