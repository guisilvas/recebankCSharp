# recebankCSharp
Sistema bancário com Banco de Dados - Desenvolvimento de Sistemas: Módulo Desenvolvimento Mobile - C#

## Banco de dados

-- Destrui o banco caso já exista
DROP DATABASE IF EXISTS `recebankDB`;

-- Cria o Banco de Dados
CREATE DATABASE `recebankDB`;
-- Utilizando o Banco de Dados
USE `recebankDB`;

-- Cria a tabela user
CREATE TABLE `user` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `cpf` varchar(11) NOT NULL UNIQUE,
  `birth_date` date NOT NULL,
  `phone` varchar(11) NOT NULL,
  `state` varchar(255) NOT NULL,
  `city` varchar(255) NOT NULL,
  `income` float(11) NOT NULL,
  PRIMARY KEY (`user_id`)
);

-- Inserindo dados na tabela user
INSERT INTO `user` (`name`, `cpf`, `birth_date`, `phone`, `state`, `city`, `income`) VALUES
('Douglas', '12345678910', '2000-01-01', '37988887777', 'Minas Gerais', 'Divinópolis', 50000),
('Breno', '01234567890', '2001-11-11', '37988887777', 'Minas Gerais', 'Divinópolis', 70000),
('Iran Ferreira', '00011122233', '2003-07-05', '37988887777', 'São Paulo', 'São Paulo', 100000);

-- Criando a tabela product
CREATE TABLE `product` (
  `product_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `min_income` int(11) NOT NULL,
  PRIMARY KEY (`product_id`)
);

-- Inserindo dados na tabela product
INSERT INTO `product` (`name`, `min_income`) VALUES
('Cartão de Crédito', 2000),
('Empréstimo', 5000),
('Financiamento', 10000),
('Seguro', 8000);

-- Criando a tabela user_product
CREATE TABLE `user_product` (
  `userProduct_id` int NOT NULL AUTO_INCREMENT,
  `user_id` int NOT NULL,  -- Corrigido para int
  `product_id` int NOT NULL,  -- Corrigido para int
  PRIMARY KEY (`userProduct_id`),
  FOREIGN KEY (`user_id`) REFERENCES `user`(`user_id`),
  FOREIGN KEY (`product_id`) REFERENCES `product`(`product_id`)
);

