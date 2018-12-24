-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 24, 2018 at 05:23 PM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `goldenstadium`
--

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `empid` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `gender` varchar(6) NOT NULL,
  `address` text NOT NULL,
  `phonenumber` varchar(16) NOT NULL,
  `position` varchar(8) NOT NULL,
  `salary` int(11) NOT NULL,
  `username` varchar(16) NOT NULL,
  `password` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`empid`, `name`, `gender`, `address`, `phonenumber`, `position`, `salary`, `username`, `password`) VALUES
(1, 'Tjokorda', 'Male', 'Depok', '085718223690', 'Admin', 2000000, 'tjokorda', '20041999'),
(21, 'mala', 'Male', 'jasdj', '203902139', 'Employee', 913000, 'bule', 'malacantik'),
(28, 'Wawa', 'Male', 'Cilebut', '123456789', 'Admin', 300000, 'wawski', 'wawskii');

-- --------------------------------------------------------

--
-- Table structure for table `match`
--

CREATE TABLE `match` (
  `matchid` int(11) NOT NULL,
  `matchh` varchar(255) NOT NULL,
  `datee` varchar(20) NOT NULL,
  `timee` varchar(255) NOT NULL,
  `tournament_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `match`
--

INSERT INTO `match` (`matchid`, `matchh`, `datee`, `timee`, `tournament_name`) VALUES
(1, 'PERSIJA vs PERSIPURA', '2018-12-05', '03:12:00', 'Itulahhhssss'),
(3, 'PERSIJA vs PERSIPURA', '2018-12-05', '03:12:00', 'Itulahhh'),
(4, 'PERSIJA vs hehe', '2018-12-05', '03:12:00', 'Itulahhhssss'),
(5, 'DRAKOR vs SINETRON', '24/12/2018', '21:48:00', 'Hehehehe'),
(6, 'Jahanam kau joko', '03/12/2019', '20:19', 'hjwd');

-- --------------------------------------------------------

--
-- Table structure for table `seat`
--

CREATE TABLE `seat` (
  `matchid` int(11) NOT NULL,
  `tribune_name` varchar(255) NOT NULL,
  `gate` varchar(255) NOT NULL,
  `capacity` int(11) NOT NULL,
  `price` float NOT NULL,
  `match_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `seat`
--

INSERT INTO `seat` (`matchid`, `tribune_name`, `gate`, `capacity`, `price`, `match_name`) VALUES
(3, 'ke ', 'gate ', 10, 2000, NULL),
(4, 'ke 4', 'gate 4', 100, 10000, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `transac`
--

CREATE TABLE `transac` (
  `transacid` int(11) NOT NULL,
  `empid` int(11) NOT NULL,
  `matchid` int(11) NOT NULL,
  `total_price` float NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`empid`);

--
-- Indexes for table `match`
--
ALTER TABLE `match`
  ADD PRIMARY KEY (`matchid`);

--
-- Indexes for table `seat`
--
ALTER TABLE `seat`
  ADD KEY `fk_match` (`matchid`);

--
-- Indexes for table `transac`
--
ALTER TABLE `transac`
  ADD PRIMARY KEY (`transacid`),
  ADD KEY `empid` (`empid`),
  ADD KEY `matchid` (`matchid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `empid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `match`
--
ALTER TABLE `match`
  MODIFY `matchid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `transac`
--
ALTER TABLE `transac`
  MODIFY `transacid` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `seat`
--
ALTER TABLE `seat`
  ADD CONSTRAINT `fk_match` FOREIGN KEY (`matchid`) REFERENCES `match` (`matchid`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `transac`
--
ALTER TABLE `transac`
  ADD CONSTRAINT `transac_ibfk_1` FOREIGN KEY (`empid`) REFERENCES `employee` (`empid`),
  ADD CONSTRAINT `transac_ibfk_2` FOREIGN KEY (`matchid`) REFERENCES `match` (`matchid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
