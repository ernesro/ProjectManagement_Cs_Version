-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 08-11-2018 a las 14:47:54
-- Versión del servidor: 5.7.22-0ubuntu0.16.04.1
-- Versión de PHP: 7.0.30-0ubuntu0.16.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Data Base: `proyects`
--

-- --------------------------------------------------------



CREATE TABLE `proyects` 
(
  `cod` int(10) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `description` varchar(200) NOT NULL,
  `state` varchar(20) DEFAULT NULL,

  PRIMARY KEY (`cod`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `proyects` (`title`, `description`, `state`) VALUES
('Redesign of the website', 'Update the design and functionality of the existing website', 'in progress'),
('Launch of new product', 'Develop and launch a new product to the market', 'on hold'),
('Implementation of accounting software', 'Install and configure accounting software for the company', 'completed'),
('Organization of business event', 'Plan and coordinate a business event for the presentation of new products', 'in progress');



CREATE TABLE `tasks` 
(
  `cod` int(10) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `description` varchar(200) NOT NULL,
  `cod_proyect` int(10) NOT NULL,
  `state` varchar(20) NOT NULL,

  PRIMARY KEY (`cod`),
  CONSTRAINT `fk_tasks_projects` FOREIGN KEY (`cod_proyect`) REFERENCES `proyects` (`cod`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tasks` (`title`, `description`, `cod_proyect`, `state`)
VALUES
('Design wireframes', 'Create wireframes for the new website design', 1 , 'in progress'),
('Write content', 'Create content for the website pages', 1 , 'not started'),
('Code website frontend', 'Code the website frontend using HTML, CSS and JS', 1 , 'not started'),
('Code website backend', 'Code the website backend using PHP and MySQL', 1, 'not started'),
('Create product mockups', 'Design mockups for the new product', 2, 'in progress'),
('Develop product features', 'Develop features for the new product', 2, 'not started'),
('Perform testing', 'Perform testing of the new product', 2, 'not started'),
('Train employees', 'Provide training to employees on the new accounting software', 3, 'in progress'),
('Migrate data', 'Migrate existing data to the new accounting software', 3, 'not started'),
('Plan event agenda', 'Plan the agenda for the business event', 4, 'in progress'),
('Contact suppliers', 'Contact suppliers for event materials', 4, 'not started'),
('Book venue', 'Book the venue for the event', 4, 'not started');



CREATE TABLE `comments` 
(
  `cod` int(10) NOT NULL AUTO_INCREMENT,
  `cod_task` int(10) NOT NULL,
  `content` varchar(200) NOT NULL,

  PRIMARY Key (`cod`),
  CONSTRAINT `fk_comments_tasks` FOREIGN KEY (`cod_task`) REFERENCES `tasks` (`cod`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `comments` (`cod_task`, `content`) VALUES
(1, 'Great wireframes!'),
(2, 'I am working on the content for this task.'),
(3, 'I started working on the frontend.'),
(3, 'I am having some trouble with this task. Need help!');



CREATE TABLE `teams` 
(
  `cod` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,

  PRIMARY Key (`cod`)
);

 INSERT INTO `teams` (`name`) VALUES
 ('Team 1'),
 ('Team 2'),
 ('Team 3');



CREATE TABLE `employees`
(
  `cod` int(10) NOT NULL AUTO_INCREMENT,
  `admin` varchar(5) NOT NULL,
  `dni` varchar(10) Unique NOT NULL,
  `name` varchar(200) NOT NULL,
  `lastName`varchar(200) NOT NULL,
  `phoneNumber` varchar(9) NOT NULL,
  `address` varchar(200) NOT NULL,
  `email` varchar(200) NOT NULL Unique,
  `password` varchar(200) NOT NULL DEFAULT `dni`,

  PRIMARY Key (`cod`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `employees` (`dni`, `name`, `lastName`, `phoneNumber`, `address`, `email`, `admin`) VALUES 
('12345678A', 'John', 'Doe', '123456789', '123 Main St', 'johndoe@email.com', 'true'),
('87654321B', 'Jane', 'Doe', '987654321', '456 Elm St', 'janedoe@email.com', 'false'),
('11111111C', 'Alice', 'Smith', '111111111', '789 Oak St', 'alice.smith@email.com', 'false'),
('22222222D', 'Bob', 'Johnson', '222222222', '321 Pine St', 'bob.johnson@email.com', 'false');



CREATE TABLE `assigntask`
(
  cod int(10) NOT NULL, 
  cod_task int(10) NOT NULL,

  PRIMARY Key (`cod`, `cod_task`),
  CONSTRAINT `fk_assignTask_employees` FOREIGN KEY (`cod`) REFERENCES `employees` (`cod`) ON DELETE CASCADE,
  CONSTRAINT `fk_assignTask_tasks` FOREIGN KEY (`cod_task`) REFERENCES `tasks` (`cod`) ON DELETE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `assigntask` (`cod`, `cod_task`) VALUES
(1, 1),
(2, 2),
(3, 5);



CREATE TABLE `assignteam`
(
  cod_team int(10) NOT NULL, 
  cod_proyect int(10) NOT NULL,

  PRIMARY Key (`cod_team`, `cod_proyect`),
  CONSTRAINT `fk_assignTeam_team` FOREIGN KEY (`cod_team`) REFERENCES `teams` (`cod`) ON DELETE CASCADE,
  CONSTRAINT `fk_assignTeam_Project` FOREIGN KEY (`cod_proyect`) REFERENCES `proyects` (`cod`) ON DELETE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `assignteam` (`cod_team`, `cod_proyect`) VALUES
(1, 1),
(2, 1),
(3, 2);



CREATE TABLE `assignemployee`
(
  cod int(10) NOT NULL, 
  cod_team int(10) NOT NULL,

  PRIMARY Key (`cod`, `cod_team`),
  CONSTRAINT `fk_assignEmployees_team` FOREIGN KEY (`cod_team`) REFERENCES `teams` (`cod`) ON DELETE CASCADE,
  CONSTRAINT `fk_assignemployess_employee` FOREIGN KEY (`cod`) REFERENCES `employees` (`cod`) ON DELETE CASCADE
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `assignemployee` (`cod`, `cod_team`) VALUES
(1, 1),
(2, 1),
(3, 2);

COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;