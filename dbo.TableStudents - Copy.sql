CREATE TABLE [dbo].[Students] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)   NOT NULL,
    [IndexNumber] NVARCHAR (50)   NOT NULL,
    [AverageMark] DECIMAL (16, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

