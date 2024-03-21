GO
USE QLGDEPL2324
--Cập nhật ngày tháng năm
SET DATEFORMAT DMY


--Chèn bảng DoiBong------------------------------------------------------------------------------------------------------------
--1. ARSENAL
GO
INSERT INTO Clubs(ClubID, ClubName, Logo, FoundedTime)
VALUES('ARS', 'Arsenal', 'ars.png','03/06/1982'),

--2. ASTON VILLA
('AVL', 'Aston Villa', 'avl.png','21/11/1900'),

--3. BOURNEMOUTH
('BOU', 'Bournemouth', 'bou.png','23/04/1899'),

--4. BRENTFORD
('BRE', 'Brentford', 'bre.png','10/10/1889'),

--5. BRIGHTON & HOVE ALBION
('BHA', 'Brighton', 'bha.png','24/06/1901'),

--6. BURNLEY FC
('BUR', 'Burnley FC', 'bur.png','18/05/1882'),

--7. CHELSEA
('CHE', 'Chelsea', 'che.png','23/04/1899'),

--8. CRYSTAL PALACE
('CRY', 'Crystal Palace', 'cry.png','10/09/1905'),

--9. EVERTON
('EVE', 'Everton', 'eve.png','04/03/1878'),

--10. FULHAM FC
('FUL', 'Fulham FC', 'ful.png','10/08/1879'),

--11. LIVERPOOL
('LIV', 'Liverpool', 'liv.png','03/06/1982'),

--12. LUTON TOWN FC
('LUT', 'Luton Town FC', 'lut.png','11/04/1885'),

--13. MAN CITY
('MCI', 'Manchester City', 'mci.png','13/04/1880'),

--14. MAN UNITED
('MUN', 'Manchester United', 'mun.png','05/04/1878'),

--15. NEWCASTLE UNITED
('NEW', 'Newcastle United', 'new.png','05/03/1878'),

--16. NOTTINGHAM FOREST
('NFO', 'Nottingham Forest', 'nfo.png','01/01/1865'),

--17. SHEFFIELD UNITED FC
('SHU', 'Sheffield United FC', 'shu.png','22/03/1889'),

--18. TOTTENHAM
('TOT', 'Tottenham Hotspur', 'tot.png','05/09/1882'),

--19. WEST HAM UNITED
('WHU', 'West Ham United', 'whu.png','29/06/1895'),

--20. WOLVERHAMPTON WANDERERS
('WOL', 'Wolverhampton', 'wol.png','10/12/1877')

GO
INSERT INTO Clubs(ClubID, ClubName)
VALUES(N'NONE', N'None')

--SELECT * FROM DoiBong

--DELETE FROM Clubs
-------------------------------------------------------------------------------------------------------------------------------