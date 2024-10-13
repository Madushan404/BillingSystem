-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 04, 2024 at 09:21 AM
-- Server version: 8.2.0
-- PHP Version: 8.2.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `details_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `after_p_bill`
--

DROP TABLE IF EXISTS `after_p_bill`;
CREATE TABLE IF NOT EXISTS `after_p_bill` (
  `bill_no` int NOT NULL AUTO_INCREMENT,
  `Date` date NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Ph_Number` int NOT NULL,
  `Total` int NOT NULL,
  PRIMARY KEY (`bill_no`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `after_p_bill_tb`
--

DROP TABLE IF EXISTS `after_p_bill_tb`;
CREATE TABLE IF NOT EXISTS `after_p_bill_tb` (
  `bill_no` int NOT NULL AUTO_INCREMENT,
  `Date` date NOT NULL,
  `Cus_Name` varchar(100) NOT NULL,
  `Phone_nb` int NOT NULL,
  `Total` int NOT NULL,
  PRIMARY KEY (`bill_no`)
) ENGINE=MyISAM AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `after_p_bill_tb`
--

INSERT INTO `after_p_bill_tb` (`bill_no`, `Date`, `Cus_Name`, `Phone_nb`, `Total`) VALUES
(1, '2024-02-12', 'cus1', 771953507, 640),
(2, '2024-02-12', 'cus1', 771953507, 1540),
(3, '2024-02-12', 'cus1', 771953507, 320),
(4, '2024-02-12', 'cus1', 771953507, 640),
(5, '2024-02-16', 'cus2', 789885443, 640),
(6, '2024-02-22', 'cus1', 771953507, 320),
(7, '2024-02-28', 'cus1', 771953507, 320),
(8, '2024-05-04', 'mkas', 710478189, 500),
(9, '2024-05-04', 'cus1', 771953507, 440),
(10, '0000-00-00', 'mkas', 710478189, 500),
(11, '0000-00-00', 'cus1', 771953507, 440),
(12, '0000-00-00', 'cus1', 771953507, 440),
(13, '0000-00-00', 'cus1', 771953507, 440);

-- --------------------------------------------------------

--
-- Table structure for table `bill`
--

DROP TABLE IF EXISTS `bill`;
CREATE TABLE IF NOT EXISTS `bill` (
  `bill_no` int NOT NULL AUTO_INCREMENT,
  `Date` date NOT NULL,
  `Total` int NOT NULL,
  PRIMARY KEY (`bill_no`)
) ENGINE=MyISAM AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bill`
--

INSERT INTO `bill` (`bill_no`, `Date`, `Total`) VALUES
(1, '2024-04-26', 2650),
(2, '2024-04-26', 1424),
(3, '2024-05-04', 440),
(4, '2024-05-04', 440),
(5, '2024-05-04', 440),
(6, '2024-05-04', 440),
(7, '2024-05-04', 440),
(8, '2024-05-04', 440),
(9, '2024-05-04', 1520),
(10, '2024-05-04', 440),
(11, '2024-05-04', 440),
(12, '2024-05-04', 440),
(13, '2024-05-04', 800),
(14, '2024-05-04', 440),
(15, '2024-05-04', 440),
(16, '2024-05-04', 440),
(17, '2024-05-04', 1430),
(18, '2024-05-04', 440);

-- --------------------------------------------------------

--
-- Table structure for table `customer_tb`
--

DROP TABLE IF EXISTS `customer_tb`;
CREATE TABLE IF NOT EXISTS `customer_tb` (
  `Customer_ID` int NOT NULL AUTO_INCREMENT,
  `Customer_Name` varchar(255) NOT NULL,
  `Mobile_Number` int NOT NULL,
  `Other_Details` varchar(255) NOT NULL,
  PRIMARY KEY (`Customer_ID`),
  UNIQUE KEY `Customer_Name` (`Customer_Name`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_tb`
--

INSERT INTO `customer_tb` (`Customer_ID`, `Customer_Name`, `Mobile_Number`, `Other_Details`) VALUES
(1, 'cus1', 771953507, 'Matara'),
(2, 'cus2', 789885443, 'matara 42t4y4y6h'),
(3, 'cus3', 701343099, 'Galle'),
(4, 'cus4', 770722362, ''),
(5, ' cus5', 770722362, ''),
(7, 'gdjgfdj', 771953507, 'cfdvfewvfwrv');

-- --------------------------------------------------------

--
-- Table structure for table `day_item`
--

DROP TABLE IF EXISTS `day_item`;
CREATE TABLE IF NOT EXISTS `day_item` (
  `Item_code` int NOT NULL AUTO_INCREMENT,
  `Item_name` varchar(100) NOT NULL,
  `Price` varchar(20) NOT NULL,
  `Quantity` int NOT NULL,
  PRIMARY KEY (`Item_code`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `day_item`
--

INSERT INTO `day_item` (`Item_code`, `Item_name`, `Price`, `Quantity`) VALUES
(2, 'leaks', '200', 500),
(1, 'carrote', '250', 1500);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
CREATE TABLE IF NOT EXISTS `inventory` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Date` datetime NOT NULL,
  `I_Code` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `Name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Quantity` int NOT NULL,
  `M_Price` int NOT NULL,
  `O_Price` int NOT NULL,
  `active` int NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Name` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=107 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`Id`, `Date`, `I_Code`, `Name`, `Quantity`, `M_Price`, `O_Price`, `active`) VALUES
(105, '2024-05-03 10:26:04', 'CA', 'Carrot', 1753, 250, 220, 1),
(106, '2024-05-03 10:26:04', 'LS', 'Leeks', 466, 200, 180, 1);

-- --------------------------------------------------------

--
-- Table structure for table `item_tb`
--

DROP TABLE IF EXISTS `item_tb`;
CREATE TABLE IF NOT EXISTS `item_tb` (
  `I_Code` varchar(10) COLLATE utf8mb4_general_ci NOT NULL,
  `I_Name` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `I_Name_Sin` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`I_Code`),
  UNIQUE KEY `I_Name` (`I_Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `item_tb`
--

INSERT INTO `item_tb` (`I_Code`, `I_Name`, `I_Name_Sin`) VALUES
('CA', 'Carrot', 'කැරට්'),
('LS', 'Leeks', 'ලීක්ස්');

-- --------------------------------------------------------

--
-- Table structure for table `position_tb`
--

DROP TABLE IF EXISTS `position_tb`;
CREATE TABLE IF NOT EXISTS `position_tb` (
  `po_id` int NOT NULL AUTO_INCREMENT,
  `po_name` varchar(255) NOT NULL,
  PRIMARY KEY (`po_id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `position_tb`
--

INSERT INTO `position_tb` (`po_id`, `po_name`) VALUES
(1, 'Admin'),
(2, 'User');

-- --------------------------------------------------------

--
-- Table structure for table `users_tb`
--

DROP TABLE IF EXISTS `users_tb`;
CREATE TABLE IF NOT EXISTS `users_tb` (
  `user_ID` int NOT NULL AUTO_INCREMENT,
  `Position` int NOT NULL,
  `User_Name` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  PRIMARY KEY (`user_ID`),
  UNIQUE KEY `User_Name` (`User_Name`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users_tb`
--

INSERT INTO `users_tb` (`user_ID`, `Position`, `User_Name`, `Password`) VALUES
(1, 1, 'admin1', 'MjEyNA=='),
(2, 2, 'user1', 'MjEyNA=='),
(3, 1, 'admin2', 'MjEyNA=='),
(5, 2, 'user45', 'ICAgIA=='),
(6, 2, '  userex', 'MjEyNA=='),
(7, 1, 'new', 'MTIzNA=='),
(8, 1, 'Chandika', 'MTExICAg'),
(9, 1, 'gggt', 'MTIz'),
(10, 1, 'ad25', 'MTIz'),
(11, 2, '12fd', 'Y2hhbmRpa2EyMTI0'),
(12, 1, 'us23', 'MTIzY2g='),
(13, 1, 'gfd', 'MTJjaGc='),
(14, 1, 'asff', 'MTIzNDVjaGE='),
(15, 1, 'oshi2', 'MjEyNA=='),
(16, 2, 'bbb', 'MjEyNA=='),
(17, 2, 'fff', 'MjEyNA==');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
