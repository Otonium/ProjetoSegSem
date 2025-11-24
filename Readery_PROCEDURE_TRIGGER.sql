USE Readery

INSERT INTO Usuario(Nome, Email, SenhaHash, FotoURL, DataCadastro)
VALUES
('Pablo', 'pablopesadelo@email.com', HASHBYTES('SHA2_256', 'pesadelo123'), 'https://pablopesadelopiCture.com', '2025-10-16')

-- PROCEDURE
CREATE PROCEDURE adicionarLivro
	@Titulo NVARCHAR(150),
	@Sinopse NVARCHAR(MAX),
	@ISBN VARCHAR(15),
	@NumPaginas INT,
	@CapaURL NVARCHAR(500),
	@EditoraId INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Livro(Titulo, Sinopse, ISBN, NumPaginas, CapaURL, EditoraId)
	VALUES (@Titulo, @Sinopse, @ISBN, @NumPaginas, @CapaURL, @EditoraId)
END


--TESTANDO PROCEDURE
EXEC adicionarLivro 'Trono de Vidro', 'blablabla...', '978-8501401380', 392, 'https://capatronodevidro', 3

SELECT * FROM Livro


-- TRIGGER

CREATE TABLE LogUsuario (
	LogId INT IDENTITY PRIMARY KEY,
	UsuarioId INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	Nome NVARCHAR(100),
	DataCadastro DATETIME2(0) DEFAULT DATEADD(HOUR, -3, SYSUTCDATETIME())
);

CREATE TRIGGER trg_LogUsuario
ON Usuario
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON
	INSERT INTO LogUsuario(UsuarioId, Nome)
	SELECT IdUsuario, Nome FROM inserted
END

--TESTANDO TRIGGER
INSERT INTO Usuario(Nome, Email, SenhaHash, FotoURL, DataCadastro)
VALUES
('Rafaella', 'rafarafarafa@email.com', HASHBYTES('SHA2_256', '12341234'), 'https://rafa.com', '2025-10-16')

SELECT * FROM Usuario
SELECT * FROM LogUsuario