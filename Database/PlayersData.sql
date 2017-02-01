CREATE TABLE [dbo].[PlayersData]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(20) NOT NULL, 
    [Surname] VARCHAR(10) NOT NULL, 
    [Sex] VARCHAR NOT NULL, 
    [Club] TEXT NULL, 
    [SwimTime] TIME NULL, 
    [Birth] DATE NOT NULL
)
