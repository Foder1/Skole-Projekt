CREATE TABLE[dbo].[solgtBolig]
(
    [boligID] INT NOT NULL PRIMARY KEY,
	[bAdresse] Varchar(50),
	[bSt�rrelse] INT,
	[bPris] INT NOT NULL,
	[kundeID] INT NOT NULL,
)
