GO
USE QLGDEPL2324
--Cập nhật ngày tháng năm
SET DATEFORMAT DMY

--Chèn bảng Coaches----------------------------------------------------------------------------------------------------------------
----1. ARSENAL
GO
INSERT INTO Coaches(CoachID, ClubID, CoachName, Nation, CoachDOB)
VALUES('Coach_ARS', 'ARS', 'Mikel Arteta', N'Spain', '26/03/1982'),

----2. ASTON VILLA
('Coach_AVL', 'AVL', 'Unai Emery Etxegoien', 'Spain', '03/11/1971'),

----3. BOURNEMOUTH	
('Coach_BOU', 'BOU', 'Andoni Iraola', 'Spain', '22/06/1982'),

----4. BRENTFORD
('Coach_BRE', 'BRE', 'Thomas Frank', N'Denmark', '09/10/1973'),

----5. BRIGHTON & HOVE ALBION
('Coach_BHA', 'BHA', 'Roberto De Zerbi', 'Italia', '06/06/1979'),

----6. BURNLEY FC
('Coach_BUR', 'BUR', 'Vincent Kompany', 'Belgium', '10/04/1986'),

----7. CHELSEA
('Coach_CHE', 'CHE', 'Mauricio Pochettino', 'Argentina', '02/03/1972'),

----8. CRYSTAL PALACE
('Coach_CRY', 'CRY', 'Roy Hodgson', 'England', '09/08/1947'),

----9. EVERTON
('Coach_EVE', 'EVE', 'Sean Dyche', 'England', '28/06/1971'),

----10. FULHAM FC
('Coach_FUL', 'FUL', 'Marco Silva', N'Portugal', '12/07/1977'),

----11. LIVERPOOL
('Coach_LIV', 'LIV', N'Jürgen Klopp', N'Germany', '16/06/1967'),

----12. LUTON TOWN FC
('Coach_LUT', 'LUT', N'Rob Edwards', N'England', '25/11/1962'),

----13. MAN CITY
('Coach_MCI', 'MCI', 'Pep Guardiola', N'Spain', '18/01/1971'),

----14. MAN UNITED
('Coach_MUN', 'MUN', 'Erik ten Hag', N'Netherlands', '02/02/1970'),

----15. NEWCASTLE UNITED
('Coach_NEW', 'NEW', 'Eddie Howe', N'Bắc Ireland', '29/11/1977'),

----16. NOTTINGHAM FOREST
('Coach_NFO', 'NFO', 'Steve Cooper', 'Wales', '10/12/1979'),

----17. SHEFFIELD UNITED FC
('Coach_SHU', 'SHU', N'Paul Heckingbottom', N'Áo', '17/07/1977'),

----18. TOTTENHAM
('Coach_TOT', 'TOT', 'Ange Postecoglou', 'Greece', '27/08/1965'),

----19. WEST HAM UNITED
('Coach_WHU', 'WHU', 'David Moyes', N'Scotland', '25/04/1963'),

----20. WOLVERHAMPTON WANDERERS
('Coach_WOL', 'WOL', 'Gary ONeil', N'England', '18/05/1983')

--SELECT* FROM Coaches
--SELECT MaHLV, HoTen, QuocTich, NamSinh FROM HLV where MaDB = 'LIV'
--DELETE HLV
-------------------------------------------------------------------------------------------------------------------------------