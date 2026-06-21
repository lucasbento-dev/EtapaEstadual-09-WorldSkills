CREATE DATABASE Hospital;
GO

USE Hospital;
GO

CREATE TABLE Medicos (
	Id_medico INT IDENTITY(1,1) PRIMARY KEY,
	CRM NCHAR(10) NOT NULL UNIQUE,
	NomeCompleto NVARCHAR(150) NOT NULL,
	Formacao NVARCHAR(50) NOT NULL,
	Especialidade NVARCHAR(50) NOT NULL,
	FotoPerfil VARBINARY(MAX)
);
GO

CREATE TABLE Pacientes (
	Id_paciente INT IDENTITY(1,1) PRIMARY KEY,
	CPF NCHAR(11) NOT NULL UNIQUE,
	Nome NVARCHAR(50) NOT NULL,
	Sobrenome NVARCHAR(100) NOT NULL,
	Idade INT NOT NULL,
	Altura DECIMAL(3,2) NOT NULL,
	Peso DECIMAL(6,3) NOT NULL,
	TipoParto NVARCHAR(20) CHECK (TipoParto IN ('Normal', 'Cesária')),
	FotoPerfil VARBINARY(MAX),
	Id_medico INT NOT NULL,
	FOREIGN KEY (Id_medico)
	REFERENCES Medicos(Id_medico)
);
GO

CREATE TABLE Nascimentos (
	Id_nascimento INT IDENTITY(1,1) PRIMARY KEY,
	Registro NCHAR(5) NOT NULL,
	CPFMae NCHAR(11) NOT NULL,
	Peso DECIMAL(6,3) NOT NULL,
	Tamanho DECIMAL(3,2) NOT NULL,
	DataNascimento DATE DEFAULT GETDATE(),
	HoraNascimento TIME DEFAULT GETDATE(),
	ObservacoesRelevantes NVARCHAR(MAX),
	Id_paciente INT NOT NULL,
	FOREIGN KEY (Id_paciente)
	REFERENCES Pacientes(Id_paciente)
);
GO

CREATE TABLE Cargos (
	Id_cargo INT IDENTITY(1,1) PRIMARY KEY,
	Codigo NCHAR(10) NOT NULL UNIQUE,
	Descricao NVARCHAR(MAX),
	Salario DECIMAL(10,2) NOT NULL
);
GO

CREATE TABLE Funcionarios (
	Id_funcionario INT IDENTITY(1,1) PRIMARY KEY,
	Matricula NCHAR(10) NOT NULL,
	Nome NVARCHAR(50) NOT NULL,
	Sobrenome NVARCHAR(100) NOT NULL,
	Setor NVARCHAR(30) NOT NULL,
	CPF NCHAR(11) NOT NULL UNIQUE,
	RG NCHAR(11) NOT NULL UNIQUE,
	Email NVARCHAR(150) NOT NULL UNIQUE,
	Senha NVARCHAR(50) NOT NULL,
	DataContratacao DATETIME DEFAULT GETDATE(),
	Id_cargo INT NOT NULL,
	FOREIGN KEY (Id_cargo)
	REFERENCES Cargos(Id_cargo)
);
GO

CREATE TABLE Telefones (
	Id_funcionario INT NOT NULL,
	Telefone NCHAR(11) NOT NULL,
	FOREIGN KEY (Id_funcionario)
	REFERENCES Funcionarios(Id_funcionario)
);
GO

CREATE TABLE Endereco (
	Id_funcionario INT NOT NULL,
	Estado NVARCHAR(50) NOT NULL,
	Cidade NVARCHAR(50) NOT NULL,
	Bairro NVARCHAR(50) NOT NULL,
	Rua NVARCHAR(100) NOT NULL,
	Numero INT NOT NULL
);
GO

INSERT INTO Cargos (Codigo, Descricao, Salario)
VALUES
('1234567890', 'Descrição 1', 1000.00),
('0987654321', 'Descrição 2', 2000.00),
('1234509876', 'Descrição 3', 3000.00),
('0987612345', 'Descrição 4', 4000.00),
('5432109876', 'Descrição 5', 5000.00);
GO

INSERT INTO Funcionarios (Matricula, Nome, Sobrenome, Setor, CPF, RG, Email, Senha, DataContratacao, Id_cargo)
VALUES
('PET4567890', 'Nome 1', 'Sobrenome 1', 'Setor 1', '12345678910', '72354274211', 'exemplo1@email.com', 'senhateste', GETDATE(), 1),
('PET7654321', 'Nome 2', 'Sobrenome 2', 'Setor 2', '73763746647', '37462842832', 'exemplo2@email.com', 'senhateste', GETDATE(), 2),
('PET4509876', 'Nome 3', 'Sobrenome 3', 'Setor 3', '23445542346', '55536646651', 'exemplo3@email.com', 'senhateste', GETDATE(), 3),
('PET7612345', 'Nome 4', 'Sobrenome 4', 'Setor 4', '75675685433', '78517545961', 'exemplo4@email.com', 'senhateste', GETDATE(), 4),
('PET2109876', 'Nome 5', 'Sobrenome 5', 'Setor 5', '13423241453', '11145444412', 'exemplo5@email.com', 'senhateste', GETDATE(), 5),
('PET4785476', 'Nome 6', 'Sobrenome 6', 'Setor 6', '23145155546', '55536649691', 'exemplo6@email.com', 'senhateste', GETDATE(), 1),
('PET7613145', 'Nome 7', 'Sobrenome 7', 'Setor 7', '75675647883', '78488485961', 'exemplo7@email.com', 'senhateste', GETDATE(), 2),
('PET2144782', 'Nome 8', 'Sobrenome 8', 'Setor 8', '13145141453', '11141414112', 'exemplo8@email.com', 'senhateste', GETDATE(), 3);
GO

INSERT INTO Telefones (Id_funcionario, Telefone)
VALUES
(1, '12884758295'),
(2, '12884564295'),
(3, '12454545295'),
(4, '12884212195'),
(5, '12884757575'),
(6, '17874758295'),
(7, '12884751235'),
(8, '12887898295');
GO

INSERT INTO Endereco (Id_funcionario, Estado, Cidade, Bairro, Rua, Numero)
VALUES
(1, 'RJ', 'Petrópolis', 'Bingen', 'Rua Bingen', 1),
(2, 'RJ', 'Petrópolis', 'Bingen', 'Rua Bingen', 2),
(3, 'RJ', 'Petrópolis', 'Bingen', 'Rua Bingen', 3),
(4, 'RJ', 'Petrópolis', 'Bingen', 'Rua Bingen', 4),
(5, 'RJ', 'Petrópolis', 'Bingen', 'Rua Bingen', 5),
(6, 'RJ', 'Petrópolis', 'Bingen', 'Rua Bingen', 6),
(7, 'RJ', 'Petrópolis', 'Bingen', 'Rua Bingen', 7),
(8, 'RJ', 'Petrópolis', 'Bingen', 'Rua Bingen', 8);

INSERT INTO Medicos (CRM, NomeCompleto, Formacao, Especialidade)
VALUES
('A123456789', 'Nome 1', 'Faculdade 1', 'Algo 1'),
('B123456789', 'Nome 2', 'Faculdade 2', 'Algo 2'),
('C123456789', 'Nome 3', 'Faculdade 3', 'Algo 3');

INSERT INTO Pacientes (CPF, Nome, Sobrenome, Idade, Altura, Peso, TipoParto, Id_medico)
VALUES
('12345678910', 'Nome 1', 'Sobrnome 1', 21, 1.61, 61, 'Normal', 1),
('22345678910', 'Nome 2', 'Sobrnome 2', 22, 1.62, 62, 'Normal', 2),
('32345678910', 'Nome 3', 'Sobrnome 3', 23, 1.63, 63, 'Normal', 3),
('42345678910', 'Nome 4', 'Sobrnome 4', 24, 1.64, 64, 'Normal', 1),
('52345678910', 'Nome 5', 'Sobrnome 5', 25, 1.65, 65, 'Normal', 2),
('62345678910', 'Nome 6', 'Sobrnome 6', 26, 1.66, 66, 'Normal', 3);

INSERT INTO Nascimentos (Registro, CPFMae, Peso, Tamanho, DataNascimento, HoraNascimento, ObservacoesRelevantes, Id_paciente)
VALUES
('12345', '12345678910', 3.601, 0.31, GETDATE(), GETDATE(), 'OBS 1', 1),
('22345', '22345678910', 3.602, 0.32, GETDATE(), GETDATE(), 'OBS 2', 2),
('32345', '32345678910', 3.603, 0.33, GETDATE(), GETDATE(), 'OBS 3', 3),
('42345', '42345678910', 3.604, 0.34, GETDATE(), GETDATE(), 'OBS 4', 4),
('52345', '52345678910', 3.605, 0.35, GETDATE(), GETDATE(), 'OBS 5', 5),
('62345', '62345678910', 3.606, 0.36, GETDATE(), GETDATE(), 'OBS 6', 6);