IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Employee] (
    [ID] int NOT NULL IDENTITY,
    [name] nvarchar(130) NOT NULL,
    [position] nvarchar(80) NOT NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [Room] (
    [ID] int NOT NULL IDENTITY,
    [name] nvarchar(80) NOT NULL,
    [description] nvarchar(300) NOT NULL,
    [capacity] int NOT NULL,
    [isEnable] bit NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY ([ID])
);
GO

CREATE TABLE [Reservation] (
    [ID] int NOT NULL IDENTITY,
    [date] datetime2 NOT NULL,
    [RoomId] int NOT NULL,
    [EmployeeId] int NOT NULL,
    CONSTRAINT [PK_Reservation] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Reservation_Employee_EmployeeId] FOREIGN KEY ([EmployeeId]) REFERENCES [Employee] ([ID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Reservation_Room_RoomId] FOREIGN KEY ([RoomId]) REFERENCES [Room] ([ID]) ON DELETE CASCADE
);
GO

CREATE TABLE [Assistant] (
    [ID] int NOT NULL IDENTITY,
    [isAttend] bit NOT NULL,
    [ReservationId] int NOT NULL,
    CONSTRAINT [PK_Assistant] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Assistant_Reservation_ReservationId] FOREIGN KEY ([ReservationId]) REFERENCES [Reservation] ([ID]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Assistant_ReservationId] ON [Assistant] ([ReservationId]);
GO

CREATE INDEX [IX_Reservation_EmployeeId] ON [Reservation] ([EmployeeId]);
GO

CREATE INDEX [IX_Reservation_RoomId] ON [Reservation] ([RoomId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220726180210_InitialMigration', N'6.0.7');
GO

COMMIT;
GO

