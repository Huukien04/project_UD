GO
USE QLGDEPL2324
--Cập nhật ngày tháng năm
SET DATEFORMAT DMY

--Chèn bảng MatchDetail------------------------------------------------------------------------------------------------------------
----1. Matchweek 1
GO
INSERT INTO MatchDetail(MatchID, HomeID, AwayID, MotmID, HomeGoals, AwayGoals, HomeCapID, AwayCapID, HomeTactical, AwayTactical, Referee)
VALUES('MW1_BUR-MCI', 'BUR', 'MCI', 1412, 0, 3, 1174, 1406, '4-2-3-1', '5-4-1', 'Craig Pawson'),
('MW1_ARS-NFO', 'ARS', 'NFO', 1023,  2, 1, 1016, 1486, '4-3-3', '3-4-3', 'Michael Oliver'),
('MW1_BOU-WHU', 'BOU', 'WHU', 1611,  1, 1, 1063, 1593, '4-2-3-1', '4-2-3-1', 'Peter Bankes'),
('MW1_BHA-LUT', 'BHA', 'LUT', 1145, 4, 1, 1132, 1356, '4-2-3-1', '3-5-2', 'David Coote'),
('MW1_EVE-FUL', 'EVE', 'FUL', 1293, 0, 1, 1268, 1305, '4-4-1-1', '4-3-3', 'Stuart Attwell'),
('MW1_SHU-CRY', 'SHU', 'CRY', 1244, 0, 1, 1525, 1232, '3-4-3', '4-2-3-1', 'John Brooks'),
('MW1_NEW-AVL', 'NEW', 'AVL', 1477,  5, 1, 1453, 1047, '4-2-3-1', '4-3-3', 'Andy Madley'),
('MW1_BRE-TOT', 'BRE', 'TOT', 1573,  2, 2, 1108, 1581, '5-3-2', '4-2-3-1', 'Robert Jones'),
('MW1_CHE-LIV', 'CHE', 'LIV', 1201, 1, 1, 1202, 1327, '3-4-2-1', '4-3-3', 'Anthony Taylor'),
('MW1_MUN-WOL', 'MUN', 'WOL', 1416, 1, 0, 1432, 1624, '4-1-4-1', '4-4-2', 'Simon Hooper')


--delete MatchDetail where MatchID = 'MW4_ARS-NFO'
--select *  from MatchDetail where MatchID = 'MW1_BRE-TOT'

       
        
         