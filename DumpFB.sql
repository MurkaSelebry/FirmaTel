CREATE DATABASE  IF NOT EXISTS `firmadb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `firmadb`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: firmadb
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `abonnents`
--

DROP TABLE IF EXISTS `abonnents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `abonnents` (
  `Kod_abonenta` int NOT NULL,
  `Nomber_telefona` varchar(15) DEFAULT NULL,
  `INN` varchar(12) DEFAULT NULL,
  `Adres` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Kod_abonenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `abonnents`
--

LOCK TABLES `abonnents` WRITE;
/*!40000 ALTER TABLE `abonnents` DISABLE KEYS */;
INSERT INTO `abonnents` VALUES (1,'+79001234567','7707083893','ул. Ленина,  10, Москва'),(2,'+79002345678','7707083894','пр. Мира,  20, Санкт-Петербург'),(3,'+79003456789','7707083895','ул. Гоголя,  30, Екатеринбург'),(4,'+79004567890','7707083896','пр. Ленина,  40, Новосибирск'),(5,'+79005678901','7707083897','ул. Пушкина,  50, Казань'),(6,'+79006789012','7707083898','пер. Гагарина,  60, Ростов-на-Дону'),(7,'+79007890123','7707083899','пл. Октября,  70, Волgograd'),(8,'+79008901234','7707083900','пр. Маяковского,  80, Омск'),(9,'+79009012345','7707083901','ул. Баумана,  90, Челябинск'),(10,'+79010123456','7707083902','пр. Свердлова,  100, Уфа'),(11,'+79011234567','7707083903','ул. Достоевского,  110, Красноярск'),(12,'+79012345678','7707083904','пер. Толстого,  120, Самара'),(13,'+79013456789','7707083905','пл. Ленина,  130, Нижний Новгород'),(14,'+79014567890','7707083906','ул. Горького,  140, Краснодар'),(15,'+79015678901','7707083907','пер. Тургенева,  150, Владивосток'),(16,'+79016789012','7707083908','пл. Победы,  160, Иркутск'),(17,'+79017890123','7707083909','пр. Ленина,  170, Тюмень'),(18,'+79018901234','7707083910','ул. Революции,  180, Сочи'),(19,'+79019012345','7707083911','пер. Кирова,  190, Воронеж'),(20,'+79020123456','7707083912','пл. Гагарина,  200, Пермь'),(21,'+79021234567','7707083913','ул. Кирова,  210, Томск'),(22,'+79022345678','7707083914','пр. Мира,  220, Ярославль'),(23,'+79023456789','7707083915','ул. Ленина,  230, Ульяновск'),(24,'+79024567890','7707083916','пер. Маяковского,  240, Тольятти'),(25,'+79025678901','7707083917','пл. Свердлова,  250, Ижевск'),(26,'2312','12342','Пушкина'),(202855,'+79001212367','7701233','FSDf');
/*!40000 ALTER TABLE `abonnents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `goroda`
--

DROP TABLE IF EXISTS `goroda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `goroda` (
  `Kod_goroda` int NOT NULL,
  `Nazvanie` varchar(255) DEFAULT NULL,
  `Tarif_dnevnoy` decimal(5,2) DEFAULT NULL,
  `Tarif_nochnoy` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`Kod_goroda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `goroda`
--

LOCK TABLES `goroda` WRITE;
/*!40000 ALTER TABLE `goroda` DISABLE KEYS */;
INSERT INTO `goroda` VALUES (1,'Москва',1.00,0.75),(2,'Санкт-Петербург',1.50,1.25),(3,'Екатеринбург',1.25,0.90),(4,'Новосибирск',1.20,0.95),(5,'Казань',1.40,1.10),(6,'Ростов-на-Дону',1.35,1.05),(7,'Волгоград',1.30,1.00),(8,'Омск',1.10,0.85),(9,'Челябинск',1.25,0.95),(10,'Уфа',1.30,1.00),(11,'Красноярск',1.15,0.90),(12,'Самара',1.30,1.05),(13,'Нижний Новгород',1.20,0.95),(14,'Краснодар',1.35,1.10),(15,'Владивосток',1.40,1.15),(16,'Иркутск',1.25,0.95),(17,'Тюмень',1.20,0.90),(18,'Сочи',1.45,1.20),(19,'Воронеж',1.30,1.05),(20,'Пермь',1.35,1.10),(21,'Томск',1.20,0.95),(22,'Ярославль',1.25,1.00),(23,'Ульяновск',1.30,1.05),(24,'Тольятти',1.35,1.10),(25,'Ижевск',1.20,0.95),(26,'Ивнев',1.23,1.24),(27,'Ижевск',1.23,1.24);
/*!40000 ALTER TABLE `goroda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `peregovory`
--

DROP TABLE IF EXISTS `peregovory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `peregovory` (
  `Kod_peregovorov` int NOT NULL AUTO_INCREMENT,
  `Kod_abonenta` int DEFAULT NULL,
  `Kod_goroda` int DEFAULT NULL,
  `Data` date DEFAULT NULL,
  `Kolichestvo_minut` int DEFAULT NULL,
  `Vremya_sutok` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Kod_peregovorov`),
  KEY `Kod_abonenta` (`Kod_abonenta`),
  KEY `Kod_goroda` (`Kod_goroda`),
  CONSTRAINT `peregovory_ibfk_1` FOREIGN KEY (`Kod_abonenta`) REFERENCES `abonnents` (`Kod_abonenta`),
  CONSTRAINT `peregovory_ibfk_2` FOREIGN KEY (`Kod_goroda`) REFERENCES `goroda` (`Kod_goroda`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `peregovory`
--

LOCK TABLES `peregovory` WRITE;
/*!40000 ALTER TABLE `peregovory` DISABLE KEYS */;
INSERT INTO `peregovory` VALUES (1,1,1,'2024-02-01',30,'утро'),(2,2,2,'2024-02-02',45,'день'),(3,3,3,'2024-02-03',60,'вечер'),(4,8,7,'2024-02-07',50,'день'),(5,9,8,'2024-02-08',55,'вечер'),(6,10,9,'2024-02-09',60,'утро'),(7,11,10,'2024-02-10',65,'день'),(8,12,11,'2024-02-11',70,'вечер'),(9,13,12,'2024-02-12',75,'утро'),(10,14,13,'2024-02-13',80,'день'),(11,15,14,'2024-02-14',85,'вечер'),(12,16,15,'2024-02-15',90,'утро'),(13,17,16,'2024-02-16',95,'день'),(14,18,17,'2024-02-17',100,'вечер'),(15,19,18,'2024-02-18',105,'утро'),(16,20,19,'2024-02-19',110,'день'),(17,21,20,'2024-02-20',115,'вечер'),(18,22,21,'2024-02-21',120,'утро'),(19,23,22,'2024-02-22',125,'день'),(20,24,23,'2024-02-23',130,'вечер'),(21,25,24,'2024-02-24',135,'утро'),(22,4,25,'2024-02-25',140,'день'),(23,5,4,'2024-02-26',145,'вечер'),(24,6,5,'2024-02-27',150,'утро'),(25,7,6,'2024-02-28',155,'день'),(26,8,7,'2024-02-29',160,'вечер'),(27,1,1,'2024-02-27',1,'день');
/*!40000 ALTER TABLE `peregovory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `skidki`
--

DROP TABLE IF EXISTS `skidki`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `skidki` (
  `Kod_goroda` int NOT NULL AUTO_INCREMENT,
  `Skidka` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`Kod_goroda`),
  CONSTRAINT `skidki_ibfk_1` FOREIGN KEY (`Kod_goroda`) REFERENCES `goroda` (`Kod_goroda`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `skidki`
--

LOCK TABLES `skidki` WRITE;
/*!40000 ALTER TABLE `skidki` DISABLE KEYS */;
INSERT INTO `skidki` VALUES (1,0.10),(2,0.15),(3,0.12),(4,0.12),(5,0.13),(6,0.11),(7,0.10),(8,0.09),(9,0.11),(10,0.10),(11,0.08),(12,0.11),(13,0.12),(14,0.13),(15,0.14),(16,0.11),(17,0.09),(18,0.15),(19,0.10),(20,0.13),(21,0.12),(22,0.10),(23,0.11),(24,0.13),(25,0.12);
/*!40000 ALTER TABLE `skidki` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-27  0:56:57
