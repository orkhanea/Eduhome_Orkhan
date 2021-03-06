USE [EduHomeDb]
GO
SET IDENTITY_INSERT [dbo].[TeacherSkills] ON 

INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (1, 23, 44, 56, 87, 19, 33)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (2, 95, 80, 78, 82, 27, 50)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (3, 100, 100, 100, 100, 100, 100)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (4, 80, 90, 100, 90, 80, 70)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (5, 56, 67, 78, 89, 90, 98)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (6, 34, 56, 23, 87, 34, 98)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (7, 56, 67, 72, 12, 49, 38)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (8, 23, 65, 88, 99, 100, 32)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (9, 43, 66, 73, 34, 54, 76)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (10, 50, 30, 50, 60, 70, 80)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (11, 49, 98, 87, 76, 65, 54)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (12, 45, 74, 36, 84, 89, 36)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (13, 75, 95, 85, 95, 100, 85)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (14, 23, 44, 56, 87, 19, 33)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (15, 75, 95, 85, 95, 100, 85)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (16, 45, 67, 90, 89, 78, 56)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (17, 23, 44, 56, 87, 19, 33)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (18, 90, 75, 90, 100, 100, 95)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (19, 90, 75, 90, 100, 100, 95)
INSERT [dbo].[TeacherSkills] ([Id], [Language], [Design], [TeamLeader], [Inovation], [Development], [Communication]) VALUES (20, 50, 76, 43, 54, 65, 87)
SET IDENTITY_INSERT [dbo].[TeacherSkills] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (1, N'Imran', N'Alizade', N'Boş işlər müdürü', N'Lambadaki değerli olduğu için göze çarpan masanın masanın koyun. Türemiş sıfat göze çarpan çünkü yapacakmış çünkü koşuyorlar karşıdakine koşuyorlar yazın adanaya yapacakmış ve öyle ki. Gül lambadaki çobanın tv karşıdakine. Düşünüyor çobanın duyulmamış yazın sevindi bundan dolayı uzattı sokaklarda batarya kutusu gördüm.', N'teacher1.jpg', N'Bənövşəyi Kəmər', N'18 years of experience', NULL, N'Biznesin Bankrot Edilmesi', N'İmranAliyev@azmail.az', N'+9940505000005', N'Imran.ali', 17)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (3, N'Samuel', N'L. Jackson', N'Actor', N'Lambadaki masaya doğru domates öyle ki yapacakmış anlamsız. Un değirmeni değerli olduğu için bahar gülüyorum değerli olduğu için. Uzattı anlamsız ötekinden dolayı sokaklarda ötekinden dolayı masanın biber öyle ki sokaklarda lakin.', N'teacher3.jpg', N'Criminal Killer', N'20 years of experience', N'Killing, Chilling, Bulling', N'Oxford University Criminalogia Faculity', N'SamuelLJackson@gmail.com', N'+19001000001', N'Samue.L', 2)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (7, N'Nate', N'Diaz', N'Fighter', N'Nathan Donald Diaz is an American professional mixed martial artist, currently signed with the Ultimate Fighting Championship. Before signing with the UFC, Diaz competed in World Extreme Cagefighting, Strikeforce, and Pancrase.', N'teacher6.jpg', N'Gonden Belt Owner', N'15 years of experience', N'Fighting, Eating, Sleeping', N'Mixed Martial Arts ', N'NateDiaz@gmail.com', N'+15555555055', N'nate.d', 3)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (8, N'Nizami', N'Gencevi', N'Shair', N'Bir inci safligi olsa da suda artiq icilende derd verer o da.', N'teacher8.jpg', N'Master', N'800 years of experience', N'Writing, Speaking', N'Ganja Iqtisad Universiteti', N'NizaiGencevi@gmail.com', N'+994502111112', N'Niko.G', 4)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (9, N'Sultan', N'Suleyman', N'Shah', N'Gamina gamlanip olma mahzun, demine demlenib olma magrur, ne gam baki ne dem baki ya hu.', N'teacher9.jpg', N'Sultan Suleyman', N'500 years of experience', N'Figting, Occuping Lands', N'Istanbul Teknik Universitesi', N'Suleyman@gmail.com', N'+9095985887867', N'Sulu.S', 5)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (13, N'Ismayil', N'Hesenov', N'Developer', N'Bir guzguye baxdigimda gorduyume birde goye baxanda gormediyime inaniram!', N'teacher2.jpg', N'Senior', N'5 years of experience', N'Coding, Searching, Drink Coffee', N'Code Academy', N'IsmayilH@gmail.com', N'+99455055055', N'Ismayil.h', 6)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (20, N'Kazim', N'Abidov', N'Fisher', N'Heyatda vurdun bir birine kimi tadun sen?', N'teacher10.jpg', N'Senior', N'9 years of experience', N'Eating, Drinking, Repeating', N'Mingecevir Dovlet Akademiyasi', N'KazimH@gmail.com', N'+99453452675', N'Kazim_033', 7)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (22, N'Samuel', N'L. Jackson', N'Actor', N'Lambadaki masaya doğru domates öyle ki yapacakmış anlamsız. Un değirmeni değerli olduğu için bahar gülüyorum değerli olduğu için. Uzattı anlamsız ötekinden dolayı sokaklarda ötekinden dolayı masanın biber öyle ki sokaklarda lakin.', N'teacher11.jpg', N'Criminal Killer', N'20 years of experience', N'Killing, Chilling, Bulling', N'Oxford University Criminalogia Faculity', N'SamuelLJackson@gmail.com', N'+19001000001', N'Samue.L', 8)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (24, N'Nate', N'Diaz', N'Fighter', N'Nathan Donald Diaz is an American professional mixed martial artist, currently signed with the Ultimate Fighting Championship. Before signing with the UFC, Diaz competed in World Extreme Cagefighting, Strikeforce, and Pancrase.', N'teacher12.jpg', N'Gonden Belt Owner', N'15 years of experience', N'Fighting, Eating, Sleeping', N'Mixed Martial Arts ', N'NateDiaz@gmail.com', N'+15555555055', N'nate.d', 9)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (26, N'Sultan', N'Suleyman', N'Shah', N'Gamina gamlanip olma mahzun, demine demlenib olma magrur, ne gam baki ne dem baki ya hu.', N'teacher7.jpg', N'Sultan Suleyman', N'500 years of experience', N'Figting, Occuping Lands', N'Istanbul Teknik Universitesi', N'Suleyman@gmail.com', N'+9095985887867', N'Sulu.S', 10)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (28, N'Imran', N'Aliyev', N'Boş işlər müdürü', N'Lambadaki değerli olduğu için göze çarpan masanın masanın koyun. Türemiş sıfat göze çarpan çünkü yapacakmış çünkü koşuyorlar karşıdakine koşuyorlar yazın adanaya yapacakmış ve öyle ki. Gül lambadaki çobanın tv karşıdakine. Düşünüyor çobanın duyulmamış yazın sevindi bundan dolayı uzattı sokaklarda batarya kutusu gördüm.', N'teacher4.jpg', N'Bənövşəyi Kəmər', N'18 years of experience', N'Yatmaq, Yemek, Gəzmək', N'Biznesin Bankrot Edilmesi', N'İmranAliyev@azmail.az', N'+9940505000005', N'Imran.ali', 11)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (30, N'Ismayil', N'Hesenov', N'Developer', N'Bir guzguye baxdigimda gorduyume birde goye baxanda gormediyime inaniram!', N'teacher5.jpg', N'Senior', N'5 years of experience', N'Coding, Searching, Drink Coffee', N'Code Academy', N'IsmayilH@gmail.com', N'+99455055055', N'Ismayil.h', 12)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (31, N'Orkhan', N'Amirli', N'Developer', N'Ya hər şeyin dəyəri itib, ya da mənimçün hər şey bu qədər ciddi!', N'eb2e26fc-f25c-4304-acab-b4d2f8593e71-DDDecemberYYYY-214899863.jpg', N'Master', N'8 years of experience', NULL, N'Marketing', N'amirovorxan@gmail.com', N'+994705888828', N'orkhan_amir', 15)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (33, N'Orkhan', N'Amirli', N'Developer', N'Gamına gamlanıp olma mahzun,
Demine demlenip olma mağrur,
Ne dem baki ne gam baki, ya Hû!', N'1fec9ae2-1f29-43eb-bac5-488448bc284a-DDDecemberYYYY-2086729644678457549_n.jpg', N'Master', N'8 years of experience', NULL, N'Marketing', N'amirovorxan@gmail.com', N'+994705888828', N'orkhan_amir', 19)
INSERT [dbo].[Teachers] ([Id], [Name], [Surname], [Position], [About], [Image], [Degree], [Experience], [Hobbie], [Faculity], [Email], [Phone], [Skype], [TeacherSkillsId]) VALUES (34, N'Eldeniz', N'Alizade', N'Developer', N'kj hkjh kjhkjh kjhkjh lkhl kglhgf gkgh lihgkj g;k gkg ;ogj bkjg kjg. kj;b', NULL, N'Master', N'8 Years of Experience', NULL, N'sds', N'amirovorxan@gmail.com', N'+994705888828', N'orkhan_amir', 20)
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
SET IDENTITY_INSERT [dbo].[TeacherSocials] ON 

INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (1, N'Fcebook', N'Fb', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (2, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (3, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (4, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (5, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (6, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (7, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (8, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (9, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (10, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (11, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (12, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (13, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (14, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (15, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (16, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (17, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (18, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (19, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (20, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (21, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (22, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (23, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (24, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (25, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (26, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (27, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (28, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (29, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (30, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (31, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (32, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (33, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (34, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (35, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (36, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (37, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (38, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (39, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (40, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (41, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (42, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (43, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (44, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (45, N'Fcebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (46, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (47, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (48, N'Twitter', N'#', N'zmdi zmdi-twitter')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (49, N'Fcebook', N'EldenizFb', N'zmdi zmdi-facebook')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (50, N'Pinteres', N'Eldenizpt', N'zmdi zmdi-pinterest')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (51, N'Vimeo', N'eldenizVM', N'zmdi zmdi-vimeo')
INSERT [dbo].[TeacherSocials] ([Id], [Name], [Link], [Icon]) VALUES (52, N'Twitter', N'eLDENIZTW', N'zmdi zmdi-twitter')
SET IDENTITY_INSERT [dbo].[TeacherSocials] OFF
GO
SET IDENTITY_INSERT [dbo].[TeacherSocialToTeachers] ON 

INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (1, 1, 1)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (2, 1, 2)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (3, 1, 3)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (4, 1, 4)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (6, 3, 5)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (7, 3, 6)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (8, 3, 7)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (9, 3, 8)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (10, 7, 9)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (11, 7, 10)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (12, 7, 11)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (13, 7, 12)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (14, 8, 13)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (15, 8, 14)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (16, 8, 15)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (17, 8, 16)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (18, 9, 17)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (19, 9, 18)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (20, 9, 19)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (21, 9, 20)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (22, 13, 21)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (23, 13, 22)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (24, 13, 23)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (25, 13, 24)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (26, 20, 25)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (27, 20, 26)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (28, 20, 27)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (29, 20, 28)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (30, 22, 29)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (31, 22, 30)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (32, 22, 31)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (33, 22, 32)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (34, 24, 33)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (35, 24, 34)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (36, 24, 35)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (37, 24, 36)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (38, 26, 37)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (39, 26, 38)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (40, 26, 39)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (41, 26, 40)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (42, 28, 41)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (43, 28, 42)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (44, 28, 43)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (45, 28, 44)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (46, 30, 45)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (47, 30, 46)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (48, 30, 47)
INSERT [dbo].[TeacherSocialToTeachers] ([Id], [TeacherId], [TeacherSocialId]) VALUES (49, 30, 48)
SET IDENTITY_INSERT [dbo].[TeacherSocialToTeachers] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211210160430_FirstInit', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211210225349_Added_HeaderLogo2', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211210233651_Added_FooterText', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211211002354_Removed_BgImageFromChooseEduHome', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211211002655_Updated_PropertyNameOnChooseEduHomes', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211211215409_Made_BannerTitleLenghtLonger', N'5.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211212182727_Updated_NoticeBoardLeft', N'5.0.12')
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([Id], [Title], [Text], [Image]) VALUES (1, N'This Is FikirTepe', N'Çakıl domates gitti de bilgisayarı otobüs gül salladı ekşili çorba hesap makinesi. Filmini mi balıkhaneye bundan dolayı sokaklarda karşıdakine ona doğru. Çobanın beğendim mutlu oldular lakin gitti telefonu türemiş sıfat çakıl dergi orta camisi biber ama umut. Cesurca yaptı göze çarpan kapının kulu anlamsız masaya doğru telefonu bundan dolayı duyulmamışnesi orta ', N'about.png')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (1, N'ABOUT US', N'About')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (4, N'Our Teachers', N'Our Teachers')
INSERT [dbo].[Banners] ([Id], [Title], [Page]) VALUES (5, N'Teacher / Details', N'Teacher')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[ChooseEduHomes] ON 

INSERT [dbo].[ChooseEduHomes] ([Id], [Title], [Text], [Background]) VALUES (1, N'WHY YOU CHOOSE EDUHOME ?
', N'Gazete gülüyorum uzattı tv de düşünüyor ve ışık dağılımı lambadaki. Patlıcan değerli olduğu için ötekinden dolayı kapının kulu ötekinden dolayı. Ve değerli olduğu için ekşili çorba şafak sandalye. Gülüyorum karşıdakine salladı adresini ekşili çorba kalemi telefonu sarmal açılmadan dolayı beğendim eve doğru. Masanın beğendim otobüs koyun orta camisi adanaya cesurca yaptı kalemi ama koyun anlamsız balıkhaneye hesap makinesi hesap makinesi. Nedirnedemek Türkçe Lorem İpsum.', N'choose-bd.jpg')
SET IDENTITY_INSERT [dbo].[ChooseEduHomes] OFF
GO
SET IDENTITY_INSERT [dbo].[NoticeBoardLefts] ON 

INSERT [dbo].[NoticeBoardLefts] ([Id], [Text], [CreatedDate]) VALUES (1, N'Balıkhaneye bahar gül umut domates ama umut de öyle ki mıknatıslı okuma sayfası mutlu oldular un değirmeni mutlu oldular.', CAST(N'2017-06-05T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardLefts] ([Id], [Text], [CreatedDate]) VALUES (4, N'Uzattı ekşili çorba cezbelendi gül eve doğru değerli olduğu için gülüyorum yapacakmış domates masanın.', CAST(N'2017-09-15T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardLefts] ([Id], [Text], [CreatedDate]) VALUES (5, N'Teldeki bilgiyasayarı cesurca yaptı eve doğru çünkü çakıl sandalye teldeki ve anlamsız eve doğru domates un değirmeni koyun.', CAST(N'2017-06-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardLefts] ([Id], [Text], [CreatedDate]) VALUES (6, N'Çakıl beğendim batarya kutusu koşuyorlar telefonu bundan dolayı mıknatıslı okuma sayfası cezbelendi eve doğru mutlu oldular.', CAST(N'2017-11-19T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardLefts] ([Id], [Text], [CreatedDate]) VALUES (7, N'Batarya kutusu gördüm salladı bahar telefonu cezbelendi tv lambadaki cezbelendi cezbelendi dışarı çıktılar şafak mıknatıslı okuma sayfası batarya kutusu.', CAST(N'2019-06-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardLefts] ([Id], [Text], [CreatedDate]) VALUES (8, N'Teldeki bilgiyasayarı cesurca yaptı eve doğru çünkü çakıl sandalye teldeki ve anlamsız eve doğru domates un değirmeni koyun.', CAST(N'2019-03-30T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardLefts] ([Id], [Text], [CreatedDate]) VALUES (11, N'Uzattı ekşili çorba cezbelendi gül eve doğru değerli olduğu için gülüyorum yapacakmış domates masanın.', CAST(N'2017-09-15T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardLefts] ([Id], [Text], [CreatedDate]) VALUES (17, N'Adresini cezbelendi dergi batarya kutusu koşuyorlar. De koyun koyun ekşili çorba eve doğru ekşili çorba tv beğendim uzattı cezbelendi', CAST(N'2021-12-12T22:30:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardLefts] ([Id], [Text], [CreatedDate]) VALUES (18, N'Nulla neque felis, posuere vel erat vel, posuere varius nulla. Suspendisse facilisis metus in augue fermentum congue. Etiam dapibus mi vitae velit rutrum, in pulvinar arcu elementum.', CAST(N'2021-12-13T12:30:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[NoticeBoardLefts] OFF
GO
SET IDENTITY_INSERT [dbo].[NoticeBoardRights] ON 

INSERT [dbo].[NoticeBoardRights] ([Id], [Title], [Text], [CreatedDate]) VALUES (1, N'PROFESSIONAL TEACHER', N'Çobanın türemiş sıfat ekşili çorba sokaklarda göze çarpan dışarı çıktılar karşıdakine gazete sandalye. Beğendim mutlu oldular sıradanlıktan bahar adresini ötekinden dolayı sandalye masanın mutlu oldular göze çarpan umut yazın sinema.', CAST(N'2021-12-11T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardRights] ([Id], [Title], [Text], [CreatedDate]) VALUES (2, N'NULLONLINE COURSES', N'Layıkıyla domates şafak çakıl değerli olduğu için bilgisayarı beğendim kapının kulu gazete bahar. Uzattı de bundan dolayı kapının kulu gül türemiş sıfat gazete kalemi çobanın duyulmamış. Un değirmeni öyle ki un değirmeni çünkü şafak domates filmini mi biber biber koştum.', CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[NoticeBoardRights] ([Id], [Title], [Text], [CreatedDate]) VALUES (3, N'EASY TO ADDMISSION', N'Ona doğru sarmal açılmadan dolayı bahar karşıdakine de lakin koyun batarya kutusu lakin bilgisayarı. Düşünüyor ekşili çorba yapacakmış masaya doğru de duyulmamış. Mutlu oldular eve doğru uzattı sıradanlıktan lakin masaya doğru düşünüyor adanaya sevindi kalemi.', CAST(N'2021-12-12T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[NoticeBoardRights] OFF
GO
SET IDENTITY_INSERT [dbo].[PositionTestimonials] ON 

INSERT [dbo].[PositionTestimonials] ([Id], [Name], [Text], [Position], [Image]) VALUES (1, N'Nate Diaz', N'Nathan Donald Diaz is an American professional mixed martial artist, currently signed with the Ultimate Fighting Championship. Before signing with the UFC, Diaz competed in World Extreme Cagefighting, Strikeforce, and Pancrase.', N' Mixed Martial Arts (MMA)', N'testimonial.jpg')
SET IDENTITY_INSERT [dbo].[PositionTestimonials] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [HeaderLogo], [FooterLogo], [Address], [Phone1], [Phone2], [Email1], [Email2], [CopyrightTitle], [CopyrightLink], [HeaderLogo2], [FooterText]) VALUES (1, N'logo.png', N'footer-loggo.png', N'Baku City, Khazar district, Bina settlement, Natavan street', N'+994 070 588 88 28', N'+994 051 571 18 90', N'amirovorxan@gmail.com', N'amirov_orxan@hotmail.com', N'BinaTech', N'#', N'logo2.png', N'Aya əppəy çırtımına yiyə dursan? öy mamoğlu mığı əppəy öy pırpız baş öy, səni suruxvat murtta yağlaşoy a bimürvət yağlaşoy dınqı pırpız baş döyğa, nağarersan?')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[SiteSocials] ON 

INSERT [dbo].[SiteSocials] ([Id], [Name], [Link], [Icon]) VALUES (1, N'Facebook', N'#', N'zmdi zmdi-facebook')
INSERT [dbo].[SiteSocials] ([Id], [Name], [Link], [Icon]) VALUES (2, N'Pinteres', N'#', N'zmdi zmdi-pinterest')
INSERT [dbo].[SiteSocials] ([Id], [Name], [Link], [Icon]) VALUES (3, N'Vimeo', N'#', N'zmdi zmdi-vimeo')
INSERT [dbo].[SiteSocials] ([Id], [Name], [Link], [Icon]) VALUES (4, N'Twitter', N'#', N'zmdi zmdi-twitter')
SET IDENTITY_INSERT [dbo].[SiteSocials] OFF
GO
SET IDENTITY_INSERT [dbo].[VideoTours] ON 

INSERT [dbo].[VideoTours] ([Id], [VideoLink], [VideoImage]) VALUES (1, N'https://www.youtube.com/watch?v=_N4bMTmtCc4', N'Moto.jpg')
SET IDENTITY_INSERT [dbo].[VideoTours] OFF
GO
