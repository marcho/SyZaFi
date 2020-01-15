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