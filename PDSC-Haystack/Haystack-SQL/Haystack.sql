USE [Haystack]
GO
/****** Object:  Schema [Haystack]    Script Date: 10/24/2021 8:40:56 AM ******/
CREATE SCHEMA [Haystack]
GO
/****** Object:  Table [Haystack].[DBColumn]    Script Date: 10/24/2021 8:40:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Haystack].[DBColumn](
	[DBColumnId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[DBObjectId] [int] NOT NULL,
	[ColumnName] [varchar](250) NOT NULL,
	[ColumnAlias] [varchar](250) NULL,
	[PrivatePropertyName] [varchar](250) NOT NULL,
	[PublicPropertyName] [varchar](250) NOT NULL,
	[DotNetType] [varchar](50) NOT NULL,
	[DatabaseDataType] [varchar](100) NOT NULL,
	[OrdinalPosition] [int] NULL,
	[UseMaxLength] [bit] NULL,
	[IsSPParameter] [bit] NULL,
	[IsCustomColumn] [bit] NULL,
	[IsDescriptionField] [bit] NULL,
	[IsChecked] [bit] NULL,
	[IsRequired] [bit] NULL,
	[IsMaxColumn] [bit] NULL,
	[RequiredMessage] [varchar](500) NULL,
	[HeaderText] [varchar](100) NOT NULL,
	[DefaultValue] [varchar](100) NULL,
	[ParamValue] [varchar](100) NULL,
	[Tag] [varchar](100) NULL,
	[MinLength] [int] NULL,
	[MinValue] [varchar](50) NULL,
	[MaxValue] [varchar](50) NULL,
	[IsInsertable] [bit] NULL,
	[IsUpdatable] [bit] NULL,
	[IsSelectable] [bit] NULL,
	[IsSearchField] [bit] NULL,
	[IncludeInAuditTracking] [bit] NULL,
	[ReturnNullWhenNull] [bit] NULL,
	[IsConcurrencyField] [bit] NULL,
	[IsStandardField] [bit] NULL,
	[DisplayOrder] [int] NULL,
	[Tooltip] [varchar](80) NULL,
	[GridAttribute] [varchar](500) NULL,
	[EditAttribute] [varchar](500) NULL,
	[DisplayInGrid] [bit] NULL,
	[DisplayInEdit] [bit] NULL,
	[IsFieldReadOnlyOnEdit] [bit] NULL,
	[IsReturnValueInService] [bit] NULL,
	[ColumnAttributes] [varchar](500) NULL,
	[ColumnRegularExpression] [varchar](500) NULL,
	[RegularExpressionMessage] [varchar](255) NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[ConcurrencyValue] [smallint] NULL,
	[HTML5Type] [varchar](12) NULL,
	[MVCMethod] [varchar](20) NULL,
 CONSTRAINT [PK_DataColumn] PRIMARY KEY NONCLUSTERED 
(
	[DBColumnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Haystack].[DBGeneratorStatement]    Script Date: 10/24/2021 8:40:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Haystack].[DBGeneratorStatement](
	[DBGeneratorStatementId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[DBObjectId] [int] NOT NULL,
	[GenerateType] [int] NOT NULL,
	[StatementName] [varchar](250) NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[IsAll] [bit] NULL,
	[IsSearch] [bit] NULL,
	[DynamicSourceCode] [varchar](max) NULL,
	[SPSourceCode] [varchar](max) NULL,
	[StoredProcName] [varchar](250) NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[ConcurrencyValue] [smallint] NULL,
 CONSTRAINT [PK_DBGeneratorStatement] PRIMARY KEY CLUSTERED 
(
	[DBGeneratorStatementId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Haystack].[DBObject]    Script Date: 10/24/2021 8:40:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Haystack].[DBObject](
	[DBObjectId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[TypeOfObject] [int] NOT NULL,
	[TypeToGenerate] [int] NOT NULL,
	[TypeOfPrimaryKey] [int] NOT NULL,
	[CatalogName] [varchar](250) NOT NULL,
	[DBSchemaName] [varchar](250) NOT NULL,
	[DBObjectName] [varchar](250) NOT NULL,
	[DBPackageName] [varchar](250) NULL,
	[DBObjectDescription] [varchar](1000) NOT NULL,
	[DBObjectDescriptionPlural] [varchar](100) NOT NULL,
	[DBObjectClassName] [varchar](100) NOT NULL,
	[EntityToMapTo] [varchar](100) NULL,
	[UsesStandardFields] [bit] NULL,
	[StandardFieldsClassName] [varchar](100) NULL,
	[DoNotGenerateAgain] [bit] NULL,
	[DoNotGenerateComment] [varchar](255) NULL,
	[UseAuditTracking] [bit] NULL,
	[UsesColumnPrefixes] [bit] NULL,
	[ClassUsesDynamicSQL] [bit] NULL,
	[ClassUsesStoredProcs] [bit] NULL,
	[GenViewAsTable] [bit] NULL,
	[GenViewSQL] [bit] NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[ConcurrencyValue] [smallint] NULL,
 CONSTRAINT [PK_DBObject] PRIMARY KEY CLUSTERED 
(
	[DBObjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Haystack].[DBProject]    Script Date: 10/24/2021 8:40:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Haystack].[DBProject](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectName] [varchar](250) NOT NULL,
	[ProjectDescription] [varchar](255) NOT NULL,
	[Author] [varchar](100) NULL,
	[Copyright] [varchar](150) NULL,
	[CompanyName] [varchar](250) NULL,
	[ProjectNamespace] [varchar](100) NOT NULL,
	[PrivateVariablePrefix] [char](5) NOT NULL,
	[DefaultSchemaName] [varchar](30) NULL,
	[GenerationLanguageCode] [char](5) NOT NULL,
	[DBSchemaProviderName] [varchar](50) NOT NULL,
	[ProjectConnectString] [varchar](500) NOT NULL,
	[ProjectSolutionFile] [varchar](500) NULL,
	[ClassNameSuffix] [char](10) NULL,
	[UsePrefixReplacement] [bit] NULL,
	[IsPDSAFrameworkProject] [bit] NULL,
	[RemoveUnderscores] [bit] NULL,
	[WrapIdentifiers] [bit] NULL,
	[PrefixColumnsWithObjectName] [bit] NULL,
	[PrefixObjectsWithSchema] [bit] NULL,
	[PrefixObjectsWithCatalog] [bit] NULL,
	[AutoLoadForiegnKeyTables] [bit] NULL,
	[UseAuditTracking] [bit] NULL,
	[ClassUsesDynamicSQL] [bit] NULL,
	[ClassUsesStoredProcs] [bit] NULL,
	[UseDotNetTypePrefixes] [bit] NULL,
	[UseStandardFields] [bit] NULL,
	[DoNotGenerateAgain] [bit] NULL,
	[ConvertUpperToProperCase] [bit] NULL,
	[DoNotGenerateComment] [varchar](255) NULL,
	[SqlFileExtension] [char](10) NOT NULL,
	[IdentifierPrefix] [char](5) NULL,
	[IdentifierSuffix] [char](5) NULL,
	[GenerationFolder] [varchar](500) NOT NULL,
	[TemplatesFolder] [varchar](500) NOT NULL,
	[XmlFolder] [varchar](500) NOT NULL,
	[XsdFolder] [varchar](500) NOT NULL,
	[SqlGenerateToSubFolder] [varchar](50) NULL,
	[RequiredMessage] [varchar](255) NOT NULL,
	[RegularExpressionMessage] [varchar](255) NULL,
	[UseSeparateAssemblies] [bit] NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[ConcurrencyValue] [smallint] NULL,
	[UseNullableTypes] [bit] NULL,
	[TemplatesToGen] [varchar](150) NULL,
	[UseDataAnnotations] [bit] NULL,
	[AddDataMember] [bit] NULL,
	[UseGlobalization] [bit] NULL,
	[UseDataAccessLayer] [bit] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Haystack].[ProductVersion]    Script Date: 10/24/2021 8:40:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Haystack].[ProductVersion](
	[VersionId] [int] IDENTITY(1,1) NOT NULL,
	[VersionNumber] [numeric](18, 4) NOT NULL,
	[InsertName] [varchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateName] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[ConcurrencyValue] [smallint] NULL,
 CONSTRAINT [PK_Haystack.Version] PRIMARY KEY CLUSTERED 
(
	[VersionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DBColumn]    Script Date: 10/24/2021 8:40:56 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DBColumn] ON [Haystack].[DBColumn]
(
	[ProjectId] ASC,
	[DBObjectId] ASC,
	[ColumnName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DBColumn_CustCol]    Script Date: 10/24/2021 8:40:56 AM ******/
CREATE NONCLUSTERED INDEX [IX_DBColumn_CustCol] ON [Haystack].[DBColumn]
(
	[ProjectId] ASC,
	[DBObjectId] ASC,
	[IsCustomColumn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DBGeneratorStatement_ProjectIdDBObject]    Script Date: 10/24/2021 8:40:56 AM ******/
CREATE NONCLUSTERED INDEX [IX_DBGeneratorStatement_ProjectIdDBObject] ON [Haystack].[DBGeneratorStatement]
(
	[ProjectId] ASC,
	[DBObjectId] ASC,
	[GenerateType] ASC,
	[StatementName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DBObject]    Script Date: 10/24/2021 8:40:56 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_DBObject] ON [Haystack].[DBObject]
(
	[ProjectId] ASC,
	[CatalogName] ASC,
	[DBSchemaName] ASC,
	[DBObjectName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_DBProject_ProjectName]    Script Date: 10/24/2021 8:40:56 AM ******/
CREATE NONCLUSTERED INDEX [IX_DBProject_ProjectName] ON [Haystack].[DBProject]
(
	[ProjectName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [Haystack].[DBColumn] ADD  CONSTRAINT [def_DisplayOrder]  DEFAULT ((0)) FOR [DisplayOrder]
GO
ALTER TABLE [Haystack].[DBColumn] ADD  CONSTRAINT [def_DisplayInGrid]  DEFAULT ((1)) FOR [DisplayInGrid]
GO
ALTER TABLE [Haystack].[DBColumn] ADD  CONSTRAINT [def_DisplayInEdit]  DEFAULT ((1)) FOR [DisplayInEdit]
GO
ALTER TABLE [Haystack].[DBColumn] ADD  CONSTRAINT [def_IsFieldReadOnlyOnEdit]  DEFAULT ((0)) FOR [IsFieldReadOnlyOnEdit]
GO
ALTER TABLE [Haystack].[DBColumn] ADD  CONSTRAINT [def_IsReturnValueInService]  DEFAULT ((0)) FOR [IsReturnValueInService]
GO
ALTER TABLE [Haystack].[DBColumn] ADD  CONSTRAINT [DF__DBColumn__Insert__0F975522]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Haystack].[DBColumn] ADD  CONSTRAINT [DF__DBColumn__Update__108B795B]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Haystack].[DBGeneratorStatement] ADD  CONSTRAINT [DF__DBGenerat__IsAll__0CBAE877]  DEFAULT ((0)) FOR [IsAll]
GO
ALTER TABLE [Haystack].[DBGeneratorStatement] ADD  CONSTRAINT [DF__DBGenerat__Inser__0DAF0CB0]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Haystack].[DBGeneratorStatement] ADD  CONSTRAINT [DF__DBGenerat__Updat__0EA330E9]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Haystack].[DBObject] ADD  CONSTRAINT [DF__DBObject__Insert__0AD2A005]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Haystack].[DBObject] ADD  CONSTRAINT [DF__DBObject__Update__0BC6C43E]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Haystack].[DBProject] ADD  CONSTRAINT [DF__DBProject__Inser__08EA5793]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Haystack].[DBProject] ADD  CONSTRAINT [DF__DBProject__Updat__09DE7BCC]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Haystack].[DBProject] ADD  CONSTRAINT [def_UseNullableTypes]  DEFAULT ((0)) FOR [UseNullableTypes]
GO
ALTER TABLE [Haystack].[DBProject] ADD  CONSTRAINT [DF_DBProject_UseDataAccessLayer]  DEFAULT ((0)) FOR [UseDataAccessLayer]
GO
ALTER TABLE [Haystack].[ProductVersion] ADD  CONSTRAINT [DF__ProductVe__Inser__07020F21]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [Haystack].[ProductVersion] ADD  CONSTRAINT [DF__ProductVe__Updat__07F6335A]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [Haystack].[DBColumn]  WITH CHECK ADD  CONSTRAINT [FK_DBColumn_DBObjectID] FOREIGN KEY([DBObjectId])
REFERENCES [Haystack].[DBObject] ([DBObjectId])
ON DELETE CASCADE
GO
ALTER TABLE [Haystack].[DBColumn] CHECK CONSTRAINT [FK_DBColumn_DBObjectID]
GO
ALTER TABLE [Haystack].[DBGeneratorStatement]  WITH CHECK ADD  CONSTRAINT [FK_DBGeneratorStatement_DBObjectID] FOREIGN KEY([DBObjectId])
REFERENCES [Haystack].[DBObject] ([DBObjectId])
ON DELETE CASCADE
GO
ALTER TABLE [Haystack].[DBGeneratorStatement] CHECK CONSTRAINT [FK_DBGeneratorStatement_DBObjectID]
GO
ALTER TABLE [Haystack].[DBObject]  WITH CHECK ADD  CONSTRAINT [FK_DBObject_Project] FOREIGN KEY([ProjectId])
REFERENCES [Haystack].[DBProject] ([ProjectId])
ON DELETE CASCADE
GO
ALTER TABLE [Haystack].[DBObject] CHECK CONSTRAINT [FK_DBObject_Project]
GO
SET IDENTITY_INSERT [Haystack].[ProductVersion] ON 
GO
INSERT [Haystack].[ProductVersion] ([VersionId], [VersionNumber], [InsertName], [InsertDate], [UpdateName], [UpdateDate], [ConcurrencyValue]) VALUES (1, CAST(1.0000 AS Numeric(18, 4)), N'PDSC', CAST(N'2021-10-23T17:54:40.967' AS DateTime), N'PDSC', CAST(N'2021-10-23T17:54:40.967' AS DateTime), 1)
GO
SET IDENTITY_INSERT [Haystack].[ProductVersion] OFF
GO
