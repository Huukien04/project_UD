GO
USE QLGDEPL2324
--Cập nhật ngày tháng năm
SET DATEFORMAT DMY

--Chèn bảng VongDau------------------------------------------------------------------------------------------------------------
GO
INSERT INTO Rounds(RoundID, RoundName, Clubs, Matches)
VALUES('MW1', 'Matchweek 1', 20, 10),
('MW2', 'Matchweek 2', 20, 10),
('MW3', 'Matchweek 3', 20, 10),
('MW4', 'Matchweek 4', 20, 10),
('MW5', 'Matchweek 5', 20, 10),
('MW6', 'Matchweek 6', 20, 10),
('MW7', 'Matchweek 7', 20, 10),
('MW8', 'Matchweek 8', 20, 10),
('MW9', 'Matchweek 9', 20, 10),
('MW10', 'Matchweek 10', 20, 10),
('MW11', 'Matchweek 11', 20, 10),
('MW12', 'Matchweek 12', 20, 10),
('MW13', 'Matchweek 13', 20, 10),
('MW14', 'Matchweek 14', 20, 10),
('MW15', 'Matchweek 15', 20, 10),
('MW16', 'Matchweek 16', 20, 10),
('MW17', 'Matchweek 17', 20, 10),
('MW18', 'Matchweek 18', 20, 10),
('MW19', 'Matchweek 19', 20, 10),
('MW20', 'Matchweek 20', 20, 10),
('MW21', 'Matchweek 21', 20, 10),
('MW22', 'Matchweek 22', 20, 10),
('MW23', 'Matchweek 23', 20, 10),
('MW24', 'Matchweek 24', 20, 10),
('MW25', 'Matchweek 25', 20, 10),
('MW26', 'Matchweek 26', 20, 10),
('MW27', 'Matchweek 27', 20, 10),
('MW28', 'Matchweek 28', 20, 10),
('MW29', 'Matchweek 29', 20, 10),
('MW30', 'Matchweek 30', 20, 10),
('MW31', 'Matchweek 31', 20, 10),
('MW32', 'Matchweek 32', 20, 10),
('MW33', 'Matchweek 33', 20, 10),
('MW34', 'Matchweek 34', 20, 10),
('MW35', 'Matchweek 35', 20, 10),
('MW36', 'Matchweek 36', 20, 10),
('MW37', 'Matchweek 37', 20, 10),
('MW38', 'Matchweek 38', 20, 10)

--Sắp xếp mã vòng đấu tăng dần
--SELECT * 
--FROM VongDau 
--ORDER BY CAST(SUBSTRING(MaVD, 3, LEN(MaVD)) AS INT);

--DELETE FROM VongDau
-------------------------------------------------------------------------------------------------------------------------------
