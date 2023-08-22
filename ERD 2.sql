CREATE TABLE `Playlist`(
    `Playlist Id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Name` VARCHAR(255) NOT NULL
);
CREATE TABLE `Song`(
    `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `Title` VARCHAR(255) NOT NULL,
    `Artist` VARCHAR(255) NOT NULL,
    `Album` VARCHAR(255) NOT NULL,
    `Release Date` DATETIME NULL,
    `Genre` VARCHAR(255) NULL,
    `Likes` INT NOT NULL,
    `PlaylistId` INT NULL
);
ALTER TABLE
    `Song` ADD CONSTRAINT `song_playlistid_foreign` FOREIGN KEY(`PlaylistId`) REFERENCES `Playlist`(`Playlist Id`);