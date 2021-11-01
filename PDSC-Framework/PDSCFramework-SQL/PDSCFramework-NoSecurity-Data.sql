USE [PDSCFramework]
GO
SET IDENTITY_INSERT [Lookup].[PersonType] ON 
GO
INSERT [Lookup].[PersonType] ([PersonTypeId], [TypeDescription], [IsActive], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (1, N'Administrator', 1, N'dbo', CAST(N'2021-09-16T15:25:02.210' AS DateTime), N'dbo', CAST(N'2021-09-16T15:25:02.210' AS DateTime))
GO
INSERT [Lookup].[PersonType] ([PersonTypeId], [TypeDescription], [IsActive], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (2, N'Mentor', 1, N'dbo', CAST(N'2021-09-16T15:25:06.830' AS DateTime), N'dbo', CAST(N'2021-09-16T15:25:06.830' AS DateTime))
GO
SET IDENTITY_INSERT [Lookup].[PersonType] OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON 
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (1, NULL, N'Paul', N'Sheriff', N'psheriff@pdsa.com', NULL, N'(714) 745-1224', N'217 Williamsburg Circle', NULL, NULL, N'Brentwood', NULL, N'TN', NULL, N'37027', N'USA', NULL, NULL, 1, 0, 1, N'psheriff@pdsa.com', CAST(N'2021-09-18T13:21:35.540' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-18T13:21:35.540' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (3, NULL, N'Paul                ', N'Shaefer', N'Pauls@netinc.com', NULL, N'(714) 399-9212', N'2 A Street', NULL, NULL, N'Tustin', NULL, N'CA', NULL, N'92780      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (4, NULL, N'Michael             ', N'Kawoski', N'Michaelk@netinc.com', NULL, N'(714) 939-0002', N'19239 West Hills Road', NULL, NULL, N'Irvine', NULL, N'CA', NULL, N'92688      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (5, NULL, N'Sara                ', N'Winchell', N'Saraw@netinc.com', NULL, N'(714) 738-9382', N'993 W. Country Lane', NULL, NULL, N'Chino Hills', NULL, N'CA', NULL, N'92705      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (6, NULL, N'John                ', N'Kroon', N'Johnk@netinc.com', NULL, N'(949) 667-7347', N'55 Wave Street', NULL, NULL, N'Costa Mesa', NULL, N'CA', NULL, N'92780      ', N'USA', NULL, NULL, 1, 1, 1, N'info@yoursite.com', CAST(N'2021-09-20T21:05:27.893' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-20T21:05:27.893' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (7, NULL, N'Tim                 ', N'Nicker', N'Timn@netinc.com', NULL, N'(714) 767-3747', N'23 Old Town Court', NULL, NULL, N'Fullerton', NULL, N'CA', NULL, N'92675      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (8, NULL, N'Russ                ', N'Martlog', N'Russm@netinc.com', NULL, N'(714) 334-5643', N'9984 Hill Drive', NULL, NULL, N'Anaheim', NULL, N'CA', NULL, N'92690      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (9, NULL, N'John                ', N'Boron', N'Johnb@netinc.com', NULL, N'(714) 939-9993', N'454 Treetop Lane', NULL, NULL, N'Irvine', NULL, N'CA', NULL, N'92692      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (10, NULL, N'James               ', N'Birdy', N'Jamesb@netinc.com', NULL, N'(310) 939-9932', N'345 Haney Avenue', NULL, NULL, N'Tustin', NULL, N'CA', NULL, N'92831      ', N'USA', NULL, NULL, 1, 1, 1, N'info@yoursite.com', CAST(N'2021-09-20T21:05:01.167' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-20T21:05:01.180' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (11, NULL, N'Trey                ', N'Chen', N'Treyc@netinc.com', NULL, N'(562) 991-0009', N'99489 Simple Street', NULL, NULL, N'Aliso Viejo', NULL, N'CA', NULL, N'92833      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (12, NULL, N'Jim                 ', N'Jones', N'Jimj@netinc.com', NULL, N'(714) 223-0029', N'773 Sea Drive', NULL, NULL, N'Costa Mesa', NULL, N'CA', NULL, N'92836      ', N'USA', NULL, NULL, 1, 1, 1, N'info@yoursite.com', CAST(N'2021-09-20T20:42:03.387' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-20T20:42:03.387' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (13, NULL, N'John                ', N'Pittsburgh', N'Johnp@netinc.com', NULL, N'(714) 554-0493', N'1298 1st Street', NULL, NULL, N'Santa Ana', NULL, N'CA', NULL, N'90239      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (14, NULL, N'Jeanne              ', N'Russell', N'Jeanner@netinc.com', NULL, N'(949) 339-0000', N'2993 5th Street', NULL, NULL, N'Santa Ana', NULL, N'CA', NULL, N'90241      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (15, NULL, N'David               ', N'Lafeet', N'Davidl@netinc.com', NULL, N'(949) 399-9232', N'38293 Alma Way', NULL, NULL, N'Rancho Santa Margarita', NULL, N'CA', NULL, N'92604      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (16, NULL, N'Khanh               ', N'Voon', N'Khanhv@netinc.com', NULL, N'(714) 342-3232', N'9847 35th Street', NULL, NULL, N'Lakewood', NULL, N'CA', NULL, N'92618      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (17, NULL, N'Jim                 ', N'Russell', N'Jimr@netinc.com', NULL, N'(714) 123-2343', N'2345 Finch Street', NULL, NULL, N'Long Beach', NULL, N'CA', NULL, N'92619      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (18, NULL, N'David               ', N'Tarkas', N'Davidt@netinc.com', NULL, N'(714) 893-7361', N'883 W. Highland Ave.', NULL, NULL, N'Westminster', NULL, N'CA', NULL, N'92626      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (19, NULL, N'Craig               ', N'Showman', N'Craigs@netinc.com', NULL, N'(949) 938-1234', N'45 Teak Road', NULL, NULL, N'Fullerton', NULL, N'CA', NULL, N'92626      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (20, NULL, N'Brooks              ', N'Anderson', N'Brooksa@netinc.com', NULL, N'(949) 777-3929', N'34 Trussel Ave.', NULL, NULL, N'Yorba Linda', NULL, N'CA', NULL, N'92628      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (21, NULL, N'Mark                ', N'Parks', N'Markp@netinc.com', NULL, N'(425) 377-7333', N'98-4 Court Street', NULL, NULL, N'Redmond', NULL, N'WA', NULL, N'98052      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (22, NULL, N'Keith               ', N'Nashville', N'Keithn@netinc.com', NULL, N'(702) 773-0093', N'322 Casino View Drive', NULL, NULL, N'Las Vegas', NULL, N'NV', NULL, N'89030      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
INSERT [dbo].[Person] ([PersonId], [AspNetUsersId], [FirstName], [LastName], [EmailAddress], [HomePhone], [CellPhone], [Street1], [Street2], [Street3], [City], [Village], [StateCode], [ProvinceCode], [PostalCode], [CountryCode], [SiteTermsId], [DateTermsAccepted], [IsActive], [OkToSendEmails], [PersonTypeId], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (23, NULL, N'Jane                ', N'Joan', N'Janej@netinc.com', NULL, N'(408) 939-9993', N'8873 Cactus Lane', NULL, NULL, N'Phoenix', NULL, N'AZ', NULL, N'85001      ', N'USA', NULL, NULL, 1, 1, 1, N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime), N'dbo', CAST(N'2016-09-30T15:02:07.490' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([CustomerId], [FirstName], [LastName], [EmailAddress], [Phone], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (1, N'John', N'Smith', N'j.smith@jsmith.com', N'(615) 123-4567', N'info@yoursite.com', CAST(N'2021-11-01T14:20:28.983' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-11-01T14:20:28.983' AS DateTime))
GO
INSERT [dbo].[Customer] ([CustomerId], [FirstName], [LastName], [EmailAddress], [Phone], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (2, N'Sally ', N'Jones', N'sallyj@jonesinc.com', N'(714) 339-9382', N'dbo', CAST(N'2021-11-01T14:18:30.740' AS DateTime), N'dbo', CAST(N'2021-11-01T14:18:30.740' AS DateTime))
GO
INSERT [dbo].[Customer] ([CustomerId], [FirstName], [LastName], [EmailAddress], [Phone], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (3, N'Joe', N'Schmoe', N'js@acme.com', N'(800) 988-1267', N'dbo', CAST(N'2021-11-01T14:18:30.740' AS DateTime), N'dbo', CAST(N'2021-11-01T14:18:30.740' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'AB', N'Alberta', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'BC', N'British Columbia', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MB', N'Manitoba', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NB', N'Brunswick', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NF', N'Newfoundland', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NS', N'Nova Scotia', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NT', N'Northwest Territories', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ON', N'Ontario', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'PE', N'Prince Edward Island', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'QC', N'Quebec', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'SK', N'Saskatchewan', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
INSERT [Lookup].[CanadianProvince] ([ProvinceCode], [ProvinceName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'YT', N'Yukon Territory', N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime), N'dbo', CAST(N'2020-09-17T14:45:50.060' AS DateTime))
GO
SET IDENTITY_INSERT [Lookup].[ContactUs] ON 
GO
INSERT [Lookup].[ContactUs] ([ContactUsId], [FirstName], [LastName], [EmailAddress], [Phone], [ContactText], [IPAddress], [RespondedByName], [RespondedDate], [IsActive], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (1, N'Paul', N'Sheriff', N'psheriff@pdsa.com', NULL, N'This is a test', NULL, NULL, NULL, 0, N'info@yoursite.com', CAST(N'2021-09-17T14:17:36.443' AS DateTime), N'info@yoursite.com', CAST(N'2021-09-17T14:17:36.443' AS DateTime))
GO
INSERT [Lookup].[ContactUs] ([ContactUsId], [FirstName], [LastName], [EmailAddress], [Phone], [ContactText], [IPAddress], [RespondedByName], [RespondedDate], [IsActive], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (2, N'Paul', N'Sheriff', N'psheriff@pdsa.com', NULL, N'Some contact information', NULL, NULL, NULL, 0, N'dba@pdsa.com', CAST(N'2021-09-17T14:31:09.687' AS DateTime), N'dba@pdsa.com', CAST(N'2021-09-17T14:31:09.687' AS DateTime))
GO
SET IDENTITY_INSERT [Lookup].[ContactUs] OFF
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ARG', N'Argentina', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'AUS', N'Australia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'AUT', N'Austria', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'BEL', N'Belgium', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'BGD', N'Bangladesh', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'BLR', N'Belarus', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'BRA', N'Brazil', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'CAN', N'Canada', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'CHE', N'Switzerland', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'CHL', N'Chile', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'CHN', N'China', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'CZE', N'Czech Republic', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'DEU', N'Germany', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'DNK', N'Denmark', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ESP', N'Spain', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'EST', N'Estonia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'FIN', N'Finland', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'FRA', N'France', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'GBR', N'United Kingdom', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'GRC', N'Greece', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'HKG', N'Hong Kong', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'HRV', N'Croatia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'HUN', N'Hungary', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'IDN', N'Indonesia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'IND', N'India', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'IRL', N'Ireland', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'IRN', N'Iran', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'IRQ', N'Iraq', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ISL', N'Iceland', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ISR', N'Israel', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ITA', N'Italy', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'JPN', N'Japan', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'LKA', N'Sri Lanka', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'LVA', N'Latvia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MAC', N'Macau', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MEX', N'Mexico', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MYS', N'Malaysia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NIC', N'Nicaragua', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NLD', N'Netherlands', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NOR', N'Norway', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NZL', N'New Zealand', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'OMN', N'Oman', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'PAK', N'Pakistan', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'PER', N'Peru', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'PHL', N'Philippines', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'POL', N'Poland', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'PRT', N'Portugal', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'QAT', N'Qatar', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ROU', N'Romania', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'RUS', N'Russia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'SAU', N'Saudi Arabia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'SGP', N'Singapore', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'SVK', N'Slovakia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'SVN', N'Slovenia', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'SWE', N'Sweden', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'THA', N'Thailand', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'TUR', N'Turkey', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'TWN', N'Taiwan', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'UKR', N'Ukraine', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'USA', N'United States', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
INSERT [Lookup].[Country] ([CountryCode], [CountryName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'VNM', N'Vietnam', N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:03.987' AS DateTime))
GO
SET IDENTITY_INSERT [Lookup].[EmailTemplate] ON 
GO
INSERT [Lookup].[EmailTemplate] ([EmailTemplateId], [EmailTemplateName], [EmailSubject], [EmailTemplateText], [IsBodyHtml], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (2, N'Confirm Email', N'Confirm Your Email for the EIC Portal', N'<!DOCTYPE html>
<html>

<head>
  <meta charset="UTF-8">
  <title>{AppName} Confirm Email</title>
</head>

<body>
  <div class="container">
    <div class="row">
      <h1>Confirm Your Email for the {AppName}</h1>
    </div>

    <p>Hello,</p>

    <p>In order to be granted access to the {AppName}, you must confirm this is a valid email by <a
        href="{URL}">clicking here</a>.</p>
    <p>If the link does not work, copy and paste the following link into your browser and press the Enter key.</p>
    <p>{URL}</p>
    <br />
    <p>After you confirm your email, you may then enter the rest of your account information such as your name, address, phone, email, etc.</p>
    <br />
    <p>Welcome to the {AppName}!</p>
    <p>Sincerely,</p>
    <p>The {AppName} Team</p>
  </div>
  <hr>
  <div class="container">
    <p>This email was sent from the {AppName} website at your request.</p>
    <address>
      EIC<br />
      104 Claude Yates Drive<br />
      Franklin, TN 37064<br />
      (615) 472-4000
    </address>
    <div>
      <span>Information: <a href="mailto:{InformationEmail}">{InformationEmail}</a></span><br />
      <span>Sales: <a href="mailto:{SalesEmail}">{SalesEmail}</a></span><br />
      <span>Support: <a href="mailto:{SupportEmail}">{SupportEmail}</a></span>
    </div>
  </div>
</body>

</html>', 1, N'info@yoursite.com', CAST(N'2021-09-16T15:20:19.213' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-16T15:20:19.213' AS DateTime))
GO
INSERT [Lookup].[EmailTemplate] ([EmailTemplateId], [EmailTemplateName], [EmailSubject], [EmailTemplateText], [IsBodyHtml], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (3, N'Welcome Email', N'Welcome to the EIC Community!', N'<!DOCTYPE html>
<html>

<head>
  <meta charset="UTF-8">
  <title>{AppName} Welcome</title>
</head>

<body>
  <div class="container">
    <div class="row">
      <h1>Welcome to the EIC Community!</h1>
    </div>
    <p>
      Dear {FirstName} {LastName},
    </p>
    <p>
      Welcome to the <strong>{AppName}</strong> website. Nice to have you on board!
    </p>
    <p>
      On this site you can enter information about yourself (if you are mentor or teacher) so that students can identify with you and hopefully seek our your services.
    </p>
    <p>
      Best Regards,
    </p>
    <address>
      The <strong>{AppName}</strong> Team<br />
      <a href="mailto:{InformationEmail}">{InformationEmail}</a> 
    </address>
    <br />
  </div>
  <hr>
  <div class="container">
    <p>This email was sent from the {AppName} website at your request.</p>
    <address>
      EIC<br />
      104 Claude Yates Drive<br />
      Franklin, TN 37064<br />
      (615) 472-4000
    </address>
    <div>
      <span>Information: <a href="mailto:{InformationEmail}">{InformationEmail}</a></span><br />
      <span>Sales: <a href="mailto:{SalesEmail}">{SalesEmail}</a></span><br />
      <span>Support: <a href="mailto:{SupportEmail}">{SupportEmail}</a></span>
    </div>
  </div>
</body>

</html>', 1, N'info@yoursite.com', CAST(N'2021-09-16T15:20:08.457' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-16T15:20:08.457' AS DateTime))
GO
SET IDENTITY_INSERT [Lookup].[EmailTemplate] OFF
GO
SET IDENTITY_INSERT [Lookup].[FAQ] ON 
GO
INSERT [Lookup].[FAQ] ([FAQId], [FAQQuestion], [FAQAnswer], [IsActive], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (2, N'Where can I get this framework?', N'Just ask Paul for it.', 1, N'info@yoursite.com', CAST(N'2021-09-18T09:50:01.070' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-18T09:50:01.087' AS DateTime))
GO
INSERT [Lookup].[FAQ] ([FAQId], [FAQQuestion], [FAQAnswer], [IsActive], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (3, N'How does this site work?', N'Very well, thank you.', 1, N'info@yoursite.com', CAST(N'2021-09-17T15:26:32.263' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-17T15:26:32.273' AS DateTime))
GO
INSERT [Lookup].[FAQ] ([FAQId], [FAQQuestion], [FAQAnswer], [IsActive], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (4, N'What is the PDSC Framework?', N'A set of classes, views, and controllers.', 1, N'info@yoursite.com', CAST(N'2021-10-11T13:06:24.213' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-10-11T13:06:24.227' AS DateTime))
GO
SET IDENTITY_INSERT [Lookup].[FAQ] OFF
GO
SET IDENTITY_INSERT [Lookup].[LogInfo] ON 
GO
INSERT [Lookup].[LogInfo] ([Id], [Message], [MessageTemplate], [Level], [TimeStamp], [Exception], [Properties]) VALUES (62, N'Failed executing DbCommand ("17"ms) [Parameters=["@__p_0=''?'' (DbType = Int32), @__p_1=''?'' (DbType = Int32)"], CommandType=''Text'', CommandTimeout=''30'']"
""SELECT [p].[PersonId], [p].[AspNetUsersId], [p].[CellPhone], [p].[City], [p].[CountryCode], [p].[DateTermsAccepted], [p].[EmailAddress], [p].[FirstName], [p].[HomePhone], [p].[InsertDate], [p].[InsertName], [p].[IsActive], [p].[LastName], [p].[OkToSendEmails], [p].[PersonTypeId], [p].[PostalCode], [p].[ProvinceCode], [p].[SiteTermsId], [p].[StateCode], [p].[Street1], [p].[Street2], [p].[Street3], [p].[UpdateDate], [p].[UpdateName], [p].[Village]
FROM [dbo].[Person] AS [p]
ORDER BY [p].[LastName]
OFFSET @__p_0 ROWS FETCH NEXT @__p_1 ROWS ONLY"', N'Failed executing DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType=''{commandType}'', CommandTimeout=''{commandTimeout}'']{newLine}{commandText}', N'Error', CAST(N'2021-10-15T12:43:05.813' AS DateTime), NULL, N'<properties><property key=''elapsed''>17</property><property key=''parameters''>@__p_0=''?'' (DbType = Int32), @__p_1=''?'' (DbType = Int32)</property><property key=''commandType''>Text</property><property key=''commandTimeout''>30</property><property key=''newLine''>
</property><property key=''commandText''>SELECT [p].[PersonId], [p].[AspNetUsersId], [p].[CellPhone], [p].[City], [p].[CountryCode], [p].[DateTermsAccepted], [p].[EmailAddress], [p].[FirstName], [p].[HomePhone], [p].[InsertDate], [p].[InsertName], [p].[IsActive], [p].[LastName], [p].[OkToSendEmails], [p].[PersonTypeId], [p].[PostalCode], [p].[ProvinceCode], [p].[SiteTermsId], [p].[StateCode], [p].[Street1], [p].[Street2], [p].[Street3], [p].[UpdateDate], [p].[UpdateName], [p].[Village]
FROM [dbo].[Person] AS [p]
ORDER BY [p].[LastName]
OFFSET @__p_0 ROWS FETCH NEXT @__p_1 ROWS ONLY</property><property key=''EventId''><structure type=''''><property key=''Id''>20102</property><property key=''Name''>Microsoft.EntityFrameworkCore.Database.Command.CommandError</property></structure></property><property key=''SourceContext''>Microsoft.EntityFrameworkCore.Database.Command</property><property key=''ActionId''>8a95997e-f6bc-48f1-bf6f-e538d403835a</property><property key=''ActionName''>PDSCFramework.Controllers.PersonController.PersonIndex (PDSCFramework)</property><property key=''RequestId''>80000033-0008-fe00-b63f-84710c7967bb</property><property key=''RequestPath''>/Person/PersonIndex</property></properties>')
GO
INSERT [Lookup].[LogInfo] ([Id], [Message], [MessageTemplate], [Level], [TimeStamp], [Exception], [Properties]) VALUES (63, N'An exception occurred while iterating over the results of a query for context type ''"PDSCFramework.DataLayer.ApplicationDbContext"''."
""Microsoft.Data.SqlClient.SqlException (0x80131904): Invalid column name ''AspNetUsersId''.
   at Microsoft.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose)
   at Microsoft.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean& dataReady)
   at Microsoft.Data.SqlClient.SqlDataReader.TryConsumeMetaData()
   at Microsoft.Data.SqlClient.SqlDataReader.get_MetaData()
   at Microsoft.Data.SqlClient.SqlCommand.FinishExecuteReader(SqlDataReader ds, RunBehavior runBehavior, String resetOptionsString, Boolean isInternal, Boolean forDescribeParameterEncryption, Boolean shouldCacheForAlwaysEncrypted)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReaderTds(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, Boolean isAsync, Int32 timeout, Task& task, Boolean asyncWrite, Boolean inRetry, SqlDataReader ds, Boolean describeParameterEncryptionRequest)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, TaskCompletionSource`1 completion, Int32 timeout, Task& task, Boolean& usedCache, Boolean asyncWrite, Boolean inRetry, String method)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, String method)
   at Microsoft.Data.SqlClient.SqlCommand.ExecuteReader(CommandBehavior behavior)
   at Microsoft.Data.SqlClient.SqlCommand.ExecuteDbDataReader(CommandBehavior behavior)
   at System.Data.Common.DbCommand.ExecuteReader()
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReader(RelationalCommandParameterObject parameterObject)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.Enumerator.InitializeReader(DbContext _, Boolean result)
   at Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal.SqlServerExecutionStrategy.Execute[TState,TResult](TState state, Func`3 operation, Func`3 verifySucceeded)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.Enumerator.MoveNext()
ClientConnectionId:3f30be7f-7fcf-487e-a49e-4f556ace2335
Error Number:207,State:1,Class:16"', N'An exception occurred while iterating over the results of a query for context type ''{contextType}''.{newline}{error}', N'Error', CAST(N'2021-10-15T12:43:05.870' AS DateTime), N'Microsoft.Data.SqlClient.SqlException (0x80131904): Invalid column name ''AspNetUsersId''.
   at Microsoft.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose)
   at Microsoft.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean& dataReady)
   at Microsoft.Data.SqlClient.SqlDataReader.TryConsumeMetaData()
   at Microsoft.Data.SqlClient.SqlDataReader.get_MetaData()
   at Microsoft.Data.SqlClient.SqlCommand.FinishExecuteReader(SqlDataReader ds, RunBehavior runBehavior, String resetOptionsString, Boolean isInternal, Boolean forDescribeParameterEncryption, Boolean shouldCacheForAlwaysEncrypted)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReaderTds(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, Boolean isAsync, Int32 timeout, Task& task, Boolean asyncWrite, Boolean inRetry, SqlDataReader ds, Boolean describeParameterEncryptionRequest)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, TaskCompletionSource`1 completion, Int32 timeout, Task& task, Boolean& usedCache, Boolean asyncWrite, Boolean inRetry, String method)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, String method)
   at Microsoft.Data.SqlClient.SqlCommand.ExecuteReader(CommandBehavior behavior)
   at Microsoft.Data.SqlClient.SqlCommand.ExecuteDbDataReader(CommandBehavior behavior)
   at System.Data.Common.DbCommand.ExecuteReader()
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReader(RelationalCommandParameterObject parameterObject)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.Enumerator.InitializeReader(DbContext _, Boolean result)
   at Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal.SqlServerExecutionStrategy.Execute[TState,TResult](TState state, Func`3 operation, Func`3 verifySucceeded)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.Enumerator.MoveNext()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at PDSCFramework.ViewModelLayer.PersonViewModel.Search() in D:\PDSConsulting\PDSA-Products\PDSCFramework\PDSCFramework.ViewModelLayer\PersonViewModel.cs:line 90
   at PDSCFramework.Controllers.PersonController.PersonIndex() in D:\PDSConsulting\PDSA-Products\PDSCFramework\PDSCFramework\Controllers\PersonController.cs:line 45
   at lambda_method51(Closure , Object , Object[] )
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.SyncActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeActionMethodAsync()
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeNextActionFilterAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeInnerFilterAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.InvokeFilterPipelineAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at PDSCFramework.GlobalErrorHandlingMiddleware.Invoke(HttpContext context, ILogger`1 logger) in D:\PDSConsulting\PDSA-Products\PDSCFramework\PDSCFramework\HelperClasses\GlobalErrorHandlingMiddleware.cs:line 23
ClientConnectionId:3f30be7f-7fcf-487e-a49e-4f556ace2335
Error Number:207,State:1,Class:16', N'<properties><property key=''contextType''>PDSCFramework.DataLayer.ApplicationDbContext</property><property key=''newline''>
</property><property key=''error''>Microsoft.Data.SqlClient.SqlException (0x80131904): Invalid column name ''AspNetUsersId''.
   at Microsoft.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose)
   at Microsoft.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean&amp; dataReady)
   at Microsoft.Data.SqlClient.SqlDataReader.TryConsumeMetaData()
   at Microsoft.Data.SqlClient.SqlDataReader.get_MetaData()
   at Microsoft.Data.SqlClient.SqlCommand.FinishExecuteReader(SqlDataReader ds, RunBehavior runBehavior, String resetOptionsString, Boolean isInternal, Boolean forDescribeParameterEncryption, Boolean shouldCacheForAlwaysEncrypted)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReaderTds(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, Boolean isAsync, Int32 timeout, Task&amp; task, Boolean asyncWrite, Boolean inRetry, SqlDataReader ds, Boolean describeParameterEncryptionRequest)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, TaskCompletionSource`1 completion, Int32 timeout, Task&amp; task, Boolean&amp; usedCache, Boolean asyncWrite, Boolean inRetry, String method)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, String method)
   at Microsoft.Data.SqlClient.SqlCommand.ExecuteReader(CommandBehavior behavior)
   at Microsoft.Data.SqlClient.SqlCommand.ExecuteDbDataReader(CommandBehavior behavior)
   at System.Data.Common.DbCommand.ExecuteReader()
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReader(RelationalCommandParameterObject parameterObject)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.Enumerator.InitializeReader(DbContext _, Boolean result)
   at Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal.SqlServerExecutionStrategy.Execute[TState,TResult](TState state, Func`3 operation, Func`3 verifySucceeded)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.Enumerator.MoveNext()
ClientConnectionId:3f30be7f-7fcf-487e-a49e-4f556ace2335
Error Number:207,State:1,Class:16</property><property key=''EventId''><structure type=''''><property key=''Id''>10100</property><property key=''Name''>Microsoft.EntityFrameworkCore.Query.QueryIterationFailed</property></structure></property><property key=''SourceContext''>Microsoft.EntityFrameworkCore.Query</property><property key=''ActionId''>8a95997e-f6bc-48f1-bf6f-e538d403835a</property><property key=''ActionName''>PDSCFramework.Controllers.PersonController.PersonIndex (PDSCFramework)</property><property key=''RequestId''>80000033-0008-fe00-b63f-84710c7967bb</property><property key=''RequestPath''>/Person/PersonIndex</property></properties>')
GO
INSERT [Lookup].[LogInfo] ([Id], [Message], [MessageTemplate], [Level], [TimeStamp], [Exception], [Properties]) VALUES (64, N'{"message":"Invalid column name \u0027AspNetUsersId\u0027.","statusCode":500}', N'{"message":"Invalid column name \u0027AspNetUsersId\u0027.","statusCode":500}', N'Error', CAST(N'2021-10-15T12:43:10.820' AS DateTime), N'Microsoft.Data.SqlClient.SqlException (0x80131904): Invalid column name ''AspNetUsersId''.
   at Microsoft.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at Microsoft.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose)
   at Microsoft.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean& dataReady)
   at Microsoft.Data.SqlClient.SqlDataReader.TryConsumeMetaData()
   at Microsoft.Data.SqlClient.SqlDataReader.get_MetaData()
   at Microsoft.Data.SqlClient.SqlCommand.FinishExecuteReader(SqlDataReader ds, RunBehavior runBehavior, String resetOptionsString, Boolean isInternal, Boolean forDescribeParameterEncryption, Boolean shouldCacheForAlwaysEncrypted)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReaderTds(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, Boolean isAsync, Int32 timeout, Task& task, Boolean asyncWrite, Boolean inRetry, SqlDataReader ds, Boolean describeParameterEncryptionRequest)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, TaskCompletionSource`1 completion, Int32 timeout, Task& task, Boolean& usedCache, Boolean asyncWrite, Boolean inRetry, String method)
   at Microsoft.Data.SqlClient.SqlCommand.RunExecuteReader(CommandBehavior cmdBehavior, RunBehavior runBehavior, Boolean returnStream, String method)
   at Microsoft.Data.SqlClient.SqlCommand.ExecuteReader(CommandBehavior behavior)
   at Microsoft.Data.SqlClient.SqlCommand.ExecuteDbDataReader(CommandBehavior behavior)
   at System.Data.Common.DbCommand.ExecuteReader()
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReader(RelationalCommandParameterObject parameterObject)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.Enumerator.InitializeReader(DbContext _, Boolean result)
   at Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal.SqlServerExecutionStrategy.Execute[TState,TResult](TState state, Func`3 operation, Func`3 verifySucceeded)
   at Microsoft.EntityFrameworkCore.Query.Internal.SingleQueryingEnumerable`1.Enumerator.MoveNext()
   at System.Collections.Generic.List`1..ctor(IEnumerable`1 collection)
   at System.Linq.Enumerable.ToList[TSource](IEnumerable`1 source)
   at PDSCFramework.ViewModelLayer.PersonViewModel.Search() in D:\PDSConsulting\PDSA-Products\PDSCFramework\PDSCFramework.ViewModelLayer\PersonViewModel.cs:line 90
   at PDSCFramework.Controllers.PersonController.PersonIndex() in D:\PDSConsulting\PDSA-Products\PDSCFramework\PDSCFramework\Controllers\PersonController.cs:line 45
   at lambda_method51(Closure , Object , Object[] )
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.SyncActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeActionMethodAsync()
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeNextActionFilterAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeInnerFilterAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.InvokeFilterPipelineAsync()
--- End of stack trace from previous location ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at PDSCFramework.GlobalErrorHandlingMiddleware.Invoke(HttpContext context, ILogger`1 logger) in D:\PDSConsulting\PDSA-Products\PDSCFramework\PDSCFramework\HelperClasses\GlobalErrorHandlingMiddleware.cs:line 23
ClientConnectionId:3f30be7f-7fcf-487e-a49e-4f556ace2335
Error Number:207,State:1,Class:16', N'<properties><property key=''SourceContext''>PDSCFramework.GlobalErrorHandlingMiddleware</property><property key=''ActionId''>8a95997e-f6bc-48f1-bf6f-e538d403835a</property><property key=''ActionName''>PDSCFramework.Controllers.PersonController.PersonIndex (PDSCFramework)</property><property key=''RequestId''>80000033-0008-fe00-b63f-84710c7967bb</property><property key=''RequestPath''>/Person/PersonIndex</property></properties>')
GO
SET IDENTITY_INSERT [Lookup].[LogInfo] OFF
GO
SET IDENTITY_INSERT [Lookup].[PrivacyPolicy] ON 
GO
INSERT [Lookup].[PrivacyPolicy] ([PrivacyPolicyId], [PrivacyText], [IsActive], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (1, N'<h2>What Personal Information Does EIC Portal Collect? </h2>
<p>We collect the bare minimum of your personal information in order to provide the service for which you are
  signing up for.</p>
<p>Here are the types of personal information we collect: </p>
<p><strong>Information You Give Us</strong>: We receive and store any information you provide in relation to working with the EIC.</p>
<h2>How We Use Your Personal Information? </h2>
<ul>
  <li>Communicate with you via email and through this site.</li>
  <li>Promote you to the students at WCS.</li>
  <li>Comply with any applicable laws.</li>
</ul>
<h2>What About Cookies and Other Identifiers?</h2>
<p>To enable our systems to recognize your browser or device and to provide and improve this site, we
  use cookies and other identifiers.</p>
<p>The Help feature on most browsers and devices will tell you how to prevent your browser or device from accepting new
  cookies or other identifiers, how to have the browser notify you when you receive a new cookie, or how to block
  cookies altogether. Because cookies and identifiers allow you to take advantage of some essential features of this site, we recommend that you leave them turned on.</p>
<h2>Do We Share Your Personal Information?</h2>
<p>Information about you is never sold to third-parties.
</p>
<p>We release account and other personal information when we believe release is appropriate to comply with the law;
  enforce or apply our Terms of Service and other agreements; or protect the rights, property, or safety of WCS, our users, or others. This includes exchanging information with other companies and organizations for fraud
  protection and credit risk reduction.</p>
<p>Other than as set out above, you will receive notice when personal information about you might be shared with third
  parties, and you will have an opportunity to choose not to share the information.</p>
<h2>How Secure Is Information About Me?</h2>
<p>We design our systems with your security and privacy in mind.</p>
<p>We work to protect the security of your personal information during transmission by using encryption protocols and
  software.</p>
<p> We maintain physical, electronic, and procedural safeguards in connection with the collection, storage, and
  disclosure of personal customer information. Our security procedures mean that we may occasionally request proof of
  identity before we disclose personal information to you.</p>
<p>It is important for you to protect against unauthorized access to your password and to your computers, devices, and
  applications. Be sure to sign off when finished using a shared computer.</p>
<h2> What Information Can I Access? </h2>
<p>You can access your information, including your name, address, and emails in the "<strong>Your
    Account</strong>" section of the website.</p>
<h2>What Choices Do I Have?</h2>
<p> If you have any questions as to how we collect and use your personal information, please contact our Customer
  Service.</p>
<p>As described above, you can choose not to provide certain information, but then you might not be able to take
  advantage of many of the Services of this site.</p>
<h2>Conditions of Use, Notices, and Revisions</h2>
<p>If you choose to use the EIC Portal, your use and any dispute over privacy is subject to this Notice and
  our Conditions of Use, including limitations on damages, resolution of disputes, and application of the law of the
  state of Tennessee. If you have any concern about privacy at EIC Portal, please contact us with a thorough
  description, and we will try to resolve it. Our business changes constantly, and our Privacy Notice will change also.
  You should check our websites frequently to see recent changes. Unless stated otherwise, our current Privacy Notice
  applies to all information that we have about you and your account. We stand behind the promises we make, however, and
  will never materially change our policies and practices to make them less protective of customer information collected
  in the past without the consent of affected customers. </p>
<h2>Automatic Information</h2>
<p> Examples of the information we collect and analyze include: </p>
<ul>
  <li>The internet protocol (IP) address used to connect your computer to the internet.</li>
  <li>Login, e-mail address, and password.</li>
  <li>The location of your device or computer.</li>
  <li>Version and time zone settings</li>
  <li>The full Uniform Resource Locator (URL) clickstream to, through, and from our websites, including date and time;
    content you viewed or searched for; page response times, download errors, length of visits to certain pages, and page
    interaction information (such as scrolling, clicks, and mouse-overs)</li>
  <li>We may also use device identifiers, cookies, and other technologies on devices, applications, and our web pages to
    collect browsing, usage, or other technical information.</li>
</ul>
<h2>Information You Can Access</h2>
<p> Examples of information you can access through EIC Portal include: </p>
<p> Your name, address, email and password; </p>
<p> Your emails used for reporting; </p>
', 1, N'info@yoursite.com', CAST(N'2021-09-16T15:04:04.770' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-16T15:04:04.770' AS DateTime))
GO
SET IDENTITY_INSERT [Lookup].[PrivacyPolicy] OFF
GO
SET IDENTITY_INSERT [Lookup].[SiteTerms] ON 
GO
INSERT [Lookup].[SiteTerms] ([SiteTermsId], [TermsText], [IsActive], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (1, N'<h1>AGREEMENT TO TERMS</h1>
<p>
    These Terms and Conditions constitute a legally binding agreement made
    between you, whether personally or on behalf of an entity ("you") and EIC Portal("we," "us" or "our"), concerning your
    access to and use of the EIC Portal website as well as any other
    media form, media channel, mobile website or mobile application related,
    linked, or otherwise connected thereto (collectively, the "Site").
</p>
<p>
    You agree that by accessing the Site, you have read, understood, and agree
    to be bound by all of these Terms and Conditions. If you do not agree with
    all of these Terms and Conditions, then you are expressly prohibited from
    using the Site and you must discontinue use immediately.
</p>
<p>
    Supplemental terms and conditions or documents that may be posted on the
    Site from time to time are hereby expressly incorporated herein by
    reference. We reserve the right, in our sole discretion, to make changes or
    modifications to these Terms and Conditions at any time and for any reason.
</p>
<p>
    We will alert you about any changes by updating the "Last updated" date of
    these Terms and Conditions, and you waive any right to receive specific
    notice of each such change.
</p>
<p>
    It is your responsibility to periodically review these Terms and Conditions
    to stay informed of updates. You will be subject to, and will be deemed to
    have been made aware of and to have accepted, the changes in any revised
    Terms and Conditions by your continued use of the Site after the date such
    revised Terms and Conditions are posted.
</p>
<p>
    The information provided on the Site is not intended for distribution to or
    use by any person or entity in any jurisdiction or country where such
    distribution or use would be contrary to law or regulation or which would
    subject us to any registration requirement within such jurisdiction or
    country.
</p>
<p>
    Accordingly, those persons who choose to access the Site from other
    locations do so on their own initiative and are solely responsible for
    compliance with local laws, if and to the extent local laws are applicable.
</p>
<h1>INTELLECTUAL PROPERTY RIGHTS</h1>
<p>
    Unless otherwise indicated, the Site is our proprietary property and all
    source code, databases, functionality, software, website designs, audio,
    video, text, photographs, and graphics on the Site (collectively, the
    "Content") and the trademarks, service marks, and logos contained therein
    (the "Marks") are owned or controlled by us or licensed to us, and are
    protected by copyright and trademark laws and various other intellectual
    property rights and unfair competition laws of the United States, foreign
    jurisdictions, and international conventions.
</p>
<p>
    The Content and the Marks are provided on the Site "AS IS" for your
    information and personal use only. Except as expressly provided in these
    Terms and Conditions, no part of the Site and no Content or Marks may be
    copied, reproduced, aggregated, republished, uploaded, posted, publicly
    displayed, encoded, translated, transmitted, distributed, sold, licensed,
    or otherwise exploited for any commercial purpose whatsoever, without our
    express prior written permission.
</p>
<p>
    Provided that you are eligible to use the Site, you are granted a limited
    license to access and use the Site and to download or print a copy of any
    portion of the Content to which you have properly gained access solely for
    your personal, non-commercial use. We reserve all rights not expressly
    granted to you in and to the Site, the Content and the Marks.
</p>
<h1>USER REPRESENTATIONS</h1>
<p>
    By using the Site, you represent and warrant that:
</p>
<p>
    [(1) all registration information you submit will be true, accurate,
    current, and complete;<strong> </strong>(2) you will maintain the accuracy
    of such information and promptly update such registration information as
    necessary;]<strong> </strong>
</p>
<p>
    (3) you have the legal capacity and you agree to comply with these Terms
    and Conditions;
</p>
<p>
    (4) you will not access the Site through automated or non-human means,
    whether through a bot, script, or otherwise;
</p>
<p>
    (5) you will not use the Site for any illegal or unauthorized purpose;
</p>
<p>
    (6) your use of the Site will not violate any applicable law or regulation.
</p>
<p>
    If you provide any information that is untrue, inaccurate, not current, or
    incomplete, we have the right to suspend or terminate your account and
    refuse any and all current or future use of the Site (or any portion
    thereof).
</p>
<h1>USER REGISTRATION</h1>
<p>
    You may be required to register with the Site. You agree to keep your
    password confidential and will be responsible for all use of your account
    and password. We reserve the right to remove, reclaim, or change a username
    you select if we determine, in our sole discretion, that such username is
    inappropriate, obscene, or otherwise objectionable.
</p>
<h1>PROHIBITED ACTIVITIES</h1>
<p>
    You may not access or use the Site for any purpose other than that for
    which we make the Site available. The Site may not be used in connection
    with any commercial endeavors except those that are specifically endorsed
    or approved by us.
</p>
<p>
    As a user of the Site, you agree not to:
</p>
<p>
    1. systematically retrieve data or other content from the Site to create or
    compile, directly or indirectly, a collection, compilation, database, or
    directory without written permission from us.
</p>
<p>
    2. make any unauthorized use of the Site, including collecting usernames
    and/or email addresses of users by electronic or other means for the
    purpose of sending unsolicited email, or creating user accounts by
    automated means or under false pretenses.
</p>
<p>
    3. use a buying agent or purchasing agent to make purchases on the Site.
</p>
<p>
    4. use the Site to advertise or offer to sell goods and services.
</p>
<p>
    5. circumvent, disable, or otherwise interfere with security-related
    features of the Site, including features that prevent or restrict the use
    or copying of any Content or enforce limitations on the use of the Site
    and/or the Content contained therein.
</p>
<p>
    6. engage in unauthorized framing of or linking to the Site.
</p>
<p>
    7. trick, defraud, or mislead us and other users, especially in any attempt
    to learn sensitive account information such as user passwords;
</p>
<p>
    8. make improper use of our support services or submit false reports of
    abuse or misconduct.
</p>
<p>
    9. engage in any automated use of the system, such as using scripts to send
    comments or messages, or using any data mining, robots, or similar data
    gathering and extraction tools.
</p>
<p>
    10. interfere with, disrupt, or create an undue burden on the Site or the
    networks or services connected to the Site.
</p>
<p>
    11. attempt to impersonate another user or person or use the username of
    another user.
</p>
<p>
    12. sell or otherwise transfer your profile.
</p>
<p>
    13. use any information obtained from the Site in order to harass, abuse,
    or harm another person.
</p>
<p>
    14. use the Site as part of any effort to compete with us or otherwise use
    the Site and/or the Content for any revenue-generating endeavor or
    commercial enterprise.
</p>
<p>
    15. decipher, decompile, disassemble, or reverse engineer any of the
    software comprising or in any way making up a part of the Site.
</p>
<p>
    16. attempt to bypass any measures of the Site designed to prevent or
    restrict access to the Site, or any portion of the Site.
</p>
<p>
    17. harass, annoy, intimidate, or threaten any of our employees or agents
    engaged in providing any portion of the Site to you.
</p>
<p>
    18. delete the copyright or other proprietary rights notice from any
    Content.
</p>
<p>
    19. copy or adapt the Site’s software, including but not limited to Flash,
    PHP, HTML, CSS, JavaScript, jQyuery, or other code.
</p>
<p>
    20. upload or transmit (or attempt to upload or to transmit) viruses,
    Trojan horses, or other material, including excessive use of capital
    letters and spamming (continuous posting of repetitive text), that
    interferes with any party’s uninterrupted use and enjoyment of the Site or
    modifies, impairs, disrupts, alters, or interferes with the use, features,
    functions, operation, or maintenance of the Site.
</p>
<p>
    21. upload or transmit (or attempt to upload or to transmit) any material
    that acts as a passive or active information collection or transmission
    mechanism, including without limitation, clear graphics interchange formats
    ("gifs"), 1×1 pixels, web bugs, cookies, or other similar devices
    (sometimes referred to as "spyware" or "passive collection mechanisms" or
    "pcms").
</p>
<p>
    22. except as may be the result of standard search engine or Internet
    browser usage, use, launch, develop, or distribute any automated system,
    including without limitation, any spider, robot, cheat utility, scraper, or
    offline reader that accesses the Site, or using or launching any
    unauthorized script or other software.
</p>
<p>
    23. disparage, tarnish, or otherwise harm, in our opinion, us and/or the
    Site.
</p>
<p>
    24. use the Site in a manner inconsistent with any applicable laws or
    regulations.
</p>
<p>
    <strong>USER GENERATED CONTRIBUTIONS</strong>
</p>
<p>
    The Site may invite you to chat, contribute to, or participate in blogs,
    message boards, online forums, and other functionality, and may provide you
    with the opportunity to create, submit, post, display, transmit, perform,
    publish, distribute, or broadcast content and materials to us or on the
    Site, including but not limited to text, writings, video, audio,
    photographs, graphics, comments, suggestions, or personal information or
    other material (collectively, "Contributions").
</p>
<p>
    Contributions may be viewable by other users of the Site and through
    third-party websites. As such, any Contributions you transmit may be
    treated as non-confidential and non-proprietary. When you create or make
    available any Contributions, you thereby represent and warrant that:
</p>
<p>
    1. the creation, distribution, transmission, public display, or
    performance, and the accessing, downloading, or copying of your
    Contributions do not and will not infringe the proprietary rights,
    including but not limited to the copyright, patent, trademark, trade
    secret, or moral rights of any third party.
</p>
<p>
    2. you are the creator and owner of or have the necessary licenses, rights,
    consents, releases, and permissions to use and to authorize us, the Site,
    and other users of the Site to use your Contributions in any manner
    contemplated by the Site and these Terms and Conditions.
</p>
<p>
    3. you have the written consent, release, and/or permission of each and
    every identifiable individual person in your Contributions to use the name
    or likeness of each and every such identifiable individual person to enable
    inclusion and use of your Contributions in any manner contemplated by the
    Site and these Terms and Conditions.
</p>
<p>
    4. your Contributions are not false, inaccurate, or misleading.
</p>
<p>
    5. your Contributions are not unsolicited or unauthorized advertising,
    promotional materials, pyramid schemes, chain letters, spam, mass mailings,
    or other forms of solicitation.
</p>
<p>
    6. your Contributions are not obscene, lewd, lascivious, filthy, violent,
    harassing, libelous, slanderous, or otherwise objectionable (as determined
    by us).
</p>
<p>
    7. your Contributions do not ridicule, mock, disparage, intimidate, or
    abuse anyone.
</p>
<p>
    8. your Contributions do not advocate the violent overthrow of any
    government or incite, encourage, or threaten physical harm against another.
</p>
<p>
    9. your Contributions do not violate any applicable law, regulation, or
    rule.
</p>
<p>
    10. your Contributions do not violate the privacy or publicity rights of
    any third party.
</p>
<p>
    11. your Contributions do not contain any material that solicits personal
    information from anyone under the age of 18 or exploits people under the
    age of 18 in a sexual or violent manner.
</p>
<p>
    12. your Contributions do not violate any federal or state law concerning
    child pornography, or otherwise intended to protect the health or
    well-being of minors;
</p>
<p>
    13. your Contributions do not include any offensive comments that are
    connected to race, national origin, gender, sexual preference, or physical
    handicap.
</p>
<p>
    14. your Contributions do not otherwise violate, or link to material that
    violates, any provision of these Terms and Conditions, or any applicable
    law or regulation.
</p>
<p>
    Any use of the Site in violation of the foregoing violates these Terms and
    Conditions and may result in, among other things, termination or suspension
    of your rights to use the Site.
</p>
<h1>CONTRIBUTION LICENSE</h1>
<p>
    By posting your Contributions to any part of the Site [or making
    Contributions accessible to the Site by linking your account from the Site
    to any of your social networking accounts], you automatically grant, and
    you represent and warrant that you have the right to grant, to us an
    unrestricted, unlimited, irrevocable, perpetual, non-exclusive,
    transferable, royalty-free, fully-paid, worldwide right, and license to
    host, use, copy, reproduce, disclose, sell, resell, publish, broadcast,
    retitle, archive, store, cache, publicly perform, publicly display,
    reformat, translate, transmit, excerpt (in whole or in part), and
    distribute such Contributions (including, without limitation, your image
    and voice) for any purpose, commercial, advertising, or otherwise, and to
    prepare derivative works of, or incorporate into other works, such
    Contributions, and grant and authorize sublicenses of the foregoing. The
    use and distribution may occur in any media formats and through any media
    channels.
</p>
<p>
    This license will apply to any form, media, or technology now known or
    hereafter developed, and includes our use of your name, company name, and
    franchise name, as applicable, and any of the trademarks, service marks,
    trade names, logos, and personal and commercial images you provide. You
    waive all moral rights in your Contributions, and you warrant that moral
    rights have not otherwise been asserted in your Contributions.
</p>
<p>
    We do not assert any ownership over your Contributions. You retain full
    ownership of all of your Contributions and any intellectual property rights
    or other proprietary rights associated with your Contributions. We are not
    liable for any statements or representations in your Contributions provided
    by you in any area on the Site.
</p>
<p>
    You are solely responsible for your Contributions to the Site and you
    expressly agree to exonerate us from any and all responsibility and to
    refrain from any legal action against us regarding your Contributions.
</p>
<p>
    We have the right, in our sole and absolute discretion, (1) to edit,
    redact, or otherwise change any Contributions; (2) to re-categorize any
    Contributions to place them in more appropriate locations on the Site; and
    (3) to pre-screen or delete any Contributions at any time and for any
    reason, without notice. We have no obligation to monitor your
    Contributions.
</p>
<h1>GUIDELINES FOR REVIEWS</h1>
<p>
    We may provide you areas on the Site to leave reviews or ratings. When
    posting a review, you must comply with the following criteria:
</p>
<p>
    (1) you should have firsthand experience with the person/entity being
    reviewed;
</p>
<p>
    (2) your reviews should not contain offensive profanity, or abusive,
    racist, offensive, or hate language;
</p>
<p>
    (3) your reviews should not contain discriminatory references based on
    religion, race, gender, national origin, age, marital status, sexual
    orientation, or disability;
</p>
<p>
    (4) your reviews should not contain references to illegal activity;
</p>
<p>
    (5) you should not be affiliated with competitors if posting negative
    reviews;
</p>
<p>
    (6) you should not make any conclusions as to the legality of conduct;
</p>
<p>
    (7) you may not post any false or misleading statements;
</p>
<p>
    (8) you may not organize a campaign encouraging others to post reviews,
    whether positive or negative.
</p>
<p>
    We may accept, reject, or remove reviews in our sole discretion. We have
    absolutely no obligation to screen reviews or to delete reviews, even if
    anyone considers reviews objectionable or inaccurate. Reviews are not
    endorsed by us, and do not necessarily represent our opinions or the views
    of any of our affiliates or partners.
</p>
<p>
    We do not assume liability for any review or for any claims, liabilities,
    or losses resulting from any review. By posting a review, you hereby grant
    to us a perpetual, non-exclusive, worldwide, royalty-free, fully-paid,
    assignable, and sublicensable right and license to reproduce, modify,
    translate, transmit by any means, display, perform, and/or distribute all
    content relating to reviews.
</p>
<h1>MOBILE APPLICATION LICENSE</h1>
<h2>Use License</h2>
<p>
    If you access the Site via a mobile application, then we grant you a
    revocable, non-exclusive, non-transferable, limited right to install and
    use the mobile application on wireless electronic devices owned or
    controlled by you, and to access and use the mobile application on such
    devices strictly in accordance with the terms and conditions of this mobile
    application license contained in these Terms and Conditions.
</p>
<p>
    You shall not:
</p>
<p>
    (1) decompile, reverse engineer, disassemble, attempt to derive the source
    code of, or decrypt the application;
</p>
<p>
    (2) make any modification, adaptation, improvement, enhancement,
    translation, or derivative work from the application;
</p>
<p>
    (3) violate any applicable laws, rules, or regulations in connection with
    your access or use of the application;
</p>
<p>
    (4) remove, alter, or obscure any proprietary notice (including any notice
    of copyright or trademark) posted by us or the licensors of the
    application;
</p>
<p>
    (5) use the application for any revenue generating endeavor, commercial
    enterprise, or other purpose for which it is not designed or intended;
</p>
<p>
    (6) make the application available over a network or other environment
    permitting access or use by multiple devices or users at the same time;
</p>
<p>
    (7) use the application for creating a product, service, or software that
    is, directly or indirectly, competitive with or in any way a substitute for
    the application;
</p>
<p>
    (8) use the application to send automated queries to any website or to send
    any unsolicited commercial e-mail;
</p>
<p>
    (9) use any proprietary information or any of our interfaces or our other
    intellectual property in the design, development, manufacture, licensing,
    or distribution of any applications, accessories, or devices for use with
    the application.
</p>
<h2>Apple and Android Devices</h2>
<p>
    The following terms apply when you use a mobile application obtained from
    either the Apple Store or Google Play (each an "App Distributor") to access
    the Site:
</p>
<p>
    (1) the license granted to you for our mobile application is limited to a
    non-transferable license to use the application on a device that utilizes
    the Apple iOS or Android operating systems, as applicable, and in
    accordance with the usage rules set forth in the applicable App
    Distributor’s terms of service;
</p>
<p>
    (2) we are responsible for providing any maintenance and support services
    with respect to the mobile application as specified in the terms and
    conditions of this mobile application license contained in these Terms and
    Conditions or as otherwise required under applicable law, and you
    acknowledge that each App Distributor has no obligation whatsoever to
    furnish any maintenance and support services with respect to the mobile
    application;
</p>
<p>
    (3) in the event of any failure of the mobile application to conform to any
    applicable warranty, you may notify the applicable App Distributor, and the
    App Distributor, in accordance with its terms and policies, may refund the
    purchase price, if any, paid for the mobile application, and to the maximum
    extent permitted by applicable law, the App Distributor will have no other
    warranty obligation whatsoever with respect to the mobile application;
</p>
<p>
    (4) you represent and warrant that (i) you are not located in a country
    that is subject to a U.S. government embargo, or that has been designated
    by the U.S. government as a "terrorist supporting" country and (ii) you are
    not listed on any U.S. government list of prohibited or restricted parties;
</p>
<p>
    (5) you must comply with applicable third-party terms of agreement when
    using the mobile application, e.g., if you have a VoIP application, then
    you must not be in violation of their wireless data service agreement when
    using the mobile application;
</p>
<p>
    6) you acknowledge and agree that the App Distributors are third-party
    beneficiaries of the terms and conditions in this mobile application
    license contained in these Terms and Conditions, and that each App
    Distributor will have the right (and will be deemed to have accepted the
    right) to enforce the terms and conditions in this mobile application
    license contained in these Terms and Conditions against you as a
    third-party beneficiary thereof.
</p>
<h1>SOCIAL MEDIA</h1>
<p>
    As part of the functionality of the Site, you may link your account with
    online accounts you have with third-party service providers (each such
    account, a "Third-Party Account") by either: (1) providing your Third-Party
    Account login information through the Site; or (2) allowing us to access
    your Third-Party Account, as is permitted under the applicable terms and
    conditions that govern your use of each Third-Party Account.
</p>
<p>
    You represent and warrant that you are entitled to disclose your
    Third-Party Account login information to us and/or grant us access to your
    Third-Party Account, without breach by you of any of the terms and
    conditions that govern your use of the applicable Third-Party Account, and
    without obligating us to pay any fees or making us subject to any usage
    limitations imposed by the third-party service provider of the Third-Party
    Account.
</p>
<p>
    By granting us access to any Third-Party Accounts, you understand that (1)
    we may access, make available, and store (if applicable) any content that
    you have provided to and stored in your Third-Party Account (the "Social
    Network Content") so that it is available on and through the Site via your
    account, including without limitation any friend lists and (2) we may
    submit to and receive from your Third-Party Account additional information
    to the extent you are notified when you link your account with the
    Third-Party Account.
</p>
<p>
    Depending on the Third-Party Accounts you choose and subject to the privacy
    settings that you have set in such Third-Party Accounts, personally
    identifiable information that you post to your Third-Party Accounts may be
    available on and through your account on the Site.
</p>
<p>
    Please note that if a Third-Party Account or associated service becomes
    unavailable or our access to such Third-Party Account is terminated by the
    third-party service provider, then Social Network Content may no longer be
    available on and through the Site. You will have the ability to disable the
    connection between your account on the Site and your Third-Party Accounts
    at any time.
</p>
<p>
    PLEASE NOTE THAT YOUR RELATIONSHIP WITH THE THIRD-PARTY SERVICE PROVIDERS
    ASSOCIATED WITH YOUR THIRD-PARTY ACCOUNTS IS GOVERNED SOLELY BY YOUR
    AGREEMENT(S) WITH SUCH THIRD-PARTY SERVICE PROVIDERS.
</p>
<p>
    We make no effort to review any Social Network Content for any purpose,
    including but not limited to, for accuracy, legality, or non-infringement,
    and we are not responsible for any Social Network Content.
</p>
<p>
    You acknowledge and agree that we may access your email address book
    associated with a Third-Party Account and your contacts list stored on your
    mobile device or tablet computer solely for purposes of identifying and
    informing you of those contacts who have also registered to use the Site.
</p>
<p>
    You can deactivate the connection between the Site and your Third-Party
    Account by contacting us using the contact information below or through
    your account settings (if applicable). We will attempt to delete any
    information stored on our servers that was obtained through such
    Third-Party Account, except the username and profile picture that become
    associated with your account.
</p>
<h1>SUBMISSIONS</h1>
<p>
    You acknowledge and agree that any questions, comments, suggestions, ideas,
    feedback, or other information regarding the Site ("Submissions") provided
    by you to us are non-confidential and shall become our sole property. We
    shall own exclusive rights, including all intellectual property rights, and
    shall be entitled to the unrestricted use and dissemination of these
    Submissions for any lawful purpose, commercial or otherwise, without
    acknowledgment or compensation to you.
</p>
<p>
    You hereby waive all moral rights to any such Submissions, and you hereby
    warrant that any such Submissions are original with you or that you have
    the right to submit such Submissions. You agree there shall be no recourse
    against us for any alleged or actual infringement or misappropriation of
    any proprietary right in your Submissions.
</p>
<h1>THIRD-PARTY WEBSITES AND CONTENT</h1>
<p>
    The Site may contain (or you may be sent via the Site) links to other
    websites ("Third-Party Websites") as well as articles, photographs, text,
    graphics, pictures, designs, music, sound, video, information,
    applications, software, and other content or items belonging to or
    originating from third parties ("Third-Party Content").
</p>
<p>
    Such Third-Party Websites and Third-Party Content are not investigated,
    monitored, or checked for accuracy, appropriateness, or completeness by us,
    and we are not responsible for any Third-Party Websites accessed through
    the Site or any Third-Party Content posted on, available through, or
    installed from the Site, including the content, accuracy, offensiveness,
    opinions, reliability, privacy practices, or other policies of or contained
    in the Third-Party Websites or the Third-Party Content.
</p>
<p>
    Inclusion of, linking to, or permitting the use or installation of any
    Third-Party Websites or any Third-Party Content does not imply approval or
    endorsement thereof by us. If you decide to leave the Site and access the
    Third-Party Websites or to use or install any Third-Party Content, you do
    so at your own risk, and you should be aware these Terms and Conditions no
    longer govern.
</p>
<p>
    You should review the applicable terms and policies, including privacy and
    data gathering practices, of any website to which you navigate from the
    Site or relating to any applications you use or install from the Site. Any
    purchases you make through Third-Party Websites will be through other
    websites and from other companies, and we take no responsibility whatsoever
    in relation to such purchases which are exclusively between you and the
    applicable third party.
</p>
<p>
    You agree and acknowledge that we do not endorse the products or services
    offered on Third-Party Websites and you shall hold us harmless from any
    harm caused by your purchase of such products or services. Additionally,
    you shall hold us harmless from any losses sustained by you or harm caused
    to you relating to or resulting in any way from any Third-Party Content or
    any contact with Third-Party Websites.
</p>
<h1>ADVERTISERS</h1>
<p>
    We allow advertisers to display their advertisements and other information
    in certain areas of the Site, such as sidebar advertisements or banner
    advertisements. If you are an advertiser, you shall take full
    responsibility for any advertisements you place on the Site and any
    services provided on the Site or products sold through those
    advertisements.
</p>
<p>
    Further, as an advertiser, you warrant and represent that you possess all
    rights and authority to place advertisements on the Site, including, but
    not limited to, intellectual property rights, publicity rights, and
    contractual rights.
</p>
<p>
    [As an advertiser, you agree that such advertisements are subject to our
    Digital Millennium Copyright Act ("DMCA") Notice and Policy provisions as
    described below, and you understand and agree there will be no refund or
    other compensation for DMCA takedown-related issues.] We simply provide the
    space to place such advertisements, and we have no other relationship with
    advertisers. <strong></strong>
</p>
<h1>SITE MANAGEMENT</h1>
<p>
    We reserve the right, but not the obligation, to:
</p>
<p>
    (1) monitor the Site for violations of these Terms and Conditions;
</p>
<p>
    (2) take appropriate legal action against anyone who, in our sole
    discretion, violates the law or these Terms and Conditions, including
    without limitation, reporting such user to law enforcement authorities;
</p>
<p>
    (3) in our sole discretion and without limitation, refuse, restrict access
    to, limit the availability of, or disable (to the extent technologically
    feasible) any of your Contributions or any portion thereof;
</p>
<p>
    (4) in our sole discretion and without limitation, notice, or liability, to
    remove from the Site or otherwise disable all files and content that are
    excessive in size or are in any way burdensome to our systems;
</p>
<p>
    (5) otherwise manage the Site in a manner designed to protect our rights
    and property and to facilitate the proper functioning of the Site.
</p>
<h1>PRIVACY POLICY</h1>
<p>
    We care about data privacy and security. Please review our Privacy Policy
    posted on the Site. By using the Site, you agree to be bound by our Privacy
    Policy, which is incorporated into these Terms and Conditions. Please be
    advised the Site is hosted in the United States.
</p>
<p>
    If you access the Site from the European Union, Asia, or any other region
    of the world with laws or other requirements governing personal data
    collection, use, or disclosure that differ from applicable laws in the
    United States, then through your continued use of the Site, you are
    transferring your data to the United States, and you expressly consent to
    have your data transferred to and processed in the United States.
</p>
<p>
    [Further, we do not knowingly accept, request, or solicit information from
    children or knowingly market to children. Therefore, in accordance with the
    U.S. Children’s Online Privacy Protection Act, if we receive actual
    knowledge that anyone under the age of 13 has provided personal information
    to us without the requisite and verifiable parental consent, we will delete
    that information from the Site as quickly as is reasonably practical.]
</p>
<h1>DIGITAL MILLENNIUM COPYRIGHT ACT (DMCA) NOTICE AND POLICY</h1>
<h2>Notifications</h2>
<p>
    We respect the intellectual property rights of others. If you believe that
    any material available on or through the Site infringes upon any copyright
    you own or control, please immediately notify our Designated Copyright
    Agent using the contact information provided below (a "Notification").
</p>
<p>
    A copy of your Notification will be sent to the person who posted or stored
    the material addressed in the Notification. Please be advised that pursuant
    to federal law you may be held liable for damages if you make material
    misrepresentations in a Notification. Thus, if you are not sure that
    material located on or linked to by the Site infringes your copyright, you
    should consider first contacting an attorney.
</p>
<p>
    All Notifications should meet the requirements of DMCA 17 U.S.C. §
    512(c)(3) and include the following information:
</p>
<p>
    (1) A physical or electronic signature of a person authorized to act on
    behalf of the owner of an exclusive right that is allegedly infringed;
</p>
<p>
    (2) identification of the copyrighted work claimed to have been infringed,
    or, if multiple copyrighted works on the Site are covered by the
    Notification, a representative list of such works on the Site;
</p>
<p>
    (3) identification of the material that is claimed to be infringing or to
    be the subject of infringing activity and that is to be removed or access
    to which is to be disabled, and information reasonably sufficient to permit
    us to locate the material;
</p>
<p>
    (4) information reasonably sufficient to permit us to contact the
    complaining party, such as an address, telephone number, and, if available,
    an email address at which the complaining party may be contacted;
</p>
<p>
    (5) a statement that the complaining party has a good faith belief that use
    of the material in the manner complained of is not authorized by the
    copyright owner, its agent, or the law;
</p>
<p>
    (6) a statement that the information in the notification is accurate, and
    under penalty of perjury, that the complaining party is authorized to act
    on behalf of the owner of an exclusive right that is allegedly infringed
    upon.
</p>
<h2>Counter Notification</h2>
<p>
    If you believe your own copyrighted material has been removed from the Site
    as a result of a mistake or misidentification, you may submit a written
    counter notification to [us/our Designated Copyright Agent] using the
    contact information provided below (a "Counter Notification").
</p>
<p>
    To be an effective Counter Notification under the DMCA, your Counter
    Notification must include substantially the following:
</p>
<p>
    (1) identification of the material that has been removed or disabled and
    the location at which the material appeared before it was removed or
    disabled;
</p>
<p>
    (2) a statement that you consent to the jurisdiction of the Federal
    District Court in which your address is located, or if your address is
    outside the United States, for any judicial district in which we are
    located;
</p>
<p>
    (3) a statement that you will accept service of process from the party that
    filed the Notification or the party''s agent;
</p>
<p>
    (4) your name, address, and telephone number;
</p>
<p>
    (5) a statement under penalty of perjury that you have a good faith belief
    that the material in question was removed or disabled as a result of a
    mistake or misidentification of the material to be removed or disabled;
</p>
<p>
    (6) your physical or electronic signature.
</p>
<p>
    If you send us a valid, written Counter Notification meeting the
    requirements described above, we will restore your removed or disabled
    material, unless we first receive notice from the party filing the
    Notification informing us that such party has filed a court action to
    restrain you from engaging in infringing activity related to the material
    in question.
</p>
<p>
    Please note that if you materially misrepresent that the disabled or
    removed content was removed by mistake or misidentification, you may be
    liable for damages, including costs and attorney''s fees. Filing a false
    Counter Notification constitutes perjury.
</p>
<h1>COPYRIGHT INFRINGEMENTS</h1>
<p>
    We respect the intellectual property rights of others. If you believe that
    any material available on or through the Site infringes upon any copyright
    you own or control, please immediately notify us using the contact
    information provided below (a "Notification"). A copy of your Notification
    will be sent to the person who posted or stored the material addressed in
    the Notification.
</p>
<p>
    Please be advised that pursuant to federal law you may be held liable for
    damages if you make material misrepresentations in a Notification. Thus, if
    you are not sure that material located on or linked to by the Site
    infringes your copyright, you should consider first contacting an
    attorney.]
</p>
<h1>TERM AND TERMINATION</h1>
<p>
    These Terms and Conditions shall remain in full force and effect while you
    use the Site. WITHOUT LIMITING ANY OTHER PROVISION OF THESE TERMS AND
    CONDITIONS, WE RESERVE THE RIGHT TO, IN OUR SOLE DISCRETION AND WITHOUT
    NOTICE OR LIABILITY, DENY ACCESS TO AND USE OF THE SITE (INCLUDING BLOCKING
    CERTAIN IP ADDRESSES), TO ANY PERSON FOR ANY REASON OR FOR NO REASON,
    INCLUDING WITHOUT LIMITATION FOR BREACH OF ANY REPRESENTATION, WARRANTY, OR
    COVENANT CONTAINED IN THESE TERMS AND CONDITIONS OR OF ANY APPLICABLE LAW
    OR REGULATION. WE MAY TERMINATE YOUR USE OR PARTICIPATION IN THE SITE OR
    DELETE [YOUR ACCOUNT AND] ANY CONTENT OR INFORMATION THAT YOU POSTED AT ANY
    TIME, WITHOUT WARNING, IN OUR SOLE DISCRETION.
</p>
<p>
    If we terminate or suspend your account for any reason, you are prohibited
    from registering and creating a new account under your name, a fake or
    borrowed name, or the name of any third party, even if you may be acting on
    behalf of the third party.
</p>
<p>
    In addition to terminating or suspending your account, we reserve the right
    to take appropriate legal action, including without limitation pursuing
    civil, criminal, and injunctive redress.
</p>
<h1>MODIFICATIONS AND INTERRUPTIONS</h1>
<p>
    We reserve the right to change, modify, or remove the contents of the Site
    at any time or for any reason at our sole discretion without notice.
    However, we have no obligation to update any information on our Site. We
    also reserve the right to modify or discontinue all or part of the Site
    without notice at any time.
</p>
<p>
    We will not be liable to you or any third party for any modification, price
    change, suspension, or discontinuance of the Site.
</p>
<p>
    We cannot guarantee the Site will be available at all times. We may
    experience hardware, software, or other problems or need to perform
    maintenance related to the Site, resulting in interruptions, delays, or
    errors.
</p>
<p>
    We reserve the right to change, revise, update, suspend, discontinue, or
    otherwise modify the Site at any time or for any reason without notice to
    you. You agree that we have no liability whatsoever for any loss, damage,
    or inconvenience caused by your inability to access or use the Site during
    any downtime or discontinuance of the Site.
</p>
<p>
    Nothing in these Terms and Conditions will be construed to obligate us to
    maintain and support the Site or to supply any corrections, updates, or
    releases in connection therewith.
</p>
<h1>GOVERNING LAW</h1>
<p>
    These Terms and Conditions and your use of the Site are governed by and
construed in accordance with the laws of the State of Tennessee    <strong> </strong>applicable to agreements made and to be entirely
    performed within the State/Commonwealth of Tennessee, without regard to its
    conflict of law principles.
</p>
<h1>DISPUTE RESOLUTION</h1>
<h2>Informal Negotiations</h2>
<p>
    To expedite resolution and control the cost of any dispute, controversy, or
    claim related to these Terms and Conditions (each a "Dispute" and
    collectively, the "Disputes") brought by either you or us (individually, a
    "Party" and collectively, the "Parties"), the Parties agree to first
    attempt to negotiate any Dispute (except those Disputes expressly provided
    below) informally for at least <strong>60 </strong>days before initiating
    arbitration. Such informal negotiations commence upon written notice from
    one Party to the other Party.
</p>
<h2>Binding Arbitration</h2>
<p>
    If the Parties are unable to resolve a Dispute through informal
    negotiations, the Dispute (except those Disputes expressly excluded below)
    will be finally and exclusively resolved by binding arbitration. YOU
    UNDERSTAND THAT WITHOUT THIS PROVISION, YOU WOULD HAVE THE RIGHT TO SUE IN
    COURT AND HAVE A JURY TRIAL.
</p>
<p>
    The arbitration shall be commenced and conducted under the Commercial
    Arbitration Rules of the American Arbitration Association ("AAA") and,
    where appropriate, the AAA’s Supplementary Procedures for Consumer Related
    Disputes ("AAA Consumer Rules"), both of which are available at the AAA
    website <a href="http://www.adr.org/">www.adr.org</a>.
</p>
<p>
    Your arbitration fees and your share of arbitrator compensation shall be
    governed by the AAA Consumer Rules and, where appropriate, limited by the
    AAA Consumer Rules. [If such costs are determined to by the arbitrator to
    be excessive, we will pay all arbitration fees and expenses.]
</p>
<p>
    The arbitration may be conducted in person, through the submission of
    documents, by phone, or online. The arbitrator will make a decision in
    writing, but need not provide a statement of reasons unless requested by
    either Party.
</p>
<p>
    The arbitrator must follow applicable law, and any award may be challenged
    if the arbitrator fails to do so. Except where otherwise required by the
    applicable AAA rules or applicable law, the arbitration will take place in
    Williamson County, Tennessee.
</p>
<p>
    Except as otherwise provided herein, the Parties may litigate in court to
    compel arbitration, stay proceedings pending arbitration, or to confirm,
    modify, vacate, or enter judgment on the award entered by the arbitrator.
</p>
<p>
    If for any reason, a Dispute proceeds in court rather than arbitration, the
    Dispute shall be commenced or prosecuted in the state and federal courts
    located in [name of county] County, [name of state], and the Parties hereby
    consent to, and waive all defenses of lack of personal jurisdiction, and
    forum non conveniens with respect to venue and jurisdiction in such state
    and federal courts.
</p>
<p>
    Application of the United Nations Convention on Contracts for the
    International Sale of Goods and the Uniform Computer Information
    Transaction Act (UCITA) are excluded from these Terms and Conditions.
</p>
<p>
    In no event shall any Dispute brought by either Party related in any way to
    the Site be commenced more than <strong>1</strong> year after the cause of
    action arose. If this provision is found to be illegal or unenforceable,
    then neither Party will elect to arbitrate any Dispute falling within that
    portion of this provision found to be illegal or unenforceable and such
    Dispute shall be decided by a court of competent jurisdiction within the
    courts listed for jurisdiction above, and the Parties agree to submit to
    the personal jurisdiction of that court.
</p>
<h2>Restrictions</h2>
<p>
    The Parties agree that any arbitration shall be limited to the Dispute
    between the Parties individually. To the full extent permitted by law, (a)
    no arbitration shall be joined with any other proceeding; (b) there is no
    right or authority for any Dispute to be arbitrated on a class-action basis
    or to utilize class action procedures; and (c) there is no right or
    authority for any Dispute to be brought in a purported representative
    capacity on behalf of the general public or any other persons.
</p>
<h2>Exceptions to Informal Negotiations and Arbitration</h2>
<p>
    The Parties agree that the following Disputes are not subject to the above
    provisions concerning [informal negotiations and] binding arbitration: (a)
    any Disputes seeking to enforce or protect, or concerning the validity of,
    any of the intellectual property rights of a Party; (b) any Dispute related
    to, or arising from, allegations of theft, piracy, invasion of privacy, or
    unauthorized use; and (c) any claim for injunctive relief.
</p>
<p>
    If this provision is found to be illegal or unenforceable, then neither
    Party will elect to arbitrate any Dispute falling within that portion of
    this provision found to be illegal or unenforceable and such Dispute shall
    be decided by a court of competent jurisdiction within the courts listed
    for jurisdiction above, and the Parties agree to submit to the personal
    jurisdiction of that court.<strong></strong>
</p>
<h1>CORRECTIONS</h1>
<p>
    There may be information on the Site that contains typographical errors,
    inaccuracies, or omissions that may relate to the Site, including
    descriptions, pricing, availability, and various other information. We
    reserve the right to correct any errors, inaccuracies, or omissions and to
    change or update the information on the Site at any time, without prior
    notice.
</p>
<h1>DISCLAIMER</h1>
<p>
    THE SITE IS PROVIDED ON AN AS-IS AND AS-AVAILABLE BASIS. YOU AGREE THAT
    YOUR USE OF THE SITE AND OUR SERVICES WILL BE AT YOUR SOLE RISK. TO THE
    FULLEST EXTENT PERMITTED BY LAW, WE DISCLAIM ALL WARRANTIES, EXPRESS OR
    IMPLIED, IN CONNECTION WITH THE SITE AND YOUR USE THEREOF, INCLUDING,
    WITHOUT LIMITATION, THE IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR
    A PARTICULAR PURPOSE, AND NON-INFRINGEMENT. WE MAKE NO WARRANTIES OR
    REPRESENTATIONS ABOUT THE ACCURACY OR COMPLETENESS OF THE SITE’S CONTENT OR
    THE CONTENT OF ANY WEBSITES LINKED TO THE SITE AND WE WILL ASSUME NO
    LIABILITY OR RESPONSIBILITY FOR ANY (1) ERRORS, MISTAKES, OR INACCURACIES
    OF CONTENT AND MATERIALS, (2) PERSONAL INJURY OR PROPERTY DAMAGE, OF ANY
    NATURE WHATSOEVER, RESULTING FROM YOUR ACCESS TO AND USE OF THE SITE, (3)
    ANY UNAUTHORIZED ACCESS TO OR USE OF OUR SECURE SERVERS AND/OR ANY AND ALL
    PERSONAL INFORMATION AND/OR FINANCIAL INFORMATION STORED THEREIN, (4) ANY
    INTERRUPTION OR CESSATION OF TRANSMISSION TO OR FROM THE SITE, (5) ANY
    BUGS, VIRUSES, TROJAN HORSES, OR THE LIKE WHICH MAY BE TRANSMITTED TO OR
    THROUGH THE SITE BY ANY THIRD PARTY, AND/OR (6) ANY ERRORS OR OMISSIONS IN
    ANY CONTENT AND MATERIALS OR FOR ANY LOSS OR DAMAGE OF ANY KIND INCURRED AS
    A RESULT OF THE USE OF ANY CONTENT POSTED, TRANSMITTED, OR OTHERWISE MADE
    AVAILABLE VIA THE SITE. WE DO NOT WARRANT, ENDORSE, GUARANTEE, OR ASSUME
    RESPONSIBILITY FOR ANY PRODUCT OR SERVICE ADVERTISED OR OFFERED BY A THIRD
    PARTY THROUGH THE SITE, ANY HYPERLINKED WEBSITE, OR ANY WEBSITE OR MOBILE
    APPLICATION FEATURED IN ANY BANNER OR OTHER ADVERTISING, AND WE WILL NOT BE
    A PARTY TO OR IN ANY WAY BE RESPONSIBLE FOR MONITORING ANY TRANSACTION
    BETWEEN YOU AND ANY THIRD-PARTY PROVIDERS OF PRODUCTS OR SERVICES.
</p>
<p>
    AS WITH THE PURCHASE OF A PRODUCT OR SERVICE THROUGH ANY MEDIUM OR IN ANY
    ENVIRONMENT, YOU SHOULD USE YOUR BEST JUDGMENT AND EXERCISE CAUTION WHERE
    APPROPRIATE.
</p>
<h1>LIMITATIONS OF LIABILITY</h1>
<p>
    IN NO EVENT WILL WE OR OUR DIRECTORS, EMPLOYEES, OR AGENTS BE LIABLE TO YOU
    OR ANY THIRD PARTY FOR ANY DIRECT, INDIRECT, CONSEQUENTIAL, EXEMPLARY,
    INCIDENTAL, SPECIAL, OR PUNITIVE DAMAGES, INCLUDING LOST PROFIT, LOST
    REVENUE, LOSS OF DATA, OR OTHER DAMAGES ARISING FROM YOUR USE OF THE SITE,
    EVEN IF WE HAVE BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.
</p>
<p>
    [NOTWITHSTANDING ANYTHING TO THE CONTRARY CONTAINED HEREIN, OUR LIABILITY
    TO YOU FOR ANY CAUSE WHATSOEVER AND REGARDLESS OF THE FORM OF THE ACTION,
    WILL AT ALL TIMES BE LIMITED TO [THE LESSER OF] [THE AMOUNT PAID, IF ANY,
    BY YOU TO US DURING THE <strong>FIRST MONTH</strong> PERIOD PRIOR TO ANY
    CAUSE OF ACTION ARISING OR <strong>$99.00</strong>. CERTAIN STATE LAWS DO
    NOT ALLOW LIMITATIONS ON IMPLIED WARRANTIES OR THE EXCLUSION OR LIMITATION
    OF CERTAIN DAMAGES.
</p>
<p>
    IF THESE LAWS APPLY TO YOU, SOME OR ALL OF THE ABOVE DISCLAIMERS OR
    LIMITATIONS MAY NOT APPLY TO YOU, AND YOU MAY HAVE ADDITIONAL RIGHTS.]
</p>
<h1>INDEMNIFICATION</h1>
<p>
    You agree to defend, indemnify, and hold us harmless, including our
    subsidiaries, affiliates, and all of our respective officers, agents,
    partners, and employees, from and against any loss, damage, liability,
    claim, or demand, including reasonable attorneys’ fees and expenses, made
    by any third party due to or arising out of: (1) [your Contributions]; (2)
    use of the Site; (3) breach of these Terms and Conditions; (4) any breach
    of your representations and warranties set forth in these Terms and
    Conditions; (5) your violation of the rights of a third party, including
    but not limited to intellectual property rights; or (6) any overt harmful
    act toward any other user of the Site with whom you connected via the Site.
</p>
<p>
    Notwithstanding the foregoing, we reserve the right, at your expense, to
    assume the exclusive defense and control of any matter for which you are
    required to indemnify us, and you agree to cooperate, at your expense, with
    our defense of such claims. We will use reasonable efforts to notify you of
    any such claim, action, or proceeding which is subject to this
    indemnification upon becoming aware of it.
</p>
<h1>USER DATA</h1>
<p>
    We will maintain certain data that you transmit to the Site for the purpose
    of managing the Site, as well as data relating to your use of the Site.
    Although we perform regular routine backups of data, you are solely
    responsible for all data that you transmit or that relates to any activity
    you have undertaken using the Site.
</p>
<p>
    You agree that we shall have no liability to you for any loss or corruption
    of any such data, and you hereby waive any right of action against us
    arising from any such loss or corruption of such data.
</p>
<h1>ELECTRONIC COMMUNICATIONS, TRANSACTIONS, AND SIGNATURES</h1>
<p>
    Visiting the Site, sending us emails, and completing online forms
    constitute electronic communications. You consent to receive electronic
    communications, and you agree that all agreements, notices, disclosures,
    and other communications we provide to you electronically, via email and on
    the Site, satisfy any legal requirement that such communication be in
    writing.
</p>
<p>
    YOU HEREBY AGREE TO THE USE OF ELECTRONIC SIGNATURES, CONTRACTS, ORDERS,
    AND OTHER RECORDS, AND TO ELECTRONIC DELIVERY OF NOTICES, POLICIES, AND
    RECORDS OF TRANSACTIONS INITIATED OR COMPLETED BY US OR VIA THE SITE.
</p>
<p>
    You hereby waive any rights or requirements under any statutes,
    regulations, rules, ordinances, or other laws in any jurisdiction which
    require an original signature or delivery or retention of non-electronic
    records, or to payments or the granting of credits by any means other than
    electronic means.
</p>
<h1>MISCELLANEOUS</h1>
<p>
    These Terms and Conditions and any policies or operating rules posted by us
    on the Site constitute the entire agreement and understanding between you
    and us. Our failure to exercise or enforce any right or provision of these
    Terms and Conditions shall not operate as a waiver of such right or
    provision.
</p>
<p>
    These Terms and Conditions operate to the fullest extent permissible by
    law. We may assign any or all of our rights and obligations to others at
    any time. We shall not be responsible or liable for any loss, damage,
    delay, or failure to act caused by any cause beyond our reasonable control.
</p>
<p>
    If any provision or part of a provision of these Terms and Conditions is
    determined to be unlawful, void, or unenforceable, that provision or part
    of the provision is deemed severable from these Terms and Conditions and
    does not affect the validity and enforceability of any remaining
    provisions.
</p>
<p>
    There is no joint venture, partnership, employment or agency relationship
    created between you and us as a result of these Terms and Conditions or use
    of the Site. You agree that these Terms and Conditions will not be
    construed against us by virtue of having drafted them.
</p>
<p>
    You hereby waive any and all defenses you may have based on the electronic
    form of these Terms and Conditions and the lack of signing by the parties
    hereto to execute these Terms and Conditions.
</p>
', 1, N'info@yoursite.com', CAST(N'2021-09-16T15:04:13.950' AS DateTime), N'psheriff@pdsa.com', CAST(N'2021-09-16T15:04:13.953' AS DateTime))
GO
SET IDENTITY_INSERT [Lookup].[SiteTerms] OFF
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'AK', N'Alaska', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'AL', N'Alabama', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'AR', N'Arkansas', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'AZ', N'Arizona', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'CA', N'California', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'CO', N'Colorado', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'CT', N'Connecticut', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'DC', N'District of Columbia', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'DE', N'Delaware', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'FL', N'Florida', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'GA', N'Georgia', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'GU', N'Guam', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'HI', N'Hawaii', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'IA', N'Iowa', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ID', N'Idaho', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'IL', N'Illinois', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'IN', N'Indiana', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'KS', N'Kansas', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'KY', N'Kentucky', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'LA', N'Louisiana', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MA', N'Massachusetts', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MD', N'Maryland', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ME', N'Maine', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MI', N'Michigan', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MN', N'Minnesota', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MO', N'Missouri', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MS', N'Mississippi', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'MT', N'Montana', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NC', N'North Carolina', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'ND', N'North Dakota', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NE', N'Nebraska', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NH', N'New Hampshire', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NJ', N'New Jersey', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NM', N'New Mexico', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NV', N'Nevada', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'NY', N'New York', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'OH', N'Ohio', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'OK', N'Oklahoma', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'OR', N'Oregon', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'PA', N'Pennsylvania', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'PR', N'Puerto Rico', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'RI', N'Rhode Island', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'SC', N'South Carolina', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'SD', N'South Dakota', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'TN', N'Tennessee', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'TX', N'Texas', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'UT', N'Utah', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'VA', N'Virginia', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'VT', N'Vermont', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'WA', N'Washington', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'WI', N'Wisconsin', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'WV', N'West Virginia', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
INSERT [Lookup].[USStateCode] ([StateCode], [StateName], [InsertName], [InsertDate], [UpdateName], [UpdateDate]) VALUES (N'WY', N'Wyoming', N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime), N'dbo', CAST(N'2020-09-17T14:46:13.037' AS DateTime))
GO
