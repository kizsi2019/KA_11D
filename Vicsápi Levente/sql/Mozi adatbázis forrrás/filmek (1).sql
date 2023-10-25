-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Hoszt: localhost
-- Létrehozás ideje: 2013. máj. 19. 22:33
-- Szerver verzió: 5.5.16
-- PHP verzió: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Adatbázis: `test`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet: `filmek`
--

CREATE TABLE IF NOT EXISTS `filmek` (
  `fkod` int(11) NOT NULL,
  `filmcim` varchar(255) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `szines` tinyint(1) DEFAULT NULL,
  `szinkron` varchar(255) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `szarmazas` varchar(255) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `mufaj` varchar(255) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `hossz` int(11) DEFAULT NULL,
  PRIMARY KEY (`fkod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `filmek`
--

INSERT INTO `filmek` (`fkod`, `filmcim`, `szines`, `szinkron`, `szarmazas`, `mufaj`, `hossz`) VALUES
(1, 'Ágnes öcsénk', 1, 'fel', 'német', 'dráma', 115),
(2, 'Az állomásfőnök', 1, 'mb', 'amerikai', 'dráma', 88),
(3, 'Álmodozók', 1, 'fel', 'angol-francia-olasz', 'dráma', 130),
(4, 'Amelie csodálatos élete', 1, 'mb', 'francia-német', 'vígjáték', 117),
(5, 'Annie Hall', 1, 'mb', 'amerikai', 'vígjáték', 89),
(6, 'Anyám a lányokat szereti', 1, 'fel', 'spanyol', 'vígjáték', 96),
(7, 'Anyátlanok', 1, 'fel', 'japán', 'játékfilm', 141),
(8, 'Apokalipszis most - rendezői változat', 1, 'fel', 'amerikai', 'dráma', 202),
(9, 'Apokalipszis most I-II', 1, 'fel', 'amerikai', 'dráma', 159),
(10, 'Arizonai álmodozók', 1, 'mb', 'amerikai', 'dráma', 135),
(11, 'Bábok', 1, 'mb', 'japán', 'dráma', 109),
(12, 'Beszélj hozzá!', 1, 'mb', 'spanyol', 'dráma', 109),
(13, 'Bin-jip - Lopakodó lelkek', 1, 'fel', 'dél-koreai-japán', 'dráma', 88),
(14, 'A bíró és a hóhér', 1, 'mb', 'NSZK-olasz', 'krimi', 90),
(15, 'Broken Flowers - Hervadó virágok', 1, 'fel', 'amerikai-francia', 'vígjáték', 105),
(16, 'A bűvös körhinta', 1, 'mb', 'francia', 'animációs', 85),
(17, 'Cápasrác és Lávalány kalandjai', 1, 'mb', 'amerikai', 'kalandfilm', 112),
(18, 'Charlie és a csokigyár', 1, 'mb', 'amerikai-angol', 'vígjáték', 106),
(19, 'Che Guevara: A motoros naplója', 0, 'fel', 'amerikai-angol-argentin-német', 'dráma', 128),
(20, 'Csak szex és más semmi', 1, NULL, 'magyar', 'vígjáték', 93),
(21, 'Csodacsibe', 1, 'mb', 'amerikai', 'animációs', 77),
(22, 'Csodálatos Júlia', 1, 'mb', 'kanadai', NULL, 104),
(23, 'Datolya', 1, 'fel', 'belga-francia-tunéziai', NULL, 82),
(24, 'Dig! - Ezt kapd ki!', 1, 'fel', 'amerikai', 'dokumentum', 107),
(25, 'A diktátor', 0, 'mb', 'amerikai', 'filmszatíra', 120),
(26, 'Dogville - A menedék', 1, 'fel', 'dán-svéd-norvég-német-finn-olasz-japán-angol-amerikai', 'dráma', 177),
(27, 'Domino', 1, 'fel', 'francia-amerikai', 'akció', 127),
(28, 'Durr, durr és csók', 1, 'fel', 'amerikai', 'thriller', 103),
(29, 'Edukators', 1, 'fel', 'német-osztrák', 'játékfilm', 127),
(30, 'Egy cipőben', 1, 'fel', 'amerikai', 'vígjáték', 130),
(31, 'Egy hulla, egy falafel és a többiek…', 1, 'fel', 'ausztrál-olasz', 'vígjáték', 107),
(32, 'Egy szoknya, egy nadrág', 1, NULL, 'magyar', 'vígjáték', 95),
(33, 'Elveszett jelentés', 1, 'mb', 'amerikai-japán', 'dráma', 102),
(34, 'Én, Pán Péter', 1, 'fel', 'angol-amerikai', 'dráma', 106),
(35, 'Eros', 1, 'fel', 'amerikai-olasz-hongkongi-kínai-francia-luxemburgi-angol', 'dráma', 104),
(36, 'Fej vagy írás', 1, NULL, 'magyar', 'vígjáték', 90),
(37, 'Fekete Kefe', 0, NULL, 'magyar', 'vígjáték', 80),
(38, 'A fény ösvényei', 1, NULL, 'magyar', 'dráma', 89),
(39, 'Futball faktor', 1, 'fel', 'angol', 'dráma', 91),
(40, 'Fűrész 2', 1, 'fel', 'amerikai', 'thriller', 93),
(41, 'Galaxis útikalauz stopposoknak', 1, 'fel', 'amerikai-angol', 'vígjáték', 110),
(42, 'Garfield', 1, 'mb', 'amerikai', 'vígjáték', 81),
(43, 'Genezis', 1, 'mb', 'francia-olasz', 'természetfilm', 81),
(44, 'Getno', 1, NULL, 'magyar', 'játékfilm', 95),
(45, 'Grimm', 1, 'fel', 'cseh-amerikai', 'fantasy', 118),
(46, 'Ha igaz volna…', 1, 'fel', 'amerikai', 'vígjáték', 95),
(47, 'A halott menyasszony', 1, 'fel', 'angol', 'animációs', 78),
(48, 'Harry Potter és a Tűz Serlege', 1, 'mb', 'amerikai', 'fantasy', 157),
(49, 'Hawaii, Oslo', 1, 'fel', 'dán-svéd-norvég', 'dráma', 125),
(50, 'A hetedik nap', 1, 'fel', 'spanyol', 'dráma', 103),
(51, 'Hétköznapi mennyország', 1, 'fel', 'svéd', 'dráma', 130),
(52, 'Híd a Kwai folyón', 1, 'mb', 'angol-amerikai', 'dráma', 161),
(53, 'Hideg csontok', 1, 'fel', 'spanyol', 'thriller', 100),
(54, 'Holdfényév', 1, 'mb', 'amerikai', 'dráma', 117),
(55, 'Hölgyek levendulában', 1, 'fel', 'angol', 'dráma', 103),
(56, 'Hős', 1, 'mb', 'hongkongi', NULL, 96),
(57, 'A hősök nem pihennek', 1, NULL, 'francia-osztrák', 'dráma', 104),
(58, 'Human Traffic', 1, NULL, 'angol-ír', 'vígjáték', 99),
(59, 'Hurrá, nyaralunk!', 0, 'mb', 'szovjet', 'ifjúsági', 74),
(60, 'Az igazi Mikulás', 1, NULL, 'magyar', 'játékfilm', 90),
(61, 'Az igazság fogságában', 1, 'fel', 'kanadai', NULL, 108),
(62, 'Az ígéret - Fényes nappal történt', 0, 'fel', 'NSZK-svájci-spanyol', 'krimi', 90),
(63, 'Az ígéret megszállottja', 1, 'fel', 'amerikai', 'dráma', 124),
(64, 'Intimitás', 1, 'mb', 'francia-angol-német-spanyol', 'dráma', 115),
(65, 'Isten városa', 1, 'mb', 'brazil-francia', 'dráma', 130),
(66, 'Játszik még a szív', 1, 'fel', 'angol', 'vígjáték', 100),
(67, 'Johanna', 1, NULL, 'magyar', 'operafilm', 90),
(68, 'Kairó bíbor rózsája', 1, 'mb', 'amerikai', 'vígjáték', 84),
(69, 'Kávé és cigaretta', 0, 'fel', 'amerikai', 'zenés', 95),
(70, 'Kész cirkusz', 1, NULL, 'magyar', 'vígjáték', 74),
(71, 'A kilencedik nap', 1, 'fel', 'német-luxemburgi', 'dráma', 98),
(72, 'King Kong', 1, 'mb', 'új-zélandi', NULL, 188),
(73, 'Kontroll', 1, NULL, 'magyar', 'thriller', 102),
(74, 'Kőkemény család', 1, 'mb', 'amerikai', 'vígjáték', 104),
(75, 'A közvetítő', 1, NULL, 'magyar', 'dokumentum', 89),
(76, 'Kulcsár & Haverok', 1, NULL, 'magyar', NULL, 80),
(77, 'Kutyaszorítóban', 1, 'fel', 'amerikai', 'thriller', 99),
(78, 'Kutyátlanok kíméljenek', 1, 'fel', 'amerikai', 'vígjáték', 98),
(79, 'Lakótársat keresünk', 1, 'fel', 'francia-spanyol', 'vígjáték', 120),
(80, 'Leány gyöngy fülbevalóval', 1, 'fel', 'angol-luxemburgi', 'dráma', 95),
(81, 'Légcsavar', 1, 'fel', 'amerikai', 'thriller', 98),
(82, 'A legtöbb ember Kínában él…', 1, 'fel', 'norvég', 'dráma', 82),
(83, 'Lélektől lélekig', 1, 'fel', 'francia-dél-afrikai-angol', 'kalandfilm', 122),
(84, 'Madagaszkár', 1, 'mb', 'amerikai', 'animációs', 80),
(85, 'Magyar vándor', 1, NULL, 'magyar', 'vígjáték', 110),
(86, 'Manderlay', 1, 'fel', 'dán-svéd-francia-német-amerikai', 'dráma', 139),
(87, 'Manhattan', 0, 'mb', 'amerikai', 'vígjáték', 96),
(88, 'Maszájok', 1, 'fel', 'francia', 'dráma', 94),
(89, 'Még mindig lakótársat keresünk', 1, 'fel', 'francia-angol', 'vígjáték', 125),
(90, 'Melinda és Melinda', 1, 'fel', 'amerikai', 'vígjáték', 100),
(91, 'Mennyország most', 1, 'fel', 'francia-német-holland-izrael', NULL, 90),
(92, 'Mezítlábas szerelem', 1, 'fel', 'német', 'vígjáték', 110),
(93, 'Mi a csudát tudunk a világról?', 1, 'mb', 'amerikai', 'játékfilm', 108),
(94, 'Mint egy angyal', 1, 'fel', 'francia-olasz', 'dráma', 110),
(95, 'Monsieur Ibrahim és a Korán virágai', 1, 'fel', 'francia-török', 'dráma', 94),
(96, 'Naqoyqatsi - Erőszakos világ', 1, 'szöv nélkül', 'amerikai', 'filmesszé', 89),
(97, 'Narnia Krónikái - Az oroszlán, a boszorkány és a ruhásszekrény', 1, 'mb', 'amerikai-új-zélandi', 'fantasy', 140),
(98, 'Nesze neked, Pete Tong!', 1, 'fel', 'angol-kanadai', 'vígjáték', 90),
(99, 'Nézz balra, ott egy svéd!', 1, 'fel', 'dán', 'vígjáték', 90),
(100, 'Nyomorultak', 1, 'mb', 'francia-olasz-NDK', 'dráma', 225),
(101, 'Oldboy', 1, 'fel', 'dél-koreai', 'thriller', 120),
(102, 'Az operaház fantomja', 1, NULL, 'amerikai', 'musical', 92),
(103, 'Ördögűzés Emily Rose üdvéért', 1, 'fel', 'amerikai', 'horror', 119),
(104, 'Pata-csata', 1, 'mb', 'dél-afrikai-amerikai', 'vígjáték', 94),
(105, 'Pingvinek vándorlása', 1, 'mb', 'francia', 'dokumentum', 85),
(106, 'A pityergő teve története', 1, 'fel', 'német-mongol', 'dokumentum', 87),
(107, 'Ponyvaregény - Pulp Fiction', 1, 'fel', 'amerikai', 'filmszatíra', 150),
(108, 'Porcelánbaba', 1, NULL, 'magyar', 'dráma', 74),
(109, 'Rap, Revü, Rómeó', 1, NULL, 'magyar', 'vígjáték', 82),
(110, 'A Rashevski tangó', 1, 'fel', 'belga-luxemburgi-francia', NULL, 90),
(111, 'Rekonstrukció', 1, 'mb', 'dán', 'dráma', 88),
(112, 'A repülő tőrök klánja', 1, 'fel', 'kínai-hongkongi', 'akció', 111),
(113, 'A rövidek éjszakája', 1, 'fel', 'francia-angol-spanyol-dán', 'rövidfilm', 68),
(114, 'Segítség, hal lettem!', 1, 'mb', 'dán-ír-német', 'animációs', 80),
(115, 'Senki nem tud semmit', 0, 'mb', 'csehszlovák', 'vígjáték', 70),
(116, 'Sin City', 1, 'mb', 'amerikai', 'akció', 124),
(117, 'Sóhajtenger - Kuba', 0, NULL, 'magyar', 'rövidfilm', 5),
(118, 'Egy sorozatgyilkos nyara', 1, 'mb', 'amerikai', 'dráma', 136),
(119, 'A sötétség útja - Mulholland Drive', 1, 'mb', 'amerikai-francia', 'dráma', 141),
(120, 'Stalker', 1, 'fel', 'szovjet-NSZK', 'sci-fi', 160),
(121, 'Super Size Me', 1, 'fel', 'amerikai', 'dokumentum', 96),
(122, 'Szamszára', 1, 'mb', 'indiai-német-francia-olasz', 'dráma', 140),
(123, 'Szent Lajos király hídja', 1, 'fel', 'spanyol', NULL, 120),
(124, 'A szenvedélyek labirintusa', 1, 'mb', 'spanyol', 'játékfilm', 100),
(125, 'Szerelmem nyara', 1, 'fel', 'angol', 'dráma', 86),
(126, 'Szeress, ha mersz', 1, 'mb', 'francia-belga', NULL, 93),
(127, 'Szex, szerelem, olaszok', 1, 'fel', 'olasz-svájci-angol', 'vígjáték', 125),
(128, 'Szőke Kóla', 1, NULL, 'magyar', 'vígjáték', 96),
(129, 'Szürke, Mercivel', 1, 'fel', 'jugoszláv-német-szlovén-szerb', 'vígjáték', 95),
(130, 'Szürkület', 0, NULL, 'magyar', 'krimi', 105),
(131, 'Táncos a sötétben', 1, 'mb', 'dán-svéd-francia', 'dráma', 134),
(132, 'Tangó és tulipán', 1, 'fel', 'olasz-svájci', 'vígjáték', 112),
(133, 'Tapló télapó', 1, 'fel', 'amerikai-német', 'vígjáték', 98),
(134, 'Tavasz, Nyár, Ősz, Tél és Tavasz', 1, 'mb', 'dél-koreai-német', 'dráma', 99),
(135, 'Tavasz van', 0, 'fel', 'olasz', 'dráma', 90),
(136, 'Twist Olivér', 1, 'mb', 'angol-cseh-francia-olasz', 'dráma', 130),
(137, 'Utazások egy szerzetessel', 1, NULL, 'magyar', 'dokumentum', 65),
(138, 'Ütközések', 1, 'fel', 'amerikai-német', 'dráma', 113),
(139, 'Üvegfal', 1, NULL, 'magyar', 'játékfilm', 87),
(140, 'Üvegtigris', 1, NULL, 'magyar', 'vígjáték', 100),
(141, 'Vad galamb', 1, 'mb', 'angol', 'animációs', 76),
(142, 'A vágy törvénye', 1, 'fel', 'spanyol', 'dráma', 102),
(143, 'Van élet a halál előtt?', 1, NULL, 'magyar', 'dokumentum', 110),
(144, 'A vándorló palota', 1, 'mb', 'japán', 'animációs', 119),
(145, 'Vera Drake', 1, 'fel', 'angol-francia-új-zélandi', 'dráma', 124),
(146, 'Világok arca: Baraka', 1, 'szöveg nélküli', 'amerikai', 'dokumentum', 96),
(147, 'Vincent, François, Paul és a többiek', 1, 'mb', 'francia-olasz', 'dráma', 120),
(148, 'Vízcseppek a forró kövön', 1, 'fel', 'francia', 'dráma', 90),
(149, 'Vuk', 1, NULL, 'magyar', 'rajzfilm', 74),
(150, 'Wallace & Gromit és az Elvetemült Veteménylény', 1, 'mb', 'angol', 'animációs', 94),
(151, 'Waterloo Bridge', 0, 'fel', 'amerikai', 'dráma', 103),
(152, 'Whisky', 1, 'fel', 'uruguayi-argentin-német-spanyol', 'komédia', 99),
(153, 'Zorro legendája', 1, 'mb', 'amerikai', 'kalandfilm', 131),
(154, '5x2', 1, 'fel', 'francia', 'dráma', 90),
(155, 'Film', 1, 'mb', 'magyar', 'dráma', 100);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
