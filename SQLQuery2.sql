USE Master
GO
DROP DATABASE Location
GO
CREATE DATABASE Location
GO
USE Location
GO


CREATE TABLE Vehicule(
  [Modele] VARCHAR(12),
  [Prix] INT,
  [Matricule] VARCHAR(7) PRIMARY KEY,
  [Jour] INT,
  [Date] DATE,

);
GO
CREATE TABLE Client(
  [Permis] VARCHAR(13) PRIMARY KEY,
  [Nom] VARCHAR(50),
  [Prénom] VARCHAR(50),
  [Télephone] CHAR(10),  
  [Matricule] Varchar(7),
  FOREIGN KEY (Matricule) REFERENCES Vehicule(Matricule));
GO


INSERT INTO Vehicule VALUES 
('Honda Civic',6,'T45 K9A',3,'2000-01-01');
GO


--INSERT INTO Client VALUES 
--('T126547853081','Benoit','Tremblay','8194007483','5','323232');
--GO


SELECT * FROM Vehicule