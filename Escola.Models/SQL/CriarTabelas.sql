DROP TABLE Usuario;

CREATE TABLE Usuario
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    NomeDeUsuario NVARCHAR(50) NOT NULL UNIQUE,
    HashSenha VARBINARY(64) NOT NULL,
    SaltSenha VARBINARY(32) NOT NULL,
    EhAdmin BIT NOT NULL DEFAULT 0,
    ContagemSenhaIncorreta INT NOT NULL DEFAULT 0
);

/*
criar gerador de senhas para ele
mostra lista de usuários bloqueados de cara
*/

UPDATE Usuario
SET EhAdmin = 1
WHERE NomeDeUsuario = 'diego.moreira';

SELECT * FROM Usuario;



CREATE TABLE Aluno
(
    Matricula INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    DataNascimento DATE NOT NULL
);

INSERT INTO Aluno
VALUES
('Diego Moreira de Oliveira', '1997-07-02'),
('Paloma Moreira Dantas', '1999-02-25'),
('Fernando Alonso', '1992-05-25')
;

SELECT * FROM Aluno;
