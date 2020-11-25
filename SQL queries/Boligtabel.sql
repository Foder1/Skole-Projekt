CREATE TABLE[dbo].[solgtBolig]
(
    [boligID] INT NOT NULL PRIMARY KEY,
	[bAdresse] Varchar(50),
	[bStørrelse] INT,
	[bPris] INT NOT NULL,
	[kundeID] INT NOT NULL,
)
