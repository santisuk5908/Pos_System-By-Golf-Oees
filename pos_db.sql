-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 29, 2020 at 11:17 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos_db`
--
CREATE DATABASE IF NOT EXISTS `pos_db` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `pos_db`;

-- --------------------------------------------------------

--
-- Table structure for table `bill_info`
--

CREATE TABLE `bill_info` (
  `IDbill_info` varchar(20) NOT NULL,
  `sell_info` varchar(20) NOT NULL,
  `customer_info` varchar(20) NOT NULL,
  `customeraddrress_info` text NOT NULL,
  `date_info` varchar(50) NOT NULL,
  `many_info` varchar(20) NOT NULL,
  `price_info` varchar(20) NOT NULL,
  `discount_info` varchar(20) NOT NULL,
  `total_info` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bill_info`
--

INSERT INTO `bill_info` (`IDbill_info`, `sell_info`, `customer_info`, `customeraddrress_info`, `date_info`, `many_info`, `price_info`, `discount_info`, `total_info`) VALUES
('ETS-25630428035458', 'สันติสุข', 'นายณัฐพล', '183 หมู่ 10 ต.โนนเจริญ อ.บ้านกรวด จ.บุรีรัมย์ รหัสไปรษณีย์ 31180\r\nโทรศัพท์  063-7604581', '25630428035557', '10', '380', '40', '340'),
('ETS-25630428040121', 'สันติสุข', 'นายณัฐพล', '-', '25630428040229', '6', '70', '10', '60'),
('ETS-25630428040421', 'สันติสุข', 'สันติสุข', '-', '25630428040450', '3', '40', '0', '40'),
('ETS-25630428041813', 'สันติสุข', 'ณัฐพล', '-', '25630428041837', '5', '75', '0', '75'),
('ETS-25630428041947', 'สันติสุข', 'ณัฐพล', '-', '25630428042031', '4', '50', '0', '50'),
('ETS-25630428042228', 'สันติสุข', 'สันติสุข', '183 หมู่ 10 ต.โนนเจริญ อ.บ้านกรวด จ.บุรีรัมย์ รหัสไปรษณีย์ 31180\r\nโทรศัพท์  063-7604581', '25630428042334', '11', '140', '0', '140'),
('ETS-25630428042418', 'สันติสุข', 'ณัฐพล', '-', '25630428042547', '13', '165', '5', '160'),
('ETS-25630428042747', 'สันติสุข', 'Golf', '-', '25630428042823', '2', '25', '20', '5'),
('ETS-25630428195833', 'สันติสุข', 'สาธิต ทองจันทร์', '-', '25630428200033', '3', '35', '0', '35'),
('ETS-25630429032856', 'สันติสุข', 'ณัฐพล', '183 หมู่ 10 ต.โนนเจริญ อ.บ้านกรวด จ.บุรีรัมย์ รหัสไปรษณีย์ 31180\r\nโทรศัพท์  063-7604581', '25630429032958', '4', '40', '5', '35');

-- --------------------------------------------------------

--
-- Table structure for table `chat_group`
--

CREATE TABLE `chat_group` (
  `sender` varchar(50) NOT NULL,
  `receiver` varchar(50) NOT NULL,
  `text` text NOT NULL,
  `datetime` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `chat_group`
--

INSERT INTO `chat_group` (`sender`, `receiver`, `text`, `datetime`) VALUES
(' ', ' ', ' ', ' '),
('สันติสุข1', 'สันติสุข', 'ว้าวววววววววววววววววววววววววววววววววววววววววววววววววววววววววว', '2563-04-29 03:10:01'),
('สุขใจ', 'สันติสุข', 'สวัสดีค้าบ เจ้านาย', '2563-04-29 03:41:53'),
('สันติสุข', 'ณัฐพล', 'สวัสดี', '2563-04-29 03:55:38'),
('ณัฐพล', 'สันติสุข', 'ทำไรรร', '2563-04-29 03:56:01');

-- --------------------------------------------------------

--
-- Table structure for table `list_product`
--

CREATE TABLE `list_product` (
  `name_product` varchar(50) NOT NULL,
  `many_product` varchar(20) NOT NULL,
  `price_product` varchar(20) NOT NULL,
  `count_product` varchar(20) NOT NULL,
  `category_product` varchar(50) NOT NULL,
  `barcode_product` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `list_product`
--

INSERT INTO `list_product` (`name_product`, `many_product`, `price_product`, `count_product`, `category_product`, `barcode_product`) VALUES
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '5', '15', 'เส้น', 'เหล็ก โลหะ', '5630424002825'),
('ข้องอ 6 หน', '2', '10', 'ท่อ', 'ท่อ', '5630426005421'),
('ข้อต่อตรง', '10', '10', 'ชิ้น', 'ท่อ', '5630429035803');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id_login` varchar(10) NOT NULL,
  `user_login` varchar(20) NOT NULL,
  `password_login` varchar(20) NOT NULL,
  `status_login` varchar(11) NOT NULL,
  `name_login` varchar(100) NOT NULL,
  `lastname_login` varchar(100) NOT NULL,
  `address_login` text NOT NULL,
  `tel_login` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id_login`, `user_login`, `password_login`, `status_login`, `name_login`, `lastname_login`, `address_login`, `tel_login`) VALUES
('0003', 'seller', '123456', 'Salesperson', 'พนักงาน', 'พนักงาน', '-', '-'),
('61305', 'admin', '123456', 'Admin', 'สันติสุข', 'พิกุล', 'มหาวิทยาลัยขอนแก่น คณะศึกษาศาสตร์ \r\nสาขาคอมพิวเตอร์ศึกษา', '063-7604581'),
('61306', 'manager', '123456', 'Manager', 'ณัฐพล', 'สุรินทะ', '-', '-'),
('61307', 'สุขใจ', '123456', 'Salesperson', 'สุขใจ', 'มหาขอนแก่น', '-', '-');

-- --------------------------------------------------------

--
-- Table structure for table `product_sell`
--

CREATE TABLE `product_sell` (
  `name_sell` varchar(50) NOT NULL,
  `many_sell` varchar(20) NOT NULL,
  `price_sell` varchar(20) NOT NULL,
  `category_sell` varchar(20) NOT NULL,
  `barcode_sell` varchar(13) NOT NULL,
  `IDbill_sell` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `product_sell`
--

INSERT INTO `product_sell` (`name_sell`, `many_sell`, `price_sell`, `category_sell`, `barcode_sell`, `IDbill_sell`) VALUES
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '2', '30', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428035458'),
('ข้องอ 6 หน', '5', '50', 'ท่อ', '5630426005421', 'ETS-25630428035458'),
('สังกะสี คุณภาพ A', '3', '300', 'วัสดุมุงหลังคา', '5630426011302', 'ETS-25630428035458'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '2', '30', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428040121'),
('ข้องอ 6 หน', '4', '40', 'ท่อ', '5630426005421', 'ETS-25630428040121'),
('ข้องอ 6 หน', '1', '10', 'ท่อ', '5630426005421', 'ETS-25630428040421'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '2', '30', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428040421'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '5', '75', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428041813'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '2', '30', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428041947'),
('ข้องอ 6 หน', '2', '20', 'ท่อ', '5630426005421', 'ETS-25630428041947'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '1', '15', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428042228'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '1', '15', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428042228'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '1', '15', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428042228'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '3', '45', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428042228'),
('ข้องอ 6 หน', '2', '20', 'ท่อ', '5630426005421', 'ETS-25630428042228'),
('ข้องอ 6 หน', '3', '30', 'ท่อ', '5630426005421', 'ETS-25630428042228'),
('ข้องอ 6 หน', '1', '10', 'ท่อ', '5630426005421', 'ETS-25630428042418'),
('ข้องอ 6 หน', '1', '10', 'ท่อ', '5630426005421', 'ETS-25630428042418'),
('ข้องอ 6 หน', '1', '10', 'ท่อ', '5630426005421', 'ETS-25630428042418'),
('ข้องอ 6 หน', '1', '10', 'ท่อ', '5630426005421', 'ETS-25630428042418'),
('ข้องอ 6 หน', '2', '20', 'ท่อ', '5630426005421', 'ETS-25630428042418'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '5', '75', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428042418'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '2', '30', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428042418'),
('ข้องอ 6 หน', '1', '10', 'ท่อ', '5630426005421', 'ETS-25630428042747'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '1', '15', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428042747'),
('เหล็กเส้น 5 มม. (ของดีมหาวิทยาลัยขอนแก่น)', '1', '15', 'เหล็ก โลหะ', '5630424002825', 'ETS-25630428195833'),
('ข้องอ 6 หน', '2', '20', 'ท่อ', '5630426005421', 'ETS-25630428195833'),
('ข้องอ 6 หน', '1', '10', 'ท่อ', '5630426005421', 'ETS-25630429032856'),
('ข้องอ 6 หน', '1', '10', 'ท่อ', '5630426005421', 'ETS-25630429032856'),
('ข้องอ 6 หน', '2', '20', 'ท่อ', '5630426005421', 'ETS-25630429032856');

-- --------------------------------------------------------

--
-- Table structure for table `shop_info`
--

CREATE TABLE `shop_info` (
  `IDshop_info` varchar(10) NOT NULL,
  `IDtex_info` varchar(20) NOT NULL,
  `nameshop_info` varchar(100) NOT NULL,
  `address_info` text NOT NULL,
  `tel_info` varchar(50) NOT NULL,
  `logo_info` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `shop_info`
--

INSERT INTO `shop_info` (`IDshop_info`, `IDtex_info`, `nameshop_info`, `address_info`, `tel_info`, `logo_info`) VALUES
('KKU-40002', '1310800229024', 'มข. เจริญก่อสร้าง', 'เลขที่ 123 มหาวิทยาลัยขอนแก่น ต.ในเมือง อ.เมืองขอนแก่น จ.ขอนแก่น \r\nรหัสไปรษณีย์ 40002', '063-7604581', 'D:\\Project_AJ_Lhin\\logo100x100.png');

-- --------------------------------------------------------

--
-- Table structure for table `type_product`
--

CREATE TABLE `type_product` (
  `ID_product` varchar(3) NOT NULL,
  `type_name` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `type_product`
--

INSERT INTO `type_product` (`ID_product`, `type_name`) VALUES
('001', 'ปูน คอนกรีต'),
('002', 'หิน ทราย'),
('003', 'ท่อ'),
('004', 'พลาสติก พอลิเมอร์'),
('005', 'เหล็ก โลหะ'),
('006', 'เครื่องสุขภัณฑ์'),
('007', 'อุปกรณ์ไฟฟ้า'),
('008', 'กระจก'),
('009', 'ไม้ ไม้อัด'),
('010', 'อิฐ'),
('011', 'เสาปูน'),
('012', 'ถังสี'),
('013', 'วัสดุปูนพื้น'),
('014', 'วัสดุมุงหลังคา'),
('015', 'เบ็ดเตล็ด'),
('099', 'อื่นๆ');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bill_info`
--
ALTER TABLE `bill_info`
  ADD PRIMARY KEY (`IDbill_info`);

--
-- Indexes for table `list_product`
--
ALTER TABLE `list_product`
  ADD PRIMARY KEY (`barcode_product`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD UNIQUE KEY `id_login` (`id_login`);

--
-- Indexes for table `shop_info`
--
ALTER TABLE `shop_info`
  ADD PRIMARY KEY (`IDshop_info`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
