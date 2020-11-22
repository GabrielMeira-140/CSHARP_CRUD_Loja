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
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtos` (
  `id_produto` int(11) NOT NULL AUTO_INCREMENT,
  `destribuidor` varchar(50) NOT NULL,
  `marca` varchar(50) NOT NULL,
  `descricao_produto` varchar(150) NOT NULL,
  `tamanho_produto` tinytext NOT NULL,
  `sexo` tinytext NOT NULL,
  `quantidade` int(11) NOT NULL,
  `preco` decimal(5,2) NOT NULL,
  `precoCliente` decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (`id_produto`)
) ENGINE=MyISAM AUTO_INCREMENT=71 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` VALUES (33,'teste','teste','Camiseta 3','PP','Unisex',500,30.00,36.00),(32,'teste','teste','Camiseta 2','PP','Unisex',500,50.00,60.00),(31,'teste','teste','Camiseta 1','PP','Unisex',500,35.00,42.00),(34,'teste','teste','Camiseta 4','PP','Unisex',500,70.00,84.00),(35,'teste','teste','Camiseta 5','PP','Unisex',500,130.00,156.00),(36,'teste','teste','Camiseta 6','PP','Unisex',500,20.00,24.00),(37,'teste','teste','Camiseta 7','PP','Unisex',500,35.00,42.00),(38,'teste','teste','Camiseta 8','PP','Unisex',500,120.00,144.00),(39,'teste','teste','Camiseta 9','PP','Unisex',500,150.00,180.00),(40,'teste','teste','Camiseta 10','PP','Unisex',500,115.00,138.00),(41,'teste','teste','Camiseta 11','PP','Unisex',500,25.00,30.00),(42,'teste','teste','Camiseta 12','PP','Unisex',500,40.00,48.00),(43,'teste','teste','Camiseta 13','PP','Unisex',500,60.00,72.00),(44,'teste','teste','Camiseta 14','PP','Unisex',500,95.00,114.00),(45,'teste','teste','Camiseta 15','PP','Unisex',500,15.00,18.00),(46,'teste','teste','Camiseta 16','PP','Unisex',500,10.00,12.00),(47,'teste','teste','Camiseta 17','PP','Unisex',500,150.00,180.00),(48,'teste','teste','Camiseta 18','PP','Unisex',500,20.00,24.00),(49,'teste','teste','Camiseta 19','PP','Unisex',500,95.00,114.00),(50,'teste','teste','Camiseta 20','PP','Unisex',500,250.00,300.00),(51,'teste','teste','Calça 1','PP','Unisex',500,250.00,300.00),(52,'teste','teste','Calça 2','PP','Unisex',500,300.00,360.00),(53,'teste','teste','Calça 3','PP','Unisex',500,70.00,84.00),(54,'teste','teste','Calça 4','PP','Unisex',500,60.00,72.00),(55,'teste','teste','Calça 5','PP','Unisex',500,90.00,108.00),(56,'teste','teste','Calça 6','PP','Unisex',500,100.00,120.00),(57,'teste','teste','Calça 7','PP','Unisex',500,300.00,360.00),(58,'teste','teste','Calça 8','PP','Unisex',500,120.00,144.00),(59,'teste','teste','Calça 9','PP','Unisex',500,60.00,72.00),(60,'teste','teste','Calça 10','PP','Unisex',500,100.00,120.00),(61,'teste','teste','Calça 11','PP','Unisex',500,360.00,432.00),(62,'teste','teste','Calça 12','PP','Unisex',500,220.00,264.00),(63,'teste','teste','Calça 13','PP','Unisex',500,110.00,132.00),(64,'teste','teste','Calça 14','PP','Unisex',500,150.00,180.00),(65,'teste','teste','Calça 15','PP','Unisex',500,160.00,192.00),(66,'teste','teste','Calça 16','PP','Unisex',500,200.00,240.00),(67,'teste','teste','Calça 17','PP','Unisex',500,180.00,216.00),(68,'teste','teste','Calça 18','PP','Unisex',500,160.00,192.00),(69,'teste','teste','Calça 19','PP','Unisex',500,150.00,180.00),(70,'teste','teste','Calça 20','PP','Unisex',500,200.00,240.00);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
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
