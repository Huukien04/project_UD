--GO
--USE QLGDEPL2324
----Cập nhật ngày tháng năm
--SET DATEFORMAT DMY

----Chèn bảng Standings----------------------------------------------------------------------------------------------------------------


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
--select * from Standings order by Points desc, GoalDifference desc, GoalsFor desc
--delete from Standings


--('MW1_BUR-MCI', 'MW1_ARS-NFO', 'MW1_BOU-WHU', 'MW1_BHA-LUT', 'MW1_EVE-FUL', 'MW1_SHU-CRY', 'MW1_NEW-AVL', 'MW1_BRE-TOT', 'MW1_CHE-LIV', 'MW1_MUN-WOL');
--go
--declare @MatchID char(20)= 'MW1_MUN-WOL'
--declare @Updated bit = 0
--UPDATE Standings
--SET
--    Played = Played + 1,
--    GoalsFor = GoalsFor + ISNULL(HomeGoals, 0),
--    GoalsAgainst = GoalsAgainst + ISNULL(AwayGoals, 0),
--    Won = Won + CASE WHEN HomeGoals > AwayGoals THEN 1 ELSE 0 END,
--    Drawn = Drawn + CASE WHEN HomeGoals = AwayGoals THEN 1 ELSE 0 END,
--    Lost = Lost + CASE WHEN HomeGoals < AwayGoals THEN 1 ELSE 0 END,
--    GoalDifference = GoalDifference + ISNULL(HomeGoals, 0) - ISNULL(AwayGoals, 0),
--    Points = Points +
--        CASE
--            WHEN HomeGoals > AwayGoals THEN 3
--            WHEN HomeGoals = AwayGoals THEN 1
--            ELSE 0
--        END,
--    @Updated = 1
--FROM
--    Standings s
--    INNER JOIN MatchDetail md ON s.ClubID = md.HomeID
--WHERE
--    md.MatchID = @MatchID;

---- Update for Away team
--UPDATE Standings
--SET
--    Played = Played + 1,
--    GoalsFor = GoalsFor + ISNULL(AwayGoals, 0),
--    GoalsAgainst = GoalsAgainst + ISNULL(HomeGoals, 0),
--    Won = Won + CASE WHEN AwayGoals > HomeGoals THEN 1 ELSE 0 END,
--    Drawn = Drawn + CASE WHEN AwayGoals = HomeGoals THEN 1 ELSE 0 END,
--    Lost = Lost + CASE WHEN AwayGoals < HomeGoals THEN 1 ELSE 0 END,
--    GoalDifference = GoalDifference + ISNULL(AwayGoals, 0) - ISNULL(HomeGoals, 0),
--    Points = Points +
--        CASE
--            WHEN AwayGoals > HomeGoals THEN 3
--            WHEN AwayGoals = HomeGoals THEN 1
--            ELSE 0
--        END
--FROM
--    Standings s
--    INNER JOIN MatchDetail md ON s.ClubID = md.AwayID
--WHERE
--    md.MatchID = @MatchID
--    AND @Updated = 1;


--DECLARE @MatchID CHAR(20)
--DECLARE @HomeID CHAR(10)
--DECLARE @AwayID CHAR(10)
--DECLARE @HomeGoals INT
--DECLARE @AwayGoals INT

--DECLARE MatchDetailCursor CURSOR FOR
--SELECT MatchID, HomeID, AwayID, HomeGoals, AwayGoals
--FROM MatchDetail

--OPEN MatchDetailCursor
--FETCH NEXT FROM MatchDetailCursor INTO @MatchID, @HomeID, @AwayID, @HomeGoals, @AwayGoals

--WHILE @@FETCH_STATUS = 0
--BEGIN
--    DECLARE @Updated BIT = 0

--    -- Update Standings for Home team
--    UPDATE Standings
--    SET
--        Played = Played + 1,
--        GoalsFor = GoalsFor + ISNULL(@HomeGoals, 0),
--        GoalsAgainst = GoalsAgainst + ISNULL(@AwayGoals, 0),
--        Won = Won + CASE WHEN @HomeGoals > @AwayGoals THEN 1 ELSE 0 END,
--        Drawn = Drawn + CASE WHEN @HomeGoals = @AwayGoals THEN 1 ELSE 0 END,
--        Lost = Lost + CASE WHEN @HomeGoals < @AwayGoals THEN 1 ELSE 0 END,
--        GoalDifference = GoalDifference + ISNULL(@HomeGoals, 0) - ISNULL(@AwayGoals, 0),
--        Points = Points +
--            CASE
--                WHEN @HomeGoals > @AwayGoals THEN 3
--                WHEN @HomeGoals = @AwayGoals THEN 1
--                ELSE 0
--            END,
--        @Updated = 1
--    FROM
--        Standings s	
--    WHERE
--        s.ClubID = @HomeID;

--    -- Update Standings for Away team
--    UPDATE Standings
--    SET
--        Played = Played + 1,
--        GoalsFor = GoalsFor + ISNULL(@AwayGoals, 0),
--        GoalsAgainst = GoalsAgainst + ISNULL(@HomeGoals, 0),
--        Won = Won + CASE WHEN @AwayGoals > @HomeGoals THEN 1 ELSE 0 END,
--        Drawn = Drawn + CASE WHEN @AwayGoals = @HomeGoals THEN 1 ELSE 0 END,
--        Lost = Lost + CASE WHEN @AwayGoals < @HomeGoals THEN 1 ELSE 0 END,
--        GoalDifference = GoalDifference + ISNULL(@AwayGoals, 0) - ISNULL(@HomeGoals, 0),
--        Points = Points +
--            CASE
--                WHEN @AwayGoals > @HomeGoals THEN 3
--                WHEN @AwayGoals = @HomeGoals THEN 1
--                ELSE 0
--            END
--    FROM
--        Standings s
--    WHERE
--        s.ClubID = @AwayID
--        AND @Updated = 1;

--    FETCH NEXT FROM MatchDetailCursor INTO @MatchID, @HomeID, @AwayID, @HomeGoals, @AwayGoals
--END

--CLOSE MatchDetailCursor
--DEALLOCATE MatchDetailCursor
