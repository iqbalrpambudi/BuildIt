-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 14, 2019 at 09:50 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `build_it`
--

-- --------------------------------------------------------

--
-- Table structure for table `build`
--

CREATE TABLE `build` (
  `id_build` varchar(5) NOT NULL,
  `id_cpu` varchar(5) NOT NULL,
  `id_mobo` varchar(5) NOT NULL,
  `id_ram` varchar(5) NOT NULL,
  `id_gpu` varchar(5) NOT NULL,
  `id_hdd` varchar(5) NOT NULL,
  `id_cases` varchar(5) NOT NULL,
  `username` varchar(12) NOT NULL,
  `harga` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `build`
--

INSERT INTO `build` (`id_build`, `id_cpu`, `id_mobo`, `id_ram`, `id_gpu`, `id_hdd`, `id_cases`, `username`, `harga`) VALUES
('1', '02', '01', '01', '01', '02', '02', 'iqbal', ''),
('2', '01', '01', '03', '01', '01', '03', 'user', ''),
('3', '02', '02', '01', '02', '02', '03', 'amikom', '');

-- --------------------------------------------------------

--
-- Table structure for table `cases`
--

CREATE TABLE `cases` (
  `id` varchar(5) NOT NULL,
  `nama` varchar(125) NOT NULL,
  `vendor` varchar(125) NOT NULL,
  `harga` decimal(10,0) NOT NULL,
  `deskripsi` varchar(130) NOT NULL,
  `url` varchar(130) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cases`
--

INSERT INTO `cases` (`id`, `nama`, `vendor`, `harga`, `deskripsi`, `url`) VALUES
('01', 'Armageddon', 'Power Logic', '415000', 'Case model modern yang kokoh untuk digunakan. dilengkapi dengan ventilasi yang baik untuk sirkulasi udara yg baik', 'D:\\Buildit\\Build it\\Asset\\case\\powerlogic.png'),
('02', 'SIM V-2922', 'Simbadda', '265000', 'Casing murah dan kokoh, cukup dengan harga 200 an sudah bisa bawa casing ini dilengkapi power supply 380W', 'D:\\Buildit\\Build it\\Asset\\case\\simbadda.png'),
('03', 'Carbide SPEC-06', 'Corsair', '1450000', 'Casing dengan desain yang stylish dan kokoh, buat PC kami semakin keren dengan Casing ini', 'D:\\Buildit\\Build it\\Asset\\case\\corsair.png');

-- --------------------------------------------------------

--
-- Table structure for table `cpu`
--

CREATE TABLE `cpu` (
  `id` varchar(5) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `vendor` varchar(15) NOT NULL,
  `soket` varchar(15) NOT NULL,
  `harga` int(25) NOT NULL,
  `deskripsi` varchar(125) NOT NULL,
  `url` varchar(125) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cpu`
--

INSERT INTO `cpu` (`id`, `nama`, `vendor`, `soket`, `harga`, `deskripsi`, `url`) VALUES
('01', 'Intel Core i7-8700K', 'Intel', 'LGA1151', 7000000, 'Varian prosesor intel yang ditujukan untuk PC/Laptop dengan spesifikasi menengah ke atas.', 'D:\\Buildit\\Build it\\Asset\\cpu\\corei7.png'),
('02', 'Intel Core 2 Duo', 'Intel', 'LGA775', 500000, 'Prosesor dengan 2 core, harganya yang murah menjadi salah satu pertimbangan untuk merakit PC degan spesifikasi yang menengah', 'D:\\Buildit\\Build it\\Asset\\cpu\\core2duo.png'),
('03', 'AMD Ryzen 5 Raven Ridge', 'AMD', 'AM4', 3000000, 'Prosesor AMD Seri A yang menawarkan kinerja yang optimal dengan harga yang kompetitif', 'D:\\Buildit\\Build it\\Asset\\cpu\\ryzen5.png');

-- --------------------------------------------------------

--
-- Table structure for table `gpu`
--

CREATE TABLE `gpu` (
  `id` varchar(5) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `vendor` varchar(25) NOT NULL,
  `tipe` varchar(20) NOT NULL,
  `harga` decimal(10,0) NOT NULL,
  `deskripsi` varchar(250) NOT NULL,
  `url` varchar(125) NOT NULL,
  `slot` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `gpu`
--

INSERT INTO `gpu` (`id`, `nama`, `vendor`, `tipe`, `harga`, `deskripsi`, `url`, `slot`) VALUES
('01', 'NVidia GeForce GTX950', 'NVidia', 'DDR5', '1770000', 'Vga keluaran Nvidia yang cocok untuk kebutuhan PC dengan pekerjaan yang berat', 'D:\\Buildit\\Build it\\Asset\\gpu\\geforce950.png', 'PCI'),
('02', 'Asus Radeon R5 230 2GB', 'Asus', 'DDR3', '530000', 'Varian rendah untuk motherboard LGA775', 'D:\\Buildit\\Build it\\Asset\\gpu\\amdr5.png', 'PCI'),
('03', 'GALAX GeForce GT 1030 2GB', 'NVidia', 'DDR5', '1250000', 'GPU versi mid end yang cocok digunakan untuk kebutuhan sehari hari seperti game ringan, editing editing dan lain-lain. Dengan harga yang cukup kompetitif dan spesifikasi yang mumpuni', 'D:\\Buildit\\Build it\\Asset\\gpu\\galax1030.png', 'PCI');

-- --------------------------------------------------------

--
-- Table structure for table `hdd`
--

CREATE TABLE `hdd` (
  `id` varchar(5) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `vendor` varchar(25) NOT NULL,
  `kapasitas` varchar(5) NOT NULL,
  `deskripsi` varchar(125) NOT NULL,
  `harga` decimal(10,0) NOT NULL,
  `url` varchar(150) NOT NULL,
  `tipe` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `hdd`
--

INSERT INTO `hdd` (`id`, `nama`, `vendor`, `kapasitas`, `deskripsi`, `harga`, `url`, `tipe`) VALUES
('01', 'WDC Black SSD', 'WD', '500GB', 'SSD buatan WD dengan kapasitas 500GB dan akses super cepat. Menunjang kecepatan pengiriman data yang super cepat', '2500000', 'D:\\Buildit\\Build it\\Asset\\hdd\\wdcssd.png', 'SSD'),
('02', 'Seagate HDD', 'Seagate', '1TB', 'Hardisk ini dapat menyimpan data hingga 1 Terrabyte dengan teknologi dari Seagate semua data digital dapat disimpan.', '800000', 'D:\\Buildit\\Build it\\Asset\\hdd\\seagate.png', 'SATA'),
('03', 'SanDisk 3D SSD', 'SanDisk', '256GB', 'SSD dengan teknologi terbaru dan akses super cepat. Cocok untuk pengguna dengan kebutuhan akses data cepat.', '1000000', 'D:\\Buildit\\Build it\\Asset\\hdd\\sandiskssd.png', 'SSD');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(12) NOT NULL,
  `password` varchar(12) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `nama`, `email`) VALUES
('admin', '123', 'admin', 'admin'),
('amikom', '123', 'amikom', 'amikom@amikom.ac.id'),
('D', '123', 'D', 'D'),
('edo1226', 'amikom', 'edo', 'edo.1226@students.amikom.ac.id'),
('iqbal', 'amikom', 'iqbal', 'iqbalrpambudi@gmail.com'),
('user', 'user', 'user', 'user@user');

-- --------------------------------------------------------

--
-- Table structure for table `mobo`
--

CREATE TABLE `mobo` (
  `id` varchar(5) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `vendor` varchar(25) NOT NULL,
  `soket` varchar(10) NOT NULL,
  `slot` varchar(5) NOT NULL,
  `storage` varchar(5) NOT NULL,
  `pci` varchar(5) NOT NULL,
  `deskripsi` varchar(125) NOT NULL,
  `harga` decimal(10,0) NOT NULL,
  `url` varchar(130) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `mobo`
--

INSERT INTO `mobo` (`id`, `nama`, `vendor`, `soket`, `slot`, `storage`, `pci`, `deskripsi`, `harga`, `url`) VALUES
('01', 'AsRock Z390 Phantom', 'AsRock', 'LGA1151', 'DDR4', 'SSD', 'DDR5', 'Motherboard yang tangguh untuk kebutuhan gaming dan rendering, motherboard ini dikhususkan untuk gaming kelas berat.', '2500000', 'D:\\Buildit\\Build it\\Asset\\mobo\\asrock.png'),
('02', 'Gigabyte GA-G41M-Combo', 'Gigabyte', 'LGA775', 'DDR3', 'SATA', 'DDR3', 'Motherboard soket LGA775 kompatibel dengan cpu Core 2 Duo dengan spesifikasi menengah', '1230000', 'D:\\Buildit\\Build it\\Asset\\mobo\\gigabyte.png'),
('03', 'MSI B450 Tomahawk', 'MSI', 'AM4', 'DDR4', 'SATA', 'DDR5', 'Mothermoard khusus prosesor AMD yang handal dan tangguh. Cocok untuk gaming kelas menengah keatas', '2250000', 'D:\\Buildit\\Build it\\Asset\\mobo\\msi.png');

-- --------------------------------------------------------

--
-- Table structure for table `ram`
--

CREATE TABLE `ram` (
  `id` varchar(5) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `vendor` varchar(25) NOT NULL,
  `tipe` varchar(5) NOT NULL,
  `kapasitas` varchar(5) NOT NULL,
  `url` varchar(125) NOT NULL,
  `deskripsi` varchar(130) NOT NULL,
  `harga` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ram`
--

INSERT INTO `ram` (`id`, `nama`, `vendor`, `tipe`, `kapasitas`, `url`, `deskripsi`, `harga`) VALUES
('01', 'Vgen', 'Vgen', 'DDR3', '4GB', 'D:\\Buildit\\Build it\\Asset\\ram\\vgenddr21gb.png', 'Ram dengan kapasitas 4GB yang membuat proses multitasking mu menjadi lebih leluasa', '500000'),
('02', 'Hynix', 'Hynix', 'DDR3', '2GB', 'D:\\Buildit\\Build it\\Asset\\ram\\hynixddr32gb.png', 'RAM dengan kapasitas 2GB yang cocok untuk kebutuhan sedang sedang saja untuk sehari hari', '250000'),
('03', 'Vengeance', 'Corsair', 'DDR4', '4GB', 'D:\\Buildit\\Build it\\Asset\\ram\\vengeanceddr34gb.png', 'RAM dengan teknologi terbaik, didukung dengan kecepatan akses data yang cpat', '550000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `build`
--
ALTER TABLE `build`
  ADD PRIMARY KEY (`id_build`),
  ADD KEY `id_cpu` (`id_cpu`),
  ADD KEY `id_hdd` (`id_hdd`),
  ADD KEY `id_ram` (`id_ram`),
  ADD KEY `id_mobo` (`id_mobo`),
  ADD KEY `id_gpu` (`id_gpu`),
  ADD KEY `username` (`username`),
  ADD KEY `id_cases` (`id_cases`);

--
-- Indexes for table `cases`
--
ALTER TABLE `cases`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `cpu`
--
ALTER TABLE `cpu`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `gpu`
--
ALTER TABLE `gpu`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `hdd`
--
ALTER TABLE `hdd`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `mobo`
--
ALTER TABLE `mobo`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pci` (`pci`),
  ADD KEY `slot` (`slot`),
  ADD KEY `soket` (`soket`),
  ADD KEY `storage` (`storage`);

--
-- Indexes for table `ram`
--
ALTER TABLE `ram`
  ADD PRIMARY KEY (`id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `build`
--
ALTER TABLE `build`
  ADD CONSTRAINT `build_ibfk_1` FOREIGN KEY (`id_cpu`) REFERENCES `cpu` (`id`),
  ADD CONSTRAINT `build_ibfk_2` FOREIGN KEY (`id_hdd`) REFERENCES `hdd` (`id`),
  ADD CONSTRAINT `build_ibfk_3` FOREIGN KEY (`id_ram`) REFERENCES `ram` (`id`),
  ADD CONSTRAINT `build_ibfk_4` FOREIGN KEY (`id_mobo`) REFERENCES `mobo` (`id`),
  ADD CONSTRAINT `build_ibfk_5` FOREIGN KEY (`id_gpu`) REFERENCES `gpu` (`id`),
  ADD CONSTRAINT `build_ibfk_6` FOREIGN KEY (`username`) REFERENCES `login` (`username`),
  ADD CONSTRAINT `build_ibfk_7` FOREIGN KEY (`id_cases`) REFERENCES `cases` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
