GO
USE QLGDEPL2324
--Cập nhật ngày tháng năm
SET DATEFORMAT DMY

--Chèn bảng StadiumID---------------------------------------------------------------------------------------------------------
GO 
INSERT INTO Stadiums(StadiumID, ClubID, StadiumName, Size, Capacity, [Location], BuiltTime)
VALUES('Stadium_ARS', 'ARS', 'Emirates', '105m x 68m', 60704, 'Emirates Stadium, Hornsey Rd, London N7 7AJ, Anh', '2006'),

('Stadium_AVL', 'AVL', 'Villa Park', '101m x 68m', 42000, 'Villa Park, Trinity Rd, Birmingham B6 6HE, Anh', '1897'),

('Stadium_BOU', 'BOU', 'Vitality', '105m x 68m', 11329, 'Dean Court, Kings Park, Bournemouth BH7 7AF, Anh', '1899'),

('Stadium_BRE', 'BRE', 'Brentford Community Stadium', '101m x 68m', 17250, 'Lionel Rd S, Brentford, London TW8 0JA, Anh', '2018'),

('Stadium_BHA', 'BHA', 'Falmer', '101m x 68m', 30666, 'American Express Community Stadium, Village Way, Brighton BN1 9BL, Anh', '2011'),

('Stadium_BUR', 'BUR', 'Turf Moor', '105m x 68m', 21944, 'Harry Potts Way, Burnley, Lancashire, BB10 4BX, Anh', '1883'),

('Stadium_CHE', 'CHE', 'Stamford Bridge', '103,3m x 67,7m', 40853, 'Fulham Rd, Fulham, London SW6 1HS, Anh', '1877'),

('Stadium_CRY', 'CRY', 'Selhurst Park', '105m x 68m', 26000, 'Selhurst Park Stadium, London SE25 6PU, Anh', '1924'),

('Stadium_EVE', 'EVE', 'Goodison Park', '100m x 68m', 40157, 'Goodison Rd, Liverpool L4 4EL, Anh', '1892'),

('Stadium_FUL', 'FUL', 'Craven Cottage', '100m x 65m', 19000, 'Stevenage Rd, Fulham, London SW6 6HH, Anh', '1896'),

('Stadium_LIV', 'LIV', 'Anfield', '101m x 68m', 56394, 'Anfield Road, Liverpool L4 0TH, Anh', '1884'),

('Stadium_LUT', 'LUT', 'Kenilworth Road', '101m x 68m', 10356, 'Kenilworth Road, Luton, Bedfordshire, LU1 1DH, Anh', '1905'),

('Stadium_MCI', 'MCI', 'Etihad Stadium', '105m x 68m', 55017, 'Etihad Stadium, Ashton New Rd, Manchester M11 3FF, Anh', '2002'),

('Stadium_MUN', 'MUN', 'Old Trafford', '105m x 68m', 74140, 'Sir Matt Busby Way, Stretford, Manchester M16 0RA, Anh', '1910'),

('Stadium_NEW', 'NEW', 'St.JamesPark', '101m x 68m', 52305, 'Barrack Rd, Newcastle upon Tyne NE1 4ST, Anh', '1892'),

('Stadium_NFO', 'NFO', 'The City Ground', '105m x 68m', 30445, 'The City Ground là Trentside, West Bridgford, Nottinghamshire, NG2 5FJ, Anh', '1898'),

('Stadium_SHU', 'SHU', 'Bramall Lane', '101m x 68m', 32.702, 'Bramall Lane, Sheffield, South Yorkshire, S2 4SU, Anh', '1855'),

('Stadium_TOT', 'TOT', 'Tottenham Hotspur Stadium', '105m x 68m', 62303, '782 High Rd, Tottenham, London N17 0BX, Anh', '2019'),

('Stadium_WHU', 'WHU', 'London Stadium', '105m x 68m', 60000, 'Queen Elizabeth Olympic Park, London E20 2ST, Anh', '2008'),

('Stadium_WOL', 'WOL', 'Molineux', '105m x 68m', 32050, 'Waterloo Rd, Wolverhampton WV1 4QR, Anh', '1889')

GO 
INSERT INTO Stadiums(StadiumID, ClubID, StadiumName, Size, Capacity, [Location], BuiltTime)
VALUES('None', 'None', 'None', null, null, null, null)

--GO 
--INSERT INTO SanVanDong(MaSVD, TenSVD)
--VALUES(N'Không có',N'Không có')

--SELECT *
--FROM SanVanDong


-- Các svd có kích thước 105m 
--SELECT *
--FROM SanVanDong
--WHERE KichThuoc LIKE '105%'


-- Các svd có sức chứa từ 50000 đến 60000
--SELECT *
--FROM SanVanDong
--WHERE SucChua BETWEEN 50000 AND 60000


--DELETE FROM SanVanDong
-------------------------------------------------------------------------------------------------------------------------------