CREATE TABLE[dbo].[Sælger]
(
    [kundeID] INT NOT NULL PRIMARY KEY,
	[sNavn] Varchar(50),
	[sTelefon] INT,
	[sEmail] Varchar(50),
	[boligID] INT NOT NULL,
	FOREIGN KEY (boligID) REFERENCES bolig (boligid)
)
