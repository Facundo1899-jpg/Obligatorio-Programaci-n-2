CREATE TABLE [dbo].[Accounts] (
    [Id]          UNIQUEIDENTIFIER NOT NULL,
    [OwnerId]     INT              NOT NULL,
    [AccountType] SMALLINT         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Accounts_Users] FOREIGN KEY ([OwnerId]) REFERENCES [dbo].[Users] ([Id])
);

