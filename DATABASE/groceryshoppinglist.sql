-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 09, 2023 at 11:13 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `groceryshoppinglist`
--
CREATE DATABASE IF NOT EXISTS `groceryshoppinglist` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `groceryshoppinglist`;

-- --------------------------------------------------------

--
-- Table structure for table `cat_table`
--

DROP TABLE IF EXISTS `cat_table`;
CREATE TABLE `cat_table` (
  `Id` int(11) NOT NULL,
  `categoryName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `cat_table`:
--

--
-- Dumping data for table `cat_table`
--

INSERT INTO `cat_table` (`Id`, `categoryName`) VALUES
(1, 'Fruit'),
(2, 'Bread and Baked'),
(3, 'Bread and Baked'),
(4, 'Snacks'),
(5, 'Others'),
(6, 'Canned Goods'),
(7, 'Others'),
(8, 'Vegetable'),
(9, 'Meat'),
(10, 'Fruit');

-- --------------------------------------------------------

--
-- Table structure for table `grocerytbl`
--

DROP TABLE IF EXISTS `grocerytbl`;
CREATE TABLE `grocerytbl` (
  `Id` int(11) NOT NULL,
  `gname` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `cat_ID` int(11) NOT NULL,
  `item_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `grocerytbl`:
--   `cat_ID`
--       `cat_table` -> `Id`
--   `item_ID`
--       `item` -> `Id`
--

--
-- Dumping data for table `grocerytbl`
--

INSERT INTO `grocerytbl` (`Id`, `gname`, `date`, `cat_ID`, `item_ID`) VALUES
(1, 'Alfamart', '2023-11-03', 1, 1),
(2, 'Breadtalk', '2023-11-17', 2, 2),
(3, 'Goldilocks', '2023-11-17', 3, 3),
(4, 'Alfamart', '2023-11-30', 4, 4),
(5, 'Super Market', '2023-11-30', 5, 5),
(6, 'Waltermart', '2023-12-02', 6, 6),
(7, '7/11', '2023-12-04', 7, 7),
(8, 'Public Market', '2023-12-07', 8, 8),
(9, 'Public Market', '2023-12-07', 9, 9),
(10, 'Public Market', '2023-12-07', 10, 10);

-- --------------------------------------------------------

--
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
CREATE TABLE `item` (
  `Id` int(11) NOT NULL,
  `itemName` varchar(255) NOT NULL,
  `price` double NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `item`:
--

--
-- Dumping data for table `item`
--

INSERT INTO `item` (`Id`, `itemName`, `price`, `quantity`) VALUES
(1, 'Apple', 24, 2),
(2, 'Morning Egg', 68, 5),
(3, 'Carrot Cake', 298, 1),
(4, 'Piatos', 25, 10),
(5, 'Dress', 1548, 1),
(6, 'Corned Beef', 40, 5),
(7, 'Chocolates', 190, 3),
(8, 'Lettuce', 190, 6),
(9, 'Beef', 200, 2),
(10, 'Strawberry', 190, 2);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE `login` (
  `user_ID` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `Address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- RELATIONSHIPS FOR TABLE `login`:
--

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`user_ID`, `username`, `password`, `fname`, `lname`, `Address`) VALUES
(1, 'admin', 'password', 'group ten', 'database management system', 'grocery mate');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cat_table`
--
ALTER TABLE `cat_table`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `grocerytbl`
--
ALTER TABLE `grocerytbl`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Constraint_FK_Cat_ID` (`cat_ID`),
  ADD KEY `Constraint_FK_item_ID` (`item_ID`);

--
-- Indexes for table `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`user_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cat_table`
--
ALTER TABLE `cat_table`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `grocerytbl`
--
ALTER TABLE `grocerytbl`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `item`
--
ALTER TABLE `item`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `user_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `grocerytbl`
--
ALTER TABLE `grocerytbl`
  ADD CONSTRAINT `Constraint_FK_Cat_ID` FOREIGN KEY (`cat_ID`) REFERENCES `cat_table` (`Id`),
  ADD CONSTRAINT `Constraint_FK_item_ID` FOREIGN KEY (`item_ID`) REFERENCES `item` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
