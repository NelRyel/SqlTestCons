--CREATE TABLE Games (Id INT PRIMARY KEY INDENTITY, Name NVARCHAR(100) NOT NULL, Description NVARCHAR(1000))
--CREATE TABLE Games (Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(100) NOT NULL, Description NVARCHAR(1000))

--Insert INTO Games (Name, Description) VALUES ('Divinity: Original Sin 2', 'игра про дивинити')

--CREATE TABLE Genres (Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(100))

--INSERT INTO Genres ( Name) VALUES( 'RPG')
--INSERT INTO Genres ( Name) VALUES( 'Fantasy')

--CREATE TABLE GamesGenres(GameId INT foreign key references Games(Id), GenreId int foreign key references Genres(Id), primary key(GameId, GenreId) )

--INSERT INTO GamesGenres(GameId, GenreId) VALUES (1,1)
--INSERT INTO GamesGenres(GameId, GenreId) VALUES (1,2)