USE [PDSCFramework]
GO
/****** Object:  Schema [Lookup]    Script Date: 11/1/2021 2:24:19 PM ******/
CREATE SCHEMA [Lookup]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](75) NOT NULL,
	[EmailAddress] [nvarchar](255) NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CustomerId] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[AspNetUsersId] [nvarchar](450) NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](75) NOT NULL,
	[EmailAddress] [nvarchar](255) NOT NULL,
	[HomePhone] [nvarchar](50) NULL,
	[CellPhone] [nvarchar](50) NOT NULL,
	[Street1] [nvarchar](255) NOT NULL,
	[Street2] [nvarchar](255) NULL,
	[Street3] [nvarchar](255) NULL,
	[City] [nvarchar](100) NOT NULL,
	[Village] [nvarchar](100) NULL,
	[StateCode] [char](2) NULL,
	[ProvinceCode] [char](2) NULL,
	[PostalCode] [nvarchar](50) NOT NULL,
	[CountryCode] [char](3) NOT NULL,
	[SiteTermsId] [int] NULL,
	[DateTermsAccepted] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[OkToSendEmails] [bit] NOT NULL,
	[PersonTypeId] [int] NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PersonId] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[CanadianProvince]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[CanadianProvince](
	[ProvinceCode] [char](2) NOT NULL,
	[ProvinceName] [nvarchar](50) NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_CanadianProvinces] PRIMARY KEY CLUSTERED 
(
	[ProvinceCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[ContactUs]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[ContactUs](
	[ContactUsId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](75) NOT NULL,
	[EmailAddress] [nvarchar](255) NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[ContactText] [nvarchar](max) NOT NULL,
	[IPAddress] [nvarchar](150) NULL,
	[RespondedByName] [nvarchar](50) NULL,
	[RespondedDate] [datetime] NULL,
	[IsActive] [bit] NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ContactUs] PRIMARY KEY CLUSTERED 
(
	[ContactUsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[Country]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[Country](
	[CountryCode] [char](3) NOT NULL,
	[CountryName] [nvarchar](50) NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[EmailTemplate]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[EmailTemplate](
	[EmailTemplateId] [int] IDENTITY(1,1) NOT NULL,
	[EmailTemplateName] [nvarchar](30) NOT NULL,
	[EmailSubject] [nvarchar](100) NOT NULL,
	[EmailTemplateText] [nvarchar](max) NOT NULL,
	[IsBodyHtml] [bit] NULL,
	[InsertName] [nvarchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [nvarchar](50) NULL,
	[UpdateDate] [datetime] NULL,
 CONSTRAINT [PK_EmailTemplate] PRIMARY KEY CLUSTERED 
(
	[EmailTemplateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[FAQ]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[FAQ](
	[FAQId] [int] IDENTITY(1,1) NOT NULL,
	[FAQQuestion] [nvarchar](500) NOT NULL,
	[FAQAnswer] [nvarchar](500) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_FAQ] PRIMARY KEY CLUSTERED 
(
	[FAQId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[LogInfo]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[LogInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NULL,
	[MessageTemplate] [nvarchar](max) NULL,
	[Level] [nvarchar](128) NULL,
	[TimeStamp] [datetime] NOT NULL,
	[Exception] [nvarchar](max) NULL,
	[Properties] [nvarchar](max) NULL,
 CONSTRAINT [PK_LogInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[PersonType]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[PersonType](
	[PersonTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeDescription] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PersonType] PRIMARY KEY CLUSTERED 
(
	[PersonTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[PrivacyPolicy]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[PrivacyPolicy](
	[PrivacyPolicyId] [int] IDENTITY(1,1) NOT NULL,
	[PrivacyText] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PrivacyPolicy] PRIMARY KEY CLUSTERED 
(
	[PrivacyPolicyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[SiteTerms]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[SiteTerms](
	[SiteTermsId] [int] IDENTITY(1,1) NOT NULL,
	[TermsText] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_SiteTerms] PRIMARY KEY CLUSTERED 
(
	[SiteTermsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Lookup].[USStateCode]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Lookup].[USStateCode](
	[StateCode] [char](2) NOT NULL,
	[StateName] [nvarchar](50) NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_USStateCode] PRIMARY KEY CLUSTERED 
(
	[StateCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 11/1/2021 2:24:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 11/1/2021 2:24:19 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 11/1/2021 2:24:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 11/1/2021 2:24:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 11/1/2021 2:24:19 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 11/1/2021 2:24:19 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 11/1/2021 2:24:19 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_OkToSendEmails]  DEFAULT ((1)) FOR [OkToSendEmails]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Lookup].[CanadianProvince] ADD  CONSTRAINT [DF_CanadianProvince_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [Lookup].[CanadianProvince] ADD  CONSTRAINT [DF_CanadianProvince_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Lookup].[CanadianProvince] ADD  CONSTRAINT [DF_CanadianProvince_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [Lookup].[CanadianProvince] ADD  CONSTRAINT [DF_CanadianProvince_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Lookup].[ContactUs] ADD  CONSTRAINT [DF_ContactUs_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [Lookup].[ContactUs] ADD  CONSTRAINT [DF_ContactUs_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [Lookup].[ContactUs] ADD  CONSTRAINT [DF_ContactUs_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Lookup].[ContactUs] ADD  CONSTRAINT [DF_ContactUs_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [Lookup].[ContactUs] ADD  CONSTRAINT [DF_ContactUs_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Lookup].[Country] ADD  CONSTRAINT [DF_Country_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [Lookup].[Country] ADD  CONSTRAINT [DF_Country_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Lookup].[Country] ADD  CONSTRAINT [DF_Country_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [Lookup].[Country] ADD  CONSTRAINT [DF_Country_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Lookup].[EmailTemplate] ADD  CONSTRAINT [DF_EmailTemplate_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [Lookup].[EmailTemplate] ADD  CONSTRAINT [DF_EmailTemplate_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Lookup].[EmailTemplate] ADD  CONSTRAINT [DF_EmailTemplate_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [Lookup].[EmailTemplate] ADD  CONSTRAINT [DF_EmailTemplate_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Lookup].[FAQ] ADD  CONSTRAINT [DF_FAQ_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [Lookup].[FAQ] ADD  CONSTRAINT [DF_FAQ_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [Lookup].[FAQ] ADD  CONSTRAINT [DF_FAQ_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Lookup].[FAQ] ADD  CONSTRAINT [DF_FAQ_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [Lookup].[FAQ] ADD  CONSTRAINT [DF_FAQ_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Lookup].[PersonType] ADD  CONSTRAINT [DF_PersonType_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [Lookup].[PersonType] ADD  CONSTRAINT [DF_PersonType_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [Lookup].[PersonType] ADD  CONSTRAINT [DF_PersonType_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Lookup].[PersonType] ADD  CONSTRAINT [DF_PersonType_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [Lookup].[PersonType] ADD  CONSTRAINT [DF_PersonType_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Lookup].[PrivacyPolicy] ADD  CONSTRAINT [DF_PrivacyPolicy_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [Lookup].[PrivacyPolicy] ADD  CONSTRAINT [DF_PrivacyPolicy_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [Lookup].[PrivacyPolicy] ADD  CONSTRAINT [DF_PrivacyPolicy_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Lookup].[PrivacyPolicy] ADD  CONSTRAINT [DF_PrivacyPolicy_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [Lookup].[PrivacyPolicy] ADD  CONSTRAINT [DF_PrivacyPolicy_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Lookup].[SiteTerms] ADD  CONSTRAINT [DF_SiteTerms_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [Lookup].[SiteTerms] ADD  CONSTRAINT [DF_SiteTerms_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [Lookup].[SiteTerms] ADD  CONSTRAINT [DF_SiteTerms_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Lookup].[SiteTerms] ADD  CONSTRAINT [DF_SiteTerms_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [Lookup].[SiteTerms] ADD  CONSTRAINT [DF_SiteTerms_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Lookup].[USStateCode] ADD  CONSTRAINT [DF_USStateCode_InsertName]  DEFAULT (user_name()) FOR [InsertName]
GO
ALTER TABLE [Lookup].[USStateCode] ADD  CONSTRAINT [DF_USStateCode_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Lookup].[USStateCode] ADD  CONSTRAINT [DF_USStateCode_UpdateName]  DEFAULT (user_name()) FOR [UpdateName]
GO
ALTER TABLE [Lookup].[USStateCode] ADD  CONSTRAINT [DF_USStateCode_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_PersonType] FOREIGN KEY([PersonTypeId])
REFERENCES [Lookup].[PersonType] ([PersonTypeId])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_PersonType]
GO
/****** Object:  StoredProcedure [Lookup].[ContactUsIsDuplicate]    Script Date: 11/1/2021 2:24:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [Lookup].[ContactUsIsDuplicate]
	@FirstName nvarchar(50),
	@LastName nvarchar(75),
	@EmailAddress nvarchar(255),
	@ContactText nvarchar(MAX)
AS
	SELECT COUNT(*) FROM [Lookup].ContactUs
	WHERE FirstName = @FirstName
	AND   LastName = @LastName
	AND   EmailAddress = @EmailAddress
	AND   ContactText = @ContactText;

GO
