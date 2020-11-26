CREATE TABLE[dbo].[Køber]
(
    [køberID] INT NOT NULL PRIMARY KEY,
	[kNavn] Varchar(50),
	[kTelefon] INT,
	[kEmail] Varchar(50),
	[boligID] INT NOT NULL,
)
