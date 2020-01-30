-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 23 Sty 2020, 18:06
-- Wersja serwera: 10.4.6-MariaDB
-- Wersja PHP: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `syzafi`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `companydetails`
--
DROP TABLE IF EXISTS companydetails;
CREATE TABLE `companydetails` (
  `id` int(11) NOT NULL,
  `companyName` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `companyNIP` int(11) NOT NULL,
  `companyREGON` int(11) NOT NULL,
  `companyKRS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `deletedemployees`
--
DROP TABLE IF EXISTS deletedemployees;
CREATE TABLE `deletedemployees` (
  `id` int(11) NOT NULL,
  `firstName` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `lastName` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `fathersName` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `mothersName` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `birthday` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `placeOfResidence` varchar(500) COLLATE utf8_polish_ci NOT NULL,
  `correspondenceAddress` varchar(500) COLLATE utf8_polish_ci NOT NULL,
  `education` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `historyOfEmployment` varchar(500) COLLATE utf8_polish_ci NOT NULL,
  `pesel` int(11) NOT NULL,
  `childrensNames` varchar(500) COLLATE utf8_polish_ci NOT NULL,
  `childrensBirthdays` varchar(500) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `employees`
--
DROP TABLE IF EXISTS employees;
CREATE TABLE `employees` (
  `id` int(11) NOT NULL,
  `firstName` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `lastName` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `fathersName` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `mothersName` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `birthday` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `placeOfResidence` varchar(500) COLLATE utf8_polish_ci NOT NULL,
  `correspondenceAddress` varchar(500) COLLATE utf8_polish_ci NOT NULL,
  `education` varchar(50) COLLATE utf8_polish_ci NOT NULL,
  `historyOfEmployment` varchar(500) COLLATE utf8_polish_ci NOT NULL,
  `pesel` int(11) NOT NULL,
  `childrensNames` varchar(500) COLLATE utf8_polish_ci NOT NULL,
  `childrensBirthdays` varchar(500) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Struktura tabeli dla tabeli `financialoperations`
--
DROP TABLE IF EXISTS financialoperations;
CREATE TABLE `financialoperations` (
  `id` int(11) NOT NULL,
  `receiver` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `amount` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `category` varchar(300) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Struktura tabeli dla tabeli `inventory`
--
DROP TABLE IF EXISTS inventory;
CREATE TABLE `inventory` (
  `id` int(11) NOT NULL,
  `inventorycode` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `name` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `orders`
--
DROP TABLE IF EXISTS orders;
CREATE TABLE `orders` (
  `id` int(11) NOT NULL,
  `client` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `itemname` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `amount` int(11) NOT NULL,
  `date` varchar(300) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Struktura tabeli dla tabeli `productionplan`
--
DROP TABLE IF EXISTS productionplan;
CREATE TABLE `productionplan` (
  `id` int(11) NOT NULL,
  `item` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `amount` int(11) NOT NULL,
  `position` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `date` varchar(300) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `users`
--
DROP TABLE IF EXISTS users;
CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `firstName` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `lastName` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `birthday` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `workgroup` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `login` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `password` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `pwdhash` varchar(300) COLLATE utf8_polish_ci NOT NULL,
  `employmentMonth` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `emailAddress` varchar(30) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `companydetails`
--
ALTER TABLE `companydetails`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `deletedemployees`
--
ALTER TABLE `deletedemployees`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `financialoperations`
--
ALTER TABLE `financialoperations`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `productionplan`
--
ALTER TABLE `productionplan`
  ADD PRIMARY KEY (`id`);

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `companydetails`
--
ALTER TABLE `companydetails`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT dla tabeli `deletedemployees`
--
ALTER TABLE `deletedemployees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT dla tabeli `employees`
--
ALTER TABLE `employees`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT dla tabeli `financialoperations`
--
ALTER TABLE `financialoperations`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT dla tabeli `inventory`
--
ALTER TABLE `inventory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT dla tabeli `orders`
--
ALTER TABLE `orders`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT dla tabeli `productionplan`
--
ALTER TABLE `productionplan`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT dla tabeli `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
