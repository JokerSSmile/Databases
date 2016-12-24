-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Дек 24 2016 г., 23:26
-- Версия сервера: 5.7.14
-- Версия PHP: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `lab5`
--

DELIMITER $$
--
-- Процедуры
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectGroup` (IN `mGroup` TEXT CHARSET utf8)  NO SQL
BEGIN
SELECT * FROM students WHERE sGroup = mGroup;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Структура таблицы `pcspecification`
--

CREATE TABLE `pcspecification` (
  `Id` int(10) UNSIGNED NOT NULL,
  `SpecificationName` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `pcspecification`
--

INSERT INTO `pcspecification` (`Id`, `SpecificationName`) VALUES
(1, 'Pulls'),
(2, 'Push ups'),
(3, 'Skipping rope');

-- --------------------------------------------------------

--
-- Структура таблицы `results`
--

CREATE TABLE `results` (
  `Id` int(10) UNSIGNED NOT NULL,
  `IdStudent` int(10) UNSIGNED NOT NULL,
  `IdPCSpecificaion` int(10) UNSIGNED NOT NULL,
  `Result` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `results`
--

INSERT INTO `results` (`Id`, `IdStudent`, `IdPCSpecificaion`, `Result`) VALUES
(1, 1, 1, 10),
(2, 1, 2, 30),
(3, 2, 2, 35),
(4, 3, 1, 12),
(5, 5, 3, 100),
(6, 3, 3, 95);

-- --------------------------------------------------------

--
-- Структура таблицы `students`
--

CREATE TABLE `students` (
  `Id` int(10) UNSIGNED NOT NULL,
  `StudentName` text NOT NULL,
  `SGroup` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `students`
--

INSERT INTO `students` (`Id`, `StudentName`, `SGroup`) VALUES
(1, 'Михаил Горбачёв', 'PS-11'),
(2, 'Корасон Акино', 'PS-12'),
(3, 'Дэн Сяопин', 'PS-21'),
(4, 'Юрий Андропов', 'PS-11'),
(5, 'Лех Валенса', 'IVT-21');

--
-- Триггеры `students`
--
DELIMITER $$
CREATE TRIGGER `AfterInsert` AFTER INSERT ON `students` FOR EACH ROW BEGIN
SET @SGroup = 'PS-11';
END
$$
DELIMITER ;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `pcspecification`
--
ALTER TABLE `pcspecification`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Id` (`Id`);

--
-- Индексы таблицы `results`
--
ALTER TABLE `results`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IdStudent` (`IdStudent`),
  ADD KEY `IdPCSpecificaion` (`IdPCSpecificaion`);

--
-- Индексы таблицы `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `Id` (`Id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `pcspecification`
--
ALTER TABLE `pcspecification`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT для таблицы `results`
--
ALTER TABLE `results`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT для таблицы `students`
--
ALTER TABLE `students`
  MODIFY `Id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `pcspecification`
--
ALTER TABLE `pcspecification`
  ADD CONSTRAINT `pcspecification_ibfk_1` FOREIGN KEY (`Id`) REFERENCES `results` (`IdPCSpecificaion`);

--
-- Ограничения внешнего ключа таблицы `results`
--
ALTER TABLE `results`
  ADD CONSTRAINT `results_ibfk_1` FOREIGN KEY (`IdStudent`) REFERENCES `students` (`Id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
