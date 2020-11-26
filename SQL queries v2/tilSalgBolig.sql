CREATE TABLE[dbo].[tilSalgBolig]
(
    [boligID] INT NOT NULL PRIMARY KEY,
	[bAdresse] Varchar(50),
	[bStørrelse] INT,
	[bPris] INT NOT NULL,
	[sælgerID] INT NOT NULL,
)
