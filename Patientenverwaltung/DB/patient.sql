-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Erstellungszeit: 14. Feb 2019 um 15:15
-- Server-Version: 5.6.24
-- PHP-Version: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Datenbank: `db_patienverwaltung`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `patient`
--

CREATE TABLE IF NOT EXISTS `patient` (
  `id_patient` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `vorname` varchar(255) NOT NULL,
  `adresse` varchar(255) DEFAULT NULL,
  `versicherungsnummer` int(11) NOT NULL,
  `geschlecht` varchar(1) DEFAULT NULL,
  `geburtstag` date DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `patient`
--

INSERT INTO `patient` (`id_patient`, `name`, `vorname`, `adresse`, `versicherungsnummer`, `geschlecht`, `geburtstag`) VALUES
(1, 'Penelopa', 'Kruz', 'Hozweg 5', 2147483647, 'w', NULL),
(2, 'ertz', 'etz', 'etrz', 555, 'w', NULL),
(3, 'Aaaaaa', 'Bbbbb', 'Adresse', 55555, 'm', '0000-00-00'),
(4, 'Aaaaaa', 'Bbbbb', 'Adresse', 55555, 'm', '2019-02-13'),
(5, 'Aaaaaa', 'Bbbbb', 'Adresse', 555551, 'm', '2019-02-14'),
(6, 'Aaaaaa', 'Bbbbb', 'Adresse', 55555, 'm', '2019-02-14'),
(7, 'Aaaaaa', 'Bbbbb', 'Adresse', 55555, 'm', '2019-02-14'),
(8, 'Aaaaaa', 'Bbbbb', 'Adresse', 55555, 'm', '2019-02-14');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`id_patient`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `patient`
--
ALTER TABLE `patient`
  MODIFY `id_patient` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=9;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
