GO
CREATE DATABASE QLGDEPL2324
GO
USE QLGDEPL2324
SET DATEFORMAT DMY

--DROP DATABASE QLGDEPL2324


--Players---------------------------------------------------------
CREATE TABLE Players(
	PlayerID INT PRIMARY KEY IDENTITY(1001,1),
	ClubID CHAR(10) NOT NULL,
	Number INT,
	PlayerName NVARCHAR(30) NOT NULL UNIQUE,
	Nation NVARCHAR(30) NOT NULL,
	Height FLOAT,
	[Weight] INT,
	PlayerDOB DATE,
	Salary INT,
	Position NVARCHAR(30),
	Foot NVARCHAR(20)
)
--ALTER TABLE Players
--ALTER COLUMN PlayerName NVARCHAR(30) NOT NULL;
----------------------------------------------------------------------


--Clubs-------------------------------------------------------------
CREATE TABLE Clubs(
	ClubID CHAR(10) NOT NULL UNIQUE,
	ClubName NVARCHAR(30) NOT NULL UNIQUE,
	Logo NVARCHAR(30) UNIQUE,
	FoundedTime DATE,
	constraint PK_ClubID primary key (ClubID)
)
----------------------------------------------------------------------



--Coaches-----------------------------------------------------------------
CREATE TABLE Coaches(
	CoachID CHAR(10) NOT NULL UNIQUE,
	ClubID CHAR(10) NOT NULL UNIQUE,
	CoachName NVARCHAR(50) NOT NULL,
	Nation NVARCHAR(30) NOT NULL,
	CoachDOB DATE,
	constraint PK_CoachID primary key (CoachID)
)
----------------------------------------------------------------------



--Stadiums----------------------------------------------------------
CREATE TABLE Stadiums(
	StadiumID CHAR(20) NOT NULL UNIQUE,
	ClubID CHAR(10) NOT NULL,
	StadiumName NVARCHAR(100) NOT NULL UNIQUE,
	Size VARCHAR(30),
	Capacity INT,
	[Location] NVARCHAR(100),
	BuiltTime DATE,
	constraint PK_StadiumID primary key (StadiumID)
)
----------------------------------------------------------------------



--Rounds-------------------------------------------------------------
CREATE TABLE Rounds(
	RoundID CHAR(10) NOT NULL,
	RoundName NVARCHAR(30) NOT NULL UNIQUE,
	Clubs INT,
	Matches INT,
	constraint PK_RoundID primary key (RoundID)
)
----------------------------------------------------------------------



--Matches-------------------------------------------------------------
CREATE TABLE Matches(
	MatchID CHAR(20) NOT NULL,
	RoundID CHAR(10) NOT NULL,
	MatchName NVARCHAR(50),
	MatchTime DateTime,
	constraint PK_MatchID primary key (MatchID)
)
----------------------------------------------------------------------



----DetailMatch-------------------------------------------------------------
CREATE TABLE MatchDetail(
	MatchID CHAR(20) NOT NULL,
	HomeID CHAR(10) NOT NULL,
	AwayID CHAR(10) NOT NULL,
	MotmID INT NOT NULL,
	HomeGoals INT,
	AwayGoals INT,
	HomeCapID INT NOT NULL,
	AwayCapID INT NOT NULL,
	HomeTactical NVARCHAR(50) NOT NULL,
	AwayTactical NVARCHAR(50) NOT NULL,
	Referee NVARCHAR(30),
	constraint PK_DetailMatch primary key (MatchID, HomeID, AwayID, MotmID, HomeCapID, AwayCapID)
)
------------------------------------------------------------------------



--PlayersInMatch----------------------------------------------------
CREATE TABLE PlayersInMatch(
	MatchID CHAR(20) NOT NULL,
	PlayerID INT NOT NULL,
	IsHomeTeam INT NOT NULL,
	Position NVARCHAR(20),
	Goal INT,
	YellowCard INT,
	RedCard INT,
	OwnGoal INT,
	constraint PK_PlayersInMatch primary key (MatchID, PlayerID)
)
----------------------------------------------------------------------



--Standings-----------------------------------------------------------------
CREATE TABLE Standings(
	StandingID INT PRIMARY KEY IDENTITY (1,1),
	ClubID CHAR(10) NOT NULL,
	Played INT,
	Won INT,
	Drawn INT,
	Lost INT, 
	GoalsFor INT,
	GoalsAgainst INT,
	GoalDifference INT,
	Points INT,
)
----------------------------------------------------------------------


--Add foreign key-----------------------------------------------------
alter table Players
add constraint FK_Player_ClubID foreign key(ClubID) references Clubs(ClubID)

alter table Stadiums
add constraint FK_Stadium_ClubID foreign key(ClubID) references Clubs(ClubID)

alter table Coaches
add constraint FK_Coach_ClubID foreign key(ClubID) references Clubs(ClubID)

alter table Matches
add constraint FK_Match_RoundID foreign key(RoundID) references Rounds(RoundID)

alter table MatchDetail
add constraint FK_MatchDetail_HomeID foreign key(HomeID) references Clubs(ClubID)
alter table MatchDetail
add constraint FK_MatchDetail_AwayID foreign key(AwayID) references Clubs(ClubID)
alter table MatchDetail
add constraint FK_MatchDetail_MotmID foreign key(MotmID) references Players(PlayerID)
alter table MatchDetail
add constraint FK_MatchDetail_HomeCaptainID foreign key(HomeCapID) references Players(PlayerID)
alter table MatchDetail
add constraint FK_MatchDetail_AwayCapID foreign key(AwayCapID) references Players(PlayerID)

ALTER TABLE PlayersInMatch
ADD CONSTRAINT FK_PlayersInMatch_PlayerID FOREIGN KEY(PlayerID) REFERENCES Players(PlayerID)
ALTER TABLE PlayersInMatch
ADD CONSTRAINT FK_PlayersInMatch_MatchID FOREIGN KEY(MatchID) REFERENCES Matches(MatchID)

--ALTER TABLE Standings
--ADD CONSTRAINT FK_Standings_RoundID FOREIGN KEY(RoundID) REFERENCES Rounds(RoundID)
ALTER TABLE Standings
ADD CONSTRAINT FK_Standings_ClubID FOREIGN KEY(ClubID) REFERENCES Clubs(ClubID)