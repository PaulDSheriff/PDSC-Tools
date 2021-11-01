-- Use this SQL to add the PDSC Standard fields to the tables in your database
-- *** IMPORTANT ***
-- In Query Analyzer go to Query | Results in Text (Ctrl-T)
-- also be sure to go to Options | Results and set the maximum column length to 2048
SELECT 'ALTER TABLE ' + rtrim(TABLE_SCHEMA) + '.' + rtrim(TABLE_NAME) + '
ADD InsertName varchar(50) NULL,
InsertDate datetime NULL, 
UpdateName varchar(50) NULL, 
UpdateDate datetime NULL, 
ConcurrencyValue smallint NULL 
Go' + CHAR(10) + 
'ALTER TABLE ' + rtrim(TABLE_SCHEMA) + '.' + rtrim(TABLE_NAME) + ' ADD CONSTRAINT DF_' + rtrim(TABLE_NAME) + '_InsertName DEFAULT (user_name()) FOR InsertName
Go' + CHAR(10) +
'ALTER TABLE ' + rtrim(TABLE_SCHEMA) + '.' + rtrim(TABLE_NAME) + ' ADD CONSTRAINT DF_' + rtrim(TABLE_NAME) + '_InsertDate DEFAULT (getdate()) FOR InsertDate
Go' + CHAR(10) +
'ALTER TABLE ' + rtrim(TABLE_SCHEMA) + '.' + rtrim(TABLE_NAME) + ' ADD CONSTRAINT DF_' + rtrim(TABLE_NAME) + '_UpdateName DEFAULT (user_name()) FOR UpdateName
Go' + CHAR(10) +
'ALTER TABLE ' + rtrim(TABLE_SCHEMA) + '.' + rtrim(TABLE_NAME) + ' ADD CONSTRAINT DF_' + rtrim(TABLE_NAME) + '_UpdateDate DEFAULT (getdate()) FOR UpdateDate
Go' + CHAR(10) +
'ALTER TABLE ' + rtrim(TABLE_SCHEMA) + '.' + rtrim(TABLE_NAME) + ' ADD CONSTRAINT DF_' + rtrim(TABLE_NAME) + '_ConcurrencyValue DEFAULT (1) FOR ConcurrencyValue
Go' + CHAR(10) + 
'UPDATE ' + rtrim(TABLE_SCHEMA) + '.' + rtrim(TABLE_NAME) + '
SET ConcurrencyValue = 1' + '
Go' + Char(10) 
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'