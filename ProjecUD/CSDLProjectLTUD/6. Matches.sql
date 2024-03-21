GO
USE QLGDEPL2324
--Cập nhật ngày tháng năm
SET DATEFORMAT DMY

--Chèn bảng Matches------------------------------------------------------------------------------------------------------------
----1. Matchweek 1
GO
INSERT INTO Matches(MatchID, RoundID, MatchName, MatchTime)
VALUES('MW1_BUR-MCI', 'MW1', 'Burnley - Man City', '12/08/2023 2:00:00'),
('MW1_ARS-NFO', 'MW1', 'Arsenal - Nottingham Forest', '12/08/2023 18:30:00'),
('MW1_BOU-WHU', 'MW1', 'Bournemouth - West Ham', '12/08/2023 21:00:00'),
('MW1_BHA-LUT', 'MW1', 'Brighton - Luton', '12/08/2023 21:00:00'),
('MW1_EVE-FUL', 'MW1', 'Everton - Fulham', '12/08/2023 21:00:00'),
('MW1_SHU-CRY', 'MW1', 'Sheffield United - Crystal Palace', '12/08/2023 21:00:00'),
('MW1_NEW-AVL', 'MW1', 'Newcastle - Aston Villa', '12/08/2023 23:30:00'),
('MW1_BRE-TOT', 'MW1', 'Brentford - Tottenham', '13/08/2023 20:00:00'),
('MW1_CHE-LIV', 'MW1', 'Chelsea - Liverpool', '13/08/2023 22:30:00'),
('MW1_MUN-WOL', 'MW1', 'Wolves - Man United', '15/08/2023 02:00:00')	

--select *from CauThu where HoTen like N'%lockyer%' or HoTen like N'%josh%'
----2. Matchweek 2
GO
INSERT INTO Matches(MatchID, RoundID, MatchName, MatchTime)
VALUES('MW2_NFO-SHU', 'MW2', 'Nottingham Forest - Sheffield Utd', '19/08/2023 2:00:00'),
('MW2_FUL-BRE', 'MW2', 'Fulham - Brentford', '19/08/2023 21:00:00'),
('MW2_LIV-BOU', 'MW2', 'Liverpool - Bournemouth', '19/08/2023 21:00:00'),
('MW2_WOL-BHA', 'MW2', 'Wolves - Brighton', '19/08/2023 21:00:00'),
('MW2_TOT-MUN', 'MW2', 'Tottenham - Man United', '19/08/2023 23:30:00'),
('MW2_MCI-NEW', 'MW2', 'Man City - Newcastle', '20/08/2023 02:00:00'),
('MW2_AVL-EVE', 'MW2', 'Aston Villa - Everton', '20/08/2023 20:00:00'),
('MW2_WHU-CHE', 'MW2', 'West Ham - Chelsea', '20/08/2023 22:30:00'),
('MW2_CRY-ARS', 'MW2', 'Crystal Palace - Arsenal', '22/08/2023 02:00:00'),
('MW2_LUT-BUR', 'MW2', 'Luton - Burnley', '01/10/2023 01:30:00')


GO
INSERT INTO Matches(MatchID, RoundID, MatchName, MatchTime)
VALUES('MW3_NFO-SHU', 'MW3', 'Nottingham Forest - Sheffield Utd', '19/08/2023 2:00:00'),
('MW3_BOU-TOT', 'MW3', 'Bournemouth - Tottenham', '26/08/2023 18:30:00')


------3. Matchweek 3
--GO
--INSERT INTO TranDau(MaTD, MaVD, TenTD, SVD, CTHayNhat, DoiNha, DoiKhach, SLBanThangDN, SLBanThangDK, TrongTai, ThoiGian)
--VALUES('MW3_CHE-LUT', 'MW3', 'Chelsea - Luton', '26/08/2023 2:00:00'),
--('MW3_BOU-TOT', 'MW3', 'Bournemouth - Spurs', '26/08/2023 18:30:00'),
--('MW3_ARS-FUL', 'MW3', 'Arsenal - Fulham', '26/08/2023 21:00:00'),
--('MW3_BRE-CRY', 'MW3', 'Brentford - Crystal Palace', '26/08/2023 21:00:00'),
--('MW3_EVE-WOL', 'MW3', 'Everton - Wolves', '26/08/2023 21:00:00'),
--('MW3_MUN-NFO', 'MW3', 'Man Utd - Nottingham Forest', '26/08/2023 21:00:00'),
--('MW3_BHA-WHU', 'MW3', 'Brighton - West Ham', '26/08/2023 23:30:00'),
--('MW3_BUR-AVL', 'MW3', 'Burnley - Aston Villa', '27/08/2023 20:00:00'),
--('MW3_SHU-MCI', 'MW3', 'Sheffield Utd - Man City', '27/08/2023 20:00:00'),
--('MW3_NEW-LIV', 'MW3', 'Newcastle - Liverpool', '27/08/2023 22:30:00')


------4. Matchweek 4
--GO
--INSERT INTO TranDau(MaTD, MaVD, TenTD, SVD, CTHayNhat, DoiNha, DoiKhach, SLBanThangDN, SLBanThangDK, TrongTai, ThoiGian)
--VALUES('MW4_LUT-WHU', 'MW4', 'Luton - West Ham', '02/09/2023 2:00:00'),
--('MW4_SHU-EVE', 'MW4', 'Sheffield Utd - Everton', '02/09/2023 18:30:00'),
--('MW4_BRE-BOU', 'MW4', 'Brentford - Bournemouth', '02/09/2023 21:00:00'),
--('MW4_BUR-TOT', 'MW4', 'Burnley - Spurs', '02/09/2023 21:00:00'),
--('MW4_CHE-NFO', 'MW4', 'Chelsea - Nottingham Forest', '02/09/2023 21:00:00'),
--('MW4_MCI-FUL', 'MW4', 'Man City - Fulham', '02/09/2023 21:00:00'),
--('MW4_BHA-NEW', 'MW4', 'Brighton - Newcastle', '02/09/2023 23:30:00'),
--('MW4_CRY-WOL', 'MW4', 'Crystal Palace - Wolves', '03/09/2023 20:00:00'),
--('MW4_LIV-AVL', 'MW4', 'Liverpool - Aston Villa', '03/09/2023 20:00:00'),
--('MW4_ARS-MUN', 'MW4', 'Arsenal - Man Utd', '03/09/2023 22:30:00')


------5. Matchweek 5
--GO
--INSERT INTO TranDau(MaTD, MaVD, TenTD, SVD, CTHayNhat, DoiNha, DoiKhach, SLBanThangDN, SLBanThangDK, TrongTai, ThoiGian)
--VALUES('MW5_WOL-LIV', 'MW5', 'Wolves - Liverpool', '16/09/2023 18:30:00'),
--('MW5_AVL-CRY', 'MW5', 'Aston Villa - Crystal Palace', '16/09/2023 21:00:00'),
--('MW5_FUL-LUT', 'MW5', 'Fulham - Luton', '16/09/2023 21:00:00'),
--('MW5_MUN-BHA', 'MW5', 'Man Utd - Brighton', '16/09/2023 21:00:00'),
--('MW5_TOT-SHU', 'MW5', 'Spurs - Sheffield Utd', '16/09/2023 21:00:00'),
--('MW5_WHU-MCI', 'MW5', 'West Ham - Man City', '16/09/2023 21:00:00'),
--('MW5_NEW-BRE', 'MW5', 'Newcastle - Brentford', '16/09/2023 23:30:00'),
--('MW5_BOU-CHE', 'MW5', 'Bournemouth - Chelsea', '17/09/2023 20:00:00'),
--('MW5_EVE-ARS', 'MW5', 'Everton - Arsenal', '17/09/2023 22:30:00'),
--('MW5_NFO-BUR', 'MW5', 'Nottingham Forest - Burnley', '19/09/2023 01:45:00')


------6. Matchweek 6
--GO
--INSERT INTO TranDau(MaTD, MaVD, TenTD, SVD, CTHayNhat, DoiNha, DoiKhach, SLBanThangDN, SLBanThangDK, TrongTai, ThoiGian)
--VALUES('MW6_CRY-FUL', 'MW6', 'Crystal Palace - Fulham', '23/09/2023 21:00:00'),
--('MW6_LUT-WOL', 'MW6', 'Luton - Wolves', '23/09/2023 21:00:00'),
--('MW6_MCI-NFO', 'MW6', 'Man City - Nottingham Forest', '23/09/2023 21:00:00'),
--('MW6_BRE-EVE', 'MW6', 'Brentford - Everton', '23/09/2023 23:30:00'),
--('MW6_BUR-MUN', 'MW6', 'Burnley - Man Utd', '24/09/2023 02:00:00'),
--('MW6_ARS-TOT', 'MW6', 'Arsenal - Man Spurs', '24/09/2023 20:00:00'),
--('MW6_BHA-BOU', 'MW6', 'Brighton - Bournemouth', '24/09/2023 20:00:00'),
--('MW6_CHE-AVL', 'MW6', 'Chelsea - Aston Villa', '24/09/2023 20:00:00'),
--('MW6_LIV-WHU', 'MW6', 'Liverpool - West Ham', '24/09/2023 20:00:00'),
--('MW6_SHU-NEW', 'MW6', 'Sheffield Utd - Newcastle', '24/09/2023 22:30:00')


--SELECT* FROM TranDau
--ORDER BY CAST(SUBSTRING(MaVD, 3, LEN(MaVD)) AS INT);
--DELETE TranDau

--SELECT *
--FROM TranDau
--DELETE TranDau

-------------------------------------------------------------------------------------------------------------------------------