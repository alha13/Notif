-- Adminer 4.6.3 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP TABLE IF EXISTS `licence_1`;
CREATE TABLE `licence_1` (
  `id_l1` int(11) NOT NULL AUTO_INCREMENT,
  `email_l1` varchar(255) NOT NULL,
  `algebre_l1` int(11) NOT NULL DEFAULT '0',
  `logique_l1` int(11) NOT NULL DEFAULT '0',
  `architecture_l1` int(11) NOT NULL DEFAULT '0',
  `analyse_l1` int(11) NOT NULL DEFAULT '0',
  `projet_perso_l1` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_l1`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `licence_1` (`id_l1`, `email_l1`, `algebre_l1`, `logique_l1`, `architecture_l1`, `analyse_l1`, `projet_perso_l1`) VALUES
(47,	'orangecrack01@gmail.com',	1,	1,	1,	1,	1),
(48,	'leandrenguessan4@gmail.com',	1,	1,	1,	1,	1),
(49,	'zejadan@gmail.com',	1,	1,	1,	1,	1),
(50,	'alhassaneo@gmail.com',	1,	1,	1,	1,	0),
(51,	'leandrenguessan4@gmail.com',	0,	0,	1,	0,	1);

DROP TABLE IF EXISTS `licence_2`;
CREATE TABLE `licence_2` (
  `id_l2` int(11) NOT NULL AUTO_INCREMENT,
  `email_l2` varchar(255) NOT NULL,
  `php_l2` int(11) NOT NULL DEFAULT '0',
  `algebre_l2` int(11) NOT NULL DEFAULT '0',
  `analyses_l2` int(11) NOT NULL DEFAULT '0',
  `comptabilite_l2` int(11) NOT NULL DEFAULT '0',
  `c_l2` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_l2`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `licence_2` (`id_l2`, `email_l2`, `php_l2`, `algebre_l2`, `analyses_l2`, `comptabilite_l2`, `c_l2`) VALUES
(18,	'leandrenguessan4@gmail.com',	0,	0,	1,	1,	1),
(19,	'orangecrack01@gmail.com',	1,	0,	0,	1,	0);

DROP TABLE IF EXISTS `licence_3`;
CREATE TABLE `licence_3` (
  `id_l3` int(11) NOT NULL AUTO_INCREMENT,
  `email_l3` varchar(255) NOT NULL,
  `grh_l3` int(11) NOT NULL DEFAULT '0',
  `isi_l3` int(11) NOT NULL DEFAULT '0',
  `php_l3` int(11) NOT NULL DEFAULT '0',
  `asp_l3` int(11) NOT NULL DEFAULT '0',
  `optimisation_l3` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_l3`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `licence_3` (`id_l3`, `email_l3`, `grh_l3`, `isi_l3`, `php_l3`, `asp_l3`, `optimisation_l3`) VALUES
(7,	'orangecrack01@gmail.com',	1,	1,	0,	0,	1),
(8,	'leandrenguessan4@gmail.com',	1,	1,	1,	1,	1),
(9,	'leandrenguessan4@gmail.com',	1,	1,	1,	0,	0),
(10,	'alhassaneo@gmail.com',	1,	1,	0,	0,	0);

DROP TABLE IF EXISTS `notification_1`;
CREATE TABLE `notification_1` (
  `id_notification_1` int(11) NOT NULL AUTO_INCREMENT,
  `sujet_notification_1` varchar(255) NOT NULL,
  `description_notification_1` varchar(255) NOT NULL,
  `message_notification_1` text NOT NULL,
  `image_notification_1` varchar(255) NOT NULL DEFAULT 'azo',
  `categorie_notification_1` varchar(255) NOT NULL,
  PRIMARY KEY (`id_notification_1`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `notification_1` (`id_notification_1`, `sujet_notification_1`, `description_notification_1`, `message_notification_1`, `image_notification_1`, `categorie_notification_1`) VALUES
(30,	'c',	'c',	'c',	'upload/1.PNG',	'ab'),
(31,	's',	's',	's',	'upload/16487537_10207169223423561_276668827137338449_o.jpg',	'ab'),
(32,	'vvvvvvvvvvvvvvvvvv',	'vvvvvvvvvvvvvvvvvvvvvvv',	'vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv',	'upload/218770_1600944118131_2111134_o.jpg',	'ab'),
(33,	'logic',	'logical',	'la logic logical',	'upload/ID tete.jpg',	'ab'),
(34,	'sssssssss',	'qqqqqqqqqqq',	'qqqqqqqqqqqqq',	'upload/dddddddddddddddddd.png',	'ab'),
(35,	'sssssssss',	'c',	'c',	'upload/2016-05-25.png',	'ab'),
(36,	'a',	'a',	'a',	'upload/2016-05-25 (1).png',	'ab'),
(37,	'p',	'p',	'p',	'upload/cpanel.PNG',	'ab'),
(38,	'hjv',	'hiu',	'ni',	'upload/d.png',	'ab'),
(39,	'sssssssss',	'w',	'w',	'upload/im-B000672_hp-billboard_965x325.FINAL.ReachforGreat_new.jpg',	'Logique'),
(40,	'sssssssss',	'dddd',	'ddddd',	'upload/1.PNG',	'Algebre'),
(41,	'aaa',	'aaaa',	'aaaa',	'upload/1.PNG',	'Algebre'),
(42,	'aaaaa',	'aaaaa',	'aaaa',	'upload/1.PNG',	'Logique'),
(43,	'AAA',	'aaaa',	'aaaaaaaa',	'upload/ID tete.jpg',	'Analyse'),
(44,	'aaaaaaaaa',	'aaaaaaaaaaaaa',	'aaaaaaaaaa',	'upload/1.PNG',	'Projet perso');

DROP TABLE IF EXISTS `notification_2`;
CREATE TABLE `notification_2` (
  `id_notification_2` int(11) NOT NULL AUTO_INCREMENT,
  `sujet_notification_2` varchar(255) NOT NULL,
  `description_notification_2` varchar(255) NOT NULL,
  `message_notification_2` text NOT NULL,
  `image_notification_2` varchar(255) NOT NULL,
  `categorie_notification_2` varchar(255) NOT NULL,
  PRIMARY KEY (`id_notification_2`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `notification_2` (`id_notification_2`, `sujet_notification_2`, `description_notification_2`, `message_notification_2`, `image_notification_2`, `categorie_notification_2`) VALUES
(1,	'SELECT * FROM licence_3 WHERE grh_l3 = @1 GROUP by email_l3 ',	'SELECT * FROM licence_3 WHERE grh_l3 = @1 GROUP by email_l3 ',	'SELECT * FROM licence_3 WHERE grh_l3 = @1 GROUP by email_l3 ',	'upload/bb5e6f71009bb2e6cb847c65c7196939.jpg',	'Comptabilite'),
(2,	'W',	'cc',	'cccc',	'upload/maxresdefault.jpg',	'C#');

DROP TABLE IF EXISTS `notification_3`;
CREATE TABLE `notification_3` (
  `id_notification_3` int(11) NOT NULL AUTO_INCREMENT,
  `sujet_notification_3` varchar(255) NOT NULL,
  `description_notification_3` varchar(255) NOT NULL,
  `message_notification_3` text NOT NULL,
  `image_notification_3` varchar(255) NOT NULL,
  `categorie_notification_3` varchar(255) NOT NULL,
  PRIMARY KEY (`id_notification_3`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `notification_3` (`id_notification_3`, `sujet_notification_3`, `description_notification_3`, `message_notification_3`, `image_notification_3`, `categorie_notification_3`) VALUES
(1,	'g',	'g',	'g',	'upload/im-B000672_hp-billboard_965x325.FINAL.ReachforGreat_new.jpg',	'GRH'),
(2,	'W',	'W',	'W',	'upload/im-B000672_hp-billboard_965x325.FINAL.ReachforGreat_new.jpg',	'GRH'),
(3,	'W',	'W',	'W',	'upload/16487537_10207169223423561_276668827137338449_o.jpg',	'ISI'),
(4,	'W',	'W',	'W',	'upload/36493741_2052013384840491_171963695893577728_n.jpg',	'ISI'),
(5,	'X',	'X',	'X',	'upload/ID1.jpg',	'ISI'),
(6,	'qqqq',	'Q',	'Q',	'upload/ID1.jpg',	'ISI'),
(7,	's',	's',	's',	'upload/2018-05-25_135357.jpg',	'ISI'),
(8,	'saaaaaaaaaaaaa',	's',	's',	'upload/Prize.jpg',	'ISI'),
(9,	'W',	'x',	'x',	'upload/Me new.jpg',	'Optimisation'),
(10,	'<',	'<',	'<',	'upload/Copie de Prize.jpg',	'ISI'),
(11,	'ASP S',	'ASP D',	'ASP M',	'upload/answer_147.png',	'ASP'),
(12,	'sssssssss',	'vvv',	'cccc',	'upload/ID1.jpg',	'GRH'),
(13,	'ddd',	'oui',	'jjjjjjjjjjjjjjjjjjjjj',	'upload/1.PNG',	'ISI'),
(14,	'aaaaaaaa',	'aaaaaaaaa',	'aaaaaaaaaa',	'upload/1.PNG',	'PHP'),
(15,	'aaaa',	'aaaa',	'aaaaaaaaaa',	'upload/1.PNG',	'GRH'),
(16,	',n',	',',	',n',	'upload/10296685_229270773949350_4549700065850139376_n.jpg',	'PHP'),
(17,	'n',	'j',	'nj',	'upload/23_1406357315m.jpg.pagespeed.ce.Oas8Hqqv4k.jpg',	'ASP'),
(18,	'nj',	'j',	'ujuog',	'upload/E7440.png',	'GRH'),
(19,	'sujet',	'description',	'mesaage',	'upload/avatar-1577909_960_720.png',	'ISI');

-- 2018-08-09 15:55:18
