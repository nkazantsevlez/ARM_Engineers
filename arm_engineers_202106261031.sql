--
-- Script was generated by Devart dbForge Studio 2020 for MySQL, Version 9.0.597.0
-- Product home page: http://www.devart.com/dbforge/mysql/studio
-- Script date 26.06.2021 10:31:53
-- Server version: 8.0.25
-- Client version: 4.1
--

-- 
-- Disable foreign keys
-- 
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;

-- 
-- Set SQL mode
-- 
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

DROP DATABASE IF EXISTS arm_engineers;

CREATE DATABASE arm_engineers
	CHARACTER SET utf8
	COLLATE utf8_general_ci;

--
-- Set default database
--
USE arm_engineers;

--
-- Create table `employee`
--
CREATE TABLE employee (
  ID INT NOT NULL AUTO_INCREMENT,
  Surname VARCHAR(255) DEFAULT NULL,
  Name VARCHAR(50) DEFAULT NULL,
  Middle_Name VARCHAR(255) DEFAULT NULL,
  Position VARCHAR(255) DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 27,
AVG_ROW_LENGTH = 655,
CHARACTER SET utf8,
COLLATE utf8_general_ci;

--
-- Create table `room`
--
CREATE TABLE room (
  ID INT NOT NULL AUTO_INCREMENT,
  Number INT DEFAULT NULL,
  Name_Room VARCHAR(50) DEFAULT NULL,
  ID_Employee INT DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 14,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'organization''s office table';

--
-- Create foreign key
--
ALTER TABLE room 
  ADD CONSTRAINT FK_room_employee_ID FOREIGN KEY (ID_Employee)
    REFERENCES employee(ID);

--
-- Create view `room_view`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW room_view
AS
SELECT
  `room`.`ID` AS `ID`,
  `room`.`Number` AS `Number`,
  `room`.`Name_Room` AS `Name_Room`,
  `employee`.`Surname` AS `Surname`,
  `room`.`Description` AS `Description`
FROM (`room`
  JOIN `employee`
    ON ((`room`.`ID_Employee` = `employee`.`ID`)))
WHERE ((`room`.`Name_Room` <> 'TechObsluzhivanie')
AND (`room`.`Name_Room` <> 'Spisanie'));

--
-- Create table `ram`
--
CREATE TABLE ram (
  ID INT NOT NULL AUTO_INCREMENT,
  Inventory_Number_RAM INT DEFAULT NULL,
  Name VARCHAR(50) DEFAULT NULL,
  Type VARCHAR(255) DEFAULT NULL,
  Memory_Size INT DEFAULT NULL,
  Operating_Freequency INT DEFAULT NULL,
  ID_Room INT DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 10000041,
AVG_ROW_LENGTH = 442,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'organization ram dice table';

--
-- Create foreign key
--
ALTER TABLE ram 
  ADD CONSTRAINT FK_ram_room_ID FOREIGN KEY (ID_Room)
    REFERENCES room(ID);

DELIMITER $$

--
-- Create procedure `moving_RAM`
--
CREATE 
	DEFINER = 'root'@'localhost'
PROCEDURE moving_RAM(IN Inventory_Number INT, IN ID_Room INT)
  COMMENT 'Stored procedure to move RAM to a specified location'
BEGIN
UPDATE ram
SET ram.ID_Room = ID_Room
WHERE ram.Inventory_Number_RAM = Inventory_Number;
END
$$

DELIMITER ;

--
-- Create view `ram_view`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW ram_view
AS
SELECT
  `ram`.`ID` AS `ID`,
  `ram`.`Inventory_Number_RAM` AS `Inventory_Number_RAM`,
  `ram`.`Name` AS `Name`,
  `ram`.`Type` AS `Type`,
  `ram`.`Memory_Size` AS `Memory_Size`,
  `ram`.`Operating_Freequency` AS `Operating_Freequency`,
  `room`.`Name_Room` AS `Name_Room`,
  `ram`.`Description` AS `Description`
FROM (`ram`
  JOIN `room`
    ON ((`ram`.`ID_Room` = `room`.`ID`)));

--
-- Create table `peripherals`
--
CREATE TABLE peripherals (
  ID INT NOT NULL AUTO_INCREMENT,
  Inventory_Number INT DEFAULT NULL,
  Name VARCHAR(50) DEFAULT NULL,
  ID_Room INT DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 91,
AVG_ROW_LENGTH = 182,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'organization peripherals table';

--
-- Create foreign key
--
ALTER TABLE peripherals 
  ADD CONSTRAINT FK_peripherals_room_ID FOREIGN KEY (ID_Room)
    REFERENCES room(ID);

DELIMITER $$

--
-- Create procedure `Moving_Peripherals`
--
CREATE 
	DEFINER = 'root'@'localhost'
PROCEDURE Moving_Peripherals(IN Inventory_Number INT, IN ID_Room INT)
  COMMENT 'Stored procedure to move periphery to specified location'
BEGIN
UPDATE peripherals
SET peripherals.ID_Room = ID_Room
WHERE peripherals.Inventory_Number = Inventory_Number;
END
$$

DELIMITER ;

--
-- Create view `peripherals_view`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW peripherals_view
AS
SELECT
  `peripherals`.`ID` AS `ID`,
  `peripherals`.`Inventory_Number` AS `Inventory_Number`,
  `peripherals`.`Name` AS `Name`,
  `room`.`Name_Room` AS `Name_Room`,
  `peripherals`.`Description` AS `Description`
FROM (`peripherals`
  JOIN `room`
    ON ((`peripherals`.`ID_Room` = `room`.`ID`)));

--
-- Create table `other_devices`
--
CREATE TABLE other_devices (
  ID INT NOT NULL AUTO_INCREMENT,
  Inventory_Number INT DEFAULT NULL,
  Name VARCHAR(50) DEFAULT NULL,
  ID_Room INT DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 5,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'organization other devices table';

--
-- Create foreign key
--
ALTER TABLE other_devices 
  ADD CONSTRAINT FK_other_devices_room_ID FOREIGN KEY (ID_Room)
    REFERENCES room(ID);

DELIMITER $$

--
-- Create procedure `moving_OtherDevices`
--
CREATE 
	DEFINER = 'root'@'localhost'
PROCEDURE moving_OtherDevices(IN Inventory_Number INT, IN ID_Room INT)
  COMMENT 'Stored procedure to move other devices to a specified location'
BEGIN
UPDATE other_devices
SET other_devices.ID_Room = ID_Room
WHERE other_devices.Inventory_Number = Inventory_Number;
END
$$

DELIMITER ;

--
-- Create view `other_devices_view`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW other_devices_view
AS
SELECT
  `other_devices`.`ID` AS `ID`,
  `other_devices`.`Inventory_Number` AS `Inventory_Number`,
  `other_devices`.`Name` AS `Name`,
  `room`.`Name_Room` AS `Name_Room`,
  `other_devices`.`Description` AS `Description`
FROM (`other_devices`
  JOIN `room`
    ON ((`other_devices`.`ID_Room` = `room`.`ID`)));

--
-- Create table `network_devices`
--
CREATE TABLE network_devices (
  ID INT NOT NULL AUTO_INCREMENT,
  Inventory_Number INT DEFAULT NULL,
  Name VARCHAR(50) DEFAULT NULL,
  ID_Room INT DEFAULT NULL,
  Description VARCHAR(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 17,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'organization network device table';

--
-- Create foreign key
--
ALTER TABLE network_devices 
  ADD CONSTRAINT FK_network_devices_room_ID FOREIGN KEY (ID_Room)
    REFERENCES room(ID);

DELIMITER $$

--
-- Create procedure `moving_NetworkDevices`
--
CREATE 
	DEFINER = 'root'@'localhost'
PROCEDURE moving_NetworkDevices(IN Inventory_Number INT, IN ID_Room INT)
  COMMENT 'Stored procedure to move network devices to a specified location'
BEGIN
UPDATE network_devices
SET network_devices.ID_Room = ID_Room
WHERE network_devices.Inventory_Number = Inventory_Number;
END
$$

DELIMITER ;

--
-- Create view `network_devices_view`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW network_devices_view
AS
SELECT
  `network_devices`.`ID` AS `ID`,
  `network_devices`.`Inventory_Number` AS `Inventory_Number`,
  `network_devices`.`Name` AS `Name`,
  `room`.`Name_Room` AS `Name_Room`,
  `network_devices`.`Description` AS `Description`
FROM (`network_devices`
  JOIN `room`
    ON ((`network_devices`.`ID_Room` = `room`.`ID`)));

--
-- Create table `cpu`
--
CREATE TABLE cpu (
  ID INT NOT NULL AUTO_INCREMENT,
  Inventory_Number_CPU INT DEFAULT NULL,
  Name VARCHAR(50) DEFAULT NULL,
  Socket VARCHAR(255) DEFAULT NULL,
  Clock_Frequency VARCHAR(255) DEFAULT NULL,
  ID_Room INT DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 46,
AVG_ROW_LENGTH = 481,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'organization processor table';

--
-- Create foreign key
--
ALTER TABLE cpu 
  ADD CONSTRAINT FK_cpu_room_ID FOREIGN KEY (ID_Room)
    REFERENCES room(ID);

DELIMITER $$

--
-- Create procedure `moving_CPU`
--
CREATE 
	DEFINER = 'root'@'localhost'
PROCEDURE moving_CPU(IN Inventory_Number INT, IN ID_Room INT)
  COMMENT 'Stored procedure to move the processor to a specified location'
BEGIN
UPDATE cpu
SET cpu.ID_Room = ID_Room
WHERE cpu.Inventory_Number_CPU = Inventory_Number;
END
$$

DELIMITER ;

--
-- Create view `cpu_view`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW cpu_view
AS
SELECT
  `cpu`.`ID` AS `ID`,
  `cpu`.`Inventory_Number_CPU` AS `Inventory_Number_CPU`,
  `cpu`.`Name` AS `Name`,
  `cpu`.`Socket` AS `Socket`,
  `cpu`.`Clock_Frequency` AS `Clock_Frequency`,
  `room`.`Name_Room` AS `Name_Room`,
  `cpu`.`Description` AS `Description`
FROM (`cpu`
  JOIN `room`
    ON ((`cpu`.`ID_Room` = `room`.`ID`)));

--
-- Create table `pc`
--
CREATE TABLE pc (
  ID INT NOT NULL AUTO_INCREMENT,
  Inventory_Number INT DEFAULT NULL,
  Name VARCHAR(50) DEFAULT NULL,
  ID_CPU INT DEFAULT NULL,
  ID_RAM INT DEFAULT NULL,
  ID_Room INT DEFAULT NULL,
  ID_Employee INT DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 31,
AVG_ROW_LENGTH = 585,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'Organization PC table';

--
-- Create foreign key
--
ALTER TABLE pc 
  ADD CONSTRAINT FK_pc_cpu_ID FOREIGN KEY (ID_CPU)
    REFERENCES cpu(ID);

--
-- Create foreign key
--
ALTER TABLE pc 
  ADD CONSTRAINT FK_pc_employee_ID FOREIGN KEY (ID_Employee)
    REFERENCES employee(ID);

--
-- Create foreign key
--
ALTER TABLE pc 
  ADD CONSTRAINT FK_pc_ram_ID FOREIGN KEY (ID_RAM)
    REFERENCES ram(ID);

--
-- Create foreign key
--
ALTER TABLE pc 
  ADD CONSTRAINT FK_pc_room_ID FOREIGN KEY (ID_Room)
    REFERENCES room(ID);

DELIMITER $$

--
-- Create procedure `moving_pc`
--
CREATE 
	DEFINER = 'root'@'localhost'
PROCEDURE moving_pc(IN inventory_Number_PC INT, IN id_room INT)
  COMMENT 'Stored procedure to move a computer to a specified location'
BEGIN
UPDATE pc, ram, cpu
SET pc.id_room = id_room,
    cpu.ID_Room = id_room,
    ram.ID_Room = id_room
WHERE (Inventory_Number = inventory_Number_PC
AND pc.ID_CPU = cpu.ID
AND pc.ID_RAM = RAM.ID);
END
$$

DELIMITER ;

--
-- Create view `pc_viewsearch`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW pc_viewsearch
AS
SELECT
  `pc`.`ID` AS `ID`,
  `pc`.`Inventory_Number` AS `Inventory_Number`,
  `pc`.`Name` AS `Name`,
  `room`.`Name_Room` AS `Name_Room`,
  `employee`.`Surname` AS `Surname`,
  `pc`.`Description` AS `Description`
FROM ((`pc`
  JOIN `room`
    ON ((`pc`.`ID_Room` = `room`.`ID`)))
  JOIN `employee`
    ON ((`pc`.`ID_Employee` = `employee`.`ID`)));

--
-- Create table `cartridge`
--
CREATE TABLE cartridge (
  ID INT NOT NULL AUTO_INCREMENT,
  Inventory_Number INT DEFAULT NULL,
  Name_Cartinge VARCHAR(50) DEFAULT NULL,
  ID_Room INT DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 19,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'organization cartridge table';

--
-- Create foreign key
--
ALTER TABLE cartridge 
  ADD CONSTRAINT FK_cartridge_room_ID FOREIGN KEY (ID_Room)
    REFERENCES room(ID);

DELIMITER $$

--
-- Create procedure `moving_Cartridge`
--
CREATE 
	DEFINER = 'root'@'localhost'
PROCEDURE moving_Cartridge(IN Inventory_Number INT, IN ID_Room INT)
  COMMENT 'Stored Procedure for Moving a Cartridge to a Specified Location'
BEGIN
UPDATE cartridge
SET cartridge.ID_Room = ID_Room
WHERE cartridge.Inventory_Number = Inventory_Number;
END
$$

DELIMITER ;

--
-- Create view `cartridge_view`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW cartridge_view
AS
SELECT
  `cartridge`.`ID` AS `ID`,
  `cartridge`.`Inventory_Number` AS `Inventory_Number`,
  `cartridge`.`Name_Cartinge` AS `Name_Cartinge`,
  `room`.`Name_Room` AS `Name_Room`,
  `cartridge`.`Description` AS `Description`
FROM (`cartridge`
  JOIN `room`
    ON ((`cartridge`.`ID_Room` = `room`.`ID`)));

--
-- Create table `printer`
--
CREATE TABLE printer (
  ID INT NOT NULL AUTO_INCREMENT,
  Inventory_Number INT DEFAULT NULL,
  Name VARCHAR(50) DEFAULT NULL,
  ID_Cartrige INT DEFAULT NULL,
  ID_Room INT DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 16,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'organization printers table';

--
-- Create foreign key
--
ALTER TABLE printer 
  ADD CONSTRAINT FK_printer_cartridge_ID FOREIGN KEY (ID_Cartrige)
    REFERENCES cartridge(ID);

--
-- Create foreign key
--
ALTER TABLE printer 
  ADD CONSTRAINT FK_printer_room_ID FOREIGN KEY (ID_Room)
    REFERENCES room(ID);

DELIMITER $$

--
-- Create procedure `moving_printer`
--
CREATE 
	DEFINER = 'root'@'localhost'
PROCEDURE moving_printer(IN Inventory_Number INT, IN ID_Room INT)
  COMMENT 'Stored procedure to move the printer to a specified location'
BEGIN
UPDATE printer, cartridge
SET printer.ID_Room = ID_Room,
    cartridge.ID_Room = ID_Room
WHERE (printer.Inventory_Number = Inventory_Number
AND printer.ID_Cartrige = cartridge.ID);
END
$$

DELIMITER ;

--
-- Create view `printer_view`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW printer_view
AS
SELECT
  `printer`.`ID` AS `ID`,
  `printer`.`Inventory_Number` AS `Inventory_Number`,
  `printer`.`Name` AS `Name`,
  `room`.`Name_Room` AS `Name_Room`,
  `printer`.`Description` AS `Description`
FROM (`printer`
  JOIN `room`
    ON ((`printer`.`ID_Room` = `room`.`ID`)));

--
-- Create table `users`
--
CREATE TABLE users (
  ID INT NOT NULL AUTO_INCREMENT,
  Surname VARCHAR(255) DEFAULT NULL,
  Name VARCHAR(50) DEFAULT NULL,
  Login_Auth VARCHAR(255) DEFAULT NULL,
  Password_Auth VARCHAR(255) DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 3,
CHARACTER SET utf8,
COLLATE utf8_general_ci;

DELIMITER $$

--
-- Create procedure `Check_Login_And_Password`
--
CREATE 
	DEFINER = 'root'@'localhost'
PROCEDURE Check_Login_And_Password(IN Login VARCHAR(255), IN Password VARCHAR(255))
BEGIN
SELECT
  *
FROM users
WHERE Login = Login_Auth
AND Password = Password_Auth;

END
$$

DELIMITER ;

--
-- Create table `event_log`
--
CREATE TABLE event_log (
  ID INT NOT NULL AUTO_INCREMENT,
  ID_Users INT DEFAULT NULL,
  DateTime VARCHAR(255) DEFAULT NULL,
  Event VARCHAR(50) DEFAULT NULL,
  Description TEXT DEFAULT NULL,
  PRIMARY KEY (ID)
)
ENGINE = INNODB,
AUTO_INCREMENT = 233,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8,
COLLATE utf8_general_ci,
COMMENT = 'Table of information about the actions of the program user';

--
-- Create foreign key
--
ALTER TABLE event_log 
  ADD CONSTRAINT FK_event_log_users_ID FOREIGN KEY (ID_Users)
    REFERENCES users(ID);

--
-- Create view `event_log_view`
--
CREATE 
	DEFINER = 'root'@'localhost'
VIEW event_log_view
AS
SELECT
  `event_log`.`ID` AS `ID`,
  `event_log`.`DateTime` AS `DateTime`,
  `users`.`Surname` AS `Surname`,
  `event_log`.`Event` AS `Event`
FROM (`event_log`
  JOIN `users`
    ON ((`event_log`.`ID_Users` = `users`.`ID`)));

-- 
-- Restore previous SQL mode
-- 
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;

-- 
-- Enable foreign keys
-- 
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;