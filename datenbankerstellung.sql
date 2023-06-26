CREATE DATABASE IF NOT EXISTS `telefonbuch` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `telefonbuch`;

CREATE TABLE IF NOT EXISTS `orte` (
  `ortId` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `plz` int DEFAULT NULL,
  PRIMARY KEY (`ortId`)
) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `users` (
  `userId` int NOT NULL AUTO_INCREMENT,
  `vorname` varchar(255) DEFAULT NULL,
  `nachname` varchar(255) DEFAULT NULL,
  `strasse` varchar(255) DEFAULT NULL,
  `telefon` varchar(45) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `ortId` int DEFAULT NULL,
  `hausnummer` int DEFAULT NULL,
  PRIMARY KEY (`userId`)
) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `users` (vorname, nachname, strasse, hausnummer, email, telefon, ortId) VALUES 
('Sarah', 'Schneider', 'Blumenstrasse', 9, 'sarah.schneider@example.com', '1234567890', 2),
('Michael', 'Wagner', 'Lindenallee', 21, 'michael.wagner@example.com', '987654321', 3),
('Laura', 'Becker', 'Feldweg', 7, 'laura.becker@example.com', '456789123', 1),
('Markus', 'Keller', 'Birkenweg', 14, 'markus.keller@example.com', '789123456', 2),
('Julia', 'Hoffmann', 'Rosenweg', 3, 'julia.hoffmann@example.com', '321654987', 3),
('Thomas', 'Schulz', 'Lindengaasse', 11, 'thomas.schulz@example.com', '159357852', 1),
('Anna', 'Schmidt', 'Steinweg', 12, 'anna.schmidt@example.com', '0123456789', 1),
('Max', 'Mueller', 'Hauptstrasse', 5, 'max.mueller@example.com', '9876543210', 2),
('Lisa', 'Meier', 'Bahnhofstrasse', 18, 'lisa.meier@example.com', '555666777', 1),
('Peter', 'Hofmann', 'Gartenweg', 3, 'peter.hofmann@example.com', '111222333', 3);

