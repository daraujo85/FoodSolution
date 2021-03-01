CREATE DATABASE [foodsolution];
USE [foodsolution];

--DROP TABLE foodsolution.dbo.ingrediente;
CREATE TABLE foodsolution.dbo.ingrediente (
	id int IDENTITY(1,1) NOT NULL,
	descricao varchar(150) NOT NULL,
	valor decimal(10,2) NULL,
	CONSTRAINT ingrediente_PK PRIMARY KEY (id),
	CONSTRAINT ingrediente_UN UNIQUE (descricao)
)

INSERT INTO foodsolution.dbo.ingrediente
VALUES ('Alface', 0.40)
      ,('Bacon', 2)
      ,('Hambúrguer de carne', 3)
      ,('Ovo', 0.80)
      ,('Queijo', 1.50)
      
--DROP TABLE foodsolution.dbo.lanche;
CREATE TABLE foodsolution.dbo.lanche (
	id int IDENTITY(1,1) NOT NULL,
	descricao varchar(150) NOT NULL,	
	CONSTRAINT lanche_PK PRIMARY KEY (id),
	CONSTRAINT lanche_UN UNIQUE (descricao)
)

INSERT INTO foodsolution.dbo.lanche
VALUES ('X-Bacon')
      ,('X-Burger')
      ,('X-Egg')
      ,('X-Egg Bacon')      
      ,('Monte do seu jeito')  
      
--DROP TABLE foodsolution.dbo.lanche_ingrediente;
CREATE TABLE foodsolution.dbo.lanche_ingrediente (
	id int IDENTITY(1,1) NOT NULL,
	ingrediente_id int NOT NULL,
	lanche_id int NOT NULL,
	CONSTRAINT lanche_ingrediente_PK PRIMARY KEY (id),
	CONSTRAINT lanche_ingrediente_UN UNIQUE (lanche_id, ingrediente_id),
	CONSTRAINT lanche_ingrediente_lanche_FK FOREIGN KEY (lanche_id) REFERENCES lanche (id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT lanche_ingrediente_ingrediente_FK FOREIGN KEY (ingrediente_id) REFERENCES ingrediente (id) ON DELETE CASCADE ON UPDATE CASCADE	
)

INSERT INTO foodsolution.dbo.lanche_ingrediente (ingrediente_id, lanche_id)
VALUES (2,1)
      ,(3,1)
      ,(5,1)      
      ,(3,2)
      ,(5,2)      
      ,(4,3)
      ,(3,3)
      ,(5,3)      
      ,(4,4)
      ,(2,4)
      ,(3,4)
      ,(5,4)
      
--DROP TABLE foodsolution.dbo.pedido;
CREATE TABLE foodsolution.dbo.pedido (
	id int IDENTITY(1,1) NOT NULL,
    sub_total decimal(10,2) NULL,
    desconto_geral decimal(10,2) NULL,
    total decimal(10,2) NULL,
    data_pedido datetime NOT NULL,
	CONSTRAINT pedido_PK PRIMARY KEY (id)	
)

--DROP TABLE foodsolution.dbo.pedido_lanche;
CREATE TABLE foodsolution.dbo.pedido_lanche (
	id int IDENTITY(1,1) NOT NULL,
	quantidade int NOT NULL,
	valor_unitario decimal(10,2) NOT NULL,
	desconto decimal(10,2) NOT NULL,
	lanche_id int NOT NULL,
	pedido_id int NOT NULL,
	CONSTRAINT pedido_lanche_PK PRIMARY KEY (id),
	CONSTRAINT pedido_lanche_pedido_FK FOREIGN KEY (pedido_id) REFERENCES pedido (id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT pedido_lanche_lanche_FK FOREIGN KEY (lanche_id) REFERENCES lanche (id) ON DELETE CASCADE ON UPDATE CASCADE
)

--DROP TABLE foodsolution.dbo.pedido_lanche_itens;
CREATE TABLE foodsolution.dbo.pedido_lanche_itens (
	id int IDENTITY(1,1) NOT NULL,
	quantidade int NOT NULL,
	valor_unitario decimal(10,2) NOT NULL,
	ingrediente_id int NOT NULL,
	pedido_lanche_id int NOT NULL,
	CONSTRAINT pedido_lanche_itens_PK PRIMARY KEY (id),
	CONSTRAINT pedido_lanche_itens_pedido_lanche_FK FOREIGN KEY (pedido_lanche_id) REFERENCES pedido_lanche (id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT pedido_lanche_itens_ingrediente_FK FOREIGN KEY (ingrediente_id) REFERENCES ingrediente (id) ON DELETE CASCADE ON UPDATE CASCADE
)


--PROCEDURE DE PERSISTENCIA DE UMA PEDIDO

CREATE PROCEDURE [dbo].[sp_pedido]
 @id int,
 @subtotal decimal(10,2),
 @descontogeral decimal(10,2),
 @total decimal(10,2),
 @operacao nchar(1),
 @novoid int =0 output
AS
if lower(@operacao) = 'i' -- inserir um registro
begin
 begin transaction
 insert into foodsolution.dbo.pedido
 (sub_total, desconto_geral, total, data_pedido)
 values
 (@subtotal, @descontogeral, @total, getdate() )
set @novoid = @@identity
end
else
if lower(@operacao) = 'u' -- alterar um registro
begin
 begin transaction
 update foodsolution.dbo.pedido set
 sub_total = @subtotal, 
 desconto_geral = @descontogeral, 
 total = @total, 
 data_pedido = getdate()
 where id = @id
end
else
if lower(@operacao) = 'd' -- excluir um registro
 begin
 begin transaction
 delete from foodsolution.dbo.pedido
 where id = @id
 end
if @@error <> 0
begin
 rollback transaction
 return(1)
end
else
begin
 commit transaction
 select @novoid
 return(0)
end

--PROCEDURE DE PERSISTENCIA DO PEDIDO_LANCHE

CREATE PROCEDURE [dbo].[sp_pedido_lanche]
 @id int = 0,
 @quantidade int,
 @valorunitario decimal(10,2),
 @desconto decimal(10,2),
 @lancheid int,
 @pedidoid int,
 @operacao nchar(1),
 @novoid int = 0 output
AS
if lower(@operacao) = 'i' -- inserir um registro
begin
 begin transaction
 insert into foodsolution.dbo.pedido_lanche
 (quantidade, valor_unitario, desconto, lanche_id, pedido_id)
 values
 (@quantidade, @valorunitario, @desconto, @lancheid, @pedidoid)
 set @novoid = @@identity
end
else
if lower(@operacao) = 'u' -- alterar um registro
begin
 begin transaction
 update foodsolution.dbo.pedido_lanche set
 quantidade = @quantidade
 ,valor_unitario = @valorunitario
 ,desconto = @desconto
 ,lanche_id = @lancheid
 ,pedido_id = @pedidoid
 where id = @id
end
else
if lower(@operacao) = 'd' -- excluir um registro
 begin
 begin transaction
 delete from foodsolution.dbo.pedido_lanche
 where id = @id
 end
if @@error <> 0
begin
 rollback transaction
 return(1)
end
else
begin
 commit transaction
 select @novoid 
 return(0)
end

--PROCEDURE DE PERSISTENCIA DO PEDIDO_LANCHE_ITENS

CREATE PROCEDURE [dbo].[sp_pedido_lanche_itens]
 @id int = 0,
 @quantidade int,
 @valorunitario decimal(10,2),
 @ingredienteid int,
 @pedidolancheid int,
 @operacao nchar(1),
 @novoid int = 0 output
AS
if lower(@operacao) = 'i' -- inserir um registro
begin
 begin transaction
 insert into foodsolution.dbo.pedido_lanche_itens
 ([quantidade],[valor_unitario],[ingrediente_id],[pedido_lanche_id])
 values
 (@quantidade,@valorunitario,@ingredienteid,@pedidolancheid)
 set @novoid = @@identity
end
else
if lower(@operacao) = 'u' -- alterar um registro
begin
 begin transaction
 update foodsolution.dbo.pedido_lanche_itens set
 quantidade = @quantidade
,valor_unitario = @valorunitario
,ingrediente_id = @ingredienteid
,pedido_lanche_id = @pedidolancheid
 where id = @id
end
else
if lower(@operacao) = 'd' -- excluir um registro
 begin
 begin transaction
 delete from foodsolution.dbo.pedido_lanche_itens
 where id = @id
 end
if @@error <> 0
begin
 rollback transaction
 return(1)
end
else
begin
 commit transaction
 select @novoid 
 return(0)
end