INSERT INTO `users` (`id`, `firstName`, `lastName`, `birthday`, `workgroup`, `login`, `password`, `pwdhash`, `employmentMonth`, `emailAddress`) VALUES
(1, 'adminFirstName', 'adminLastName', 'adminBirthday', 'adminworkgroup', 'adminLogin', 'adminPassword', 'adminPwdHash', 'adminEmploymentMonth', 'adminEmailAddress');

--
-- Indeksy dla tabeli `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT dla tabeli `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;