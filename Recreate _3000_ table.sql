USE ChineseStudy
GO

DROP TABLE IF EXISTS
dbo._3000_Characters;
GO

CREATE TABLE dbo._3000_Characters
(ID int NOT NULL PRIMARY KEY IDENTITY (1,1),
FEseq nvarchar(255),
Zhuyin nvarchar(255),
Traditional nvarchar(255),
English nvarchar(255),
Numpinyin nvarchar(255),
CritPinyin nvarchar(255),
Simplified nvarchar(255),
Cji nvarchar(255));
GO