CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `Columns` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `NameColumn` longtext CHARACTER SET utf8mb4 NULL,
    CONSTRAINT `PK_Columns` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Users` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `Name` longtext CHARACTER SET utf8mb4 NOT NULL,
    `Password` longtext CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_Users` PRIMARY KEY (`Id`)
) CHARACTER SET=utf8mb4;

CREATE TABLE `Cards` (
    `Id` int NOT NULL AUTO_INCREMENT,
    `NameCard` longtext CHARACTER SET utf8mb4 NULL,
    `ColumnId` int NOT NULL,
    CONSTRAINT `PK_Cards` PRIMARY KEY (`Id`),
    CONSTRAINT `FK_Cards_Columns_ColumnId` FOREIGN KEY (`ColumnId`) REFERENCES `Columns` (`Id`) ON DELETE CASCADE
) CHARACTER SET=utf8mb4;

INSERT INTO `Columns` (`Id`, `NameColumn`)
VALUES (1, 'test');

INSERT INTO `Users` (`Id`, `Name`, `Password`)
VALUES (1, 'admin', 'qwerty'),
(2, 'tim', 'tim'),
(3, 'user', 'password');

CREATE INDEX `IX_Cards_ColumnId` ON `Cards` (`ColumnId`);

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20230118093458_migrationV1', '7.0.2');

COMMIT;

