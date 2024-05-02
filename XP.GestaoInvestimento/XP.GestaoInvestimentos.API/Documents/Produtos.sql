CREATE TABLE Produto (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Descricao NVARCHAR(255),
    DataCadastro DATETIME DEFAULT GETDATE(),
    UsuarioCadastro NVARCHAR(100),
    DataAlteracao DATETIME,
    UsuarioAlteracao NVARCHAR(100),
    ValorMinimo DECIMAL(18, 2),
    ValorMaximo DECIMAL(18, 2),
    TaxaJurosMensal DECIMAL(5, 2),
    TaxasExtras NVARCHAR(MAX),
    TempoMinimoResgate INT,
    DataVencimento DATETIME
);


INSERT INTO Produto (Descricao, UsuarioCadastro, ValorMinimo, ValorMaximo, TaxaJurosMensal, TaxasExtras, TempoMinimoResgate, DataVencimento)
VALUES
    ('Renda Fixa', 'admin', 100.00, 10000.00, 0.5, 'Taxa de administração: 0.1%', 30, '2024-06-30'),
    ('Tesouro Direto', 'admin', 500.00, 5000.00, 0.7, 'Taxa de custódia: 0.3%', 60, '2024-07-15'),
    ('CDB', 'admin', 1000.00, 100000.00, 0.8, 'Imposto de renda: 15%', 90, '2024-08-20'),
    ('Bitcoin', 'admin', 500.00, 10000.00, 1.5, 'Taxa de corretagem: 0.5%', NULL, NULL),
    ('Ethereum', 'admin', 200.00, 5000.00, 1.8, 'Taxa de câmbio: 1%', NULL, NULL);