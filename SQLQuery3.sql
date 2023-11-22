-- Tabela Aluno
CREATE TABLE Aluno (
    AlunoID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    DataNascimento DATE,
    Email NVARCHAR(255) UNIQUE
);

-- Tabela Professor
CREATE TABLE Professor (
    ProfessorID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    DataContratacao DATE,
    Email NVARCHAR(255) UNIQUE
);

CREATE TABLE Disciplina (
    DisciplinaID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    Horas INT,  -- Adicionado para os exemplos de consulta
    ProfessorID INT,
    FOREIGN KEY (ProfessorID) REFERENCES Professor(ProfessorID)
);

-- Tabela Curso com data de início e fim
CREATE TABLE Curso (
    CursoID INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    DataInicio DATE NOT NULL,
    DataFim DATE NOT NULL,
    AlunoID INT,
    DisciplinaID INT,
    FOREIGN KEY (AlunoID) REFERENCES Aluno(AlunoID),
    FOREIGN KEY (DisciplinaID) REFERENCES Disciplina(DisciplinaID)
);

-- Alunos
INSERT INTO Aluno (Nome, DataNascimento, Email) VALUES ('João Silva', '2000-01-15', 'joao.silva@email.com');
INSERT INTO Aluno (Nome, DataNascimento, Email) VALUES ('Maria Fernandes', '1999-06-10', 'maria.fernandes@email.com');
INSERT INTO Aluno (Nome, DataNascimento, Email) VALUES ('Carlos Pereira', '2001-02-22', 'carlos.pereira@email.com');

-- Professores
INSERT INTO Professor (Nome, DataContratacao, Email) VALUES ('Dr. Antônio Castro', '2015-01-01', 'antonio.castro@email.com');
INSERT INTO Professor (Nome, DataContratacao, Email) VALUES ('Dra. Regina Faria', '2018-05-05', 'regina.faria@email.com');

-- Disciplinas (considerando 50 horas para cada disciplina)
INSERT INTO Disciplina (Nome, Horas, ProfessorID) VALUES ('Matemática', 50, 1);
INSERT INTO Disciplina (Nome, Horas, ProfessorID) VALUES ('História', 50, 2);

-- Cursos
INSERT INTO Curso (Nome, DataInicio, DataFim, AlunoID, DisciplinaID) VALUES ('Curso de Verão', '2023-01-15', '2023-02-15', 1, 1);
INSERT INTO Curso (Nome, DataInicio, DataFim, AlunoID, DisciplinaID) VALUES ('Curso de Inverno', '2023-06-05', '2023-07-05', 2, 4);