CREATE TABLE Aluno
(
    Matricula INT NOT NULL PRIMARY KEY IDENTITY(1,1),
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