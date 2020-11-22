CREATE DATABASE  IF NOT EXISTS `loja` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `loja`;
-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: loja
-- ------------------------------------------------------
-- Server version	5.7.31

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
-- Table structure for table `dados`
--

DROP TABLE IF EXISTS `dados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dados` (
  `nome` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `camiseta1` int(11) DEFAULT NULL,
  `camiseta2` int(11) DEFAULT NULL,
  `camiseta3` int(11) DEFAULT NULL,
  `camiseta4` int(11) DEFAULT NULL,
  `camiseta5` int(11) DEFAULT NULL,
  `camiseta6` int(11) DEFAULT NULL,
  `camiseta7` int(11) DEFAULT NULL,
  `camiseta8` int(11) DEFAULT NULL,
  `camiseta9` int(11) DEFAULT NULL,
  `camiseta10` int(11) DEFAULT NULL,
  `camiseta11` int(11) DEFAULT NULL,
  `camiseta12` int(11) DEFAULT NULL,
  `camiseta13` int(11) DEFAULT NULL,
  `camiseta14` int(11) DEFAULT NULL,
  `camiseta15` int(11) DEFAULT NULL,
  `camiseta16` int(11) DEFAULT NULL,
  `camiseta17` int(11) DEFAULT NULL,
  `camiseta18` int(11) DEFAULT NULL,
  `camiseta19` int(11) DEFAULT NULL,
  `camiseta20` int(11) DEFAULT NULL,
  `Calca1` int(11) DEFAULT NULL,
  `Calca2` int(11) DEFAULT NULL,
  `Calca3` int(11) DEFAULT NULL,
  `Calca4` int(11) DEFAULT NULL,
  `Calca5` int(11) DEFAULT NULL,
  `Calca6` int(11) DEFAULT NULL,
  `Calca7` int(11) DEFAULT NULL,
  `Calca8` int(11) DEFAULT NULL,
  `Calca9` int(11) DEFAULT NULL,
  `Calca10` int(11) DEFAULT NULL,
  `Calca11` int(11) DEFAULT NULL,
  `Calca12` int(11) DEFAULT NULL,
  `Calca13` int(11) DEFAULT NULL,
  `Calca14` int(11) DEFAULT NULL,
  `Calca15` int(11) DEFAULT NULL,
  `Calca16` int(11) DEFAULT NULL,
  `Calca17` int(11) DEFAULT NULL,
  `Calca18` int(11) DEFAULT NULL,
  `Calca19` int(11) DEFAULT NULL,
  `Calca20` int(11) DEFAULT NULL,
  `total` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dados`
--

LOCK TABLES `dados` WRITE;
/*!40000 ALTER TABLE `dados` DISABLE KEYS */;
INSERT INTO `dados` VALUES ('Teste','Teste@teste.com',3,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,1,0,0,0,0,0,0,0,NULL,0,0,0,0,0,0,0,0,0,0,1506);
/*!40000 ALTER TABLE `dados` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-18 14:51:05
