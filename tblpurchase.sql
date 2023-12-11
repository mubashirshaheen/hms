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
-- Table structure for table `tblpurchase`
--

CREATE TABLE `tblpurchase` (
  `pur_id` int(2) NOT NULL,
  `invoice` int(2) DEFAULT NULL,
  `drug_name` varchar(22) DEFAULT NULL,
  `batch_no` varchar(6) DEFAULT NULL,
  `exp_date` varchar(10) DEFAULT NULL,
  `quantity` int(3) DEFAULT NULL,
  `tradeprice` int(3) DEFAULT NULL,
  `retailprice` int(3) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `tblpurchase`
--

INSERT INTO `tblpurchase` (`pur_id`, `invoice`, `drug_name`, `batch_no`, `exp_date`, `quantity`, `tradeprice`, `retailprice`) VALUES
(1, 1, 'panadol tab 500mg 100s', 'zxcvbn', '2023-05-03', 100, 240, 310),
(2, 1, 'panadol', '2xcv', '2024-05-01', 12, 85, 100),
(3, 1, 'panadol', '2xcv', '2024-05-01', 12, 85, 100),
(4, 2, 'panadol tab 500mg 100s', 'zxcvbn', '2023-06-15', 100, 240, 310),
(5, 3, 'panadol tab 500mg 100s', 'zxcvbn', '2025-06-11', 11, 236, 310),
(6, 4, 'panadol tab 500mg 100s', 'zxcv', '2025-10-10', 10, 230, 310),
(7, 5, 'panadol tab 500mg 100s', 'zxcv', '2025-10-10', 10, 230, 310),
(8, 6, 'panadol tab 500mg 100s', 'zxcv', '2025-10-16', 10, 230, 310),
(9, 7, 'panadol tab 500mg 100s', 'zxcv', '2025-10-16', 100, 230, 310),
(10, 8, 'panadol tab 500mg 100s', 'zxcv', '2025-10-16', 10, 236, 310),
(11, 9, 'panadol tab 500mg 100s', 'zxcv', '2025-10-16', 10, 250, 310),
(12, 9, 'panadol tab 500mg 100s', 'zxcv', '2024-10-16', 20, 230, 310),
(19, 10, 'panadol tab 500mg 100s', 'zxcv', '2024-12-10', 10, 1, 2),
(20, 11, 'brufen', 'zxcvbn', '2024-12-12', 100, 1, 2);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblpurchase`
--
ALTER TABLE `tblpurchase`
  ADD PRIMARY KEY (`pur_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblpurchase`
--
ALTER TABLE `tblpurchase`
  MODIFY `pur_id` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
