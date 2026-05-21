-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 21, 2026 at 07:49 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbminipemvis`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbdetail_pembelian`
--

CREATE TABLE `tbdetail_pembelian` (
  `id_detail_pembelian` varchar(16) NOT NULL,
  `id_pembelian` varchar(16) NOT NULL,
  `id_produk` varchar(16) NOT NULL,
  `jumlah_barang` int(11) NOT NULL,
  `harga_pembelian` decimal(15,2) NOT NULL,
  `subtotal_pembelian` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbdetail_pembelian`
--

INSERT INTO `tbdetail_pembelian` (`id_detail_pembelian`, `id_pembelian`, `id_produk`, `jumlah_barang`, `harga_pembelian`, `subtotal_pembelian`) VALUES
('DTP001', 'PMB001', 'PRD001', 100, 2500.00, 250000.00),
('DTP002', 'PMB001', 'PRD002', 125, 2000.00, 250000.00),
('DTP003', 'PMB002', 'PRD004', 10, 60000.00, 600000.00),
('DTP004', 'PMB002', 'PRD003', 50, 3000.00, 150000.00),
('DTP005', 'PMB003', 'PRD005', 25, 12000.00, 300000.00),
('DTP2026052123380', 'PMB2026052123380', 'PRD001', 10, 2500.00, 25000.00),
('DTP2026052123393', 'PMB2026052123393', 'PRD005', 10, 12000.00, 120000.00),
('DTP2026052123395', 'PMB2026052123395', 'PRD001', 10, 2500.00, 25000.00),
('DTP2026052123414', 'PMB2026052123414', 'PRD001', 1, 2500.00, 2500.00),
('DTP2026052201150', 'PMB2026052201150', 'PRD001', 1, 2500.00, 2500.00),
('DTP2026052201173', 'PMB2026052201173', 'PRD001', 10, 2500.00, 25000.00),
('DTP2026052201174', 'PMB2026052201174', 'PRD001', 10, 2500.00, 25000.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbdetail_penjualan`
--

CREATE TABLE `tbdetail_penjualan` (
  `id_detail_penjualan` varchar(16) NOT NULL,
  `id_penjualan` varchar(16) NOT NULL,
  `id_produk` varchar(16) NOT NULL,
  `jumlah_barang` int(11) NOT NULL,
  `harga_jual` decimal(15,2) NOT NULL,
  `subtotal_penjualan` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbdetail_penjualan`
--

INSERT INTO `tbdetail_penjualan` (`id_detail_penjualan`, `id_penjualan`, `id_produk`, `jumlah_barang`, `harga_jual`, `subtotal_penjualan`) VALUES
('DTJ001', 'PNJ001', 'PRD001', 5, 3500.00, 17500.00),
('DTJ002', 'PNJ001', 'PRD002', 5, 3000.00, 15000.00),
('DTJ003', 'PNJ001', 'PRD003', 5, 4500.00, 22500.00),
('DTJ004', 'PNJ002', 'PRD004', 1, 70000.00, 70000.00),
('DTJ005', 'PNJ002', 'PRD005', 1, 15000.00, 15000.00),
('DTJ006', 'PNJ003', 'PRD001', 10, 3500.00, 35000.00),
('DTJ007', 'PNJ003', 'PRD002', 15, 3000.00, 45000.00),
('DTJ008', 'PNJ003', 'PRD003', 10, 4500.00, 45000.00),
('DTJ009', 'PNJ003', 'PRD005', 1, 15000.00, 15000.00),
('DTJ2026052121033', 'PNJ004', 'PRD002', 10, 3000.00, 30000.00),
('DTJ2026052121334', 'PNJ005', 'PRD001', 10, 3500.00, 35000.00),
('DTJ2026052121403', 'PNJ006', 'PRD001', 1, 3500.00, 3500.00),
('DTJ2026052121450', 'PNJ007', 'PRD004', 1, 70000.00, 70000.00),
('DTJ2026052121492', 'PNJ008', 'PRD005', 1, 15000.00, 15000.00),
('DTJ2026052121521', 'PNJ009', 'PRD001', 1, 3500.00, 3500.00),
('DTJ2026052121565', 'PNJ010', 'PRD002', 1, 3000.00, 3000.00),
('DTJ2026052123162', 'PNJ011', 'PRD004', 1, 70000.00, 70000.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbkaryawan`
--

CREATE TABLE `tbkaryawan` (
  `id_karyawan` varchar(10) NOT NULL,
  `nama_karyawan` varchar(64) NOT NULL,
  `username` varchar(64) NOT NULL,
  `password` varchar(64) NOT NULL,
  `jabatan` varchar(32) NOT NULL,
  `telepon_karyawan` varchar(16) NOT NULL,
  `shift` varchar(16) NOT NULL DEFAULT 'Morning',
  `gaji_bersih` decimal(15,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbkaryawan`
--

INSERT INTO `tbkaryawan` (`id_karyawan`, `nama_karyawan`, `username`, `password`, `jabatan`, `telepon_karyawan`, `shift`, `gaji_bersih`) VALUES
('KAR001', 'Britama', 'tama', 'tama1', 'Kasir', '0845', 'Morning', 3000000.00),
('KAR002', 'Hermawan', 'much', 'much2', 'Kasir', '0812', 'Night', 3000000.00),
('KAR003', 'Dimas', 'dims', 'dims3', 'Manager', '0890', '', 5000000.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbproduk`
--

CREATE TABLE `tbproduk` (
  `id_produk` varchar(16) NOT NULL,
  `id_supplier` varchar(10) NOT NULL,
  `nama_produk` varchar(64) NOT NULL,
  `stok` int(11) NOT NULL,
  `stok_minimum` int(11) NOT NULL,
  `harga_beli` decimal(15,2) NOT NULL,
  `harga_jual` decimal(15,2) NOT NULL,
  `kategori` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbproduk`
--

INSERT INTO `tbproduk` (`id_produk`, `id_supplier`, `nama_produk`, `stok`, `stok_minimum`, `harga_beli`, `harga_jual`, `kategori`) VALUES
('PRD001', 'SUP001', 'Mie ayam', 143, 20, 2500.00, 3500.00, 'Makanan'),
('PRD002', 'SUP001', 'Akua', 162, 30, 2000.00, 3000.00, 'Minuman'),
('PRD003', 'SUP002', 'Teh kaleng', 81, 15, 3000.00, 4500.00, 'Minuman'),
('PRD004', 'SUP002', 'Beras', 39, 10, 60000.00, 70000.00, 'Sembako'),
('PRD005', 'SUP003', 'Gula Pasir', 69, 15, 12000.00, 15000.00, 'Sembako');

-- --------------------------------------------------------

--
-- Table structure for table `tbsupplier`
--

CREATE TABLE `tbsupplier` (
  `id_supplier` varchar(10) NOT NULL,
  `nama_supplier` varchar(64) NOT NULL,
  `alamat` varchar(64) NOT NULL,
  `telepon_supplier` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbsupplier`
--

INSERT INTO `tbsupplier` (`id_supplier`, `nama_supplier`, `alamat`, `telepon_supplier`) VALUES
('SUP001', 'suplier kacangg', 'jalan pramuka', '0899'),
('SUP002', 'fahyi', 'loa janan', '0822'),
('SUP003', 'rikoh', 'maf', '0868');

-- --------------------------------------------------------

--
-- Table structure for table `tbtransaksi_pembelian`
--

CREATE TABLE `tbtransaksi_pembelian` (
  `id_pembelian` varchar(16) NOT NULL,
  `tanggal_pembelian` date NOT NULL,
  `id_supplier` varchar(10) NOT NULL,
  `id_karyawan` varchar(10) NOT NULL,
  `total_harga_pembelian` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbtransaksi_pembelian`
--

INSERT INTO `tbtransaksi_pembelian` (`id_pembelian`, `tanggal_pembelian`, `id_supplier`, `id_karyawan`, `total_harga_pembelian`) VALUES
('PMB001', '2026-05-10', 'SUP001', 'KAR003', 500000.00),
('PMB002', '2026-05-11', 'SUP002', 'KAR003', 750000.00),
('PMB003', '2026-05-12', 'SUP003', 'KAR001', 300000.00),
('PMB2026052123380', '2026-05-21', 'SUP001', 'KAR003', 45000.00),
('PMB2026052123393', '2026-05-21', 'SUP003', 'KAR003', 120000.00),
('PMB2026052123395', '2026-05-21', 'SUP001', 'KAR003', 45000.00),
('PMB2026052123414', '2026-05-21', 'SUP001', 'KAR003', 4500.00),
('PMB2026052200101', '2026-05-22', 'SUP001', 'KAR003', 100000.00),
('PMB2026052200104', '2026-05-22', 'SUP001', 'KAR003', 80000.00),
('PMB2026052200590', '2026-05-22', 'SUP002', 'KAR003', 63000.00),
('PMB2026052201005', '2026-05-22', 'SUP001', 'KAR003', 4500.00),
('PMB2026052201115', '2026-05-22', 'SUP001', 'KAR003', 4500.00),
('PMB2026052201123', '2026-05-22', 'SUP001', 'KAR003', 45000.00),
('PMB2026052201134', '2026-05-22', 'SUP001', 'KAR003', 2500.00),
('PMB2026052201150', '2026-05-22', 'SUP001', 'KAR003', 2500.00),
('PMB2026052201173', '2026-05-22', 'SUP001', 'KAR003', 25000.00),
('PMB2026052201174', '2026-05-22', 'SUP001', 'KAR003', 45000.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbtransaksi_penjualan`
--

CREATE TABLE `tbtransaksi_penjualan` (
  `id_penjualan` varchar(16) NOT NULL,
  `tanggal_penjualan` date NOT NULL,
  `id_karyawan` varchar(10) NOT NULL,
  `total_harga_penjualan` decimal(15,2) NOT NULL,
  `bayar` decimal(15,2) NOT NULL,
  `kembalian` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbtransaksi_penjualan`
--

INSERT INTO `tbtransaksi_penjualan` (`id_penjualan`, `tanggal_penjualan`, `id_karyawan`, `total_harga_penjualan`, `bayar`, `kembalian`) VALUES
('PNJ001', '2026-05-13', 'KAR002', 55000.00, 60000.00, 5000.00),
('PNJ002', '2026-05-14', 'KAR002', 85000.00, 100000.00, 15000.00),
('PNJ003', '2026-05-15', 'KAR001', 140000.00, 150000.00, 10000.00),
('PNJ004', '2026-05-21', 'KAR001', 30000.00, 30000.00, 0.00),
('PNJ005', '2026-05-21', 'KAR001', 35000.00, 35000.00, 0.00),
('PNJ006', '2026-05-21', 'KAR001', 3500.00, 3500.00, 0.00),
('PNJ007', '2026-05-21', 'KAR001', 70000.00, 70000.00, 0.00),
('PNJ008', '2026-05-21', 'KAR001', 15000.00, 15000.00, 0.00),
('PNJ009', '2026-05-21', 'KAR001', 3500.00, 3500.00, 0.00),
('PNJ010', '2026-05-21', 'KAR001', 3000.00, 3000.00, 0.00),
('PNJ011', '2026-05-21', 'KAR001', 70000.00, 70000.00, 0.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbdetail_pembelian`
--
ALTER TABLE `tbdetail_pembelian`
  ADD PRIMARY KEY (`id_detail_pembelian`),
  ADD KEY `dtpnej` (`id_pembelian`),
  ADD KEY `dtpemb` (`id_produk`);

--
-- Indexes for table `tbdetail_penjualan`
--
ALTER TABLE `tbdetail_penjualan`
  ADD PRIMARY KEY (`id_detail_penjualan`),
  ADD KEY `dtpenjualan` (`id_penjualan`),
  ADD KEY `dtpenju` (`id_produk`);

--
-- Indexes for table `tbkaryawan`
--
ALTER TABLE `tbkaryawan`
  ADD PRIMARY KEY (`id_karyawan`);

--
-- Indexes for table `tbproduk`
--
ALTER TABLE `tbproduk`
  ADD PRIMARY KEY (`id_produk`),
  ADD KEY `id_supplier` (`id_supplier`);

--
-- Indexes for table `tbsupplier`
--
ALTER TABLE `tbsupplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indexes for table `tbtransaksi_pembelian`
--
ALTER TABLE `tbtransaksi_pembelian`
  ADD PRIMARY KEY (`id_pembelian`),
  ADD KEY `id_karyawan` (`id_karyawan`),
  ADD KEY `id_supplier` (`id_supplier`);

--
-- Indexes for table `tbtransaksi_penjualan`
--
ALTER TABLE `tbtransaksi_penjualan`
  ADD PRIMARY KEY (`id_penjualan`),
  ADD KEY `id_karyawan` (`id_karyawan`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbdetail_pembelian`
--
ALTER TABLE `tbdetail_pembelian`
  ADD CONSTRAINT `dtpemb` FOREIGN KEY (`id_produk`) REFERENCES `tbproduk` (`id_produk`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `dtpnej` FOREIGN KEY (`id_pembelian`) REFERENCES `tbtransaksi_pembelian` (`id_pembelian`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbdetail_penjualan`
--
ALTER TABLE `tbdetail_penjualan`
  ADD CONSTRAINT `dtpenju` FOREIGN KEY (`id_produk`) REFERENCES `tbproduk` (`id_produk`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `dtpenjualan` FOREIGN KEY (`id_penjualan`) REFERENCES `tbtransaksi_penjualan` (`id_penjualan`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbproduk`
--
ALTER TABLE `tbproduk`
  ADD CONSTRAINT `tbproduk_ibfk_1` FOREIGN KEY (`id_supplier`) REFERENCES `tbsupplier` (`id_supplier`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbtransaksi_pembelian`
--
ALTER TABLE `tbtransaksi_pembelian`
  ADD CONSTRAINT `tbtransaksi_pembelian_ibfk_1` FOREIGN KEY (`id_karyawan`) REFERENCES `tbkaryawan` (`id_karyawan`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tbtransaksi_pembelian_ibfk_2` FOREIGN KEY (`id_supplier`) REFERENCES `tbsupplier` (`id_supplier`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbtransaksi_penjualan`
--
ALTER TABLE `tbtransaksi_penjualan`
  ADD CONSTRAINT `tbtransaksi_penjualan_ibfk_1` FOREIGN KEY (`id_karyawan`) REFERENCES `tbkaryawan` (`id_karyawan`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
