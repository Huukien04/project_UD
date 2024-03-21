GO
USE QLGDEPL2324
--Cập nhật ngày tháng năm
SET DATEFORMAT DMY
go

------FormPlayers------
create proc usp_ShowAllPlayers
as
	begin
		select * from Players
	end
go
--exec usp_ShowAllPlayers


create proc usp_AddPlayer(@ClubID CHAR(10), @Number INT, @PlayerName NVARCHAR(30), @Nation NVARCHAR(30), @Height FLOAT, 
@Weight INT, @PlayerDOB DATE, @Salary INT, @Position NVARCHAR(30), @Foot NVARCHAR(20))
as
	begin
		if @PlayerName is not null and @PlayerName <> ''
			begin
				insert into Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot) 
				values(@ClubID, @Number, @PlayerName, @Nation, @Height, @Weight, @PlayerDOB, @Salary, @Position, @Foot)
				print 'Added successfully';
			end
		else
			begin
				print 'Add failed';
			end
	end
go
--exec usp_AddPlayer 'MUN', '30', '', 'Argentina', '1.69', '75', '1986-5-6', '12000000', 'Forward', 'Left'
--select * from Players where ClubID = 'MUN'


create proc usp_DeletePlayer(@PlayerID char(10))
as
	begin
		delete Players where PlayerID = @PlayerID
	end
go
--exec usp_DeletePlayer '1645'


create proc usp_ShowPlayerByClubID(@ClubID char(10))
as
	begin
		if exists(select * from Clubs where ClubID = @ClubID)
			begin
				select * from Players where ClubID = @ClubID
			end
		else
			begin
				print 'Club not exist'
			end
	end
go
--exec usp_ShowPlayerByClubID'LIV'


create proc usp_EditPlayer(@PlayerID char(10), @ClubID CHAR(10), @Number INT, @PlayerName NVARCHAR(30), @Nation NVARCHAR(30), @Height FLOAT, 
							@Weight INT, @PlayerDOB DATE, @Salary INT, @Position NVARCHAR(30), @Foot NVARCHAR(20))
as
	begin
		if exists(select * from Players where PlayerID = @PlayerID)
			begin
				update Players set ClubID = @ClubID, Number = @Number, PlayerName = @PlayerName, Nation = @Nation, Height = @Height, 
									[Weight] = @Weight, PlayerDOB = @PlayerDOB, Salary = @Salary, Position = @Position, Foot = @Foot where PlayerID = @PlayerID
			end
		else
			begin
				print 'Player not exist'
			end
	end
go
--exec usp_EditPlayer '1640','LIV', '7', 'Messi', 'Argentina', '1.69', '75', '1986-5-6', '15000000', 'Forward', 'Left'
--select * from Players where ClubID = 'LIV'


create proc usp_ShowPlayerByID(@PlayerID char(10))
as
	begin
		select * from Players where PlayerID = @PlayerID 
	end
go
--exec usp_ShowPlayerByID'1463'


create proc usp_ShowPlayerByName(@PlayerName NVARCHAR(30))
as
	begin
		set @PlayerName = '%' + @PlayerName + '%'
		select * from Players where PlayerName like @PlayerName
	end
go
--exec usp_ShowPlayerByName 'john'



------FormClub------
create proc usp_ShowCoachByClubID(@ClubID char(10))
as
	begin
		select CoachID, CoachName, Nation, CoachDOB from Coaches where ClubID = @ClubID
	end
go
--exec usp_ShowCoachByClubID'MUN'


create proc usp_ShowStadiumByClubID(@ClubID char(10))
as
	begin 
		select StadiumID, StadiumName, Size, Capacity, [Location], BuiltTime from Stadiums where ClubID = @ClubID
	end
go
--exec usp_ShowStadiumByClubID'MUN'


create proc usp_AddCoach(@CoachID CHAR(10), @ClubID CHAR(10), @CoachName NVARCHAR(50), @Nation NVARCHAR(30), @CoachDOB DATE)
as
	begin
		if not exists(select 1 from Coaches where ClubID = @ClubID)
		begin
			insert into Coaches(CoachID, ClubID, CoachName, Nation, CoachDOB) values(@CoachID, @ClubID, @CoachName, @Nation, @CoachDOB);
			print 'Added successfully';
		end
		else
		begin
			print 'A coach already exists for this team. Please delete the existing coach before adding a new one.'
		end
	end
go

--delete Coaches where CoachID = 'Coach_MUN'
--select * from Coaches where CoachID = 'Coach_MUN'
--exec usp_AddCoach 'Coach_MUN', 'MUN','Erik ten Hag', N'Netherlands', '1970-02-02'


create proc usp_DeleteCoach(@CoachID char(10))
as
	begin
		if exists(select * from Coaches where CoachID = @CoachID)
			begin
				delete Coaches where CoachID = @CoachID
				print 'Coach deleted successfully'
			end
		else
			begin
				print 'Coach not exist'
			end
	end;
go
--exec usp_DeleteCoach'Coach_MUN'


create proc usp_EditCoach(@CoachID char(10), @ClubID CHAR(10), @CoachName NVARCHAR(50), @Nation NVARCHAR(30), @CoachDOB DATE)
as
	begin
		if exists(select * from Coaches where CoachID = @CoachID)
			begin
				update Coaches set ClubID = @ClubID, CoachName = @CoachName, Nation = @Nation, CoachDOB = @CoachDOB where CoachID = @CoachID
				print 'Coach edited successfully'
			end
		else
			begin
				print 'Coach not exist'
			end
	end
go
--exec usp_EditCoach'Coach_MUN', 'MUN', 'alex ferguson', 'England', '1976-2-5'


create proc usp_AddStadium(@StadiumID CHAR(20), @ClubID CHAR(10), @StadiumName NVARCHAR(100), @Size VARCHAR(30), @Capacity INT, @Location NVARCHAR(100), @BuiltTime DATE)
as
	begin
		if not exists(select 1 from Stadiums where StadiumID = @StadiumID)
			begin
				insert into Stadiums(StadiumID, ClubID, StadiumName, Size, Capacity, [Location], BuiltTime)
				values (@StadiumID, @ClubID, @StadiumName, @Size, @Capacity, @Location, @BuiltTime)
				print 'Stadium added successfully'
			end
		else
			begin
				print 'Add failed'
			end
	end
go

--exec usp_AddStadium'Stadium_MUN', 'MUN', 'oldtrafford', '100m x 65m', '40157', 'Stevenage Rd, Fulham, London SW6 6HH, Anh', '1905-01-01'
--delete Stadiums where StadiumID = 'Stadium_MUN'
--select * from Stadiums where CoachID = 'Coach_MUN'


create proc usp_DeleteStadium(@StadiumID char(20))
as
	begin
		if exists(select * from Stadiums where StadiumID = @StadiumID)
			begin
				delete Stadiums where StadiumID = @StadiumID
				print 'Stadium deleted successfully'
			end
		else
			begin
				print 'Delete failed'
			end
	end
go
--exec usp_DeleteStadium'Stadium_MUN'


create proc usp_EditStadium(@StadiumID CHAR(20), @ClubID CHAR(10), @StadiumName NVARCHAR(100), @Size VARCHAR(30), @Capacity INT, @Location NVARCHAR(100), @BuiltTime DATE)
as
	begin
		if exists(select * from Stadiums where StadiumID = @StadiumID)
			begin
				update Stadiums set ClubID = @ClubID, StadiumName = @StadiumName, Size = @Size, Capacity = @Capacity, [Location] = @Location, BuiltTime = @BuiltTime
				where StadiumID = @StadiumID
			end
		else
			begin
				print 'Edit failed'
			end
	end
go


create proc usp_ShowPlayers(@ClubID CHAR(10))
as
	begin
		if exists(select * from Clubs where ClubID = @ClubID)
			begin
				select PlayerID, PlayerName, Number, Nation, PlayerDOB from Players where ClubID = @ClubID
			end
		else
			begin
				print 'Club not exist'
			end
	end
go
--exec usp_ShowPlayers 'liv'



------FormMatches------
create proc usp_ShowAllMatches
as
	begin
		select * from Matches
	end
go
--exec usp_ShowAllMatches



create proc usp_GetPlayersInClub(@ClubID char(10))
as
	begin
		select PlayerID, PlayerName from Players where ClubID = @ClubID
	end
go
--exec usp_GetPlayersInClub 'LIV'


create proc usp_GetPlayers2Team(@HomeClubID char(10), @AwayClubID char(10))
as
	begin
		select PlayerID, PlayerName from Players where ClubID = @HomeClubID or ClubID = @AwayClubID
	end
go
--exec usp_GetPlayers2Team 'liv', 'mun'


create proc usp_GetPlayerNameByPlayerID(@PLayerID int)
as
	begin
		select PlayerName from Players where PlayerID = @PLayerID
	end
go
--exec usp_GetPlayerNameByPlayerID'1054'
--select * from Clubs where ClubID = 'lut'



create proc usp_ShowMatchByRoundID(@RoundID char(10))
as
	begin
		select * from Matches where RoundID = @RoundID
	end
go



create proc usp_AddMatch(@MatchID CHAR(20), @RoundID char(10), @MatchName NVARCHAR(50), @MatchTime DateTime)
as
	begin
		insert into Matches values(@MatchID, @RoundID, @MatchName, @MatchTime)
	end
go
--exec usp_AddMatch 'MW3_LIV-TOT', 'MW3', 'Liverpool - Tottenham', '2023-08-26 18:30:00'


create proc usp_DeleteMatch(@MatchID char(20))
as
	begin
		delete Matches where MatchID = @MatchID
	end
go


create proc usp_EditMatch(@MatchID CHAR(20), @RoundID char(10), @MatchName NVARCHAR(50), @MatchTime DateTime)
as
	begin
		update Matches set RoundID = @RoundID, MatchName = @MatchName, MatchTime = @MatchTime
		where MatchID = @MatchID
	end
go


------FormPlayersInMatch------
create proc usp_GetHalfPlayersInMatch(@MatchID char(20),@IsHomeTeam int)
as
	begin
		SELECT PIM.PlayerID, P.PlayerName, PIM.Position, PIM.Goal, PIM.YellowCard, PIM.RedCard, PIM.OwnGoal
		FROM PlayersInMatch PIM
		INNER JOIN Players P ON PIM.PlayerID = P.PlayerID
		WHERE PIM.MatchID = @MatchID AND PIM.IsHomeTeam = @IsHomeTeam
		ORDER BY
        CASE
            WHEN PIM.Position = 'Goalkeeper' THEN 1
            WHEN PIM.Position = 'Defender' THEN 2
            WHEN PIM.Position = 'Midfielder' THEN 3
            WHEN PIM.Position = 'Forward' THEN 4
            WHEN PIM.Position = 'Substitute' THEN 5
        END;
	end
go
--exec usp_GetHalfPlayersInMatch 'MW1_BHA-LUT', 1
--SELECT * from Players where 


create proc usp_GetPlayerByClubID(@ClubID char(10))
as
	begin
		select PlayerID, PlayerName, Position, Foot from Players where ClubID = @ClubID
	end
go
--exec usp_GetPlayerByClubID'bha'


create proc usp_AddPlayerToMatch(@MatchID char(20), @PlayerID int, @IsHomeTeam int, @Position NVARCHAR(20), @Goal INT, @YellowCard INT,
								@RedCard INT, @OwnGoal INT, @OutputMsg NVARCHAR(MAX) OUTPUT)
as
	begin
		if not exists(select 1 from PlayersInMatch where MatchID = @MatchID and PlayerID = @PlayerID)
		begin
			if (select count(*) from PlayersInMatch where MatchID = @MatchID and IsHomeTeam = @IsHomeTeam) < 22
			begin
				INSERT INTO PlayersInMatch (MatchID, PlayerID, IsHomeTeam, Position, Goal, YellowCard, RedCard, OwnGoal)
				VALUES (@MatchID, @PlayerID, @IsHomeTeam, @Position, @Goal, @YellowCard, @RedCard, @OwnGoal);
			end
			
			else
			begin
				set @OutputMsg = 'Enough players already, can not add more';
			end
		end

		else
		begin
			set @OutputMsg = 'Players already exists in the match';
		end
	end
go
--exec usp_AddPlayerToMatch 'MW1_BHA-LUT', '1317', 0, 'Substitute', 0, 0, 0, 0
--select * from Players where ClubID = 'lut'
--select * from PlayersInMatch where MatchID = 'MW1_BHA-LUT' and IsHomeTeam = 1 


create proc usp_EditPlayerInMatch(@MatchID char(20), @PlayerID int, @IsHomeTeam int, @Position NVARCHAR(20), @Goal INT, @YellowCard INT, @RedCard INT, @OwnGoal INT)
as
	begin
		update PlayersInMatch set Position = @Position, Goal = @Goal, YellowCard = @YellowCard, RedCard = @RedCard, OwnGoal = @OwnGoal 
		where MatchID = @MatchID and PlayerID = @PlayerID and IsHomeTeam = @IsHomeTeam
	end
go
--exec usp_EditPlayerInMatch 'MW1_BHA-LUT', '1100', 1, 'Substitute', 0, 0, 0, 2


create proc usp_DeletePlayerInMatch(@MatchID char(20), @PlayerID int)
as
	begin
		delete PlayersInMatch where MatchID = @MatchID and PlayerID = @PlayerID
	end
go


------FormMatchDetail------
create proc usp_ShowMatchDetail(@MatchID char(20))
as
	begin
		select * from MatchDetail where MatchID = @MatchID
	end
go
--exec usp_ShowMatchDetail'MW1_BHA-LUT'


create proc usp_GetAllPlayersInMatch(@MatchID char(20))
as
	begin
		select PIM.PlayerID, P.PlayerName from PlayersInMatch PIM
		inner join Players P on PIM.PlayerID = P.PlayerID
		where PIM.MatchID = @MatchID
	end
go
--exec usp_GetAllPlayersInMatch'MW1_BHA-LUT'


create proc usp_GetHalfPlayersInMatch2(@MatchID char(20), @IsHomeTeam int)
as
	begin
		select PIM.PlayerID, P.PlayerName from PlayersInMatch PIM
		inner join Players P on PIM.PlayerID = P.PlayerID
		where PIM.MatchID = @MatchID and IsHomeTeam = @IsHomeTeam
	end
go
--exec usp_GetHalfPlayersInMatch2'MW1_BHA-LUT', 1


--exec usp_AddMatchDetail 'MW2_FUL-BRE', 'FUL', 'BRE', 1023,  3, 1, 1016, 1486, '4-3-3', '3-4-3', 'Michael Oliver', ''
create proc usp_AddMatchDetail(@MatchID char(20), 
								@HomeID CHAR(10), 
								@AwayID CHAR(10),
								@MotmID INT, 
								@HomeGoals INT,
								@AwayGoals INT, 
								@HomeCapID INT, 
								@AwayCapID INT, 
								@HomeTactical NVARCHAR(50), 
								@AwayTactical NVARCHAR(50), 
								@Referee NVARCHAR(30),
								@OutputMsg NVARCHAR(MAX) OUTPUT)
as
	begin
	IF NOT EXISTS (SELECT 1 FROM MatchDetail WHERE MatchID = @MatchID)
		BEGIN
			INSERT INTO MatchDetail (MatchID, HomeID, AwayID, MotmID, HomeGoals, AwayGoals, HomeCapID, AwayCapID, HomeTactical, AwayTactical, Referee)
			VALUES (@MatchID, @HomeID, @AwayID, @MotmID, @HomeGoals, @AwayGoals, @HomeCapID, @AwayCapID, @HomeTactical, @AwayTactical, @Referee);
		END
		ELSE
		BEGIN
			set @OutputMsg = 'MatchDetail for this match already exists.';
			print 'Add failed'
		END
	end
go


create proc usp_DeleteMatchDetail(@MatchID char(20))
as
	begin
		delete MatchDetail where MatchID = @MatchID
	end
go
--exec usp_DeleteMatchDetail'MW2_FUL-BRE'

create proc usp_EditMatchDetail(@MatchID char(20), 
								@HomeID CHAR(10), 
								@AwayID CHAR(10),
								@MotmID INT, 
								@HomeGoals INT,
								@AwayGoals INT, 
								@HomeCapID INT, 
								@AwayCapID INT, 
								@HomeTactical NVARCHAR(50), 
								@AwayTactical NVARCHAR(50), 
								@Referee NVARCHAR(30))
as
	begin
		update MatchDetail set HomeID = @HomeID, AwayID = @AwayID, MotmID = @MotmID, HomeGoals = @HomeGoals, AwayGoals = @AwayGoals, HomeCapID = @HomeCapID, AwayCapID = @AwayCapID, 
		HomeTactical = @HomeTactical, AwayTactical = @AwayTactical, Referee = @Referee where MatchID = @MatchID
	end
go
--exec usp_EditMatchDetail 'MW1_EVE-FUL', 'EVE', 'FUL', 1023,  3, 1, 1016, 1486, '4-3-3', '3-4-3', 'Michael Oliver'


------FormStandings------
create PROCEDURE usp_GetStandings
AS
BEGIN
	exec usp_UpdateStandingsForAllMatches
    SELECT ROW_NUMBER() OVER (ORDER BY s.Points DESC, s.GoalDifference DESC, s.GoalsFor DESC) AS Ranking,
	c.ClubName, s.Played, s.Won, s.Drawn, s.Lost, s.GoalsFor, s.GoalsAgainst, s.GoalDifference, s.Points
    FROM Standings s
    INNER JOIN Clubs c ON s.ClubID = c.ClubID
    ORDER BY s.Points DESC, s.GoalDifference DESC, s.GoalsFor DESC;
END
go
--exec usp_GetStandings


--exec usp_UpdateStandingsForAllMatches
--DROP PROC usp_UpdateStandingsForAllMatches
create PROCEDURE usp_UpdateStandingsForAllMatches
AS
BEGIN
	delete from Standings

	INSERT INTO Standings(ClubID, Played, Won, Drawn, Lost, GoalsFor, GoalsAgainst, GoalDifference, Points)
	VALUES('ARS', 0, 0, 0, 0, 0, 0, 0, 0),
	('AVL', 0, 0, 0, 0, 0, 0, 0, 0),
	('BOU', 0, 0, 0, 0, 0, 0, 0, 0),
	('BRE', 0, 0, 0, 0, 0, 0, 0, 0),
	('BHA', 0, 0, 0, 0, 0, 0, 0, 0),
	('BUR', 0, 0, 0, 0, 0, 0, 0, 0),
	('CHE', 0, 0, 0, 0, 0, 0, 0, 0),
	('CRY', 0, 0, 0, 0, 0, 0, 0, 0),
	('EVE', 0, 0, 0, 0, 0, 0, 0, 0),
	('FUL', 0, 0, 0, 0, 0, 0, 0, 0),
	('LIV', 0, 0, 0, 0, 0, 0, 0, 0),
	('LUT', 0, 0, 0, 0, 0, 0, 0, 0),
	('MCI', 0, 0, 0, 0, 0, 0, 0, 0), 
	('MUN', 0, 0, 0, 0, 0, 0, 0, 0),
	('NEW', 0, 0, 0, 0, 0, 0, 0, 0),
	('NFO', 0, 0, 0, 0, 0, 0, 0, 0),
	('SHU', 0, 0, 0, 0, 0, 0, 0, 0),
	('TOT', 0, 0, 0, 0, 0, 0, 0, 0),
	('WHU', 0, 0, 0, 0, 0, 0, 0, 0),
	('WOL', 0, 0, 0, 0, 0, 0, 0, 0)

    DECLARE @MatchID CHAR(20)
    DECLARE @HomeID CHAR(10)
    DECLARE @AwayID CHAR(10)
    DECLARE @HomeGoals INT
    DECLARE @AwayGoals INT

    DECLARE MatchDetailCursor CURSOR FOR
    SELECT MatchID, HomeID, AwayID, HomeGoals, AwayGoals
    FROM MatchDetail

    OPEN MatchDetailCursor
    FETCH NEXT FROM MatchDetailCursor INTO @MatchID, @HomeID, @AwayID, @HomeGoals, @AwayGoals

    WHILE @@FETCH_STATUS = 0
    BEGIN
        DECLARE @Updated BIT = 0

        -- Update Standings for Home team
        UPDATE Standings
        SET
            Played = Played + 1,
            GoalsFor = GoalsFor + ISNULL(@HomeGoals, 0),
            GoalsAgainst = GoalsAgainst + ISNULL(@AwayGoals, 0),
            Won = Won + CASE WHEN @HomeGoals > @AwayGoals THEN 1 ELSE 0 END,
            Drawn = Drawn + CASE WHEN @HomeGoals = @AwayGoals THEN 1 ELSE 0 END,
            Lost = Lost + CASE WHEN @HomeGoals < @AwayGoals THEN 1 ELSE 0 END,
            GoalDifference = GoalDifference + ISNULL(@HomeGoals, 0) - ISNULL(@AwayGoals, 0),
            Points = Points +
                CASE
                    WHEN @HomeGoals > @AwayGoals THEN 3
                    WHEN @HomeGoals = @AwayGoals THEN 1
                    ELSE 0
                END,
            @Updated = 1
        FROM
            Standings s
        WHERE
            s.ClubID = @HomeID;

        -- Update Standings for Away team
        UPDATE Standings
        SET
            Played = Played + 1,
            GoalsFor = GoalsFor + ISNULL(@AwayGoals, 0),
            GoalsAgainst = GoalsAgainst + ISNULL(@HomeGoals, 0),
            Won = Won + CASE WHEN @AwayGoals > @HomeGoals THEN 1 ELSE 0 END,
            Drawn = Drawn + CASE WHEN @AwayGoals = @HomeGoals THEN 1 ELSE 0 END,
            Lost = Lost + CASE WHEN @AwayGoals < @HomeGoals THEN 1 ELSE 0 END,
            GoalDifference = GoalDifference + ISNULL(@AwayGoals, 0) - ISNULL(@HomeGoals, 0),
            Points = Points +
                CASE
                    WHEN @AwayGoals > @HomeGoals THEN 3
                    WHEN @AwayGoals = @HomeGoals THEN 1
                    ELSE 0
                END
        FROM
            Standings s
        WHERE
            s.ClubID = @AwayID
            AND @Updated = 1;

        FETCH NEXT FROM MatchDetailCursor INTO @MatchID, @HomeID, @AwayID, @HomeGoals, @AwayGoals
    END

    CLOSE MatchDetailCursor
    DEALLOCATE MatchDetailCursor
END
GO


------FormStats------
create PROC usp_Top5MostGoals
AS
BEGIN
    SELECT TOP 5
        p.PlayerID,
        p.PlayerName,
		p.Number,
        c.ClubName,
        COUNT(g.MatchID) AS Goals
    FROM
        Players p
        JOIN MatchDetail g ON p.PlayerID = g.MotmID
        JOIN Clubs c ON p.ClubID = c.ClubID
    WHERE
        g.HomeGoals IS NOT NULL AND g.AwayGoals IS NOT NULL
    GROUP BY
        p.PlayerID, p.PlayerName, p.Number, c.ClubName
    ORDER BY
        Goals DESC;
END
go
--exec usp_Top5MostGoals


CREATE PROC usp_Top5MostSalary
AS
BEGIN
    SELECT TOP 5
        p.PlayerID,
        p.PlayerName,
		p.Number,
		p.Salary,
        c.ClubName
    FROM
        Players p
        JOIN Clubs c ON p.ClubID = c.ClubID
    ORDER BY
        p.Salary DESC;
END
go
--exec usp_Top5MostSalary


CREATE PROC usp_Top5TeamsMostGoals
AS
BEGIN
    SELECT TOP 5
        c.ClubID,
        c.ClubName,
        TeamGoals.GoalsScored
    FROM (
        SELECT
            HomeID AS TeamID,
            SUM(ISNULL(HomeGoals, 0)) AS GoalsScored
        FROM
            MatchDetail
        GROUP BY
            HomeID

        UNION ALL

        SELECT
            AwayID AS TeamID,
            SUM(ISNULL(AwayGoals, 0)) AS GoalsScored
        FROM
            MatchDetail
        GROUP BY
            AwayID
    ) AS TeamGoals
    INNER JOIN Clubs c ON TeamGoals.TeamID = c.ClubID
    ORDER BY
        TeamGoals.GoalsScored DESC;
END
go
--exec usp_Top5TeamsMostGoals


create PROC usp_Top5TeamsMostRedCards
AS
BEGIN
    SELECT TOP 5
        p.ClubID, -- Use the ClubID from the Players table
        c.ClubName,
        SUM(pim.RedCard) AS RedCards
    FROM
        Players p
        INNER JOIN PlayersInMatch pim ON p.PlayerID = pim.PlayerID
        INNER JOIN Clubs c ON p.ClubID = c.ClubID
    GROUP BY
        p.ClubID, c.ClubName
    ORDER BY
        RedCards DESC;
END
go
--exec usp_Top5TeamsMostRedCards
