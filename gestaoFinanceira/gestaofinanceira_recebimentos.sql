-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: gestaofinanceira
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `recebimentos`
--

DROP TABLE IF EXISTS `recebimentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recebimentos` (
  `id_recebimento` int NOT NULL AUTO_INCREMENT,
  `valor` decimal(10,0) NOT NULL,
  `data_vencimento` varchar(10) NOT NULL,
  `data_pagamento` varchar(10) NOT NULL,
  `status_recebimento` varchar(20) NOT NULL,
  `fk_id_venda` int NOT NULL,
  `fk_id_caixa` int NOT NULL,
  PRIMARY KEY (`id_recebimento`),
  KEY `fk_id_venda` (`fk_id_venda`),
  KEY `fk_id_caixa` (`fk_id_caixa`),
  CONSTRAINT `recebimentos_ibfk_1` FOREIGN KEY (`fk_id_venda`) REFERENCES `venda` (`id_venda`),
  CONSTRAINT `recebimentos_ibfk_2` FOREIGN KEY (`fk_id_caixa`) REFERENCES `caixa` (`id_caixa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recebimentos`
--

LOCK TABLES `recebimentos` WRITE;
/*!40000 ALTER TABLE `recebimentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `recebimentos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-05 13:19:23
