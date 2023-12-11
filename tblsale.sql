-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 11, 2023 at 12:14 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hmsdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblsale`
--

CREATE TABLE `tblsale` (
  `sale_id` int(1) NOT NULL,
  `sale_invoice` int(2) DEFAULT NULL,
  `drug_name` varchar(22) DEFAULT NULL,
  `quantity` int(2) DEFAULT NULL,
  `retailprice` int(3) DEFAULT NULL,
  `total` varchar(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `tblsale`
--

INSERT INTO `tblsale` (`sale_id`, `sale_invoice`, `drug_name`, `quantity`, `retailprice`, `total`) VALUES
(1, 0, 'panadol tab 500mg 100s', 12, 310, ''),
(2, 0, 'panadol tab 500mg 100s', 12, 310, ''),
(3, 0, 'panadol tab 500mg 100s', 12, 310, ''),
(4, 13, 'panadol tab 500mg 100s', 12, 310, '310'),
(5, 14, 'brufen', 10, 2, '2'),
(6, 15, 'panadol tab 500mg 100s', 10, 2, '2'),
(7, 16, 'panadol tab 500mg 100s', 10, 2, '2'),
(8, 17, 'panadol tab 500mg 100s', 10, 2, '2'),
(9, 18, 'panadol tab 500mg 100s', 10, 2, '2'),
(10, 19, 'panadol tab 500mg 100s', 10, 2, '2'),
(11, 20, 'panadol tab 500mg 100s', 10, 2, '2'),
(12, 21, 'panadol tab 500mg 100s', 10, 2, '2'),
(13, 22, 'panadol tab 500mg 100s', 10, 2, '20'),
(14, 23, 'panadol tab 500mg 100s', 10, 2, '20'),
(15, 24, 'panadol tab 500mg 100s', 10, 2, '50'),
(16, 24, 'brufen', 15, 2, '50');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblsale`
--
ALTER TABLE `tblsale`
  ADD PRIMARY KEY (`sale_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblsale`
--
ALTER TABLE `tblsale`
  MODIFY `sale_id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
