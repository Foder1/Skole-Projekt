CREATE TABLE[dbo].[solgtBolig]
(
    [boligID] INT NOT NULL PRIMARY KEY,
	[bAdresse] Varchar(50),
	[bStørrelse] INT,
	[bPris] INT NOT NULL,
	[bSolgtPris] INT NOT NULL,
	[køberID] INT NOT NULL,
	[sælgerID] INT NOT NULL,
	[bBy] Varchar(50),
	[bDato] Date
)
