﻿
CREATE DATABASE DB_

CREATE TABLE TB_FUNCIONARIOS 
(
	ID INT PRIMARY KEY NOT NULL IDENTITY,
	NOME VARCHAR(200) NOT NULL,
	DEPTO VARCHAR(40) NOT NULL,
	FUNCAO VARCHAR(40) NOT NULL,
	SALARIO DECIMAL(10,2) NOT NULL
)
GO