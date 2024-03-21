GO
USE QLGDEPL2324
--Cập nhật ngày tháng năm
SET DATEFORMAT DMY


--Chèn bảng CauThu
--1. ARSENAL--------------------------------------------------------------------------
-------------------GOALKEEPERS-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('ARS', 1, 'Aaron Ramsdale', 'England', 1.88, 77, '14/05/1998', 6240000, N'Goalkeeper', 'Right'),
('NONE', 13, 'Runar Alex Runarsson', N'Iceland', 1.86, null, '18/02/1995', 780000, N'Goalkeeper', 'Right'),
('ARS', 22, 'David Raya', N'Spain', 1.83, 80, '15/09/1995', 1300000, N'Goalkeeper', 'Right'),
('ARS', 31, 'Karl Hein', N'Estonia', 1.93, 86, '13/04/2002', 156000, N'Goalkeeper', 'Right'),
('NONE', 33, 'Arthur Okonkwo', N'England', 1.98, 86, '09/09/2001', 130000, N'Goalkeeper', 'Right'),

-------------------DEFENDERS-------------------
('ARS', 2, N'William Saliba', N'France', 1.92, 92, '24/03/2001', 9880000, N'Defender', 'Right'),
('NONE', 3, N'Kieran Tierney', N'Scotland', 1.78, 70, '15/12/1997', 5720000, N'Defender', 'Left'),	
('ARS', 4, N'Ben White', N'England', 1.82, 77, '08/10/1997', 6240000, N'Defender', 'Right'),
('ARS', 6, N'Gabriel Magalhães', N'Brazil', 1.89, 78, '19/12/1997', 5200000, N'Defender', 'Left'),
('ARS', 12, N'Jurriën Timber', N'Netherlands', 1.79, 79, '17/06/2001', 4680000, N'Defender', 'Right'),
('ARS', 15, 'Jakub Kiwior', N'Poland', 1.89, 75, '15/02/2000', 3016000, N'Defender', 'Right'),
('ARS', 17, N'Cédric Soares', N'Portugal', 1.72, 67, '31/08/1991', 1300000, N'Defender', 'Right'),
('ARS', 18, N'Tomiyasu Takehiro', N'Brazil', 1.88, 78, '05/11/1998', 2860000, N'Defender', 'Both'),
('ARS', 35, N'Oleksandr Zinchenko', N'Brazil', 1.75, 64, '15/12/1996', 7800000, N'Defender', 'Left'),

-------------------MIDFIELDERS-------------------
('ARS', 5, N'Thomas Partey', N'Ghana', 1.85, 75, '13/06/1993', 10400000, N'Midfielder', 'Right'),
('ARS', 8, N'Martin Ødegaard', N'Norway', 1.78, 69, '17/12/1998', 5980000, N'Midfielder', 'Left'),
('ARS', 10, N'Emile Smith Rowe', N'England', 1.82, 77, '28/07/2000', 2080000, N'Midfielder', 'Right'),
('ARS', 20, N'Jorginho', N'Italy', 1.80, 65, '20/12/1991', 5720000, N'Midfielder', 'Both'),
('ARS', 21, N'Fábio Vieira', N'Portugal', 1.70, 65, '30/05/2000', 2340000, N'Midfielder', 'Left'),
('ARS', 25, N'Mohamed Elneny', N'Egypt', 1.81, 74, '11/07/1992', 2860000, N'Midfielder', 'Right'),
('ARS', 29, N'Kai Havertz', N'Germany', 1.93, 83, '11/06/1999', 14560000, N'Midfielder', 'Both'),
('ARS', 41, N'Declan Rice', N'England', 1.85, 84, '14/01/1999', 12480000, N'Midfielder', 'Right'),

-------------------FORWARDS-------------------
('ARS', 7, N'Bukayo Saka', N'England', 1.78, 73, '05/09/2001', 10140000, N'Foward', 'Left'),
('ARS', 9, N'Gabriel Jesus', N'Brazil', 1.75, 73, '03/04/1997', 13780000, N'Foward', 'Right'),
('ARS', 11, N'Gabriel Martinelli', N'Brazil', 1.80, 75, '18/06/2001', 9360000, N'Foward', 'Right'),
('ARS', 14, N'Eddie Nketiah', N'England', 1.80, 70, '30/05/1999', 5200000, N'Foward', 'Right'),
('ARS', 19, N'Leandro Trossard', N'Belgium', 1.72, 61, '04/12/1994', 4680000, N'Foward', 'Right'),
('NONE', 19, N'Nicolas Pépé', N'Belgium', 1.83, 73, '29/05/1995', 7280000, N'Foward', 'Left'),
('ARS', 24, N'Reiss Nelson', N'England', 1.76, 66, '10/12/1999', 5200000, N'Foward', 'Right'),
('NONE', 27, N'Marquinhos', N'Brazil', 1.75, 85, '07/04/2003', 1560000, N'Foward', 'Left')


--2. ASTON VILLA----------------------------------------------------------------------
-------------------GOALKEEPERS-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('AVL', 1, N'Emiliano Martínez', 'Argentina', 1.92, 89, '02/09/1992', 6240000, N'Goalkeeper', 'Right'),
('AVL', 25, N'Robin Olsen', N'Sweden', 1.98, 89, '08/01/1990', 2600000, N'Goalkeeper', 'Right'),
('NONE', 38, N'Viljami Sinisalo', N'Finland', 1.90, null, '11/10/2001', 0, N'Goalkeeper', null),
('NONE', 42, N'Filip Marschall', N'England', 1.95, null, '24/04/2003', 0, N'Goalkeeper', null),
('NONE', null, N'Oliwier Zych', N'Poland', 1.93, NULL, '28/06/2004', 0, N'Goalkeeper', null),

-------------------DEFENDERS-------------------
('AVL', 2, N'Matty Cash', 'Poland', 1.85, 64, '07/08/1997', 4160000, N'Defender', 'Right'),
('AVL', 3, N'Diego Carlos', 'Brazil', 1.85, 79, '15/03/1993', 5200000, N'Defender', 'Right'),
('AVL', 4, N'Ezri Konsa', 'England', 1.83, 77, '23/10/1997', 1560000, N'Defender', 'Right'),
('AVL', 5, N'Tyrone Mings', 'England', 1.96, 77, '13/03/1993', 5200000, N'Defender', 'Left'),
('AVL', 12, N'Lucas Digne', N'France', 1.78, 74, '20/07/1993', 6240000, N'Defender', 'Left'),
('AVL', 14, N'Pau Torres', 'Spain', 1.91, 80, '16/01/1997', 0, N'Defender', 'Left'),
('AVL', 15, N'Álex Moreno', N'Spain', 1.79, 68, '08/06/1993', 1820000, N'Defender', 'Left'),
('AVL', 16, N'Calum Chambers', N'England', 1.82, 66, '20/01/1995',2600000, N'Defender', 'Right'),
('AVL', 17, N'Clément Lenglet', N'France', 1.86, 81, '17/06/1995', 7800000, N'Defender', 'Left'),
('AVL', 30, N'Kortney Hause', N'England', 1.91, 77, '16/07/1995', 420000, N'Defender', 'Left'),

-------------------MIDFIELDERS-------------------
('AVL', 6, N'Douglas Luiz', N'Brazil', 1.75, 65, '09/05/1998', 3900000, N'Midfielder', 'Right'),
('AVL', 7, N'John McGin', N'Scotland', 1.78, 68, '18/10/1994', 6240000, N'Midfielder', 'Left'),
('AVL', 8, N'Youri Tielemans', N'Belgium', 1.76, 72, '07/05/1997', 6240000, N'Midfielder', 'Both'),
('AVL', 9, N'Bertrand Traoré', N'Burkinabe', 1.81, 73, '06/09/1995', 4050000, N'Midfielder', 'Left'),
('AVL', 10, N'Emiliano Buendía', N'Brazil', 1.72, 65, '25/12/1996', 3900000, N'Midfielder', 'Right'),
('AVL', 19, N'Moussa Diaby', N'France', 1.70, 68, '07/07/1999', 0, N'Midfielder', 'Left'),
('AVL', 22, N'Nicolò Zaniolo', N'Italy', 1.90, 79, '02/07/1999', 3120000, N'Midfielder', 'Left'),
('NONE', 23, N'Philippe Coutinho', N'Brazil', 1.72, 71, '12/06/1992', 6500000, N'Midfielder', 'Right'),
('AVL', 31, N'Leon Bailey', N'Jamaica', 1.81, 75, '09/08/1997', 5200000, N'Midfielder', 'Left'),
('AVL', 32, N'Leander Dendoncker', N'Belgium', 1.88, 83, '15/04/1995', 4680000, N'Midfielder', 'Right'),
('NONE', 33, N'Jaden Philogene', N'England', 1.81, null, '08/02/2002', 0, N'Midfielder', 'Right'),
('AVL', 41, N'Jacob Ramsey', N'England', 1.80, 75, '28/05/2001', 3640000, N'Midfielder', 'Right'),
('AVL', 44, N'Boubacar Kamara', N'France', 1.84, 68, '23/11/1999', 7800000, N'Midfielder', 'Right'),
('AVL', 47, N'Tim Iroegbunam', N'England', null, null, '30/06/2003', 210000, N'Midfielder', null),
('AVL', 71, N'Omari Kellyman', N'Northern Ireland', null, null, '25/09/2005', 0, N'Midfielder', null),

-------------------FORWARDS-------------------
('AVL', 11, N'Ollie Watkins', N'Burkinabe', 1.80, 70, '30/12/1995', 3900000, N'Forward', 'Right'),
('AVL', 24, N'Jhon Durán', N'Colombia', 1.85, 73, '13/12/2003', 1560000, N'Forward', 'Right')


--3. BOURNEMOUTH----------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('BOU', 1, N'Neto', N'Brazil', 1.90, 84, '19/07/1989', 2600000, N'Goalkeeper', 'Right'),
('BOU', 12, N'Darren Randolph', N'Republic of Ireland', 1.88, 98, '12/05/1987', 1300000, N'Goalkeeper', 'Right'),
('BOU', 20, N'Andrei Radu', N'Romania', 1.88, 70, '28/05/1997', 0, N'Goalkeeper','Right'),

-------------------Defenders-------------------
('BOU', 2, N'Ryan Fredericks', N'England', 1.81, 74, '10/10/1992', 1820000, N'Defender', 'Right'),
('BOU', 3, N'Milos Kerkez', N'Hungary', 1.80, 71, '07/11/2003', 1300000, N'Defender', 'Left'),
('BOU', 5, N'Lloyd Kelly', N'England', 1.78, 70, '06/10/1998', 1560000, N'Defender', 'Left'),
('BOU', 6, N'Chris Mepham', N'Wales', 1.93, 88, '05/11/1997', 1820000, N'Defender', 'Right'),
('BOU', 15, N'Adam Smith', N'Uruguay', 1.80, 78, '29/04/1997', 1820000, N'Defender', 'Right'),
('NONE', 23, N'James Hill', N'England', 1.84, 73, '10/01/2002', 156000, N'Defender', 'Right'),
('BOU', 25, N'Marcos Senesi', N'Argentina', 1.85, 80, '10/05/1997', 2600000, N'Defender', 'Left'),
('BOU', 27, N'Illia Zabarnyi', N'Ukraine', 1.78, 70, '01/09/2002', 1300000, N'Defender', 'Right'),
('BOU', 37, N'Max Aarons', N'England', 1.78, 69, '04/01/2000', 0, N'Defender', 'Right'),
('BOU', 43, N'Ben Greenwood', N'Republic of Ireland', 1.70, 70, '20/02/2003', 0, N'Defender', null),

-------------------Midfielders--------------------
('BOU', 4, N'Lewis Cook', N'England', 1.75, 71, '03/02/1997', 2080000, N'Midfielder', 'Right'),
('BOU', 7, N'David Brooks', N'Wales', 1.73, 62, '08/07/1997', 2600000, N'Midfielder', 'Left'),
('BOU', 8, N'Joe Rothwell', N'England', 1.85, 77, '11/01/1995' , 416000, N'Midfielder', 'Right'),
('BOU', 10, N'Ryan Christie', N'Scotland', 1.78, 79, '22/02/1995', 1560000, N'Midfielder', 'Left'),
('BOU', 13, N'Emiliano Marcondes', N'Denmark', 1.82, 75, '09/03/1995', 780000, N'Midfielder', 'Right'),
('BOU', 14, N'Alex Scott', N'England', null, null, '21/08/2003' , 0, N'Midfielder', null),
('BOU', 16, N'Marcus Tavernier', N'England', 1.78, 80, '22/03/1999', 1820000, N'Midfielder', null),
('BOU', 18, N'Tyler Adams', N'USA', 1.73, 72, '14/02/1999', 3120000, N'Midfielder', 'Right'),
('BOU', 22, N'Hamed Junior Traorè', N'Côte dIvoire', 1.84, 77, '16/02/2000', 2340000, N'Midfielder', 'Right'),
('BOU', 26, N'Gavin Kilkenny', N'Republic of Ireland', 1.70, null, '01/02/2000', 78000, N'Midfielder', 'Right'),
('BOU', 29, N'Philip Billing', N'Denmark', 1.93, 83, '11/06/1996', 2080000, N'Midfielder', 'Left'),

-------------------Forwards-------------------
('BOU', 9, N'Dominic Solanke', N'England', 1.87, 80, '14/09/1997', 2600000, N'Forward', 'Right'),
('BOU', 11, N'Dango Ouattara', N'Burkina Faso', 1.77, 71, '11/02/2002', 1820000, N'Forward', null),
('BOU', 17, N'Luis Sinisterra', N'Colombia', 1.72, 60, '17/06/1999', 3380000, N'Forward', 'Right'),
('BOU', 19, N'Justin Kluivert', N'Netherlands', 1.71, 67, '06/06/1999', 4160000, N'Forward', 'Right'),
('BOU', 21, N'Kieffer Moore', N'England', 1.96, 89, '08/08/1992', 780000, N'Forward', 'Right'),
('BOU', 24, N'Antoine Semenyo', N'England', 1.85, 79, '07/01/2000', 1040000, N'Forward', null),
('NONE', 32, N'Jaidon Anthony', N'England', 1.83, null, '01/12/1999', 1300000, N'Forward', null)


--4. BRENTFORD------------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('BRE', 1, 'Mark Flekken', N'Netherlands', 1.95, 87, '13/06/1993', 0, N'Goalkeeper', 'Both'),
('BRE', 21, 'Thomas Strakosha', N'Albania', 1.86, 78, '19/03/1995', 1300000, N'Goalkeeper', 'Right'),
('BRE', 34, 'Matthew Cox', N'England', 1.82, 64, '02/05/2003', null, N'Goalkeeper', null),
('BRE', 40, 'Ellery Balcombe', N'England', 1.90, 92, '15/10/1999', null, N'Goalkeeper','Right'),

-------------------Defenders-------------------
('BRE', 2, 'Aaron Hickey', N'Scotland', 1.78, 72, '10/06/2002', 1560000, N'Defender', 'Left'),
('BRE', 3, 'Rico Henry', N'England', 1.70, 66, '08/07/1997', 1820000, N'Defender', 'Left'),
('BRE', 4, 'Charlie Goode', N'England', 1.96, 84, '03/08/1995', 416000, N'Defender', 'Right'),
('BRE', 5, 'Ethan Pinnock', N'England', 1.87, 82, '29/05/1993', 1560000, N'Defender', 'Left'),
('BRE', 13, N'Mathias Jørgensen', N'Denmark', 1.91, 79, '23/04/1990', 2600000, N'Defender', 'Right'),
('BRE', 16, 'Ben Mee', N'England', 1.80, 74, '21/09/1989', 2860000, N'Defender', 'Left'),
('BRE', 20, 'Kristoffer Ajer', N'Norway', 1.96, 84, '17/04/1998', 1820000, N'Defender', 'Right'),
('BRE', 22, 'Nathan Collins', N'Republic of Ireland', 1.93, null, '30/04/2001', 0, N'Defender', 'Right'),
('BRE', 30, 'Mads Roerslev Rasmussen', N'Denmark', 1.77, 72, '24/06/1999', 1040000, N'Defender', 'Right'),
('BRE', 33, 'Fin Stevens', N'Wales', null, null, '10/04/2003', 0, N'Defender', 'Right'),

-------------------Midfielders-------------------
('BRE', 6, N'Christian Nørgaard', N'Denmark', 1.85, 76, '10/03/1994', 1820000, N'Midfielder', 'Right'),
('BRE', 8, 'Mathias Jensen', N'Denmark', 1.80, 68, '01/01/1996', 2600000, N'Midfielder', 'Both'),
('BRE', 10, 'Joshua Da Silva', N'England', 1.84, 70, '23/10/1998', 1040000, N'Midfielder', 'Left'),
('BRE', 11, 'Yoane Wissa', N'DR Congo', 1.80, 75, '03/09/1996', 1300000, N'Midfielder', 'Right'),
('BRE', 15, 'Frank Onyeka', N'Nigeria', 1.83, 78, '01/01/1998', 1300000, N'Midfielder', 'Right'),
('BRE', 24, 'Mikkel Damsgaard', N'Denmark', 1.80, 66, '03/07/2000', 1560000, N'Midfielder', 'Right'),
('BRE', 25, 'Myles Peart-Harris', N'England', 1.80, 66, '18/09/2002', 0, N'Midfielder', null),
('BRE', 26, 'Shandon Baptiste', N'Grenada', 1.80, 67, '08/04/1998', 780000, N'Midfielder', 'Right'),
('BRE', 27, 'Vitaly Janelt', N'Germany', 1.84, 79, '10/05/1998', 1560000, N'Midfielder', 'Right'),
('BRE', 33, 'Yehor Yarmoliuk', N'Ukraine', 1.80, 72, '01/03/2004', 0, N'Midfielder', 'Both'),
('BRE', 37, 'Michael Olakigbe', N'England', null, null, '25/04/2004', 0, N'Midfielder', null),
('BRE', 38, 'Ethan Brierley', N'England', 1.68, null, '23/11/2003', 0, N'Midfielder', null),

-------------------Forwards-------------------
('BRE', 7, N'Neal Maupay', 'France', 1.73, 69, '14/08/1996', 2600000, N'Forward', 'Right'),
('BRE', 9, 'Kevin Schade', N'Germany', 1.83, 74, '27/11/2001', 520000, N'Forward', 'Right'),
('BRE', 14, 'Saman Ghoddos', N'Sweden', 1.76, 79, '06/09/1993', 1040000, N'Forward', 'Right'),
('BRE', 17, 'Ivan Toney', N'England', 1.79, 70, '16/03/1996', 1040000, N'Forward', 'Right'),
('BRE', 19, 'Bryan Mbeumo', N'Cameroon', 1.73, 64, '07/08/1999', 2340000, N'Forward', 'Left'),
('BRE', 23, 'Keane Lewis-Potter', N'England', 1.70, 67, '22/02/2001', 1820000, N'Forward', 'Right')


--5.BRIGHTON & HOVE ALBION-----------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('BHA', 1, N'Robert Sánchez', N'Spain', 1.97, 94, '18/11/1997', 1300000, N'Goalkeeper', 'Right'),
('BHA', 23, 'Jason Steele', N'England', 1.88, 79, '18/08/1990', 1040000, N'Goalkeeper', 'Right'),
('BHA', 38, 'Tom McGill', N'Canada', 1.85, 80, '25/03/2000', 520000, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('BHA', 2, 'Tariq Lamptey', N'Ghana', 1.65, 60, '30/09/2000', 1820000, N'Defender', 'Right'),
('BHA', 3, 'Igor Julio', N'Ghana', 1.85, 85, '07/02/1998', 520000, N'Defender', 'Left'),
('BHA', 4, 'Adam Webster', N'England', 1.90, 75, '04/01/1995', 2860000, N'Defender', 'Right'),
('BHA', 5, 'Lewis Dunk', N'England', 1.90, 77, '21/11/1991', 4160000, N'Defender', 'Right'),
('BHA', 29, 'Jan Paul van Hecke', N'Netherlands', 1.89, 84, '08/06/2000', 260000, N'Defender', 'Right'),
('BHA', 30, N'Pervis Estupiñán', N'Ecuador', 1.75, 73, '21/1/1998', 2600000, N'Defender', 'Left'),
('BHA', 34, N'Joël Veltman', N'Netherlands', 1.82, 73, '15/1/1992', 2600000, N'Defender', 'Right'),

-------------------Midfielders-------------------
('BHA', 6, 'James Milner', 'England', 1.75, 70, '04/01/1986', 0, N'Midfielder', 'Right'),
('BHA', 7, 'Solly March', N'England', 1.85, 77, '26/12/1994', 2600000, N'Midfielder', 'Left'),
('BHA', 8, 'Mahmoud Dahoud', N'Germany', 1.78, 68, '01/01/1996', 0, N'Midfielder', 'Right'),
('BHA', 11, 'Billy Gilmour', N'Scotland', 1.66, 60, '11/06/2001', 1040000, N'Midfielder', 'Right'),
('BHA', 13, N'Pascal Groß', N'Germany', 1.81, 78, '15/06/1991', 3380000, N'Midfielder', 'Right'),
('BHA', 14, N'Adam Lallana', N'England', 1.72, 73, '10/05/1998', 4680000, N'Midfielder', 'Both'),
('BHA', 15, 'Jakub Moder', N'Poland', 1.88, 83, '07/04/1999', 520000, N'Midfielder', 'Right'),
('NONE', 17, N'Steven Alzate', N'Colombia', 1.80, 75, '08/09/1998', 780000, N'Midfielder', 'Right'),
('BHA', 20, 'Carlos Baleba', N'Cameroon', null, null, '03/01/2004', 650000, N'Midfielder', null),
('BHA', 22, N'Mitoma Kaoru', N'Japan', 1.78, 75, '20/05/1997', 520000, N'Midfielder', 'Right'),
('BHA', 40, 'Facundo Buonanotte', N'Argentina', 1.74, 66, '23/12/2004', 780000, N'Midfielder', 'Left'),

-------------------Forwards-------------------
('BHA', 9, N'João Pedro', N'Brazil', 1.82, 70, '26/09/2001', 0, N'Forward', 'Right'),
('BHA', 10, N'Julio Enciso', N'Paraguay', 1.68, 64, '23/01/2004', 520000, N'Forward', 'Right'),
('BHA', 18, N'Danny Welbeck', N'England', 1.85, 73, '26/11/1990', 4680000, N'Forward', 'Right'),
('NONE', 19, N'Andi Zeqiri', N'Switzerland', 1.85, 81, '22/06/1999', 1378000, N'Forward', 'Left'),
('BHA', 24, N'Simon Adingra', N'Côte dIvoire', 1.75, 68, '01/01/2002', 0, N'Forward', 'Left'),
('BHA', 28, N'Evan Ferguson', N'Republic of Ireland', 1.83, 78, '19/10/2004', 1040000, N'Forward', null),
('BHA', 31, N'Ansu Fati', N'Spain', 1.78, 66, '31/10/2002', 8320000, N'Forward', 'Right')

--6. BURLEY FC--------------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('BUR', 1, N'James Trafford', N'England', 1.92, null, '10/10/2002', 0, N'Goalkeeper', 'Right'),
('BUR', 20, N'Denis Franchi', N'Italy', null, null, '22/10/2002', 30000, N'Goalkeeper', null),
('BUR', 29, N'Lawrence Vigouroux', N'Chile', 1.94, 77, '19/11/1993', 0, N'Goalkeeper', 'Right'),
('BUR', 49, N'Arijanet Muric', N'Kosovo', 1.98, 81, '07/11/1998', 1040000, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('BUR', 2, N'Dara OShea', N'Republic of Ireland', null, null, '04/03/1999', 0, N'Defender', null),
('BUR', 3, N'Charlie Taylor', N'England', 1.76, 70, '18/09/1993', 1300000, N'Defender', 'Left'),
('BUR', 5, N'Jordan Beyer', N'Germany', 1.87, 80, '19/05/2000', 160000, N'Defender', 'Right'),
('BUR', 6, N'CJ Egan-Riley', N'England', null, null, '02/01/2003', 280000, N'Defender', null),
('BUR', 14, N'Connor Roberts', N'Wales', 1.75, 72, '23/09/1995', 1360000, N'Defender', 'Right'),
('BUR', 18, N'Hjalmar Ekdal', N'Swenden', 1.88, 77, '21/10/1998', 936600, N'Defender', 'Right'),
('BUR', 21, N'Luke McNally', N'Republic of Ireland', 1.84, null, '20/09/1999', 890000, N'Defender', 'Right'),
('BUR', 22, N'Vitinho', N'Brazil', 1.75, 72, '23/07/1999', 600000, N'Defender', 'Right'),
('BUR', 28, N'Ameen Al-Dakhil', N'Belgium', 1.87, 70, '06/03/2002', 572000, N'Defender', 'Right'),
('BUR', 39, N'Owen Dodgson', N'England', null, null, '19/03/2003', null, N'Defender', null),
('BUR', 44, N'Hannes Delcroix', N'Belgium', 1.85, 78, '28/02/1999', null, N'Defender','Left'),

-------------------Midfielders-------------------
('BUR', 4, N'Jack Cork', N'Germany', 1.83, 70, '25/06/1989', 1980000, N'Midfielder', 'Right'),
('BUR', 7, N'Jóhann Gudmundsson', N'Iceland', 1.86, 78, '27/10/1990', 1560000, N'Midfielder', 'Left'),
('BUR', 8, N'Josh Brownhill', N'England', 1.78, 69, '19/12/1995', 2080000, N'Midfielder', 'Right'),
('NONE', 11, N'Scott Twine', N'England', 1.74, 69, '14/07/1999', 180000, N'Midfielder', 'Right'),
('BUR', 16, 'Sander Berge', N'Norway', 1.95, 96, '14/02/1998', 1700000, N'Midfielder', 'Right'),
('BUR', 24, N'Josh Cullen', N'Republic of Ireland', 1.75, 70, '07/04/1996', 910000, N'Midfielder', 'Right'),
('NONE', 26, N'Samuel Bastien', N'Congo DR', 1.75, 75, '26/09/1996', 780000, N'Midfielder', 'Right'),
('BUR', 31, N'Mike Trésor', N'Belgium', 1.72, 64, '28/05/1999', 520000, N'Midfielder', 'Right'),
('BUR', 42, N'Han-Noah Massengo', N'France', 1.78, null, '07/07/2001', 0, N'Midfielder', null),

-------------------Forwards-------------------
('BUR', 9, N'Jay Rodríguez', N'England', 1.85, 80, '29/07/1989', 1820000, N'Forward', 'Right'),
('BUR', 10, N'Benson Manuel', N'Belgium', 1.78, 68, '28/03/1997', 860000, N'Forward', 'Left'),
('NONE', 13, N'Wout Weghorst', N'Netherlands', 1.97, 84, '07/08/1992', 1820000, N'Forward', 'Right'),
('BUR', 15, N'Nathan Redmond', N'Netherlands', 1.73, 69, '06/03/1994', 0, N'Forward', 'Right'),
('BUR', 17, N'Lyle Foster', N'South Africa', 1.85, 70, '03/09/2000', 1040000, N'Forward', 'Right'),
('BUR', 19, N'Anass Zaroury', N'Morocco', 1.76, 70, '28/03/1997', 480000, N'Forward', 'Right'),
('BUR', 25, N'Zeki Amdouni', N'Switzerland', 1.85, 79, '04/12/2000', 0, N'Forward', 'Both'),
('BUR', 27, N'Darko Churlinov', N'North Macedonia', 1.71, 73, '11/07/2000', 440000, N'Forward', 'Right'),
('BUR', 30, N'Luca Koleosho', N'Italy', 1.75, 68, '15/09/2004', 0, N'Forward', 'Right'),
('BUR', 34, N'Jacob Bruun Larsen', N'Denmark', 1.87, 77, '19/09/1998', 0, N'Forward', 'Left'),
('BUR', 45, N'Michael Obafemi', N'Ireland', 1.69, 71, '06/07/2000', 670000, N'Forward', 'Right'),
('BUR', 47, N'Wilson Odobert', N'France', null, null, '28/11/2004', 0, N'Forward', null),
('BUR', 48, N'Enock Agyei', N'Belgium', 1.72, null, '13/02/2005', 0, N'Forward', 'Left')


--7. CHELSEA--------------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('CHE', 13, N'Marcus Bettinelli', N'England', 1.94, 82, '24/05/1992', 1820000, N'Goalkeeper', 'Right'),
('CHE', 1, N'Robert Sanchez', N'Spain', 1.97, 90, '18/11/1997', 0, N'Goalkeeper', 'Left'),
('CHE', 28, N'Djordje Petrovic', N'Serbia', 1.94, null, '08/10/1999', 0, N'Goalkeeper', null),
('CHE', 47, N'Lucas Bergström', 'Finland', 1.99, 82, '05/09/2002', 0, N'Goalkeeper', null),
('CHE', 50, N'Eddie Beach', 'Wales', 1.96, null, '14/11/2003', 0, N'Goalkeeper', null),

-------------------Defenders-------------------
('CHE', 2, N'Axel Disasi', N'France', 1.90, 83, '11/03/1998', 0, N'Defender', 'Right'),
('CHE', 3, N'Marc Cucurella', N'Spain', 1.72, 66, '22/07/1998', 9100000, N'Defender', 'Left'),
('CHE', 5, N'Benoît Badiashile', N'France', 1.94, 75, '26/03/2001', 4680000, N'Defender', 'Right'),
('CHE', 6, N'Thiago Silva', N'Brazil', 1.83, 79, '22/09/1984', 5720000, N'Defender', 'Right'),
('CHE', 14, N'Trevoh Chalobah', N'England', 1.90, 75, '05/07/1999', 2600000, N'Defender', 'Right'),
('CHE', 21, N'Ben Chilwell ', N'England', 1.78, 77, '21/12/1996', 10400000, N'Defender', 'Left'),
('CHE', 24, N'Reece James', N'England', 1.82, 82, '08/12/1999', 13000000, N'Defender', 'Right'),
('CHE', 26, N'Levi Colwill', N'England', 1.87, 83, '26/02/2003', 260000, N'Defender', null),
('CHE', 27, N'Malo Gusto', N'France', 1.79, 67, '19/05/2003', 0, N'Defender', 'Right'),
('CHE', 29, N'Ian Maatsen', N'Netherlands', 1.67, 57, '10/03/2002', 0, N'Defender', 'Left'),
('CHE', 33, N'Wesley Fofana', N'France', 1.90, 84, '17/12/2000', 10400000, N'Defender', 'Right'),
('CHE', 42, N'Alfie Gilchrist', N'England', 1.83, null, '28/11/2003', 0, N'Defender', null),
('CHE', 48, N'Bashir Humphreys', N'England', 1.87, 79, '15/03/2003', 0, N'Defender', 'Right'),
('CHE', null, N'Malang Sarr', N'France', 1.83, 73, '23/01/1999', 6240000, N'Defender', 'Left'),

-------------------Midfielders-------------------
('CHE', 8, N'Enzo Fernández', N'Argentina', 1.78, 76, '17/01/2001', 9360000, N'Midfielder', 'Right'),
('CHE', 16, N'Lesley Ugochukwu', N'France', 1.88, null, '26/03/2004', 0, N'Midfielder', null),
('CHE', 17, N'Carney Chukwuemeka', N'England', 1.87, 77, '20/10/2003', 5200000, N'Midfielder', null),
('CHE', 23, N'Conor Gallagher', N'England', 1.82, 77, '06/02/2000', 2600000, N'Midfielder', 'Right'),
('CHE', 25, 'Moisés Caicedo', N'Ecuador', 1.73, 68, '02/11/2001', 7800000, N'Midfielder', 'Right'),
('CHE', 45, 'Roméo Lavia', N'Belgium', 1.81, null, '06/01/2004', 2340000, N'Midfielder', 'Right'),

-------------------Forwards-------------------
('CHE', 7, N'Raheem Sterling', N'England', 1.72, 69, '08/12/1994', 16900000, N'Forward', 'Right'),
('CHE', 10, N'Mykhailo Mudryk', N'Ukraine', 1.75, 61, '05/01/2001', 5200000, N'Forward', 'Right'),
('CHE', 11, N'Noni Madueke', N'England', 1.76, 75, '10/03/2002', 2600000, N'Forward', 'Left'),
('CHE', 15, N'Nicolas Jackson', N'Senegal', 1.86, 78, '20/06/2001', 0, N'Forward', 'Right'),
('CHE', 18, N'Christopher Nkunku', N'France', 1.78, 68, '14/11/1997', 10140000, N'Forward', 'Right'),
('CHE', 19, N'Armando Broja', N'Albania', 1.91, 83, '10/09/2001', 2080000, N'Forward', 'Right'),
('CHE', 20, N'Cole Palmer', N'England', 1.82, 74, '06/05/2002', 2080000, N'Forward', 'Left'),
('CHE', 36, N'Deivid Washington', N'Brazil', 1.87, null, '05/06/2005', 364000, N'Forward', null),
('CHE', 37, N'Mason Burstow', N'England', 1.88, 79, '04/08/2003', 0, N'Forward', null),
('NONE', 43, N'Diego Moreira', N'Portugal', 1.79, 73, '06/08/2004', 0, N'Forward', null),
('CHE', 52, N'Alex Matos', N'England', null, null, '03/10/2004', 0, N'Forward', null),
('CHE', 62, N'Ronnie Stutter', N'England', null, null, '06/01/2005', 0, N'Forward', null)


--7. CRYSTAL PALACE-------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('CRY', 1, N'Sam Johnstone', N'England', 1.93, 85, '25/03/1993', 2080000, N'Goalkeeper', 'Right'),
('CRY', 30, 'Dean Henderson', 'England', 1.88, 85, '12/03/1997', 0, N'Goalkeeper', 'Right'),
('CRY', 31, N'Remi Matthews', N'England', 1.84, 78, '10/04/1994', 280000, N'Goalkeeper', 'Right'),
('CRY', 41, N'Joe Whitworth', N'England', null, null, '29/02/2004', 0, N'Goalkeeper', null),

-------------------Defenders-------------------
('CRY', 2, N'Joel Ward', N'England', 1.88, 83, '29/10/1989', 1820000, N'Defender', 'Right'),
('CRY', 3, N'Tyrick Mitchell', N'England', 1.75, 68, '01/09/1999', 2080000, N'Defender', null),
('CRY', 4, 'Rob Holding', N'England', 1.89, 75, '20/09/1995', 0, N'Defender', N'Right'),
('CRY', 5, N'James Tomkins', N'England', 1.92, 74, '29/03/1989', 2600000, N'Defender', 'Right'),
('CRY', 6, N'Marc Guéhi', N'England', 1.82, 82, '13/07/2000', 2600000, N'Defender', 'Right'),
('CRY', 16, N'Joachim Andersen', N'Denmark', 1.92, 90, '31/05/1996', 4160000, N'Defender', 'Right'),
('CRY', 17, N'Nathaniel Clyne', N'England', 1.75, 67, '05/04/1991', 4160000, N'Defender', 'Right'),
('CRY', 26, N'Chris Richards', N'USA', 1.88, 87, '28/03/2000', 2860000, N'Defender', 'Right'),
('CRY', 36, N'Nathan Ferguson', N'England', 1.78, 74, '06/10/2000', 1300000, N'Defender', null),
('CRY', 42, 'Seán Grehan', N'Republic of Ireland', null, null, '08/01/2004', 0, N'Defender', null),

-------------------Midfielders-------------------
('CRY', 7, N'Michael Olise', N'France', 1.84, 76, '12/12/2001', 2340000, N'Midfielder', null),
('CRY', 8, N'Jefferson Lerma', N'Colombia', 1.79, 70, '25/10/1994', 0, N'Midfielder', 'Right'),
('CRY', 10, N'Eberechi Eze', N'England', 1.78, 74, '26/06/1998', 1560000, N'Midfielder', null),
('CRY', 15, N'Jeffrey Schlupp', N'Ghana', 1.78, 72, '23/12/1992', 2600000, N'Midfielder', 'Both'),
('CRY', 19, N'Will Hughes', N'England', 1.85, 74, '17/04/1995', 1820000, N'Midfielder', 'Left'),
('CRY', 23, N'Malcolm Ebiowei', N'England', 1.85, NULL, '04/09/2003', NULL, N'Midfielder', 'Left'),
('CRY', 28, N'Cheick Doucouré', N'Mali', 1.80, 73, '08/01/2000', 3120000, N'Midfielder', 'Right'),
('CRY', 29, N'Naouirou Ahamada', N'France', 1.83, 73, '29/03/2002', 1040000, N'Midfielder', null),
('CRY', 40, N'Jack Wells-Morrison', N'England', null, null, '18/02/2004', null, N'Midfielder', null),
('CRY', 44, N'Jairo Riedewald', N'Netherlands', 1.82, 79, '09/09/1996', 2860000, N'Midfielder', 'Left'),
('CRY', 49, N'Jesurun Rak-Sakyi', N'England', null, null, '05/10/2002', null, N'Midfielder', null),
('CRY', 60, N'Jadan Raymond', N'Wales', null, null, '15/10/2003', null, N'Midfielder', null),
('CRY', 77, N'David Ozoh', N'England', null, null, '06/05/2005', null, N'Midfielder', null),

-------------------Forwards-------------------
('CRY', 9, N'Jordan Ayew', N'Ghana', 1.82, 80, '11/09/1991', 1820000, N'Forward', 'Right'),
('CRY', 11, N'Matheus França', N'Brazil', null, null, '01/04/2004', 0, N'Forward', 'Right'),
('CRY', 14, N'Jean-Philippe Mateta', N'France', 1.92, 88, '28/06/1997', 2600000, N'Forward', 'Right'),
('CRY', 22, N'Odsonne Édouard', N'France', 1.87, 83, '16/01/1998', 4680000, N'Forward', 'Right'),
('NONE', 37, N'John-Kymani Gordon', N'France', null, null, '13/02/2003', 0, N'Forward', null),
('CRY', 53, N'Ademola Ola-Adebomi', N'England', null, null, '03/09/2003', 0, N'Forward', null)


--8. EVERTON--------------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('EVE', 1, N'Jordan Pickford', 'England', 1.85, 82, '07/03/1994', 6500000, N'Goalkeeper', 'Left'),
('EVE', 12, N'João Virgínia', 'Portugal', 1.93, 83, '10/10/1999', 390000, N'Goalkeeper', 'Left'),
('EVE', 31, N'Andy Lonergan', 'England', 1.92, 87, '19/10/1983', 520000, N'Goalkeeper', 'Left'),
('EVE', 43, N'Billy Crellin', 'England', 1.85, 60, '30/06/2000', 520000, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('EVE', 2, N'Nathan Patterson', 'Scotland', 1.89, 83, '16/10/2001', 1456000, N'Defender', 'Right'),
('EVE', 4, N'Mason Holgate', 'England', 1.84, 63, '22/10/1996', 1040000, N'Defender', 'Right'),
('EVE', 5, N'Michael Keane', 'England', 1.91, 82, '11/01/1993', 4160000, N'Defender', 'Right'),
('EVE', 6, N'James Tarkowski', 'England', 1.92, 87, '19/10/1983', 5200000, N'Defender', 'Right'),
('EVE', 18, N'Ashley Young', N'England', 1.75, 65, '09/07/1985',0, N'Defender', 'Both'),
('EVE', 19, N'Vitaliy Mykolenko', 'Ukraine', 1.80, 71, '29/05/1999', 3016000, N'Defender', 'Right'),
('EVE', 22, N'Ben Godfrey', 'England', 1.83, 74, '15/01/1998', 3900000, N'Defender', 'Right'),
('EVE', 23, N'Séamus Coleman', 'Republic of Ireland', 1.77, 67, '11/10/1988', 2860000, N'Defender', 'Right'),
('EVE', 32, N'Jarrard Branthwaite', 'England', 1.95, 67, '27/06/2002', 780000, N'Defender', 'Left'),

-------------------Midfielders-------------------
('EVE', 8, N'Amadou Onana', 'Belgium', 1.92, 76, '16/08/2001', 5200000, N'Midfielder', 'Both'),
('EVE', 16, N'Abdoulaye Doucouré', 'Mali', 1.84, 75, '01/01/1993', 6240000, N'Midfielder', 'Right'),
('EVE', 20, N'Dele Alli', 'England', 1.88, 76, '11/04/1996', 5200000, N'Midfielder', 'Right'),
('EVE', 21, N'André Gomes', 'Portugal', 1.88, 84, '30/07/1993', 5840000, N'Midfielder', 'Right'),
('EVE', 25, N'Jean-Philippe Gbamin', 'Côte dIvoire', 1.86, 83, '25/09/1995', 3900000, N'Midfielder', 'Right'),
('EVE', 27, N'Idrissa Gueye', 'Senegal', 1.74, 66, '26/09/1989', 4160000, N'Midfielder', 'Right'),
('EVE', 37, N'James Garner', 'England', 1.86, 78, '13/03/2001', 1560000, N'Midfielder', 'Right'),
('EVE', 58, N'Mackenzie Hunt', N'England', null, null, '14/11/2001', 0, N'Midfielder', null),
('EVE', 62, N'Tyler Onyango', 'England', null, null, '04/03/2004', 0, N'Midfielder', null),

-------------------Forwards-------------------
('EVE', null, N'Jack Harrison', 'England', 1.75, 70, '20/10/1996', 0, N'Forward', null),
('EVE', 7, N'Dwight McNeil', 'England', 1.83, 68, '22/11/1999', 1300000, N'Forward', 'Left'),
('EVE', 9, N'Dominic Calvert-Lewin', 'England', 1.87, 71, '16/03/1997', 5200000, N'Forward', 'Right'),
('EVE', 10, N'Arnaut Danjuma', 'Netherlands', 1.78, 74, '31/01/1997', 2730000, N'Forward', 'Both'),
('EVE', 11, N'Demarai Gray', 'England', 1.80, 74, '28/06/1996', 1300000, N'Forward', 'Both'),
('EVE', 14, N'Beto', 'Portugal', 1.94, 88, '31/01/1998', 2600000, N'Forward', 'Right'),
('EVE', 28, N'Youssef Chermiti', 'Portugal', 1.92, 84, '24/05/2004', 0, N'Forward', 'Right'),
('EVE', 47, N'Thomas Cannon', 'Ireland', null, null, '28/12/2002', 390000, N'Forward', null),
('EVE', 61, N'Lewis Dobbin', 'England', null, null, '03/01/2003', 0, N'Forward', null)


--9. FULLHAM FC--------------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('FUL', 1, N'Marek Rodák', 'Slovakia', 1.94, 81, '13/12/1996', 780000, N'Goalkeeper', 'Right'),
('FUL', 17, N'Bernd Leno', N'Germany', 1.89, 82, '04/03/1992', 4680000, N'Goalkeeper', 'Right'),
('FUL', 23, N'Steven Benda', N'Germany', 1.92, 83, '01/10/1998', 0, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('FUL', 2, N'Kenny Tete', N'Netherlands', 1.80, 71, '09/10/1995', 2600000, N'Defender', 'Right'),
('FUL', 3, N'Calvin Bassey', N'Nigeria', 1.85, 76, '31/12/1999', 0, N'Defender', 'Left'),
('FUL', 4, N'Tosin Adarabioyo', 'England', 1.96, 80, '24/09/1997', 2080000, N'Defender', 'Right'),
('FUL', 12, N'Fodé Ballo-Touré', N'Defender', 1.82, 70, '03/01/1997', 1690000, N'Defender', 'Left'),
('FUL', 13, N'Tim Ream', N'USA', 1.83, 80, '05/10/1987', 1560000, N'Defender', 'Left'),
('FUL', 21, N'Timothy Castagne', N'Belgium', 1.85, 80, '05/12/1995', 0, N'Defender', 'Right'),
('FUL', 27, N'Kevin Mbabu', N'Sweden', 1.84, 83, '19/04/1995', 2080000, N'Defender', 'Right'),
('FUL', 31, N'Issa Diop', N'France', 1.94, 92, '09/01/1997', 3640000, N'Defender', 'Right'),
('FUL', 33, N'Antonee Robinson', N'USA', 1.83, 70, '08/08/1997', 2600000, N'Defender', 'Left'),

-------------------Midfielders-------------------
('FUL', 6, N'Harrison Reed', N'England', 1.81, 72, '27/01/1995', 1560000, N'Midfielder', 'Right'),
('FUL', 10, N'Tom Cairney', N'Scotland', 1.83, 72, '20/01/1991', 1560000, N'Midfielder', 'Left'),
('FUL', 18, N'Andreas Pereira', N'Brazil', 1.78, 71, '01/01/1996', 1560000, N'Midfielder', 'Right'),
('FUL', 22, N'Alex Iwobi', 'Nigeria', 1.80, 75, '03/05/1996', 0, N'Midfielder', 'Right'),
('FUL', 26, N'João Palhinha', N'Portugal', 1.90, 84, '09/07/1995', 2600000, N'Midfielder', 'Right'),
('FUL', 28, N'Sasa Lukić', N'Sebria', 1.83, 76, '13/08/1996', 676000, N'Midfielder', 'Right'),
('FUL', 35, N'Tyrese Francois', N'Australia', 1.70, 60, '16/07/2000', 676000, N'Midfielder', null),
('FUL', 38, N'Luke Harris', N'Wales', 1.77, null, '04/03/2005', 0, N'Midfielder', 'Right'),
('FUL', 49, N'Matthew Dibley-Dias', N'England', null, null, '29/10/2003', 0, N'Midfielder', null),

-------------------Forwards-------------------
('FUL', 7, N'Raúl Jiménez', N'Mexico', 1.90, 76, '05/05/1991', 5200000, N'Forward',  'Right'),
('FUL', 8, N'Harry Wilson', N'Wales', 1.73, 63, '22/03/1997', 1820000, N'Forward', 'Left'),
('FUL', 9, N'Aleksandar Mitrović', N'Sebria', 1.89, 89, '16/09/1994', 4160000, N'Forward', 'Right'),
('FUL', 11, N'Adama Traoré', N'Spain', 1.78, 86, '25/01/1996', 0, N'Tiền đạo',  N'Chân phải'),
('FUL', 14, N'Bobby De Cordova-Reid', N'Jamaica', 1.70, 68, '02/02/1993', 1820000, N'Forward', 'Right'),
('FUL', 19, N'Rodrygo Muniz', N'Brazil', 1.78, null, '04/05/2001', 3432000, N'Forward', 'Right'),
('FUL', 20, N'Willian', N'Brazil', 1.77, 75, '09/08/1988', 1820000, N'Forward', 'Right'),
('FUL', 30, N'Carlos Vinícius', N'Brazil', 1.90, 86, '25/03/1995', 2080000, N'Forward', 'Left'),
('FUL', 65, N'Jay Stansfield', N'England', null, null, '24/11/2002', 0, N'Forward', null)


--12. LIVERPOOL-----------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('LIV', 1, 'Alisson Becker', 'Brazil', 1.93, 91, '02/10/1992', 7800000, N'Goalkeeper', 'Right'),
('LIV', 13, 'Adrian', N'Spain', 1.88, 80, '01/03/1987', 3120000, N'Goalkeeper', 'Right'),
('LIV', 45, 'Marcelo Pitaluga', 'Brazil', null, null, '20/12/2002', 0, N'Goalkeeper', null),
('LIV', 62, 'Caoimhin Kelleher', 'Ireland', 1.78, 75, '23/11/1998', 520000, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('LIV', 2, 'Joe Gomez', 'England', 1.88, 77, '23/05/1997', 4420000, N'Defender', 'Right'),
('LIV', 4, 'Virgil van Dijk', N'Netherlands', 1.95, 90, '08/07/1991', 11400000, N'Defender', 'Right'),
('LIV', 5, 'Ibrahima Konate', N'France', 1.93, 84, '25/05/1999', 3640000, N'Defender', 'Right'),
('LIV', 21, 'Konstantinos Tsimikas', 'Scotland', 1.78, 77, '12/05/1996', 2600000, N'Defender', 'Left'),
('LIV', 26, 'Andrew Robertson', 'Scotland', 1.78, 64, '11/03/1998', 5200000, N'Defender','Left'),
('LIV', 32, 'Joel Matip', 'Cameroon', 1.95, 90, '08/08/1991', 5200000, N'Defender', 'Right'),
('LIV', 47, 'Nathaniel Phillips', 'England', 1.88, 76, '21/03/1997', 3380000, N'Defender', 'Right'),
('LIV', 66, 'Trent Alexander-Arnold', 'England', 1.75, 72, '07/10/1998', 9360000, N'Defender', 'Right'),
('LIV', 78, 'Jarell Quansah', 'England', NULL, NULL, '29/01/2003', 0, N'Defender', NULL),

-------------------Midfielders-------------------
('LIV', 3, 'Wataru Endo', N'Japan', 1.78, 77, '09/02/1993', 2600000, N'Midfielder', 'Right'),
('LIV', 6, 'Thiago Alcantara', N'Spain', 1.74, 70, '11/04/1991', 10400000, N'Midfielder', 'Right'),
('LIV', 8, 'Dominik Szoboszlai', 'Hungary', 1.86, 74, '25/10/2000', 6240000, N'Midfielder', 'Right'),
('LIV', 10, 'Alexis Mac Allister', 'Argentina', 1.76, 69, '24/12/1998', 7800000, N'Midfielder', 'Right'),
('LIV', 17, 'Curtis Jones', 'England', 1.85, 81, '30/01/2001', 780000, N'Midfielder', 'Right'),
('LIV', 19, 'Harvey Elliot', 'England', 1.70, 65, '04/04/2003', 2080000, N'Midfielder', 'Left'),
('LIV', 38, 'Ryan Gravenberch', 'Netherlands', 1.90, 83, '16/05/2002', 7800000, N'Midfielder', 'Right'),
('LIV', 43, N'Stefan Bajčetić', N'Spain', 1.85, 77, '22/10/2004', 2080000, N'Midfielder', null),
('LIV', 53, N'James McConnell', N'England', NULL, null, '13/09/2004', 0, N'Midfielder', null),

-------------------Forwards-------------------
('LIV', 7, 'Luis Diaz', 'Colombia', 1.78, 65, '13/01/1997', 2860000, N'Forward', 'Right'),
('LIV', 9, 'Darwin Nunez', 'Uruguay', 1.88, 78, '24/06/1999', 7280000, N'Forward', 'Right'),
('LIV', 11, 'Mohamed Salah', N'Egypt', 1.75, 71, '15/06/1992', 18200000, N'Forward', 'Left'),
('LIV', 18, 'Cody Gakpo', N'Netherlands', 1.93, 65, '07/05/1999', 6240000, N'Forward', 'Right'),
('LIV', 20, 'Diogo Jota', N'Portugal', 1.70, 65, '04/12/1996', 7280000, N'Forward', 'Right'),
('LIV', 50, 'Ben Doak', N'Scotland', null, null, '11/11/2005', 0, N'Forward', null)

--13. LUTON TOWN FC-----------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('LUT', 1, 'James Shea', 'England', 1.85, 76, '16/09/1991', 180000, N'Goalkeeper', null),
('LUT', 23, 'Tim Krul', 'Netherlands', 1.88, 84, '03/04/1988', 0, N'Goalkeeper', 'Left'),
('LUT', 24, 'Thomas Kaminski', 'Belgium', 1.90, 78, '23/10/1992', 90000, N'Goalkeeper', 'Both'),
('LUT', 33, 'Matt Macey', 'England', 2.02, 96, '09/09/1994', 90000, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('LUT', 2, 'Gabriel Osho', 'England', null, null, '14/08/1998', 260000, N'Defender', 'Right'),
('LUT', 3, 'Daniel Potts', 'England', 1.73, 76, '13/04/1994', 0, N'Defender', 'Left'),
('LUT', 4, 'Tom Lockyer', 'Wales', 1.85, 72, '03/12/1994', 420000, N'Defender', 'Right'),
('LUT', 5, 'Mads Andersen', N'Denmark', 1.94, 81, '27/12/1997', 0, N'Defender', 'Right'),
('LUT', 12, 'Issa Kaboré', 'Burkina Faso', 1.80, null, '12/05/2001', 0, N'Defender', 'Right'),
('LUT', 15, 'Teden Mengi', N'England', 1.83, 78, '30/04/2002', 0, N'Defender', 'Right'),
('LUT', 16, 'Reece Burke', 'England', 1.88, 81, '02/09/1996', 390000, N'Defender', 'Right'),
('LUT', 29, 'Amarii Bell', 'Jamaica', 1.80, 66, '05/05/1994', 320000, N'Defender', 'Left'),
('LUT', 38, 'Joseph Johnson', 'England', null, null, '09/01/2006', 0, N'Defender', null),
('LUT', 40, 'Aidan Francis-Clarke', N'England', null, null, '13/09/2005', 0, N'Defender', null),
('LUT', 45, 'Alfie Doughty', 'England', 1.83, null, '21/12/1999', 170000, N'Defender', 'Left'),

-------------------Midfielders-------------------
('LUT', 6, 'Ross Barkley', 'England', 1.89, 76, '05/12/1993', 0, N'Midfielder', 'Right'),
('LUT', 8, 'Luke Berry', 'England', 1.77, 72, '12/07/1992', 260000, N'Midfielder', 'Right'),
('LUT', 13, 'Marvelous Nakamba', 'Zimbabwe', 1.78, 71, '19/01/1994', 0, N'Midfielder', 'Left'),
('LUT', 14, 'Tahith Chong', 'England', 1.85, 75, '04/12/1999', 0, N'Midfielder', 'Left'),
('LUT', 17, 'Pelly-Ruddock Mpanzu', 'DR Congo', 1.75, 63, '22/03/1994', 160000, N'Midfielder', 'Right'),
('LUT', 18, 'Jordan Clark', 'England', 1.83, 71, '22/09/1993', 120000, N'Midfielder', 'Right'),
('LUT', 20, 'Louie Watson', 'Ireland', null, null, '07/06/2001', 120000, N'Midfielder', null),
('LUT', 22, 'Allan Campbell', 'Scotland', 1.75, 73, '04/07/1998', 440000, N'Midfielder', 'Right'),
('LUT', 26, 'Ryan Giles', 'England', 1.79, 72, '26/01/2000', 0, N'Midfielder', null),
('LUT', 30, 'Luke Freeman', 'England', 1.81, 64, '22/03/1992', 110000, N'Midfielder', 'Left'),
('LUT', 42, 'Casey Pettit', 'England', null, null, '15/10/2002', 0, N'Midfielder', null),
('LUT', 28, N'Albert Lokonga', N'Belgium', 1.73, 67, '22/10/1999', 2600000, N'Midfielder', 'Right'),

-------------------Forwards-------------------
('LUT', 7, 'Chiedozie Ogbene', 'Ireland', 1.81, 78, '01/05/1997', 0, N'Forward', 'Right'),
('LUT', 9, 'Carlton Morris', 'England', 1.85, 85, '16/12/1995', 260000, N'Forward', 'Right'),
('LUT', 10, 'Cauley Woodrow', 'England', 1.84, 78, '02/12/1994', 420000, N'Forward', 'Right'),
('LUT', 11, 'Elijah Adebayo', 'England', 1.93, 89, '02/12/1994', 390000, N'Forward', null),
('LUT', 15, 'Admiral Muskwe', 'Zimbabwe', 1.83, null, '21/08/1998', 230000, N'Forward', null),
('LUT', 19, 'Jacob Brown', 'Scotland', 1.78, 62, '10/04/1998', 0, N'Forward', 'Right'),
('LUT', 21, 'John McAtee', 'England', 1.80, 75, '23/07/1999', 150000, N'Forward', null),
('LUT', 25, 'Joe Taylor', 'Wales', null, null, '18/11/2002', 52000, N'Forward', null),
('LUT', 27, 'Aribim Pepple', 'Canada', 1.85, 83, '25/12/2002', 52000, N'Forward', null)


--14. MAN CITY-----------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('MCI', 18, 'Stefan Ortega', N'Germany', 1.85, 88, '06/11/1992', 2860000, N'Goalkeeper', 'Right'),
('MCI', 13, 'Zack Steffen', N'USA', 1.91, 86, '02/04/1995', 2392000, N'Goalkeeper', 'Right'),
('MCI', 31, 'Ederson', 'Brazil', 1.88, 89, '17/08/1993', 5200000, N'Goalkeeper', 'Left'),
('MCI', 33, 'Scott Carson', 'England', 1.88, 85, '03/09/1985', 1560000, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('MCI', 2, 'Kyle Walker', 'England', 1.78, 80, '28/05/1990', 8320000, N'Defender', 'Right'),
('MCI', 3, N'Rúben Dias', N'Portugal', 1.86, 76, '14/05/1997', 9360000, N'Defender', 'Right'),
('MCI', 5, 'John Stones', 'England', 1.88, 80, '28/05/1994', 13000000, N'Defender', 'Right'),
('MCI', 6, N'Nathan Aké', N'Netherlands', 1.80, 75, '18/02/1995', 4680000, N'Defender', 'Left'),
('MCI', 14, 'Aymeric Laporte', N'Spain', 1.89, 86, '27/05/1994', 6240000, N'Defender', N'Left'),
('MCI', 21, 'Sergio Gómez', N'Spain', 1.71, 68, '04/09/2000', 2600000, N'Defender', 'Left'),
('MCI', 24, 'Josko Gvardiol', N'Croatia', 1.85, 80, '23/01/2002', 10400000, N'Defender', 'Left'),
('MCI', 25, 'Manuel Akanji', N'Switzerland', 1.86, 91, '19/07/1995', 9360000, N'Defender', 'Right'),
('MCI', 52, 'Oscar Bobb', 'Norway', null, null, '12/07/2003', 0, N'Defender', null),
('MCI', 82, 'Rico Lewis', 'England', 1.69, null, '21/11/2004', 260000, N'Defender', null),
('MCI', 78, 'Taylor Harwood-Bellis', 'England', 1.88, null, '30/01/2002', 390000, N'Defender', 'Right'),

-------------------Midfielders-------------------
('MCI', 4, 'Kalvin Phillips', 'England', 1.78, 72, '02/12/1995', 7800000, N'Midfielder', 'Right'),
('MCI', 8, N'Mateo Kovačić', N'Croatia', 1.77, 78, '06/05/1994', 7800000, N'Midfielder', 'Right'),
('MCI', 10, 'Jack Grealish', 'England', 1.75, 76, '10/09/1995', 15600000, N'Midfielder', 'Right'),
('MCI', 11, 'Jérémy Doku', N'Belgium', 1.73, 66, '27/05/2002', 2600000, N'Midfielder', 'Right'),
('MCI', 16, 'Rodrigo', N'Spain', 1.90, 82, '22/06/1996', 11440000, N'Midfielder', 'Right'),
('MCI', 17, 'Kevin De Bruyne', N'Belgium', 1.81, 68, '28/06/1991', 20800000, N'Midfielder', 'Right'),
('MCI', 20, 'Bernardo Silva', N'Portugal', 1.73, 64, '10/08/1994', 7800000, N'Midfielder', 'Left'),
('MCI', 27, N'Matheus Nunes', N'Portugal', 1.84, 78, '27/08/1998', 0, N'Midfielder', 'Right'),
('None', 32, 'Máximo Perrone', 'Argentina', 1.78, 64, '07/01/2003', 1560000, N'Midfielder', 'Left'),
('MCI', 47, 'Phil Foden', 'England', 1.71, 70, '28/05/2000', 11700000, N'Midfielder', 'Left'),
('MCI', 96, 'Ben Knight', 'England', 1.71, null, '14/06/2002', null, N'Midfielder', null),

-------------------Forwards-------------------
('MCI', 9, 'Erling Haaland', N'Netherlands', 1.94, 88, '21/07/2000', 19500000, N'Forward', 'Left'),
('MCI', 19, 'Julián Álvarez', 'Argentina', 1.70, 71, '31/01/2000', 5200000, N'Forward', 'Right')


--14. MAN UNITED----------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('MUN', 1, 'Altay Bayindir', 'Turkey', 1.98, 88, '14/04/1998', 0, N'Goalkeeper', 'Both'),
('MUN', 22, 'Tom Heaton', 'England', 1.88, 85, '15/04/1986', 2340000, N'Goalkeeper', 'Right'),
('MUN', 24, 'André Onana', 'Cameroon', 1.90, 93, '02/04/1996', 6240000, N'Goalkeeper', 'Right'),
('MUN', 40, 'Radek Vítek', 'Czechia', 1.98, NULL, '24/10/2003', 0, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('MUN', 2, 'Victor Lindelöf', N'Sweden', 1.87, 80, '17/07/1994', 6240000, N'Defender', 'Right'),
('MUN', 5, 'Harry Maguire', 'England', 1.94, 90, '05/03/1993', 9880000, N'Defender', 'Right'),
('MUN', 6, 'Lisandro Martínez', 'Argentina', 1.75, 77, '18/01/1998', 6240000, N'Defender', 'Left'),
('MUN', 12, 'Tyrell Malacia', N'Netherlands', 1.70, 67, '17/08/1999', 3900000, N'Defender', 'Left'),
('MUN', 15, N'Sergio Reguilón', N'Spain', 1.78, 68, '16/12/1996', 2756000, N'Defender', 'Left'),
('MUN', 19, N'Raphaël Varane', N'France', 1.91, 81, '24/04/1993', 17680000, N'Defender', 'Right'),
('MUN', 20, 'Diogo Dalot', N'Portugal', 1.83, 76, '18/03/1999', 4420000, N'Defender', 'Right'),
('MUN', 23, 'Luke Shaw', 'England', 1.85, 75, '12/07/1995', 7800000, N'Defender', 'Left'),
('MUN', 29, 'Aaron Wan-Bissaka', 'England', 1.83, 72, '26/11/1997', 4680000, N'Defender', 'Right'),
('MUN', 33, 'Brandon Williams', N'England', 1.71, 63, '03/09/2000', 3380000, N'Defender', 'Right'),
('MUN', 35, 'Jonny Evans', N'Northern Ireland', 1.88, 77, '03/01/1988', 0, N'Defender', 'Both'),
('MUN', 42, 'Alvaro Fernandez', N'Spain', null, null, '23/03/2003', 0, N'Defender', null),

-------------------Midfielders-------------------
('MUN', 4, N'Sofyan Amrabat', N'Morocco', 1.83, 70, '21/08/1996', 3380000, N'Midfielder', 'Right'),
('MUN', 7, N'Mason Mount', N'England', 1.81, 76, '10/01/1999', 10400000, N'Midfielder', 'Right'),
('MUN', 8, 'Bruno Fernandes', N'Portugal', 1.79, 69, '08/09/1994', 12480000, N'Midfielder', 'Right'),
('MUN', 14, 'Christian Eriksen', N'Denmark', 1.82, 76, '14/02/1992', 7800000, N'Midfielder', 'Both'),
('MUN', 16, 'Amad Diallo', N'Côte dIvoire', 1.73, 72, '12/07/2002', 1500000, N'Midfielder', 'Right'),
('MUN', 18, 'Casemiro', 'Brazil', 1.85, 84, '23/02/1992', 18200000, N'Midfielder', 'Right'),
('MUN', 28, 'Facundo Pellistri', 'Uruguay', 1.75, 69, '20/12/2001', 1040000, N'Midfielder', 'Right'),
('MUN', 34, 'Donny van de Beek', N'Netherlands', 1.84, 76, '18/04/1997', 6240000, N'Midfielder', 'Right'),
('MUN', 37, 'Kobbie Mainoo', 'England', 1.75, null, '19/04/2005', 0, N'Midfielder', 'Right'),
('MUN', 39, 'Scott McTominay', 'Scotland', 1.93, 88, '08/12/1996', 3120000, N'Midfielder', 'Right'),	
('MUN', 44, 'Daniel Gore', 'England', null, null, '26/09/2004', 0, N'Midfielder', 'Right'),	
('MUN', 46, 'Hannibal', 'Tunisia', 1.77, 74, '21/01/2003', 180000, N'Midfielder', 'Right'),	

-------------------Forwards-------------------
('MUN', 9, 'Anthony Martial', N'France', 1.81, 76, '05/12/1995', 13000000, N'Forward', 'Right'),
('MUN', 10, 'Marcus Rashford', 'England', 1.80, 70, '31/10/1997', 10400000, N'Forward', 'Right'),
('MUN', 11, 'Rasmus Hojlund', 'Denmark', 1.91, 79, '04/02/2003', 4420000, N'Forward', 'Left'),
('MUN', 17, 'Alejandro Garnacho', 'Argentina', 1.80, 80, '01/07/2004', 2600000, N'Forward', 'Right'),
('MUN', 21, 'Antony', 'Brazil', 1.74, 63, '24/02/2000', 10400000, N'Forward', 'Left'),
('MUN', 25, 'Jadon Sancho', 'England', 1.80, 76, '25/03/2000', 18200000, N'Forward', 'Right'),
('MUN', 47, 'Shola Shoretire', 'England', 1.70, 70, '02/02/2004', 260000, N'Forward', 'Right')


--15. NEWCASTLE UNITED----------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('NEW', 1, 'Martin Dúbravka', 'Slovakia', 1.90, 83, '15/01/1989', 2080000, N'Goalkeeper', 'Right'),
('NEW', 18, 'Loris Karius', N'Germany', 1.89, 90, '22/06/1993', 520000, N'Goalkeeper', 'Right'),
('NEW', 22, 'Nick Pope', 'England', 1.91, 76, '19/04/1992', 3120000, N'Goalkeeper', 'Right'),
('NEW', 29, 'Mark Gillespie', 'England', 1.92, 83, '27/03/1992', 520000, N'Goalkeeper', null),

-------------------Defenders-------------------
('NEW', 2, 'Kieran Trippier', 'England', 1.78, 71, '19/09/1990', 6240000, N'Defender', 'Right'),
('NEW', 3, 'Paul Dummett', 'Wales', 1.83, 82, '26/09/1991', 1820000, N'Defender', 'Left'),
('NEW', 4, 'Sven Botman', N'Netherlands', 1.93, 81, '12/01/2000', 4680000, N'Defender', 'Left'),
('NEW', 5, N'Fabian Schär', N'Switzerland', 1.86, 84, '20/12/1991', 2080000, N'Defender', 'Right'),
('NEW', 6, 'Jamaal Lascelles', 'England', 1.88, 89, '11/11/1993', 2080000, N'Defender', 'Right'),
('NEW', 13, 'Matt Targett', 'England', 1.83, 70, '18/09/1995', 5200000, N'Defender', 'Left'),
('NEW', 17, 'Emil Krafth', N'Sweden', 1.84, 83, '02/08/1994', 2860000, N'Defender', 'Right'),
('NEW', 19, 'Javier Manquillo', N'Spain', 1.78, 76, '05/05/1994', 1820000, N'Defender', 'Right'),
('NEW', 20, N'Lewis Hall', N'England', 1.79, 73, '08/09/2004', 364000, N'Defender', null),
('NEW', 21, 'Tino Livramento', N'England', 1.82, null, '12/11/2002', 0, N'Defender', 'Right'),
('NEW', 33, 'Dan Burn', 'England', 1.98, 87, '09/05/1992', 1820000, N'Defender', 'Left'),

-------------------Midfielders-------------------
('NEW', 7, 'Joelinton', 'Brazil', 1.86, 81, '14/08/1996', 4420000, N'Midfielder', 'Right'),
('NEW', 8, 'Sandro Tonali', 'Italy', 1.81, 79, '08/05/2000', 10920000, N'Midfielder', 'Right'),
('NEW', 11, 'Matt Ritchie', 'Scotland', 1.72, 76, '10/09/1989', 2340000, N'Midfielder', 'Left'),
('NEW', 16, 'Jeff Hendrick', 'Republic of Ireland', 1.85, 79, '31/01/1992', 1820000, N'Midfielder', 'Right'),
('NEW', 23, 'Jacob Murphy', 'England', 1.79, 74, '24/02/1995', 1820000, N'Midfielder', 'Both'),
('NEW', 24, N'Miguel Almirón', 'Paraguay', 1.74, 63, '10/02/1994', 3120000, N'Midfielder', 'Left'),
('NEW', 28, 'Joe Willock', 'England', 1.79, 71, '20/08/1999', 4160000, N'Midfielder', 'Right'),
('NEW', 32, 'Elliot Anderson', 'Scotland', 1.79, null, '06/11/2002', 1560000, N'Midfielder', 'Right'),
('NEW', 36, 'Sean Longstaff', 'England', 1.80, 65, '30/10/1997', 2600000, N'Midfielder', 'Right'),
('NEW', 39, 'Bruno Guimarães', 'Brazil', 1.82, 74, '16/11/1997', 6240000, N'Midfielder', 'Right'),
('NEW', 67, 'Lewis Miley', 'Brazil', null, null, '01/05/2006', 0, N'Midfielder', null),

-------------------Forwards-------------------
('NEW', 9, 'Callum Wilson', 'England', 1.80, 66, '27/02/1992', 2392000, N'Forward', 'Both'),
('NEW', 10, 'Anthony Gordon', 'England', 1.83, 72, '24/02/2001', 3120000, N'Forward', 'Right'),
('NEW', 14, 'Alexander Isak', N'Sweden', 1.92, 77, '21/09/1999', 6240000, N'Forward', 'Right'),
('NEW', 15, N'Harvey Barnes', N'England', 1.77, 66, '09/12/1997', 4160000, N'Forward', 'Right')


--16. NOTTINGHAM FOREST---------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('NFO', 1, 'Matt Turner', N'USA', 1.90, 79, '24/06/1994', 660000, N'Goalkeeper', 'Right'),
('NFO', 13, 'Wayne Hennessey', 'Wales', 1.98, 90, '24/01/1987', 780000, N'Goalkeeper', 'Right'),
('NFO', 23, 'Odysseas Vlachodimos', 'Greece', 1.88, 78, '26/04/1994', 0, N'Goalkeeper', 'Right'),
('NFO', 34, 'Ethan Horvath', N'USA', 1.91, 84, '09/06/1995', 890000, N'Goalkeeper', 'Right'),
('NFO', 38, 'George Shelvey', N'England', 1.88, 83, '22/04/2001', 0, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('NFO', 2, 'Giulian Biancone', N'France', 1.87, null, '31/03/2000', 1040000, N'Defender', 'Right'),
('NFO', 3, N'Nuno Tavares', N'Portugal', 1.83, 75, '19/12/1997', 0, N'Defender', 'Left'),
('NFO', 4, 'Joe Worrall', 'England', 1.93, 64, '10/01/1997', 780000, N'Defender', 'Right'),
('NFO', 7, 'Neco Williams', 'Wales', 1.83, 72, '13/04/2001', 2600000, N'Defender', 'Right'),
('NFO', 15, 'Harry Toffolo', 'England', 1.83, 71, '19/08/1995', 780000, N'Defender', 'Left'),
('NFO', 18, N'Felipe', 'Brzail', 1.90, 83, '16/05/1989', 4160000, N'Defender', 'Right'),
('NFO', 19, N'Moussa Niakhaté', 'Senegal', 1.90, 82, '08/03/1996', 2340000, N'Defender', 'Left'),
('NFO', 24, N'Sèrge Aurier', N'Côte dIvoire', 1.76, 76, '24/12/1992', 1820000, N'Defender', 'Right'),
('NFO', 26, 'Scott Mckenna', 'Scotland', 1.89, 74, '12/11/1996', 1040000, N'Defender', 'Left'),
('NFO', 29, 'Gonzalo Montiel', 'Argentina', 1.75, 68, '01/01/1997', 0, N'Defender', 'Right'),
('NFO', 30, 'Willy Boly', N'Côte dIvoire', 1.95, 92, '03/02/1991', 2080000 , N'Defender', 'Right'),
('NFO', 39, 'Jonathan Panzo', 'England', 1.85, 72, '25/10/2000', 0, N'Defender', 'Left'),
('NFO', 42, N'Mohamed Dräger', 'Tunisia', 1.80, 75, '25/06/1996', 0, N'Defender', 'Right'),
('NFO', 43, 'Ola Aina', 'Nigeria', 1.84, 82, '08/10/1996', 2080000, N'Defender', 'Right'),

-------------------Midfielders-------------------
('NFO', 5, 'Orel Mangala', N'Belgium', 1.78, 80, '18/03/1998', 1560000, N'Midfielder', 'Right'),
('NFO', 6, 'Jonjo Shelvey', 'England', 1.84, 80, '27/02/1992', 3900000, N'Midfielder', 'Right'),
('NFO', 10, 'Morgan Gibbs-White', 'England', 1.71, null, '27/01/2000', 4160000, N'Midfielder', 'Right'),
('NFO', 8, 'Cheikhou Kouyaté', 'Senegal', 1.89, 83, '21/12/1989', 2340000, N'Midfielder', 'Right'),
('NFO', 12, N'Andrey Santos', N'Brazil', 1.80, 75, '03/05/2003', 520000, N'Midfielder', null),
('NFO', 16, N'Nicolás Domínguez', N'Argentina', 1.79, 73, '28/06/1998', 0, N'Midfielder', 'Right'),
('NFO', 22, 'Ryan Yates', 'England', 1.90, 87, '21/11/1997', 1300000, N'Midfielder', null),
('None', 23, 'Remo Freuler', N'Switzerland', 1.81, 80, '15/04/1992', 2080000, N'Midfielder', 'Right'),
('NFO', 28, 'Danilo', 'Brazil', 1.76, 69, '29/04/2001', 1560000, N'Midfielder', null),
('NFO', 32, 'Lewis OBrien', 'England', 1.73, 63, '14/08/1998', 780000, N'Midfielder', 'Right'),
('NFO', 41, 'Brandon Aguilera', 'Costa Rica', 1.79, 60, '28/06/2003', 0, N'Midfielder', 'Left'),
('NFO', 44, 'Tyrese Fornah', 'England', 1.81, 78, '11/09/1999', 0, N'Midfielder', null),

-------------------Forwards-------------------
('NFO', 9, 'Taiwo Awoniyi', 'Nigeria', 1.83, 84, '12/08/1997', 2600000, N'Forward', 'Right'),
('NFO', 11, 'Chris Wood', 'New Zealand', 1.91, 81, '07/12/1991', 4160000, N'Forward', 'Right'),
('NFO', 14, 'Callum Hudson-Odoi', 'England', 1.82, 76, '07/11/2000', 0, N'Forward', 'Right'),
('NFO', 17, 'Alex Mighten', 'England', null, null, '11/04/2002', 180000, N'Forward', null),
('NFO', 21, 'Anthony Elanga', N'Sweden', 1.78, 70, '27/04/2002', 1300000, N'Forward', 'Right'),
('NFO', 25, 'Emmanuel Dennis', 'Nigeria', 1.75, 67, '15/11/1997', 2080000, N'Forward', 'Right'),
('NFO', 27, 'Divock Origi', 'Belgium', 1.85, 75, '18/04/1995', 6240000, N'Forward', 'Both'),
('NFO', 35, 'Hwang Ui-jo', 'South Korea', 1.85, 74, '28/08/1992', 1560000, N'Forward', 'Left')


----17. Sheffield United
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('SHU', 1, 'Adam Davies', N'Wales', 1.85, 75, '17/07/1992', 1040000, N'Goalkeeper', 'Right'),
('SHU', 18, 'Wes Foderingham', N'England', 1.85, 75, '14/01/1991', 390000, N'Goalkeeper', 'Left'),
('SHU', 37, 'Jordan Amissah', N'Ghana', 1.97, null, '02/08/2001', 820000, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('SHU', 2, 'George Baldock', N'Greece', 1.78, 71, '09/03/1993', 210000, N'Defender', 'Right'),
('SHU', 3, 'Max Lowe', N'England', 1.75, 75, '11/05/1997', 230000, N'Defender', 'Left'),
('SHU', 5, 'Auston Trusty', N'USA', 1.91, 84, '12/08/1998', 210000, N'Defender', 'Left'),
('SHU', 6, 'Chris Basham', N'England', 1.90, 80, '20/07/1988', 490000, N'Defender', 'Right'),
('SHU', 12, 'John Egan', N'Republic of Ireland', 1.85, 75, '20/10/1992', 390000, N'Defender', 'Right'),
('SHU', 14, 'Luke Thomas', 'England', 1.81, null, '10/06/2001', 520000, N'Defender', 'Left'),
('SHU', 15, 'Anel Ahmedhodzic', N'Bosnia-Herzegovina', 1.95, 84, '26/03/1999', 1300000, N'Defender', 'Right'),
('SHU', 19, 'Jack Robinson', N'England', 1.80, 67, '01/09/1993', 1040000, N'Defender', 'Left'),
('SHU', 20, 'Jayden Bogle', N'England', null, null, '27/07/2000', 860000, N'Defender', null),
('SHU', 27, 'Yasser Larouci', N'France', 1.76, 68, '01/01/2001', 0, N'Defender','Left'),
('SHU', 33, 'Rhys Norrington-Davies', N'Wales', 1.81, 68, '22/04/1999', 20800, N'Defender', 'Left'),
('SHU', 38, 'Femi Seriki', N'England', 1.83, null, '28/04/2002', 0, N'Defender', null),
('SHU', null, 'Sai Sachdev', N'England', null, null, '23/10/2004', 0, N'Defender', null),
('SHU', 40, 'Jili Buyabu', N'England', null, null, '09/08/2001', 0, N'Defender', null),

-------------------Midfielders-------------------
('SHU', 4, 'John Fleck', N'Scotland', 1.70, 72, '24/08/1991', 1040000, N'Midfielder', 'Left'),
('SHU', 8, 'Gustavo Hamer', N'Netherlands', 1.69, 61, '24/06/1997', 0, N'Midfielder', 'Right'),
('SHU', 16, 'Oliver Norwood', N'Northern Ireland', 1.80, 75, '12/04/1991', 780000, N'Midfielder', 'Right'),
('SHU', 17, 'Ismaila Coulibaly', N'Mali', 1.83, 68, '25/12/2000', 312000, N'Midfielder', 'Right'),
('SHU', 21, 'Vinicius Souza', N'Brazil', 1.87, 80, '17/06/1999', 0, N'Midfielder', 'Right'),
('SHU', 22, 'Tom Davies', N'England', 1.80, 70, '30/06/1998', 0, N'Forward', 'Right'),
('SHU', 23, 'Ben Osborn', N'England', 1.76, 75, '05/08/1994', 780000, N'Midfielder', 'Left'),
('SHU', 25, 'Anis Ben Slimane', N'Tunisia', 1.88, 86, '16/03/2001', 0, N'Midfielder', 'Both'),
('SHU', 28, 'James McAtee', 'England', null, null, '18/10/2002', 0, N'Midfielder', null),
('SHU', 29, 'Iliman Ndiaye', N'Senegal', 1.80, 70, '06/03/2000', 200000, N'Midfielder', null),
('SHU', 35, 'Andre Brooks', N'England', 1.80, null, '20/08/2003', 0, N'Midfielder', null),

-------------------Forwards-------------------
('SHU', 7, 'Rhian Brewster', N'England', 1.80, 75, '01/04/2000', 1430000, N'Forward', 'Right'),
('SHU', 9, 'Oliver McBurnie', N'Scotland', 1.88, 79, '04/06/1996', 1040000, N'Forward', 'Right'),
('SHU', 10, N'Cameron Archer', N'England', 1.71, 72, '09/12/2001', 0, N'Forward', 'Right'),
('SHU', 11, 'Bénie Traoré', N'Côte dIvoire', 1.72, 64, '30/11/2002', 0, N'Forward', 'Right'),
('SHU', 32, 'William Osula', N'Denmark', 1.80, 81, '04/08/2003', 60000, N'Forward', null),
('SHU', 34, 'Louie Marsh', N'England', 1.76, 65, '16/10/2003', 0, N'Forward', null),
('SHU', 36, 'Daniel Jebbison', N'Cananda', 1.90, 69, '11/07/2003', 30000, N'Forward', 'Left'),
('SHU', 39, 'Antwoine Hackford', N'England', 1.77, null, '20/03/2004', 0, N'Forward', 'Right')


--18. TOTTENHAM-----------------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('TOT', 1, 'Hugo Lloris', N'France', 1.88, 82, '26/12/1986', 5200000, N'Goalkeeper', 'Left'),
('TOT', 13, 'Guglielmo Vicario', 'Italy', 1.94, 83, '07/10/1996', 3900000, N'Goalkeeper', 'Right'),
('TOT', 20, 'Fraser Forster', 'England', 2.01, 93, '17/03/1988', 3900000, N'Goalkeeper', 'Right'),
('TOT', 40, 'Brandon Austin', 'England', 1.88, 82, '08/01/1999', 390000, N'Goalkeeper', null),
('TOT', 41, 'Alfie Whiteman', 'England', 1.89, 84, '02/10/1998', 3900000, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('TOT', 6, N'Davinson Sánchez', N'Colombia', 1.87, 81, '12/06/1996', 3380000, N'Defender', 'Right'),	
('TOT', 12, N'Emerson Royal', N'Brazil', 1.81, 79, '14/01/1999', 2080000, N'Defender', 'Right'),	
('TOT', 15, N'Eric Dier', N'England', 1.88, 83, '15/01/1994', 4420000, N'Defender', 'Right'),
('TOT', 17, N'Cristian Romero', N'Argentina', 1.85, 79, '27/04/1998', 8580000, N'Defender', 'Right'),
('TOT', 23, N'Pedro Porro', N'Spain', 1.76, 71, '13/09/1999', 4420000, N'Defender', 'Right'),
('TOT', 24, N'Djed Spence', N'England', 1.85, null, '09/08/2000', null, N'Defender', null),
('TOT', 25, N'Japhet Tanganga', N'England', 1.84, 76, '31/03/1999', 1300000, N'Defender', 'Right'),
('TOT', 33, N'Ben Davies', N'Wales', 1.81, 77, '24/04/1993', 4160000, N'Defender', 'Left'),
('TOT', 35, N'Ashley Phillips', N'England', 1.92, null, '26/06/2005', 780000, N'Defender', 'Right'),
('TOT', 37, N'Micky van de Ven', N'Netherlands', 1.93, 81, '19/04/2001', 0, N'Defender', 'Left'),
('TOT', 38, N'Destiny Udogie', N'Italy', 1.86, 67, '28/11/2002', 0, N'Defender', 'Left'),

-------------------Midfielders-------------------
('TOT', 4, 'Oliver Skipp', 'England', 1.75, 70, '16/09/2000', 2080000, N'Midfielder', 'Right'),
('TOT', 5, N'Pierre-Emile Højbjerg', N'Denmark', 1.87, 84, '05/08/1995', 5200000, N'Midfielder', 'Right'),
('TOT', 8, N'Yves Bissouma', N'Mali', 1.82, 80, '30/08/1996', 2860000, N'Midfielder', 'Right'),
('TOT', 10, N'James Maddison', N'England', 1.75, 73, '23/11/1996', 0, N'Midfielder', 'Right'),
('TOT', 14, N'Ivan Perišić', N'Croatia', 1.86, 80, '02/02/1989', 9360000, N'Midfielder', 'Both'),
('TOT', 18, N'Giovani Lo Celso', N'Argentina', 1.77, 68, '09/04/1996', 3640000, N'Midfielder', 'Left'),
('TOT', 19, N'Ryan Sessegnon', N'England', 1.78, 70, '18/05/2000', 2860000, N'Midfielder', 'Left'),
('TOT', 21, N'Dejan Kulusevski', N'Sweden', 1.86, 80, '25/04/2000', 5720000, N'Midfielder', 'Left'),
('TOT', 28, N'Tanguy Ndombélé', N'France', 1.87, 72, '25/06/1997', 3900000, N'Midfielder', 'Right'),
('TOT', 29, N'Pape Sarr', N'Senegal', 1.85, 70, '14/09/2002', 572000, N'Midfielder', null),
('TOT', 30, N'Rodrigo Bentancur', N'Uruguay', 1.87, 72, '25/06/1997', 3900000, N'Midfielder', 'Right'),

-------------------Forwards-------------------
('TOT', 7, N'Son Heung-Min', N'South Korea', 1.84, 77, '08/07/1992', 9880000, N'Forward', 'Both'),	
('TOT', 9, N'Richarlison', N'Brazil', 1.84, 83, '10/05/1997', 4680000, N'Forward', 'Right'),	
('TOT', 11, N'Bryan Gil', N'Spain', 1.75, 60, '11/02/2001', 2080000, N'Forward', 'Left'),
('TOT', 22, N'Brennan Johnson', N'Wales', 1.86, 73, '23/05/2001', 0, N'Forward', 'Right'),
('TOT', 27, N'Manor Solomon', N'England', 1.70, 66, '24/07/1999', 0, N'Forward', 'Both'),
('TOT', 36, N'Alejo Véliz', N'Argentina', 1.86, 77, '19/09/2003', 0, N'Forward', 'Right')


--19. WEST HAM UNITED-----------------------------------------------------------------
-------------------Goalkeepers-------------------
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('WHU', 1, N'Ł. Fabiański', 'Poland', 1.90, 83, '18/04/1985', 3380000, N'Goalkeeper', 'Right'),
('WHU', 23, N'Alphonse Aréola', N'France', 1.95, 94, '27/03/1993', 6240000, N'Goalkeeper', 'Right'),
('WHU', 25, N'Nathan Trott', N'England', 1.88, null, '21/11/1998', 0, N'Goalkeeper', 'Right'),
('WHU', 49, N'Joseph Anang', N'England', 1.90, 72, '08/06/2000', 57200, N'Goalkeeper', 'Right'),

-------------------Defenders-------------------
('WHU', 2, N'Ben Johnson', N'England', 1.75, 67, '24/01/2000', 1040000, N'Defender', 'Right'),
('WHU', 3, N'Aaron Cresswell', N'England', 1.70, 66, '15/12/1989', 2600000, N'Defender', 'Left'),
('WHU', 4, N'Kurt Zouma', N'France', 1.90, 96, '27/10/1994', 6500000, N'Defender', 'Right'),
('WHU', 5, N'Vladimír Coufal', N'Czechia', 1.79, 76, '22/08/1992', 1820000, N'Defender', 'Right'),
('WHU', 15, N'Konstantinos Mavropanos', N'Greece', 1.94, 94, '11/12/1997', 2600000, N'Defender', 'Right'),
('WHU', 21, N'Angelo Ogbonna', N'Italy', 1.91, 86, '23/05/1988', 3640000, N'Defender', 'Left'),
('WHU', 24, N'Thilo Kehrer', N'Germany', 1.86, 76, '21/09/1996', 4160000, N'Defender', 'Right'),
('WHU', 27, N'Nayef Aguerd', N'Morocco', 1.90, 76, '30/03/1996', 2600000, N'Defender', 'Left'),
('WHU', 33, N'Emerson Palmieri', N'Brazil', 1.76, 63, '03/08/1994', 4940000, N'Defender', 'Left'),

-------------------Midfielders-------------------
('WHU', 7, N'James Ward-Prowse', N'England', 1.73, 66, '01/11/1994', 0, N'Midfielder', 'Right'),
('WHU', 8, N'Pablo Fornals', N'Spain', 1.78, 67, '22/02/1996', 3380000, N'Midfielder', 'Right'),
('WHU', 10, N'Lucas Paquetá', N'Brazil', 1.80, 72, '27/08/1997', 7800000, N'Midfielder', 'Left'),
('WHU', 12, N'Flynn Downes', N'England', 1.73, 70, '20/01/1999', 1300000, N'Midfielder', 'Right'),
('WHU', 14, N'Mohammed Kudus', N'Ghana', 1.77, 70, '02/08/2000', 0, 'Midfielder','Left'),
('WHU', 17, N'Maxwel Cornet', N'Côte dIvoire', 1.79, 69, '27/09/1996', 3380000, N'Midfielder', 'Right'),
('WHU', 19, N'Edson Álvarez', N'Mexico', 1.87, 73, '24/10/1997', 0, N'Midfielder', 'Right'),
('WHU', 28, N'Tomás Souček', N'Czechia', 1.92, 86, '27/02/1995', 3380000, N'Midfielder', 'Right'),
('WHU', 32, N'Conor Coventry', N'England', null, null, '25/10/2004', 0, N'Midfielder', null),

-------------------Forwards-------------------
('WHU', 9, N'Michail Antonio', N'Jamaica', 1.80, 82, '28/03/1990', 4420000, N'Forward', 'Right'),
('WHU', 18, N'Danny Ings', N'England', 1.78, 73, '23/07/1992', 6500000, N'Forward', 'Right'),
('WHU', 20, N'Jarrod Bowen', N'England', 1.75, 70, '20/12/1996', 3120000, N'Forward', 'Left'),
('WHU', 22, N'Saïd Benrahma', N'Algeria', 1.72, 67, '10/08/1995', 2860000, N'Forward', 'Left'),
('WHU', 45, N'Divin Mubama', N'Algeria', 1.72, 67, '10/08/1995', 2860000, N'Forward', 'Left')


--20. WOLVERHAMPTON WANDERERS---------------------------------------------------------
-------------------Goalkeepers-------------------
----José Sá
GO
INSERT INTO Players(ClubID, Number, PlayerName, Nation, Height, [Weight], PlayerDOB, Salary, Position, Foot)
VALUES('WOL', 1, N'José Sá', 'Portugal', 1.92, 84, '17/01/1993', 1300000, N'Goalkeeper', 'Right'),
('WOL', 25, 'Daniel Bentley', 'England', 1.88, 72, '13/07/1993', 520000, N'Goalkeeper', 'Right'),
('WOL', 40, 'Tom King', 'Wales', 1.85, 80, '09/03/1995', 0, N'Goalkeeper', null),

-------------------Defenders-------------------
('WOL', 2, 'Matt Doherty', 'Northern Ireland', 1.75, 63, '24/03/1997', 0, N'Defender', null),
('WOL', 3, N'Rayan Aït-Nouri', 'Algeria', 1.79, 70, '06/06/2001', 520000, N'Defender', 'Left'),
('WOL', 4, N'Santiago Bueno', 'Uruguay', 1.90, 76, '09/11/1998', 0, N'Defender', 'Right'),
('WOL', 15, 'Craig Dawson', 'England', 1.88, 82, '06/05/1990', 2340000, N'Defender', 'Right'),
('WOL', 17, N'Hugo Bueno', N'Spain', 1.80, 73, '18/09/2002', 260000, N'Defender', 'Left'),
('WOL', 19, 'Jonny Otto', N'Spain', 1.75, 70, '03/03/1990', 2340000, N'Defender', 'Both'),
('WOL', 22, N'Nélson Semedo', N'Portugal', 1.77, 67, '16/11/1993', 4160000, N'Defender', 'Right'),
('WOL', 23, N'Maximilian Kilman', 'England', 1.94, 89, '23/05/1997', 780000, N'Defender', 'Left'),
('WOL', 24, N'Toti Gomes', N'Portugal', 1.87, 83, '23/05/1997', 520000, N'Defender', 'Left'),

-------------------Midfielders-------------------
('WOL', 5, N'Mario Lemina', 'Gabon', 1.84, 85, '01/09/1993', 2340000, N'Midfielder', 'Right'),
('WOL', 6, N'Boubacar Traoré', 'Mali', 1.83, 67, '20/08/2001', 2860000, N'Midfielder', null),
('WOL', 8, N'João Gomes', N'Portugal', 1.74, 74, '08/09/1986', 1560000, N'Midfielder', null),
('WOL', 20, N'Tommy Doyle', N'England', 1.72, null, '17/10/2001', 0, N'Midfielder', 'Right'),
('WOL', 27, N'Jean-Ricner Bellegarde', N'France', 1.72, 70, '27/06/1998', 0, N'Midfielder', 'Right'),
('WOL', 32, N'Joseph Hodge', N'Republic of Ireland', 1.72, null, '12/02/2001', 260000, N'Midfielder', null),

-------------------Forwards-------------------
('WOL', 7, N'Pedro Neto', N'Portugal', 1.72, 62, '09/03/2000', 2600000, N'Forward',  'Left'),
('WOL', 9, N'Fábio Silva', N'Portugal', 1.85, 75, '19/07/2002', 4160000, N'Forward',  'Right'),
('WOL', 11, N'Hwang Hee-Chan', N'South Korea', 1.77, 77, '26/01/1996', 1560000, N'Forward',  'Right'),
('WOL', 12, N'Matheus Cunha', N'Brazil', 1.84, 76, '27/05/1999', 3120000, N'Forward',  'Right'),
('WOL', 18, N'Sasa Kalajdzic', N'Austria', 2.00, 93, '07/07/1997', 1820000, N'Forward',  null),
('WOL', 21, N'Pablo Sarabia', N'Spain', 1.74, 70, '11/05/1992', 4680000, N'Forward',  'Left'),
('WOL', 30, N'Enso Gonzalez', N'Paraguay', 1.69, 69, '20/01/2005', 0, N'Forward',  'Left'),
('WOL', 63, N'Nathan Fraser', N'Republic of Ireland', null, null, '22/02/2005', 0, N'Forward',  null)



--INSERT INTO CauThu(MaCT, MaDB, SoAo, HoTen, QuocTich, ChieuCao, CanNang, NamSinh, Luong, ViTri, ChanThuan) 
--values('FUL_11', 'FUL', 11, N'Adama Traoré', N'Spain', 1.78, 86, '25/01/1996', 0, N'Tiền đạo',  N'Chân phải')

--SELECT * FROM CauThu DELETE FROM CauThu
--SELECT * FROM Players where PlayerID = '1228'
--SELECT * FROM CauThu where HoTen = N'Brennan Johnson'
--select *from Players where PlayerName like N'%neto%'
--select *from CauThu where HoTen like N'serge%'
--SELECT * FROM CauThu where MaCT Like N'bre_%'
--select * from CauThu where MaDB = 'mci' and SoAo in (49,18,4,7,8,15,10,19,34)

---------------------------------------------------------------------------------------------------------------------------------