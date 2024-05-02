CREATE TABLE Clientes (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(100),
    Sobrenome NVARCHAR(100),
    Email NVARCHAR(100),
    Telefone NVARCHAR(20),
    DataNascimento DATETIME,
    DataCadastro DATETIME DEFAULT GETDATE()
);

INSERT INTO Clientes (Nome, Sobrenome, Email, Telefone, DataNascimento, DataCadastro)
VALUES
    ('John', 'Doe', 'john@example.com', '123-456-7890', '1990-05-15', GETDATE()),
    ('Jane', 'Smith', 'jane@example.com', '456-789-0123', '1985-08-20', GETDATE()),
    ('Alice', 'Johnson', 'alice@example.com', '789-012-3456', '1995-02-10', GETDATE()),
    ('Bob', 'Brown', 'bob@example.com', '234-567-8901', '1980-11-25', GETDATE()),
    ('Emily', 'Davis', 'emily@example.com', '567-890-1234', '1992-07-30', GETDATE()),
    ('Michael', 'Wilson', 'michael@example.com', '890-123-4567', '1987-04-05', GETDATE()),
    ('Samantha', 'Martinez', 'samantha@example.com', '345-678-9012', '1998-09-12', GETDATE()),
    ('David', 'Anderson', 'david@example.com', '678-901-2345', '1983-12-28', GETDATE()),
    ('Jessica', 'Taylor', 'jessica@example.com', '901-234-5678', '1993-03-18', GETDATE()),
    ('William', 'Thompson', 'william@example.com', '012-345-6789', '1989-06-23', GETDATE());