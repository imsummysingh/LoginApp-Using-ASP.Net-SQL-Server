CREATE TABLE [dbo].[LoginTable] (
    [UserID]   INT           IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (50) NULL,
    [Password] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

