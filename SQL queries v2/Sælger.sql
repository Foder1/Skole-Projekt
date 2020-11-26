CREATE TABLE[dbo].[Sælger]
(
    [sælgerID] INT NOT NULL PRIMARY KEY,
	[sNavn] Varchar(50),
	[sTelefon] INT,
	[sEmail] Varchar(50),
	[boligID] INT NOT NULL,
)