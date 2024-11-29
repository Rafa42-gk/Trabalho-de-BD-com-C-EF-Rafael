create database AvaliacaoLoja
go

use AvaliacaoLoja
go

create table Vendas(
VendasId int identity primary key,
Produto nvarchar(100),
Descricao nvarchar(max),
DataVenda date,
Valor decimal(18,2),
);
go

insert into Vendas values
('Notebook Dell Inspiron', 'Notebook com processador Intel Core i7, 16GB RAM e SSD de 512GB.', '2024-11-01', 4500.00),
('Smartphone Samsung Galaxy S21', 'Smartphone com tela AMOLED, 128GB de armazenamento.', '2024-10-25', 3200.50),
('Fone de Ouvido Bluetooth JBL', 'Fone de ouvido sem fio com cancelamento de ruído.', '2024-10-30', 599.99),
('Teclado Mecânico Logitech', 'Teclado com switches mecânicos e iluminação RGB.', '2024-11-15', 750.00),
('Placa de Vídeo NVIDIA RTX 4070', 'Placa de vídeo com 12GB GDDR6 para alto desempenho.', '2024-11-22', 3600.99),
('Console PlayStation 5', 'Console de última geração da Sony, com SSD ultrarrápido.', '2024-11-23', 3299.00);
go

select * from Vendas
go